using Models.Mapping.Topology;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Positioning;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Mapping.Topology
{
    public class PositioningNetElementMapping : IMapping<PositioningNetElementMappingDepends, PositioningNetElement>
    {
        private AssociatedPositioningSystemManager associatedPositioningSystemManager;

        public PositioningNetElementMapping(AssociatedPositioningSystemManager associatedPositioningSystemManager)
        {
            this.associatedPositioningSystemManager = associatedPositioningSystemManager;
        }

        public IEnumerable<PositionedRelation> GetRelations(IEnumerable<PositionedRelation> allRelations, PositioningNetElement netElement)
        {
            return allRelations.Where(rel => rel.elementA.Equals(netElement) || rel.elementB.Equals(netElement));
        }

        public PositioningNetElement GetPositioningNetElement(MicroLink microLink, PositionedRelation[] allRelations)
        {
            LinearElement linearElement = new LinearElement(microLink.railConnectionRef,
                this.associatedPositioningSystemManager.GetAssociatedPositioningSystems(microLink.railConnectionRef));

            var relations = GetRelations(allRelations, linearElement).ToArray();

            linearElement.relation = tElementWithIDref.GetTElementsWithIDref(relations);

            return linearElement;
        }

        public PositioningNetElement Map(PositioningNetElementMappingDepends input)
        {
            return GetPositioningNetElement(input.MicroLink, input.PositionedRelations);
        }
    }
}
