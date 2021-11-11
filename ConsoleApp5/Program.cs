using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public delegate void deli(int a);
 
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Apple app1 = new Apple();
            //app1.AppleV = 5;
            //Orange org1 = new Orange();
            //org1.OrangeV = 5;
            //PineApple Pin1 = new PineApple();
            //Pin1.PineAppleV = 5;

            //List<int> Basket = new List<int>();
            //Basket.Add(app1.AppleV);
            //Basket.Add(org1.OrangeV);
            //Basket.Add(Pin1.PineAppleV);
            #endregion
            #region task2
            //task2 tsk = new task2();
            //tsk.Date = 2000;
            //tsk.Name = "E";
            //task2 tsk1=new task2();
            //tsk1.Date = 2058;
            //tsk1.Name = "B";

            //task2 tsk3 = new task2();
            //tsk3.Name = "sa";
            //tsk3.Date = 1999;
            //List<task2> History = new List<task2>();
            //History.Add(tsk);
            //History.Add(tsk1);
            //History.Add(tsk3);
            ////History.Sort();

            //History.Sort((a,b)=>a.Name.CompareTo(b.Name));
            //foreach (var item in History)
            //{
            //    Console.WriteLine($"{item.Name}  +  {item.Date}");
            //}

            //History.Sort((a, b) => a.Date.CompareTo(b.Date));
            //foreach (var item in History)
            //{
            //    Console.WriteLine($"{item.Date}  +  {item.Name}");
            //}
            #endregion
            ///Delegate yaradırsız,int tipindən ədəd qəbul edəcək.Aşağdakıları yazdırmalıdır.

            // -Ədədin mənfi olub-olmadığını yazdırsın.
            //  - Ədədin sadə olub olmadığını yazdırsın.
            //-Ədədin tək və ya cüt olmasını yazdırsın.

         


            deli del = Menfi;
            del += Sade;
            del += Pair;
            del(5);
            

        }

        public static void Menfi(int a)
        {

            if (a>0)
            {
                Console.WriteLine("eded musbetdir");
            }
            else
            {
                Console.WriteLine("menfi ededddir");
            }
        }

        public static void Sade(int a)
        {


            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    Console.WriteLine("ve sadedir");
            }
            Console.WriteLine("ve murekkebdir");
        }
        public static void Pair(int a)
        {
            if (a % 2 == 0) { Console.WriteLine("cutdur"); }

            else
            {
                Console.WriteLine("tekdir");
            }

        }
    }
}
