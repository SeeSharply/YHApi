using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;


namespace Domain.Model
{
    public static class Common
    {
        public static string GetMD5Str(string txt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txt, "MD5").ToLower().Substring(8, 16);
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(txt));
            return System.Text.Encoding.Default.GetString(result);
        }
    }
}