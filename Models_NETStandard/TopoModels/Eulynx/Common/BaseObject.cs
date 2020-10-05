using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public abstract partial class BaseObject
    {

        public static bool operator ==(BaseObject baseObject1, BaseObject baseObject2)
        {
            if(object.ReferenceEquals(baseObject1, null))
            {
                return object.ReferenceEquals(baseObject2, null);
            }

            return baseObject1.Equals(baseObject2);
        }

        public static bool operator !=(BaseObject baseObject1, BaseObject baseObject2)
        {
            return !(baseObject1 == baseObject2);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as BaseObject);
        }

        public bool Equals(BaseObject baseObject)
        {
            if (baseObject == null) return false;
            return this.uuid == baseObject.uuid;
        }
    }
}
