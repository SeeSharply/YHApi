using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.CryptHelper
{
    public static class MD5Helper
    {
        public static string GetMD5Str(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(str));
            return System.Text.Encoding.Default.GetString(result);
        }
    }
}
