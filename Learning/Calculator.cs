using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Calculator
    {
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static async Task<int> AddAsync(int a, int b)
        {
            int result = 0;
            Func<int, int, int> add = (x, y) =>
            {
                return x + y;
            };
            result = await Task.Run(() => add(a, b));
            return result;
        }
    }
}
