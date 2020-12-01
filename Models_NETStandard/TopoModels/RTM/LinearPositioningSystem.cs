using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class LinearPositioningSystem
    {
        public LinearPositioningSystem()
        {

        }

        public LinearPositioningSystem(int startMeasure, int endMeasure)
        {
            this.startMeasure = new Length(startMeasure);
            this.endMeasure = new Length(endMeasure);
            this.name = "someName";
        }

    }
}
