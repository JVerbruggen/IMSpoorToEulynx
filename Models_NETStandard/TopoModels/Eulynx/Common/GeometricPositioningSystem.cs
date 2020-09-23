using Models.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class GeometricPositioningSystem
    {
        public GeometricPositioningSystem()
        {

        }

        public GeometricPositioningSystem(string type)
        {
            this.crsDefinition = type;
            this.uuid = UUIDService.NewFakeUUID(type);
        }
    }
}
