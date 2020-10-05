using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
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
            IList<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            tElementWithIDrefs.Add(new tElementWithIDref(baseObject.uuid));

            return tElementWithIDrefs.ToArray();
        }

        /// <summary>
        /// Extract uuids from baseObjects and converts to refs
        /// </summary>
        /// <param name="baseObjects">Objects to convert to refs</param>
        /// <returns>UUID Refs of all objects</returns>
        public static tElementWithIDref[] GetTElementsWithIDref(BaseObject[] baseObjects)
        {
            IList<tElementWithIDref> tElementWithIDrefs = new List<tElementWithIDref>();
            foreach(BaseObject bo in baseObjects)
            {
                tElementWithIDrefs.Add(new tElementWithIDref(bo.uuid));
            }

            return tElementWithIDrefs.ToArray();
        }
    }
}
