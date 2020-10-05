using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Base
{
    public abstract class ItemManager<T> : IItemManager<T>
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
