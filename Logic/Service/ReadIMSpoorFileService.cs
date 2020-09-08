using Models.File;
using Services.TopoModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class ReadIMSpoorFileService : IReadFileService<IMSpoor>
    {
        public IMSpoor Read(IReadableFile file)
        {
            XElement xelement = XElement.Load(file.FilePath);

            return new IMSpoor(xelement);
        }
    }
}
