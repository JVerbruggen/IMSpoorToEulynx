using Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Base
{
    public interface IMappingSelector : Models.Base.IComparable
    {
    }

    public interface IMappingSelector<T, U> : IMappingSelector
        where T : IMappable
        where U : IMappable
    {
        IMapping<T, U> Select(T input);

        [Obsolete]
        IMappingSelector<IMappable, IMappable> GetMappables();

        [Obsolete]
        Type GetInput();
        [Obsolete]
        Type GetOutput();
    }
}
