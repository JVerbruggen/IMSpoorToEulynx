using Models.TopoModels;
using Models.Translation;
using Services.TopoModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class XSDParseTranslationService : ITranslationService<Services.TopoModels.IMSpoor, Services.TopoModels.RailTopoModel>
    {
        public RailTopoModel Translate(Services.TopoModels.IMSpoor imSpoor)
        {
            XElement xElement = imSpoor.xElement;

            

            return null;
        }
    }
}
