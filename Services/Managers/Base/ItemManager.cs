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
            if (SavedItems.Contains(t)) return;
            SavedItems.Add(t);
        }

        public void Register(T[] ts)
        {
            foreach(T t in ts)
            {
                Register(t);
            }
        }
    }
}
