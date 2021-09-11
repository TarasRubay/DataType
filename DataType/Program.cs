using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 100, switch_on = menu,max_menu = 6;
            do
            {
                switch (switch_on)
                {
                    case 100:
                        do
                        {
                            Console.WriteLine("1 - Task 1");
                            Console.WriteLine("2 - Task 2");
                            Console.WriteLine("3 - Task 3");
                            Console.WriteLine("4 - Task 4");
                            Console.WriteLine("5 - Task 5");
                            Console.WriteLine("6 - Task 6");
                            Console.WriteLine("7 - Task 7");
                            Console.WriteLine("8 - Task 8");
                            Console.WriteLine("9 - Task 9");
                            Console.WriteLine("0 - exit");
                            try
                            {
                                switch_on = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception a)
                            {
                                Console.WriteLine(a.Message);
                            }
                        } while (switch_on < 0 || switch_on > max_menu);


                        break;
                    case 1:
                        Console.WriteLine("Task 1");
                        task1 t1 = new task1();
                        t1.task_1();
                        switch_on = menu;
                        break;
                    case 2:
                        Console.WriteLine("Task 2");
                        task2 t2 = new task2();
                        string str;
                        do
                        {
                            Console.WriteLine("enter num from 100 to 999");
                            try
                            {
                                str = Console.ReadLine();
                            }
                            catch (Exception a)
                            {
                                Console.WriteLine(a.Message);
                                str = "0";
                            }
                           
                        } while (str.Length != 3);
                        t2.task_2(Convert.ToInt32(str));
                        switch_on = menu;
                        break;
                    case 3:
                        Console.WriteLine("task 3");
                        task3 t3;
                        t3.task_3();
                        switch_on = menu;
                        break;
                    case 4:
                        Console.WriteLine("Task 4");
                        task4 t4;
                        t4.task_4();
                        switch_on = menu;
                        break;
                    case 5:
                        Console.WriteLine("Task 5");
                        task5 t5;
                        t5.task_5();
                        switch_on = menu;
                        break;
                    case 6:
                        Console.WriteLine("Task 6");
                        task6 t6;
                        t6.task_6();
                        switch_on = menu;
                        break;
                    case 7:
                        Console.WriteLine("Task 7");

                        switch_on = menu;
                        break;
                    case 8:
                        Console.WriteLine("Task 8");

                        switch_on = menu;
                        break;
                    case 9:
                        Console.WriteLine("Task 9");

                        switch_on = menu;
                        break;
                    default:
                        break;
                }

            } while (switch_on != 0);
        }
        
    }
}
