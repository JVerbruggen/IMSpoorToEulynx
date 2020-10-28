using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class GeometricPositioningSystem
    {
        public GeometricPositioningSystem()
        {

        }

        public GeometricPositioningSystem(string type, string uuid)
        {
            this.crsDefinition = type;
            this.uuid = uuid;
        }
    }
}
