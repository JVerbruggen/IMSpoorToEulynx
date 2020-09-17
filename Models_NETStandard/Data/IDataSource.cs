using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Models.Data
{
    public interface IDataSource
    {
        String FileName { get; }

        XElement Read();
    }
}
