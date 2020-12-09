using Models.TopoModels.Eulynx.Common;
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
        public T Find(T[] haystack, tElementWithIDref needle)
        {
            return Find(haystack, needle.@ref);
        }

        public T Find(T[] haystack, string needleUUID)
        {
            T found = null;

            foreach (T hay in haystack)
            {
                if (hay.uuid == needleUUID)
                {
                    found = hay;
                    break;
                }
            }
            return found;
        }
    }
}
