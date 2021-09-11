using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    struct task4
    {
        public void task_4()
        {
            for (int i = 100; i < 1000; ++i) {
                int a, b;
                a = ((Convert.ToInt32(i.ToString()[0]) - 48) + (Convert.ToInt32(i.ToString()[1]) - 48)) * ((Convert.ToInt32(i.ToString()[0]) - 48) + (Convert.ToInt32(i.ToString()[1]) - 48));
                b = (Convert.ToInt32(i.ToString()[2]) - 48) * (Convert.ToInt32(i.ToString()[2]) - 48);
                int res = a - b;
                if (res >= 100 && res <= 999)
                    Console.WriteLine(i);
            }
        }
    }
}
