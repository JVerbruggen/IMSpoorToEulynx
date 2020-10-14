using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
{
    public partial class Aspect
    {
        public Aspect()
        {

        }

        public static Aspect[] GetAspects()
        {
            Aspect[] aspects = { };

            return aspects;
        }

        public Aspect[] TranslateMultiple(IMSpoor.V1_3_0.IMSpoor imSpoor)
        {
            throw new NotImplementedException();
        }

        public Aspect TranslateSingle(IMSpoor.V1_3_0.IMSpoor imSpoor)
        {
            throw new NotImplementedException();
        }
    }
}
