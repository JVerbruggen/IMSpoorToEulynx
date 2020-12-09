using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Base
{
    /// <summary>
    /// A manageable object
    /// Used for items that want to be stored to the singleton functionality of the InstanceManager
    /// </summary>
    public interface IManageable : IMappable
    {
    }
}
