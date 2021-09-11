using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    struct task6
    {
        public void task_6()
        {
           for(int i = 100;i < 1000; ++i)
            {
                int sum = 0;
                foreach (char c in i.ToString())
                    sum += fact(Convert.ToInt32(c)-48);
                Console.WriteLine(sum);
            }
        }
        private int fact(int n)
        {
            if (n == 0) return 0;
            int fact = 1;
            for (int i = 1; i <= n; ++i)
                fact *= i;
            return fact; 
        }
    }
}
