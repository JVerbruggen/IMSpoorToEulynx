using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
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
                linearElement.uuid = microLink.trackFunctionalViewRef;
                linearElement.name = "-";
                linearElement.associatedPositioningSystems = InstanceManager.Singleton<AssociatedPositioningSystemManager>().GetInstance().GetAssociatedPositioningSystems(microLink.trackFunctionalViewRef);

                positioningNetElements.Add(linearElement);
            }

            return positioningNetElements.ToArray();
        }
    }
}
