using Models.Base;
using Models.DependencyInjection.Manager;
using Models.Positioning;
using Models.TopoModels.DependencyInjection;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Location
{
    public class SpotLocationManager : Manager<SpotLocation>
    {

        public SpotLocation GetGeoLocation(tPointLocation pointLocation)
        {
            tPoint geoLocation = pointLocation.GeographicLocation;
            string coordinates = geoLocation.Point.coordinates;
            string[] coordinatesSplit = coordinates.Split(',');
            double x = double.Parse(coordinatesSplit[0]);
            double y = double.Parse(coordinatesSplit[1]);

            PositioningSystemCoordinateManager positioningSystemCoordinateManager = InstanceManager.GetOrNewInstanceSupplier<PositioningSystemCoordinateManager>().GetInstance();
            PositioningSystemManager positioningSystemManager = InstanceManager.GetOrNewInstanceSupplier<PositioningSystemManager>().GetInstance();
            GeometricPositioningSystem gps = positioningSystemManager.GetGeometricPositioningSystem(PositioningSystemTypes.RD);

            CartesianCoordinate positioningSystemCoordinate = new CartesianCoordinate(x, y, gps.uuid);
            positioningSystemCoordinateManager.Register(positioningSystemCoordinate);

            SpotLocationCoordinate spotLocationCoordinate = new SpotLocationCoordinate(positioningSystemCoordinate.uuid);
            return spotLocationCoordinate;
        }

    }
}
