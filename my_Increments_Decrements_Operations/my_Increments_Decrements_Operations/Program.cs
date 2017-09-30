using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Increments_Decrements_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increments - Decrements Operations
            int Incre_ments1 = 10;
            int Incre_ments2 = 10;
            int decr_ements1 = 10;
            int decr_ements2 = 10;

            Console.WriteLine(" Increments number {0} \n decrements number  {1} ", Incre_ments1, decr_ements1);

            int temp1 = ++Incre_ments1; // عند وضع علامة الزيادة ++ قبل الرقم او المتغير انتجر تتغير قيمة الرقم او المتغير حتى وان ارفقت قيمته لمتغير اخر  
            int temp2 = Incre_ments2++; //عند وضع علامة الزيادة ++ بعد الرقم او المتغير انتجر تتغير قيمة الرقم او المتغير لاكن لاتتغير اذا ارفقت قيمته لمتغير اخر
            int temp3 = --decr_ements1; // عند وضع علامة الزيادة -- قبل الرقم او المتغير انتجر تتغير قيمة الرقم او المتغير حتى وان ارفقت قيمته لمتغير اخر
            int temp4 = decr_ements2--; //   عند وضع علامة الزيادة -- بعد الرقم او المتغير انتجر تتغير قيمة الرقم او المتغير لاكن لاتتغير اذا ارفقت قيمته لمتغير اخر 



            Console.WriteLine("\n 1-Increments {0} \n 2-Increments {1} \n 3-decrements {2}\n 4-decrements {3} ",temp1,temp2,temp3,temp4);

             
            Console.WriteLine("\n\n ==============\n");
            //  challenge


            int var1 = 5;
            Console.WriteLine(" var1 = {0} ", var1);


            int temp = var1++; // temp = 5 ++ /temp = 5 /  لكن عملية الزيادة تكون بعد الارفاق القيمة (temp) الى المتغير (var1)ترفق قيمة متغير  

            Console.WriteLine(" temp {0}", temp);


            int temp_ = ++var1; // temp = ++6 / temp = 7 / لكن عملية الزيادة تكون قبل الارفاق القيمة (temp) الى المتغير (var1)ترفق قيمة متغير 

            Console.WriteLine(" temp {0}", temp_);


            //======================================

            int  my_var1 = 7, my_var2 = 2;
            float _temp1;

            Console.WriteLine(" my_var1-- = {0} \n ++my_var2 = {1}" ,my_var1 , my_var2);

            _temp1 = my_var1-- / ++my_var2;
            

            Console.WriteLine(" my_var1-- / ++my_var2 = {0}", _temp1);
          


            Console.ReadKey();
        }
    }
}
