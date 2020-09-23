using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Base
{
    public abstract class Manager<T> : IManager<T>
    {
        private IList<T> SavedItems = new List<T>();

        public T[] GetAll()
        {
            return SavedItems.ToArray();
        }

        public void Register(T t)
        {
            SavedItems.Add(t);
        }
    }
}
