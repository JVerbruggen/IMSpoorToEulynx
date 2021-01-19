using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
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

        private PositioningNetElement GetElement(tElementWithIDref element, List<PositioningNetElement> positioningNetElements)
        {
            PositioningNetElement found = null;
            foreach (PositioningNetElement positioningNetElement in positioningNetElements)
            {
                if(element.GetRef() == positioningNetElement.id)
                {
                    found = positioningNetElement;
                    break;
                }
            }
            return found;
        }

        public PositioningNetElement GetElementA(List<PositioningNetElement> positioningNetElements)
        {
            return GetElement(this.elementA, positioningNetElements);
        }

        public PositioningNetElement GetElementB(List<PositioningNetElement> positioningNetElements)
        {
            return GetElement(this.elementB, positioningNetElements);
        }

        public bool IsDuplicate(PositionedRelation other)
        {
            if ((this.elementA.GetRef() == other.elementA.GetRef()
                        && this.elementB.GetRef() == other.elementB.GetRef())
                    || (this.elementA.GetRef() == other.elementB.GetRef()
                        && this.elementB.GetRef() == other.elementA.GetRef())
                    || (this.elementA.GetRef() == other.elementA.GetRef()
                        && this.elementB.GetRef() == other.elementA.GetRef())
                    || (this.elementA.GetRef() == other.elementB.GetRef()
                        && this.elementB.GetRef() == other.elementB.GetRef()))
            {
                return true;
            }
            return false;
        }
    }
}
