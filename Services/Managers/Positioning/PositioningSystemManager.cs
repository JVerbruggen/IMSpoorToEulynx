using Models.TopoModels.Eulynx.Common;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Positioning
{
    public class PositioningSystemManager : ItemManager<PositioningSystem>
    {
        public GeometricPositioningSystem GetGeometricPositioningSystem(string type)
        {
            GeometricPositioningSystem found = null;
            foreach(PositioningSystem positioningSystem in this.GetAll())
            {
                if(positioningSystem is GeometricPositioningSystem)
                {
                    if (((GeometricPositioningSystem)positioningSystem).crsDefinition.Equals(type))
                    {
                        found = (GeometricPositioningSystem)positioningSystem;
                    }
                }
            }
            if(found == null)
            {
                string uuid = UUIDService.NewFakeUUID(type, typeof(GeometricPositioningSystem));
                found = new GeometricPositioningSystem(type, uuid);
                this.Register(found);
            }
            return found;
        }
    }
}
