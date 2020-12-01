using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class LinearElement
    {
        public LinearElement()
        {

        }

        public LinearElement(AssociatedPositioningSystem[] associatedPositioningSystems)
        {
            this.associatedPositioningSystems = associatedPositioningSystems;
        }

        public LinearElement(string uuid, AssociatedPositioningSystem[] associatedPositioningSystems)
        {
            this.uuid = uuid;
            this.associatedPositioningSystems = associatedPositioningSystems;
        }

        public void AddRelation(tElementWithIDref relation)
        {
            IList<tElementWithIDref> relations = this.relation;
            if (relations == null) relations = new List<tElementWithIDref>();

            relations.Add(relation);
            this.relation = relations.ToArray();
        }
    }
}
