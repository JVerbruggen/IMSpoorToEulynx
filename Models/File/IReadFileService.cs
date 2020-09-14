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
        /// <returns>Read file in type T</returns>
        public T Read(String filePath);
    }
}
