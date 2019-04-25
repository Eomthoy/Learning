using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Common.Helper
{
    /// <summary>
    /// 加密（Md5 | Base64 | ）
    /// </summary>
    public class EncryptHelper
    {
        #region MD5

        /// <summary>
        /// Md5加密（小写）
        /// </summary>
        /// <param name="str">待加密的明文</param>
        /// <param name="type">加密类型（16,32）</param>
        /// <returns></returns>
        public static string MD5Encryp(string str, int type)
        {
            string result = "";

            switch (type)
            {
                case 16:
                    result = MD5Encryp_16(str);
                    break;
                case 32:
                    result = MD5Encryp_32(str);
                    break;
                default:
                    result = "";
                    break;
            }

            return result;
        }
        /// <summary>
        /// Md5加密（16小写）
        /// </summary>
        /// <param name="str">待加密的明文</param>
        /// <returns></returns>
        public static string MD5Encryp_16(string str)
        {
            try
            {

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string result = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str)), 4, 8);
                return result.Replace("-", "").ToLower();
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// Md5加密（32小写）
        /// </summary>
        /// <param name="str">待加密的明文</param>
        /// <returns></returns>
        public static string MD5Encryp_32(string str)
        {
            try
            {
                // 初始化MD5
                MD5 md5 = MD5.Create();

                //将源字符串转化为byte数组
                byte[] bs = Encoding.Default.GetBytes(str);

                // 转化为md5的byte数组
                byte[] md5Byte = md5.ComputeHash(bs);

                //将md5的byte数组再转化为MD5数组
                StringBuilder sb = new StringBuilder();
                foreach (var item in md5Byte)
                {
                    sb.Append(item.ToString("x2"));
                }
                return sb.ToString().ToLower();
            }
            catch
            {
                return "";
            }
        }

        #endregion

        #region Base64

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="str">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string Base64Encode(string str)
        {
            return Base64Encode(Encoding.UTF8, str);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="str">待加密的明文</param>
        /// <returns></returns>
        public static string Base64Encode(Encoding encodeType, string str)
        {
            string result = string.Empty;
            byte[] bytes = encodeType.GetBytes(str);
            try
            {
                return Convert.ToBase64String(bytes);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="str">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string str)
        {
            return Base64Decode(Encoding.UTF8, str);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="str">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(Encoding encodeType, string str)
        {
            string result = string.Empty;
            byte[] bytes = Convert.FromBase64String(str);
            try
            {
                return encodeType.GetString(bytes);
            }
            catch
            {
                return "";
            }
        }

        #endregion

    }
}

