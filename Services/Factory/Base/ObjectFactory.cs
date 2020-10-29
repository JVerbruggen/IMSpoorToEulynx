using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public abstract class ObjectFactory<T> : Factory<T>, IObjectFactory<T>
        where T : BaseObject
    {
    }
}
