using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class tElementWithIDref
    {

        public tElementWithIDref()
        {

        }

        public tElementWithIDref(string @ref)
        {
            this.@ref = @ref;
        }

        public static tElementWithIDref GetTElementWithIDref(BaseObject baseObject)
        {
            tElementWithIDref tElement = new tElementWithIDref(baseObject.uuid);
            return tElement;
        }

        public static tElementWithIDref[] GetTElementsWithIDref(BaseObject baseObject)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(new tElementWithIDref(baseObject.uuid));

            return GetTElementsWithIDreflist(baseObject).ToArray();
        }

        public static List<tElementWithIDref> GetTElementsWithIDreflist(BaseObject baseObject)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(new tElementWithIDref(baseObject.uuid));

            return tElementWithIDrefs;
        }

        /// <summary>
        /// Extract uuids from baseObjects and converts to refs
        /// </summary>
        /// <param name="baseObjects">Objects to convert to refs</param>
        /// <returns>UUID Refs of all objects</returns>
        public static List<tElementWithIDref> GetTElementsWithIDreflist(List<BaseObject> baseObjects)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            foreach(BaseObject bo in baseObjects)
            {
                tElementWithIDrefs.Add(new tElementWithIDref(bo.uuid));
            }

            return tElementWithIDrefs;
        }

        /// <summary>
        /// Extract uuids from baseObjects and converts to refs
        /// </summary>
        /// <param name="baseObjects">Objects to convert to refs</param>
        /// <returns>UUID Refs of all objects</returns>
        public static tElementWithIDref[] GetTElementsWithIDref(BaseObject[] baseObjects)
        {
            return GetTElementsWithIDreflist(baseObjects.ToList()).ToArray();
        }

        public static List<tElementWithIDref> GetTElementsWithIDreflist(tElementWithIDref tElementWithIDref)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(tElementWithIDref);
            return tElementWithIDrefs;
        }

        public static tElementWithIDref[] GetTElementsWithIDref(tElementWithIDref tElementWithIDref)
        {
            return GetTElementsWithIDreflist(tElementWithIDref).ToArray();
        }

        public bool Equals(tElementWithIDref @ref)
        {
            return this.Equals(@ref.@ref);
        }

        public bool Equals(string @ref)
        {
            return this.@ref.Equals(@ref);
        }

    }
}
