using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class LinearPositioningSystem
    {

        public LinearPositioningSystem()
        {

        }

        public LinearPositioningSystem(int startMeasure, int endMeasure)
        {
            this.uuid = "newid?";
            this.startMeasure = new Length(startMeasure);
            this.endMeasure = new Length(endMeasure);
            this.name = "someName";
        }

    }
}
