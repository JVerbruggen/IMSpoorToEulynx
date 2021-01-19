using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class LinearElement
    {
        public LinearElement()
        {

        }

        public LinearElement(List<AssociatedPositioningSystem> associatedPositioningSystems)
        {
            this.associatedPositioningSystems = associatedPositioningSystems;
        }

        public LinearElement(string id, List<AssociatedPositioningSystem> associatedPositioningSystems)
        {
            this.id = id;
            this.associatedPositioningSystems = associatedPositioningSystems;
        }

        public void AddRelation(tElementWithIDref relation)
        {
            this.relation.Add(relation);
        }
    }
}
