using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class task1
    {
        static public int SumNum(int num)
        {
            int sum = 0;
            foreach (char c in num.ToString())
                sum += Convert.ToInt32(c);
            return sum;
        }
        public void task_1()
         {    for (int i = 10; i < 100; i++)
            {
                for (int j = 2; j < 10; ++j)
                {
                    if (SumNum(i) == SumNum(i * j))
                        Console.WriteLine(i + " * " + j);

                }
            }
         }
    }
}
