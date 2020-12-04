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

        IMappingSelector<IMappable, IMappable> GetMappables();

        Type GetInput();
        Type GetOutput();
    }
}
