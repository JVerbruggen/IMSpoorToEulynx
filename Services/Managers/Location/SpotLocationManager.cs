using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Base;
using Services.Managers.Positioning;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Location
{
    public class SpotLocationManager : ItemManager<SpotLocation>
    {

        public SpotLocation GetLineLocation(tPointLocation pointLocation)
        {
            KmRibbonLocation kmRibbonLocation = pointLocation.KmRibbonLocation;

            PositioningSystemManager positioningSystemManager = InstanceManager.Singleton<PositioningSystemManager>().GetInstance();
            //positioningSystemManager.GetLinearPositioningSystem()

            //SpotLocation linearSpotLocation = new SpotLocationCoordinate()

            throw new NotImplementedException();
        }

        [Obsolete("Uses spotlocationcoordinate, gone obsolete")]
        public SpotLocation GetGeoLocation(tPointLocation pointLocation)
        {
            tPoint geoLocation = pointLocation.GeographicLocation;

            PositioningSystemCoordinateManager positioningSystemCoordinateManager = InstanceManager.Singleton<PositioningSystemCoordinateManager>().GetInstance();
            PositioningSystemManager positioningSystemManager = InstanceManager.Singleton<PositioningSystemManager>().GetInstance();
            GeometricPositioningSystem gps = positioningSystemManager.GetGeometricPositioningSystem(PositioningSystemTypes.RD);

            GeometryDeserializer geometryDeserializer = InstanceManager.Singleton<GeometryDeserializer>().GetInstance();
            float[] xy = geometryDeserializer.GetCoordinate(geoLocation.Point);

            CartesianCoordinate positioningSystemCoordinate = new CartesianCoordinate(xy[0], xy[1], gps, "");
            positioningSystemCoordinate.AllocateUUID();

            positioningSystemCoordinateManager.Register(positioningSystemCoordinate);

            tElementWithIDref positioningSystemCoordinateRef = tElementWithIDref.GetTElementWithIDref(positioningSystemCoordinate);

            string uuid = UUIDService.NewFakeUUID(positioningSystemCoordinateRef.GetRef());
            SpotLocationCoordinate spotLocationCoordinate = new SpotLocationCoordinate(positioningSystemCoordinateRef, uuid);
            //return spotLocationCoordinate;
            return null;
        }

        
        public tElementWithIDref GetGeoLocationRef(tPointLocation pointLocation)
        {
            SpotLocation spotLocation = GetGeoLocation(pointLocation);
            Register(spotLocation);

            return new tElementWithIDref(spotLocation.id);
        }

    }
}
