using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Translation
{
    public interface ITranslationService<T, U> : IService
    {
        U Translate(T t);
    }
}
