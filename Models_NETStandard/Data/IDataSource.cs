using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Models.Data
{
    [Obsolete]
    public interface IDataSource
    {
        String FileName { get; }

        XElement Read();
    }
}
