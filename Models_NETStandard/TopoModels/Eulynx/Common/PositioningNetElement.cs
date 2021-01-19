using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class PositioningNetElement
    {
        public PositioningNetElement()
        {

        }

        public double Distance(PositioningNetElement otherNetElement)
        {
            return 1;
        }

        public List<PositioningNetElement> GetRelations(List<PositionedRelation> allRelations, List<PositioningNetElement> allNetElements)
        {
            List<PositioningNetElement> localRelations = new List<PositioningNetElement>();

            foreach(PositionedRelation relation in allRelations)
            {
                if(relation.elementA.GetRef() == this.id)
                {
                    localRelations.Add(relation.GetElementB(allNetElements));
                }
                else if(relation.elementB.GetRef() == this.id)
                {
                    localRelations.Add(relation.GetElementA(allNetElements));
                }
            }

            return localRelations;
        }

        public List<PositioningNetElement> GetRelationsTraversable(List<PositionedRelation> allRelations, List<PositioningNetElement> allNetElements, Usage cameFrom)
        {
            List<PositioningNetElement> localRelations = new List<PositioningNetElement>();

            foreach(PositionedRelation relation in allRelations)
            {
                if (relation.elementA.Equals(this))
                {
                    if(relation.positionOnA != cameFrom)
                    {
                        localRelations.Add(relation.GetElementB(allNetElements));
                    }
                }
                else if (relation.elementB.Equals(this))
                {
                    if (relation.positionOnB != cameFrom)
                    {
                        localRelations.Add(relation.GetElementA(allNetElements));
                    }
                }
            }

            return localRelations;
        }




    }
}
