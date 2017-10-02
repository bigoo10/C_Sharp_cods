using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Assignment_Operations
{
    class Program
    {
        static void Main(string[] args)

        {
            //عمليات التخصيص
            // = += -= *= /= %=

            float var_1 = 7, var_2 = 3;


            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1 , var_2);
            var_1 = var_2; // ويفقد قيمته (var_2) تساوي قيمة المتغير  (var_1)تصبح قيمة المتفير
            Console.WriteLine(" var_1 = var_2 : {0}", var_1);

            Console.WriteLine(" ====================");

            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1, var_2);
            var_1 += var_2; // var_1 = var_1 + var_2
            Console.WriteLine(" var_1 += var_2 ===>>> var_1 = var_1 + var_2 : {0}", var_1);

            Console.WriteLine(" ====================");

            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1, var_2); 
            var_1 -= var_2; //var_1 = var_1 - var_2
            Console.WriteLine(" var_1 -= var_2 ===>>> var_1 = var_1 - var_2 : {0}", var_1);

            Console.WriteLine(" ====================");

            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1, var_2);
            var_1 *= var_2;//var_1 = var_1 * var_2
            Console.WriteLine(" var_1 *= var_2 ===>>> var_1 = var_1 * var_2 : {0}", var_1);

            Console.WriteLine(" ====================");

            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1, var_2);
            var_1 /= var_2;//var_1 = var_1 +var_2
            Console.WriteLine(" var_1 /= var_2 ===>>> var_1 = var_1 / var_2 : {0}", var_1);

            Console.WriteLine(" ====================");

            Console.WriteLine(" var_1 = {0} \n var_2 = {1} ", var_1, var_2);       
            var_1 %= var_2;//var_1 = var_1 % var_2
            Console.WriteLine(" var_1 %= var_2 ===>>> var_1 = var_1 % var_2 : {0}", var_1);










            // challenge

            Console.WriteLine(" \n\n====================");
            Console.WriteLine(" ======  challenge  ======");
            

            float var1 = 7, var2 = 2;
            var1 /= ++var2;  //  var1 = 7 / 3  
            Console.WriteLine(@"var1 = {0}",var1);  // var1 = 2.3333
            Console.ReadKey();
            //  (var1) في المتغير (var1 /= ++var2) تخصص قيمة عملية 
            // (وتكون النتيجة (2.333


        }
    }
}
