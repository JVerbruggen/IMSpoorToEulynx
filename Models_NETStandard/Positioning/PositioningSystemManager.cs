using Models.Base;
using Models.TopoModels.Eulynx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Positioning
{
    public class PositioningSystemManager : Manager<PositioningSystem>
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
                found = new GeometricPositioningSystem(type);
                this.Register(found);
            }
            return found;
        }
    }
}
