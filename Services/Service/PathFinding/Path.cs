using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service.PathFinding
{
    public class Path
    {
        public IEnumerable<PositioningNetElement> elements { get; set; }

        public Path(IEnumerable<PositioningNetElement> elements)
        {
            this.elements = elements;
        }

        public int GetSteps()
        {
            return elements.Count() - 1;
        }
    }
}
