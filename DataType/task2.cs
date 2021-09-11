using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class task2
    {
        public void task_2(int number)
        {
            for (int i = 100; i < 1000; ++i)
                if (task1.SumNum(number) == task1.SumNum(i))
                    Console.WriteLine("sum you enter: " + number + " == " + "sum: " + i);
        }
        
    }
}
