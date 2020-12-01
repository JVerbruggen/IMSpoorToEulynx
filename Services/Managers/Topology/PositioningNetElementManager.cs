using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Managers.Positioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Topology
{
    public class PositioningNetElementManager : UUIDObjectManager<PositioningNetElement>
    {
        public PositioningNetElement GetPositioningNetElement(MicroLink microLink, PositionedRelation[] allRelations)
        {
            AssociatedPositioningSystemManager associatedPositioningSystemManager = InstanceManager.Singleton<AssociatedPositioningSystemManager>().GetInstance();

            LinearElement linearElement = new LinearElement(microLink.railConnectionRef, 
                associatedPositioningSystemManager.GetAssociatedPositioningSystems(microLink.railConnectionRef));

            var relations = GetRelations(allRelations, linearElement).ToArray();

            linearElement.relation = tElementWithIDref.GetTElementsWithIDref(relations);

            return linearElement;
        }


        public PositioningNetElement[] GetPositioningNetElements(MicroLink[] microLinks, PositionedRelation[] positionedRelations)
        {
            IList<PositioningNetElement> positioningNetElements = new List<PositioningNetElement>();

            foreach (MicroLink microLink in microLinks)
            {
                PositioningNetElement positioningNetElement = GetPositioningNetElement(microLink, positionedRelations);
                positioningNetElements.Add(positioningNetElement);
            }

            return positioningNetElements.ToArray();
        }

        public IEnumerable<PositionedRelation> GetRelations(IEnumerable<PositionedRelation> allRelations, PositioningNetElement netElement)
        {
            return allRelations.Where(rel => rel.elementA.Equals(netElement) || rel.elementB.Equals(netElement));
        }

        public string GetUUIDFrom(MicroLink microLink)
        {
            return microLink.railConnectionRef;
        }

    }
}
