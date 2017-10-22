using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Statement الجمل الشرطية


            //======================Example1==================================
            Console.WriteLine("======================Example1==================================");
            int my_var = 11;
            if (my_var > 10) // تحقق الشرط سوف يطبع الكود
            {
                Console.WriteLine("my_var is Greater than 10 ");

            }

            //======================Example2==================================

            Console.WriteLine("======================Example2==================================");

            if (my_var != 11)
            {
                Console.WriteLine("{my_var is not is not equal:11}");


            }
            else
            {
                Console.WriteLine("my_var is equal : 11");

            }

            //====================Example3=================================

            Console.WriteLine("======================Example3==================================");

            int my_var1 = 30, my_var2 = 50;

            if ((my_var1 == 30) || (my_var2 <= 50))

            {
                Console.WriteLine("the condition is true");

            }
            else
            {
                Console.WriteLine("the condition is fals");
            }

            //=====================Example4=====================================
            Console.WriteLine("======================Example4==================================");


            int my_var3 = 20;
            string my_result;

            if (my_var3 < 20)
            {
                my_result = "my value is lass than 20";
                Console.WriteLine(my_result);

            }
            if (my_var3 > 20)
            {
                my_result = "my value is greater than 20 ";
                Console.WriteLine(my_result);
            }
            if (my_var3 == 20)
            {
                my_result = " my value is Equal 20 ";
                Console.WriteLine(my_result);
            }


            //==================the challenge1============

            Console.WriteLine("==================the challenge1============");

            int MyVar1 = 15;


            if (MyVar1 > 8)
            {
                Console.WriteLine("My Varibale is greater than : 8 ");
            }
            else
            {
                Console.WriteLine("My Varibale is lass than : 8 ");
            }



            //==================the challenge2============
            //==================Part1============
           
            Console.WriteLine("==================the challenge2============");
            Console.WriteLine("==================Part1============");

            int MyVar2 = 10, MyVar3 = 5, MyVar4 = 9;

            if ((MyVar2 <= 11) || ((MyVar3 == 5) & (MyVar4 >= 8))) // true || ( true & true) = true || true = true تحقق الشرط وتنفيذ الكود داخل الجملة الشرطية 
        
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);

            }


            //==================Part1============
            Console.WriteLine("==================Part1============");

            if ((MyVar2 <= 11) || ((MyVar3 == 6) & (MyVar4 >= 8))) // true || ( false & true) = true || false = true تحقق الشرط وتنفيذ الكود داخل الجملة الشرطية

            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);

            }








            Console.ReadKey();




        }
    }
}
