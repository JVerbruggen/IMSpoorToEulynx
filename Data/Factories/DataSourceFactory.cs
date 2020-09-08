using Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Factories
{
    public static class DataSourceFactory
    {
        public static IDataSource Build(String fileName)
        {
            return new DataSource(fileName);
        }
    }
}
