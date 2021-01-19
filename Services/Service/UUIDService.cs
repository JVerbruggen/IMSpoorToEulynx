using Models.TopoModels.EULYNX.rtmCommon;
using Models.Translation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Services.Service
{
    public class UUIDService : IService
    {

        /// <summary>
        /// Generate new fake uuid based on given seed
        /// Uses MD5 to convert seed to UUID
        /// A prefix is added to seed
        /// </summary>
        /// <param name="seed">Seed to base UUID on</param>
        /// <returns>Generated UUID string</returns>
        public static String NewFakeUUID(String seed)
        {
            seed = "fakeuuid:" + seed;

            using(MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.ASCII.GetBytes(seed);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder returningString = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    if (i == 4 || i == 6 || i == 8 || i == 10) returningString.Append('-');

                    returningString.Append(hash[i].ToString("X2").ToLower());
                }
                return returningString.ToString();
            }
        }

        public static String NewFakeUUID(String seed, Type t)
        {
            return NewFakeUUID(t.Name + seed);
        }

        /// <summary>
        /// Generate new fake uuid based on given object using reflection
        /// Uses MD5 to convert seed to UUID
        /// </summary>
        /// <param name="obj">Object to generate UUID for</param>
        /// <returns>Generated UUID string</returns>
        public static String NewFakeUUID(object obj)
        {
            Type t = obj.GetType();
            string seed = "";
            foreach(var prop in t.GetProperties())
            {
                var val = prop.GetValue(obj, null);
                if(val != null)
                {
                    string add = "";
                    if(val is BaseObject)
                    {
                        add = ((BaseObject)val).id;
                    }
                    else if(val is tElementWithIDref)
                    {
                        add = ((tElementWithIDref)val).GetRef();
                    }
                    else
                    {
                        add = val.ToString();
                    }
                    seed += add;
                }
            }

            return NewFakeUUID(seed, t);
        }
    }
}
