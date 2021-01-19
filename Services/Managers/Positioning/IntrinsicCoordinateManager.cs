using Models.TopoModels.EULYNX.rtmCommon;
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
    public class IntrinsicCoordinateManager : UUIDObjectManager<IntrinsicCoordinate>
    {
        public IntrinsicCoordinate GetIntrinsicCoordinate(double linearMeasure)
        {
            LinearCoordinate lc = new LinearCoordinate(new Length(0), linearMeasure, new Length(0));

            var intrinsicCoordinate = new IntrinsicCoordinate(lc);
            intrinsicCoordinate.AllocateUUID();

            return intrinsicCoordinate;
        }

        public IntrinsicCoordinate GetIntrinsicCoordinate(double x, double y, tElementWithIDref geometricPositioningSystem)
        {
            CartesianCoordinate cartesianCoordinate = InstanceManager.Singleton<CartesianCoordinateManager>().GetInstance().GetCartesianCoordinate(x, y, geometricPositioningSystem);
            tElementWithIDref[] cartesianCoordinateRef = tElementWithIDref.GetTElementsWithIDref(cartesianCoordinate);

            string uuid = UUIDService.NewFakeUUID("intrinsic:" + x + y + geometricPositioningSystem.GetRef());

            IntrinsicCoordinate intrinsicCoordinate = new IntrinsicCoordinate(cartesianCoordinateRef, uuid);

            return intrinsicCoordinate;
        }

        public List<IntrinsicCoordinate> GetIntrinsicCoordinates(tElementWithIDref geometricPositioningSystem, LineString lineString)
        {
            GeometryDeserializer geometryDeserializer = InstanceManager.Singleton<GeometryDeserializer>().GetInstance();

            float[,] coords = geometryDeserializer.Get3Coordinates(lineString.coordinates);

            List<IntrinsicCoordinate> intrinsicCoordinates = new List<IntrinsicCoordinate>();
            for (int i = 0; i < coords.GetLength(0); i++)
            {
                double x = coords[i, 0];
                double y = coords[i, 1];

                IntrinsicCoordinate intrinsicCoordinate = GetIntrinsicCoordinate(x, y, geometricPositioningSystem);
                intrinsicCoordinates.Add(intrinsicCoordinate);
            }

            return intrinsicCoordinates;
        }
    }
}
