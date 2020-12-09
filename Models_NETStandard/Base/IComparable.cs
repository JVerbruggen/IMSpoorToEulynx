using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    /// <summary>
    /// Object that can be compared to another
    /// </summary>
    public interface IComparable
    {
        bool CompareTo(object o);
        bool CompareTo(Type t);
    }
}
