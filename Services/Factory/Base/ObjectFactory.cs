using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    /// <summary>
    /// Creates a EULYNX object
    /// </summary>
    /// <typeparam name="T">EULYNX object to be created</typeparam>
    public abstract class ObjectFactory<T> : Factory<T>, IObjectFactory<T>
        where T : BaseObject
    {
    }
}
