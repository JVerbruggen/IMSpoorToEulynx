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
        /// <summary>
        /// Select specific mapping for a certain input object.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        IMapping<T, U> Select(T input);

        /// <summary>
        /// Map object to output.
        /// Uses Select(T input) function to select a mapping
        /// </summary>
        /// <param name="input">Object to map</param>
        /// <returns>Mapped object</returns>
        U Map(T input);

        [Obsolete]
        IMappingSelector<IMappable, IMappable> GetMappables();

        [Obsolete]
        Type GetInput();
        [Obsolete]
        Type GetOutput();
    }
}
