using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    struct task5
    {
        public void task_5()
        {
            for(int i = 10; i < 100; ++i)
            {
                int sum=0;
                foreach (char c in i.ToString())
                    sum += Convert.ToInt32(c) * Convert.ToInt32(c);
                if (sum % 17 == 0)
                    Console.WriteLine(i);
            }
        }
    }

}
