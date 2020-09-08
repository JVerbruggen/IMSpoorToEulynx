using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Translation
{
    public interface ITranslationService<T, U> 
        where T : ITranslatable 
        where U : ITranslatable
    {
        public U Translate(T t);
    }
}
