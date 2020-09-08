using System;
using System.Collections.Generic;
using System.Text;

namespace Models.File
{
    public interface IReadFileService<T>
    {
        /// <summary>
        /// Read a readable file and returns type T model for that file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public T Read(IReadableFile file);
    }
}
