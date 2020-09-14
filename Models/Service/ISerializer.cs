using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Service
{
    public interface ISerializer<T>
    {
        public String Serialize(T t);
    }
}
