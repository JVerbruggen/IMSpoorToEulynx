using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Positioning
{
    public class AssociatedPositioningSystemManager : UUIDObjectManager<AssociatedPositioningSystem>
    {
        public AssociatedPositioningSystem[] GetAssociatedPositioningSystems(string trackRef)
        {
            IList<AssociatedPositioningSystem> associatedPositioningSystems = new List<AssociatedPositioningSystem>();

            tSituation situation = InstanceManager.Singleton<IMSpoorReadingService>().GetInstance().situation;
            RailImplementation implementation = situation.RailInfrastructure.RailImplementation;

            Track foundTrack = null;
            foreach (Track track in implementation.Tracks)
            {
                if (track.puic == trackRef)
                {
                    foundTrack = track;
                    break;
                }
            }
            if (foundTrack != null)
            {
                tLineLocation location = foundTrack.Location;
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
