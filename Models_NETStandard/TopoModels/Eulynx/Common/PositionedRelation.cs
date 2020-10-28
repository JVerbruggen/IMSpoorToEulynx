using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class PositionedRelation
    {
        public PositionedRelation()
        {

        }

        public PositionedRelation(tElementWithIDref elementA, tElementWithIDref elementB, Navigability navigability, Usage positionOnA, Usage positionOnB)
        {
            this.elementA = elementA;
            this.elementB = elementB;
            this.navigability = navigability;
            this.positionOnA = positionOnA;
            this.positionOnB = positionOnB;
        }

        private PositioningNetElement GetElement(tElementWithIDref element, PositioningNetElement[] positioningNetElements)
        {
            PositioningNetElement found = null;
            foreach (PositioningNetElement positioningNetElement in positioningNetElements)
            {
                if(element.@ref == positioningNetElement.uuid)
                {
                    found = positioningNetElement;
                    break;
                }
            }
            return found;
        }

        public PositioningNetElement GetElementA(PositioningNetElement[] positioningNetElements)
        {
            return GetElement(this.elementA, positioningNetElements);
        }

        public PositioningNetElement GetElementB(PositioningNetElement[] positioningNetElements)
        {
            return GetElement(this.elementB, positioningNetElements);
        }

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
