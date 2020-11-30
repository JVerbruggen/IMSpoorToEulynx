using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Managers.Positioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Topology
{
    public class PositioningNetElementManager : UUIDObjectManager<PositioningNetElement>
    {
        public PositioningNetElement[] GetPositioningNetElements(MicroLink[] microLinks)
        {
            IList<PositioningNetElement> positioningNetElements = new List<PositioningNetElement>();

            foreach (MicroLink microLink in microLinks)
            {
                LinearElement linearElement = new LinearElement();
                linearElement.uuid = microLink.railConnectionRef;
                linearElement.name = "-";
                linearElement.associatedPositioningSystems = InstanceManager.Singleton<AssociatedPositioningSystemManager>().GetInstance().GetAssociatedPositioningSystems(microLink.railConnectionRef);

                positioningNetElements.Add(linearElement);
            }

            return positioningNetElements.ToArray();
        }

    }
}
