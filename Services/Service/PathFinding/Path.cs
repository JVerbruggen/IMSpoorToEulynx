using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service.PathFinding
{
    public class Path
    {
        public PositioningNetElement[] elements { get; set; }

        public Path(PositioningNetElement[] elements)
        {
            this.elements = elements;
        }

        public int GetSteps()
        {
            return elements.Length - 1;
        }
    }
}
