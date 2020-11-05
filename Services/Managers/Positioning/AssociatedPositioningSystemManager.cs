using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Extensions;
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

        public AssociatedPositioningSystem GetAssociatedGeometricPositioningSystem(LineString lineString)
        {
            PositioningSystemManager positioningSystemManager = InstanceManager.Singleton<PositioningSystemManager>().GetInstance();
            IntrinsicCoordinateManager intrinsicCoordinateManager = InstanceManager.Singleton<IntrinsicCoordinateManager>().GetInstance();

            GeometricPositioningSystem geometricPositioningSystem = positioningSystemManager.GetGeometricPositioningSystem(PositioningSystemTypes.RD);
            IntrinsicCoordinate[] intrinsicCoordinates = intrinsicCoordinateManager.GetIntrinsicCoordinates(geometricPositioningSystem, lineString);

            var ps = new AssociatedPositioningSystem(intrinsicCoordinates, geometricPositioningSystem);
            ps.AllocateUUID();
            return ps;
        }

        public AssociatedPositioningSystem GetAssociatedLinearPositioningSystem(int measure, LinearPositioningSystem lps)
        {
            PositioningSystemManager positioningSystemManager = InstanceManager.Singleton<PositioningSystemManager>().GetInstance();
            IntrinsicCoordinateManager intrinsicCoordinateManager = InstanceManager.Singleton<IntrinsicCoordinateManager>().GetInstance();

            IntrinsicCoordinate[] intrinsicCoordinate = new IntrinsicCoordinate[] { intrinsicCoordinateManager.GetIntrinsicCoordinate(measure) };

            var ps = new AssociatedPositioningSystem(intrinsicCoordinate, lps);
            ps.AllocateUUID();
            return ps;
        }


        public IEnumerable<AssociatedPositioningSystem> GetAssociatedPositioningSystems(tLineLocation location)
        {
            IList<AssociatedPositioningSystem> associatedPositioningSystems = new List<AssociatedPositioningSystem>();

            tLine geographicLocation = location.GeographicLocation;
            KmRibbonLocation kmRibbonLocation = location.KmRibbonLocation;

            var lps = new LinearPositioningSystem(0, 555);
            lps.AllocateUUID();

            AssociatedPositioningSystem associatedLinearPositioningSystem = GetAssociatedLinearPositioningSystem(55, lps);
            AssociatedPositioningSystem associatedGeometricPositioningSystem = GetAssociatedGeometricPositioningSystem(geographicLocation.LineString);

            associatedPositioningSystems.Add(associatedLinearPositioningSystem);
            associatedPositioningSystems.Add(associatedGeometricPositioningSystem);

            return associatedPositioningSystems;
        }


        public AssociatedPositioningSystem[] GetAssociatedPositioningSystems(string trackRef)
        {
            List<AssociatedPositioningSystem> associatedPositioningSystems = new List<AssociatedPositioningSystem>();

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
                var a = GetAssociatedPositioningSystems(foundTrack.Location);

                associatedPositioningSystems.AddRange(a);

            }

            return associatedPositioningSystems.ToArray();
        }
    }
}
