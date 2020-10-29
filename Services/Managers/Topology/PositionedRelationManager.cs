using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Topology
{
    internal enum RelationDirection
    {
        ONWARDS, BACKWARDS
    }

    internal class MicroLinkRelation
    {
        public MicroLink MicroLink { get; set; }

        public Navigability Navigability { get; set; }
        public RelationDirection RelationDirection { get; set; }
    }

    public class PositionedRelationManager : UUIDObjectManager<PositionedRelation>
    {
        private MicroLinkRelation yoWhichTrackDoesThisPortHave(RailTopology railTopology, String junction, int port)
        {
            MicroLink yoIFoundThisOne = null;
            RelationDirection relationDirection = RelationDirection.ONWARDS;

            MicroLink[] allTracks = railTopology.MicroLinks;

            foreach (MicroLink track in allTracks)
            {
                if (track.FromMicroNode.nodeRef == junction && track.FromMicroNode.portIndex == port)
                {
                    yoIFoundThisOne = track;
                    relationDirection = RelationDirection.ONWARDS;
                    break;
                }
                else if (track.ToMicroNode.nodeRef == junction && track.ToMicroNode.portIndex == port)
                {
                    yoIFoundThisOne = track;
                    relationDirection = RelationDirection.BACKWARDS;
                    break;
                }
            }

            return new MicroLinkRelation()
            {
                MicroLink = yoIFoundThisOne,
                RelationDirection = relationDirection
            };
        }

        private MicroLinkRelation[] whereCanIGoThroughThisPort(RailTopology railTopology, String junction, int port)
        {
            IList<MicroLinkRelation> tracksToGoTo = new List<MicroLinkRelation>();

            MicroNode[] allNodes = railTopology.MicroNodes;

            foreach (MicroNode node in allNodes)
            {
                if (node.Jumpers == null) continue;
                if (node.junctionRef != junction) continue;

                foreach (Jumper jumper in node.Jumpers)
                {
                    int otherPort;
                    if (port == jumper.fromIndex)
                    {
                        otherPort = jumper.toIndex;
                    }
                    else if (port == jumper.toIndex)
                    {
                        otherPort = jumper.fromIndex;
                    }
                    else
                    {
                        continue;
                    }

                    MicroLinkRelation trackOnOtherSideOfPort = yoWhichTrackDoesThisPortHave(railTopology, junction, otherPort);

                    if (trackOnOtherSideOfPort.MicroLink == null) // There is no track on other side of this junction port.. huh?
                    {
                        continue;
                    }

                    MicroLinkRelation trackRelation = new MicroLinkRelation()
                    {
                        MicroLink = trackOnOtherSideOfPort.MicroLink,
                        Navigability = Navigability.Both,
                        RelationDirection = trackOnOtherSideOfPort.RelationDirection
                    };

                    tracksToGoTo.Add(trackRelation);
                }
            }

            return tracksToGoTo.ToArray();
        }

        private PositionedRelation[] getPositionedRelationsForThisPort(RailTopology railTopology, tNodePort nodePort, MicroLink currentTrack, RelationDirection relationDirection)
        {
            IList<PositionedRelation> positionedRelations = new List<PositionedRelation>();

            MicroLinkRelation[] tracksToGoTo = whereCanIGoThroughThisPort(railTopology, nodePort.nodeRef, nodePort.portIndex);

            foreach (MicroLinkRelation tToGoToRelation in tracksToGoTo)
            {
                MicroLink tToGoTo = tToGoToRelation.MicroLink;

                if (tToGoTo == currentTrack) continue; // u cant go towards yourself weirdo that'd be very weird

                PositionedRelation trackRelation = new PositionedRelation();
                trackRelation.elementA = new tElementWithIDref() { @ref = currentTrack.railConnectionRef };
                trackRelation.elementB = new tElementWithIDref() { @ref = tToGoTo.railConnectionRef };
                trackRelation.name = "-";
                trackRelation.navigability = tToGoToRelation.Navigability;
                trackRelation.positionOnA = relationDirection == RelationDirection.ONWARDS ? Usage.start : Usage.end; // Current track
                trackRelation.positionOnB = tToGoToRelation.RelationDirection == RelationDirection.ONWARDS ? Usage.start : Usage.end;

                positionedRelations.Add(trackRelation);
            }

            return positionedRelations.ToArray();
        }

        private IList<PositionedRelation> AddRangeDistinct(IList<PositionedRelation> sourceList, PositionedRelation[] addingList)
        {
            foreach (PositionedRelation addition in addingList)
            {
                bool duplicate = false;
                foreach (PositionedRelation checking in sourceList)
                {
                    if (addition.IsDuplicate(checking))
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    sourceList.Add(addition);
                }
            }
            return sourceList;
        }



        public PositionedRelation[] GetPositionedRelations(RailTopology railTopology)
        {
            IList<PositionedRelation> positionedRelations = new List<PositionedRelation>();

            foreach (MicroLink currentTrack in railTopology.MicroLinks)
            {
                PositionedRelation[] relationsAtFromPort = getPositionedRelationsForThisPort(railTopology, currentTrack.FromMicroNode, currentTrack, RelationDirection.ONWARDS);
                PositionedRelation[] relationsAtToPort = getPositionedRelationsForThisPort(railTopology, currentTrack.ToMicroNode, currentTrack, RelationDirection.BACKWARDS);

                positionedRelations = AddRangeDistinct(positionedRelations, relationsAtFromPort);
                positionedRelations = AddRangeDistinct(positionedRelations, relationsAtToPort);
            }

            return positionedRelations.ToArray();
        }
    }

}
