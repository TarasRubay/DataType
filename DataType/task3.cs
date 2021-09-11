using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    struct task3
    {
        public void task_3()
        {
            for (int i = 100; i < 1000; ++i)
                if ((Convert.ToInt32(i.ToString()[1]) - 48) == (Convert.ToInt32(i.ToString()[0])-48) + (Convert.ToInt32(i.ToString()[2])-48))
                    Console.WriteLine(i);
              
        }
    }
}
