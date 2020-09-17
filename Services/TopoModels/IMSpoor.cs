using Models.File;
using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.TopoModels
{
    public class IMSpoor : ITranslatable
    {
        public XElement xElement { get; }

        public IMSpoor(XElement xElement)
        {
            this.xElement = xElement;
        }

    }
}
