using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class LinearCoordinate
    {
        public LinearCoordinate()
        {

        }

        public LinearCoordinate(Length lateralOffset, double measure, Length verticalOffset)
        {
            this.lateralOffset = lateralOffset;
            this.measure = measure;
            this.verticalOffset = verticalOffset;
        }
    }
}
