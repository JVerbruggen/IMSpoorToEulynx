using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public interface IXDocSerializer<T> : IService
    {
        XDocument Serialize(T t);
    }
}
