using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.sig
{
    public partial class Aspect
    {
        public Aspect()
        {

        }

        public static List<Aspect> GetAspects()
        {
            List<Aspect> aspects = new List<Aspect>();

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
