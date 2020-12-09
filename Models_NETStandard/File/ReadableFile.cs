using System;
using System.Collections.Generic;
using System.Text;

namespace Models.File
{
    [Obsolete]
    public class ReadableFile : IReadableFile
    {
        public string FilePath { get; }

        public ReadableFile(string filePath)
        {
            FilePath = filePath;
        }
    }
}
