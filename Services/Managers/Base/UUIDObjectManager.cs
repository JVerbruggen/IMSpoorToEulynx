using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Base
{
    /// <summary>
    /// Manager that manages a EUYLNX object
    /// </summary>
    /// <typeparam name="T">EULYNX object to be managed</typeparam>
    public abstract class UUIDObjectManager<T> : IManager<T> where T : BaseObject
    {
        public T Find(List<T> haystack, tElementWithIDref needle)
        {
            return Find(haystack, needle.GetRef());
        }

        public T Find(List<T> haystack, string needleID)
        {
            T found = null;

            foreach (T hay in haystack)
            {
                if (hay.id == needleID)
                {
                    found = hay;
                    break;
                }
            }
            return found;
        }
    }
}
