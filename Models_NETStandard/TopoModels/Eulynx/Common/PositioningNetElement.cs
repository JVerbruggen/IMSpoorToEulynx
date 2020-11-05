using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
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

        public PositioningNetElement[] GetRelations(PositionedRelation[] allRelations, PositioningNetElement[] allNetElements)
        {
            IList<PositioningNetElement> localRelations = new List<PositioningNetElement>();

            foreach(PositionedRelation relation in allRelations)
            {
                if(relation.elementA.@ref == this.uuid)
                {
                    localRelations.Add(relation.GetElementB(allNetElements));
                }
                else if(relation.elementB.@ref == this.uuid)
                {
                    localRelations.Add(relation.GetElementA(allNetElements));
                }
            }

            return localRelations.ToArray();
        }

        


    }
}
