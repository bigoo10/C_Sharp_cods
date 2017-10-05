using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean Operators المعاملات المنطقية
            // boolean comparison  ( == , != , < , > , <= , >= )       
            //bolean conditions     (&& , ||)

            Console.WriteLine("\n \n==================boolean comparison ( == , != , < , > , <= , >= )===================== ");
            // boolean comparison   == , != , < , > , <= , >=  
            bool comparison1, comparison2 ,comparison3 ,comparison4 ,comparison5 ,comparison6;
            int operant1 = 10, operant2 = 5 ;
            int operant3 = 10, operant4 = 5;
            int operant5 = 10, operant6 = 5;
            int operant7 = 10, operant8 = 5;
            int operant9 = 10, operant10 = 5;
            int operant11 = 10, operant12 = 5;




            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison1 = (operant1 == operant2); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 == operant2) = {0} ", comparison1); //اي خطاء false النتيجة 


            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison2 = (operant3 != operant4); //اي صحيحة true النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 != operant2) = {0} ", comparison2);  //اي صحيحة true النتيجة 


            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison3 = (operant5 < operant6); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 < operant2)  = {0} ", comparison3); //اي خطاء false النتيجة 



            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison4 = (operant7 > operant8); //اي صحيحة true النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 > operant2)  = {0} ", comparison4);  //اي صحيحة true النتيجة 



            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison5 = (operant9 <= operant10); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 <= operant2) = {0} ", comparison5); //اي خطاء false النتيجة 




            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            comparison6 = (operant11 >= operant12);  //اي صحيحة true النتيجة 
            Console.WriteLine(" \nComparison result: (operant1 >= operant2) = {0} ", comparison6);  //اي صحيحة true النتيجة 


            Console.WriteLine("\n \n=====================bolean conditions (&& , ||)======================== ");


            //bolean conditions     && , ||

            //    Logical AND (&&)                          Logical OR (||)             
            //     false  &&   false : false                 false  &&   false :  false
            //     false  &&   true  : false                 false  &&   true  :  true
            //     true   &&   false : false                 true   &&   false :  true
            //     true   &&   true  : true                  true   &&   true  :  true


            Console.WriteLine("\n Logical AND (&&)  ");
            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            //    Logical AND (&&)                                     
       
            bool conditions;
            conditions  = (operant1 == operant2) && (operant1 <= operant2); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison AND (&&) result: (operant1 == operant2) && (operant1 <= operant2) = {0} ", conditions); //اي خطاء false النتيجة 

            conditions = (operant1 < operant2) && (operant1 >= operant2); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison AND (&&) result: (operant1 > operant2)  && (operant1 >= operant2) = {0} ", conditions); //اي خطاء false النتيجة 

            conditions = (operant1 > operant2) && (operant1 <= operant2); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison AND (&&) result: (operant1 > operant2)  && (operant1 <= operant2) = {0} ", conditions); //اي خطاء false النتيجة 

            conditions = (operant1 != operant2) && (operant1 > operant2); //اي صحيحة true النتيجة
            Console.WriteLine(" \nComparison AND (&&) result: (operant1 != operant2) && (operant1 > operant2)  = {0} ", conditions); //اي صحيحة true النتيجة



            Console.WriteLine("\n __________________________________________________________________________________");

            Console.WriteLine("\n Logical OR (||)  ");
            Console.WriteLine(" \n operant1 = {0}, operant2 = {1} ", operant1, operant2);
            //    Logical OR (||)                                     


            conditions = (operant1 == operant2) || (operant1 <= operant2); //اي خطاء false النتيجة 
            Console.WriteLine(" \nComparison OR (||) result: (operant1 == operant2) || (operant1 <= operant2) = {0} ", conditions); //اي خطاء false النتيجة 

            conditions = (operant1 < operant2) || (operant1 >= operant2); //اي صحيحة true النتيجة
            Console.WriteLine(" \nComparison OR (||) result: (operant1 > operant2)  || (operant1 >= operant2) = {0} ", conditions); //اي صحيحة true النتيجة

            conditions = (operant1 > operant2) || (operant1 <= operant2); //اي صحيحة true النتيجة
            Console.WriteLine(" \nComparison OR (||) result: (operant1 > operant2)  || (operant1 <= operant2) = {0} ", conditions); //اي صحيحة true النتيجة

            conditions = (operant1 != operant2) || (operant1 > operant2); //اي صحيحة true النتيجة
            Console.WriteLine(" \nComparison OR (||) result: (operant1 != operant2) || (operant1 > operant2)  = {0} ", conditions); //اي صحيحة true النتيجة



            Console.WriteLine("\n \n=====================the challenge======================== ");

            bool Comparison1;
            int my_var1 = 9, my_var2 = 11;

            Comparison1 = (my_var1 < 10) && (my_var2 <= 11); // Comparison1 = true && true = true   Logical AND (&&) حسب جدول
            Console.WriteLine(" (my_var1 < 10) || (my_var2 <= 11) = {0}", Comparison1);

            Comparison1 = (my_var1 < 10) || (my_var2 <= 11); //Comparison1 = true || true = true   Logical OR (||) حسب جدول 
            Console.WriteLine(" (my_var1 < 10) && (my_var2 <= 11) = {0}", Comparison1);
           




            Console.ReadKey();














        }
    }
}
