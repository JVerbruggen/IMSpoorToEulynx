using Models.Base;
using Models.Mapping.Topology;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Managers.Positioning;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Topology
{
    public class PositioningNetElementManager : UUIDObjectManager<PositioningNetElement>
    {
        public IEnumerable<PositioningNetElement> GetPositioningNetElements(IEnumerable<MicroLink> microLinks, IEnumerable<PositionedRelation> positionedRelations)
        {
            IList<PositioningNetElement> positioningNetElements = new List<PositioningNetElement>();

            foreach (MicroLink microLink in microLinks)
            {
                PositioningNetElementMappingDepends depends = new PositioningNetElementMappingDepends(positionedRelations, microLink);

                IMapping<PositioningNetElementMappingDepends, PositioningNetElement> mapping
                    = InstanceManager.GetMappingSelector<PositioningNetElementMappingDepends, PositioningNetElement>().Select(depends);

                PositioningNetElement positioningNetElement = mapping.Map(depends);
                positioningNetElements.Add(positioningNetElement);
            }

            return positioningNetElements;
        }

        public string GetUUIDFrom(MicroLink microLink)
        {
            return microLink.railConnectionRef;
        }

    }
}
