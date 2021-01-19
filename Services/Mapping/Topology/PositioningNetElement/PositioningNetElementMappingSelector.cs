using Models.Mapping.Topology;
using Models.TopoModels.EULYNX.rtmCommon;
using Services.Managers.Positioning;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Topology
{
    public class PositioningNetElementMappingSelector : MappingSelector<PositioningNetElementMappingDepends, PositioningNetElement>
    {
        private AssociatedPositioningSystemManager associatedPositioningSystemManager;

        public PositioningNetElementMappingSelector(AssociatedPositioningSystemManager associatedPositioningSystemManager)
        {
            this.associatedPositioningSystemManager = associatedPositioningSystemManager;
        }

        public override IMapping<PositioningNetElementMappingDepends, PositioningNetElement> Select(PositioningNetElementMappingDepends input)
        {
            return new PositioningNetElementMapping(this.associatedPositioningSystemManager);
        }
    }
}
