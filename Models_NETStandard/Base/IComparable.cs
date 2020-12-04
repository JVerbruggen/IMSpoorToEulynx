using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    public interface IComparable
    {
        bool CompareTo(object o);
        bool CompareTo(Type t);
    }
}
