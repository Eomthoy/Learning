using System;
using System.Collections.Generic;
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
    }
}
