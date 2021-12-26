using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_10
{
    public class Practice
    {
        public static (int sum, string number, int count) Total(int k)
        {
            Random rnd = new Random();
            int count = 0;
            int sum = 0;
            int num = 0;
            string number = string.Empty;
            while (sum+num < k)
            {
                num = rnd.Next(5, 10);
                sum += num;
                count++;
                number += num.ToString() + " ";
            }
            var result = (sum , number, count);
            return result;
        }
    }
}
