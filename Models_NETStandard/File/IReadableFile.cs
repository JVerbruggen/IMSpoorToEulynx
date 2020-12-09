using System;
using System.Collections.Generic;
using System.Text;

namespace Models.File
{
    [Obsolete]
    public interface IReadableFile
    {
        String FilePath { get; }
    }
}
