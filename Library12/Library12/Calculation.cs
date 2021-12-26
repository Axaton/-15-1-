using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library12
{
    public class Calculation
    {
        static Random random = new Random();

        /// <summary>
        /// Находит сумму n целых, четных, случайных чисел, распределенных в 
        /// диапазоне от 0 до count.
        /// </summary>
        /// <param name="count">Количество чисел и граница генарции</param>
        /// <returns>Сумма четных чисел и сгенерированные числа</returns>
        public static (int sum, string numbers) SumEvenWithTuple(int count)
        {
            int sum = 0;
            string numbers = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, count);
                numbers += number.ToString() + " ";
                sum += number;
            }

            return (sum, numbers);
        }
    }
}
