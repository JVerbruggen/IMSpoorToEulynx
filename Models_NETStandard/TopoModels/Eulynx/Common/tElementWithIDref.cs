using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class tElementWithIDref
    {
        [Obsolete]
        public string @ref;

        public tElementWithIDref()
        {

        }

        public tElementWithIDref(string @ref)
        {
            SetRef(@ref);
        }

        public string GetRef()
        {
            return "";
        }

        public void SetRef(string @ref)
        {
            
        }

        public static tElementWithIDref GetTElementWithIDref(BaseObject baseObject)
        {
            tElementWithIDref tElement = new tElementWithIDref(baseObject.id);
            return tElement;
        }

        public static tElementWithIDref[] GetTElementsWithIDref(BaseObject baseObject)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(new tElementWithIDref(baseObject.id));

            return GetTElementsWithIDreflist(baseObject).ToArray();
        }

        public static List<tElementWithIDref> GetTElementsWithIDreflist(BaseObject baseObject)
        {
            List<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(new tElementWithIDref(baseObject.id));

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
                tElementWithIDrefs.Add(new tElementWithIDref(bo.id));
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
            return this.Equals(@ref.GetRef());
        }

        public bool Equals(string @ref)
        {
            return this.GetRef().Equals(@ref);
        }

        public static bool Equals(tElementWithIDref a, tElementWithIDref b)
        {
            return a.Equals(b);
        }

    }
}
