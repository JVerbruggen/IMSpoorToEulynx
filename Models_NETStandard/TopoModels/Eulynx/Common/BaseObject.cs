using Models.Base;
using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public abstract partial class BaseObject : IManageable
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

        public bool Equals(tElementWithIDref idRef)
        {
            return this.uuid == idRef.@ref;
        }

        public static implicit operator tElementWithIDref(BaseObject bo)
        {
            return new tElementWithIDref(bo.uuid);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static T[] Find<T>(T[] allElements, tElementWithIDref[] needles) where T : BaseObject
        {
            var allElementsList = allElements.ToList();
            var e = needles.Any(idRef => idRef.@ref == "ff442c00-0082-496f-9f41-461ac9cb55ab");

            //allElementsList.Where(element => needles.Any(needle => element.uuid == needle.@ref))

            return allElements.ToList().Where(element => (needles.Any(idRef => idRef.@ref.Equals(element.uuid)))).ToArray();
        }

        public static T[] Find<T>(T[] allElements, tElementWithIDref needle) where T : BaseObject
        {
            if (needle == null || needle.@ref == null) return null;
            return allElements.ToList().Where(element => needle.@ref.Equals(element.uuid)).ToArray();
        }
    }
}
