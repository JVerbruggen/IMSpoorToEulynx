using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Base
{
    public interface IObjectFactory<T> : IFactory<T>
        where T : BaseObject
    {
    }
}
