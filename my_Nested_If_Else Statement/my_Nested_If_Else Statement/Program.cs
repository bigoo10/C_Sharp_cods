using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Nested_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nested If Else Statement (1) الجمل الشرطية المتداخلة 

            //============Example===========

            Console.WriteLine("============Example===========");

            int my_var1 = 9, my_var2 = 6;

            if (my_var1 == 9 )
            {
                Console.WriteLine(" my_var1 = 9");
                if (my_var2 == 7)
                 {
                    Console.WriteLine(" my_var2 is not equal 7");
                 }
                else
                 {
                        Console.WriteLine(" my_var2 == 7");
                 }

            }


             else
            {
                Console.WriteLine(" my_var1 is not equal 9");

            }

            //============the challenge===========

            Console.WriteLine("============the challenge===========");

            my_var1 = 10;
            my_var2 = 6;
            int my_var3 = 8;
             if ( my_var1 == 10 )
            {
                Console.WriteLine("The first condition: {0}",true);
                if ((my_var2 >= 5) && (my_var3 <= 9)) 
                Console.WriteLine("The second condition: {0}", true);
                else
                {
                    Console.WriteLine("The second condition: {0}", false);
                }
            }
            else
            {
                Console.WriteLine("The first condition: {0}", false);
            }


            //Nested If Else Statement (2) الجمل الشرطية المتداخلة 

            //============Example2===========

            Console.WriteLine("============Example2===========");

            if (my_var1 <= 9 && my_var2 >= 5)
            {
                Console.WriteLine("The first condition: {0}", true);
             }
            else if (my_var1 <= 10 && my_var2 >= 6)
            {
                Console.WriteLine("The first condition: {0}", false);
                Console.WriteLine("The second condition: {0}", true);
            
            }
            else if(my_var2 > 5 )
            {
                Console.WriteLine("The first condition: {0}", false);
                Console.WriteLine("The second condition: {0}", false);
                Console.WriteLine("The third condition: {0}", true);

            }
            else
            {
                Console.WriteLine("no one of the condition");
            }



            Console.ReadKey();
        }
    }
}
