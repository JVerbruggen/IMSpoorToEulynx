using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Aspect
    {

        public static Aspect[] GetAspects()
        {
            Aspect[] aspects = { };

            return aspects;
        }

        public Aspect[] TranslateMultiple(IMSpoor.IMSpoor imSpoor)
        {
            throw new NotImplementedException();
        }

        public Aspect TranslateSingle(IMSpoor.IMSpoor imSpoor)
        {
            throw new NotImplementedException();
        }
    }
}
