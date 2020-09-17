using Models.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Data
{
    public class DataSource : IDataSource
    {
        public String FileName { get; }

        public DataSource(String fileName)
        {
            this.FileName = fileName;
        }

        public XElement Read()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(currentDirectory, "Storage", this.FileName);

            XElement file = XElement.Load(filePath);

            return file;
        }

    }
}
