using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Eom.Common.Helpers
{
    public static class ExtendHelper
    {
        /// <summary>
        /// 字符串是否为空
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string source)
        {
            return string.IsNullOrEmpty(source) || string.IsNullOrWhiteSpace(source);
        }
        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List">The list.</param>
        /// <returns>List{``0}.</returns>
        public static List<T> DeepCopy<T>(List<object> List)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, List);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as List<T>;
            }
        }
        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The list.</param>
        /// <returns>T</returns>
        public static T DeepCopy<T>(object obj)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, obj);
                objectStream.Seek(0, SeekOrigin.Begin);
                return (formatter.Deserialize(objectStream) as List<T>).FirstOrDefault();
            }
        }
    }
}
