using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class PositionedRelation
    {
        public bool IsDuplicate(PositionedRelation other)
        {
            if ((this.elementA.@ref == other.elementA.@ref
                        && this.elementB.@ref == other.elementB.@ref)
                    || (this.elementA.@ref == other.elementB.@ref
                        && this.elementB.@ref == other.elementA.@ref)
                    || (this.elementA.@ref == other.elementA.@ref
                        && this.elementB.@ref == other.elementA.@ref)
                    || (this.elementA.@ref == other.elementB.@ref
                        && this.elementB.@ref == other.elementB.@ref))
            {
                return true;
            }
            return false;
        }
    }
}
