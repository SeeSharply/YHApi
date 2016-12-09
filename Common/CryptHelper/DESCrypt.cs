using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common.CryptHelper
{
    /// <summary>
    /// DES加密/解密类。
    /// </summary>
    public static class DESCrypt
    {

        private static string key="hy";     
        /// <summary>
        /// 进行dex加密
        /// </summary>
        /// <param name="sourceString">需要加密的字符串</param>
        /// <param name="key">加密key，8位字符串</param>
        /// <param name="iv">向量，8位字符串</param>
        /// <returns></returns>

        public static string Encrypt(string sourceString)
        {
            try
            {
                byte[] btKey = Encoding.UTF8.GetBytes(key);

                byte[] btIV = Encoding.UTF8.GetBytes(key);

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] inData = Encoding.UTF8.GetBytes(sourceString);
                    try
                    {
                        using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(btKey, btIV), CryptoStreamMode.Write))
                        {
                            cs.Write(inData, 0, inData.Length);

                            cs.FlushFinalBlock();
                        }

                        return Convert.ToBase64String(ms.ToArray());
                    }
                    catch
                    {
                        return "des加密失败";
                    }
                }
            }
            catch (Exception){
                return "des加密失败";
            }
        }
        /// <summary>
        /// des解密
        /// </summary>
        /// <param name="encryptedString"></param>
        /// <returns></returns>
        public static string Decrypt(string encryptedString)
        {
            byte[] btKey = Encoding.UTF8.GetBytes(key);

            byte[] btIV = Encoding.UTF8.GetBytes(key);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] inData = Convert.FromBase64String(encryptedString);
                try
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(btKey, btIV), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);

                        cs.FlushFinalBlock();
                    }

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
                catch
                {
                    return "des解密失败";
                }
            }
        }

    }
}