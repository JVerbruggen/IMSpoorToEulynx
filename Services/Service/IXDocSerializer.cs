using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public interface IXDocSerializer<T>
    {
        XDocument Serialize(T t);
    }
}
