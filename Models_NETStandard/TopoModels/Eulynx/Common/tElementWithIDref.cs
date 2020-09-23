using System;
using System.Collections.Generic;
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


        public static tElementWithIDref GetTElementWithIDref()
        {
            tElementWithIDref tElement = new tElementWithIDref();

            

            return tElement;
        }

        public static tElementWithIDref[] GetTElementsWithIDref()
        {
            tElementWithIDref[] tElements = { };

            return tElements;
        }

    }
}
