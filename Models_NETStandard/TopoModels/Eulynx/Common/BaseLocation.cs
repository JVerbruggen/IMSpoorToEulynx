using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public abstract partial class BaseLocation
    {
        public static IEnumerable<BaseLocation> Filter<T>(IEnumerable<BaseLocation> haystack)
        {
            return haystack.Where(loc => loc.GetType() is T);
        }
    }
}
