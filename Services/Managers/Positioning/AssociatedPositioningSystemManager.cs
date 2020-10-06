using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Positioning
{
    public class AssociatedPositioningSystemManager : Manager<AssociatedPositioningSystem>
    {
        public AssociatedPositioningSystem[] GetAssociatedPositioningSystems(string trackFunctionalViewRef)
        {
            List<AssociatedPositioningSystem> associatedPositioningSystems = new List<AssociatedPositioningSystem>();

            tSituation situation = InstanceManager.Singleton<tSituation>().GetInstance();
            RailImplementation implementation = situation.RailInfrastructure.RailImplementation;

            TrackPhysicalView trackPhysicalView = null;
            foreach (TrackPhysicalView view in implementation.TrackPhysicalViews)
            {
                if (view.puic == trackFunctionalViewRef)
                {
                    trackPhysicalView = view;
                    break;
                }
            }
            if (trackPhysicalView != null)
            {
                tLineLocation location = trackPhysicalView.Location;
                tLine geographicLocation = location.GeographicLocation;
                KmRibbonLocation kmRibbonLocation = location.KmRibbonLocation;

                PositioningSystemManager positioningSystemManager = InstanceManager.Singleton<PositioningSystemManager>().GetInstance();
                GeometricPositioningSystem geometricPositioningSystem = positioningSystemManager.GetGeometricPositioningSystem(PositioningSystemTypes.RD);
                LinearPositioningSystem linearPositioningSystem = new LinearPositioningSystem(0, 2222);

                LineString lineString = geographicLocation.LineString;
                tElementWithIDref geometricPositioningSystemRef = tElementWithIDref.GetTElementWithIDref(geometricPositioningSystem);
                IntrinsicCoordinate[] intrinsicCoordinates = InstanceManager.Singleton<IntrinsicCoordinateManager>().GetInstance().GetIntrinsicCoordinates(geometricPositioningSystemRef, lineString);

                tElementWithIDref linearPositioningSystemRef = tElementWithIDref.GetTElementWithIDref(linearPositioningSystem);

                AssociatedPositioningSystem associatedLinearPositioningSystem = new AssociatedPositioningSystem(null, linearPositioningSystemRef);
                AssociatedPositioningSystem associatedGeometricPositioningSystem = new AssociatedPositioningSystem(intrinsicCoordinates, geometricPositioningSystemRef);

                associatedPositioningSystems.Add(associatedLinearPositioningSystem);
                associatedPositioningSystems.Add(associatedGeometricPositioningSystem);
            }


            return associatedPositioningSystems.ToArray();
        }
    }
}
