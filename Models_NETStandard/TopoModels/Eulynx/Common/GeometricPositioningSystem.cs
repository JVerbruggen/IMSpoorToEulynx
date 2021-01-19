using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class GeometricPositioningSystem
    {
        public GeometricPositioningSystem()
        {

        }

        public GeometricPositioningSystem(string type, string id)
        {
            this.crsDefinition = type;
            this.id = id;
        }
    }
}
