using Models.DependencyInjection.Manager;
using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class AssociatedPositioningSystem
    {

        public AssociatedPositioningSystem[] TranslateMultiple(string trackFunctionalViewRef)
        {
            List<AssociatedPositioningSystem> associatedPositioningSystems = new List<AssociatedPositioningSystem>();

            tSituation situation = InstanceManager.GetInstanceSupplier<tSituation>().GetInstance();
            RailImplementation implementation = situation.RailInfrastructure.RailImplementation;

            TrackPhysicalView trackPhysicalView = null;
            foreach(TrackPhysicalView view in implementation.TrackPhysicalViews)
            {
                if(view.puic == trackFunctionalViewRef)
                {
                    trackPhysicalView = view;
                    break;
                }
            }
            if(trackPhysicalView != null)
            {
                LinearPositioningSystem positioningSystem = new LinearPositioningSystem()
                {
                    uuid = "newid?",
                    startMeasure = new Length(0),
                    endMeasure = new Length(20000),
                    name = "someName"
                };

                AssociatedPositioningSystem associatedPositioningSystem = new AssociatedPositioningSystem()
                {
                    positioningSystem = new tElementWithIDref(positioningSystem.uuid)
                };

                associatedPositioningSystems.Add(associatedPositioningSystem);
            }


            return associatedPositioningSystems.ToArray();
        }

    }
}
