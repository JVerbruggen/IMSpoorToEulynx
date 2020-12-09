using Models.Base;
using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Base
{
    /// <summary>
    /// Manages an object
    /// Used to add functionalities to a model
    /// </summary>
    /// <typeparam name="T">Object to be managed</typeparam>
    public interface IManager<T> : IManageable
    {
    }
}
