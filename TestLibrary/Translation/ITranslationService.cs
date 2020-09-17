using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Translation
{
    public interface ITranslationService<T, U> 
    {
        public U Translate(T t);
    }
}
