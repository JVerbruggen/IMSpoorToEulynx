using Models.TopoModels.Eulynx.Common;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Positioning
{
    public class CartesianCoordinateManager : UUIDObjectManager<CartesianCoordinate>
    {



        public CartesianCoordinate GetCartesianCoordinate(double x, double y, tElementWithIDref positioningSystem)
        {
            string uuid = UUIDService.NewFakeUUID(x + "" + y + positioningSystem.@ref, typeof(CartesianCoordinate));
            CartesianCoordinate cartesianCoordinate = new CartesianCoordinate(x, y, positioningSystem, uuid);
            
            InstanceManager.Singleton<PositioningSystemCoordinateManager>().GetInstance().Register(cartesianCoordinate);

            return cartesianCoordinate;
        }

    }
}
