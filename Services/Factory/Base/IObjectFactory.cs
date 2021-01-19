using Models.TopoModels.EULYNX.rtmCommon;
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
