using Models.File;
using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.TopoModels
{
    public class IMSpoor : ITranslatable, IReadableFile
    {
        public string FilePath { get; }

        public IMSpoor(String filepath)
        {
            this.FilePath = filepath;
        }

    }
}
