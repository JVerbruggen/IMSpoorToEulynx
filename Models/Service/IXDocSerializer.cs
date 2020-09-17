using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Models.Service
{
    public interface IXDocSerializer<T>
    {
        public XDocument Serialize(T t);
    }
}
