using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Mathematical_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mathematical Operations المعاملات الرياضية 
             
            // + - / * % 

            int my_var1 = 15;
            int my_var2 = 10;
             
            int temp1 = my_var1 + my_var2;  // "+" عملية الجمع
            int temp2 = my_var1 - my_var1; // "-"  عملية الطرح   
            int temp3 = my_var1 / my_var2; // "/"  عملية القسمة
            int temp4 = my_var1 * my_var2; // "*"   عملية الضرب
            int temp5 = my_var1 % my_var2; // "%"    باقي القسمة

            Console.WriteLine(" Operand 1 : {0}  \n Operand 2 : {1}  \n\n addition : {2} \n subtraction : {3} \n division : {4} \n multiplication : {5} \n Rest of division : {6}", my_var1, my_var2, temp1, temp2, temp3, temp4, temp5);


            string my_str1 = "\n my name is \"MEROUANE SERRADJ\" ";        
            string my_str2 = "i am programmer \n";

            string im_programmer =  my_str1 + my_str2;

            Console.WriteLine("{0}", im_programmer); 
          
            


            //the challenge التحدي 

            int MY_var1 = 7;
            int MY_var2 = 3;

            int TEMP1 = MY_var1 + MY_var2;
            int TEMP2 =MY_var1 - MY_var2;
            int TEMP3 =MY_var1 / MY_var2;
            int TEMP4 =MY_var1 * MY_var2;
            int TEMP5 =MY_var1 % MY_var2;

            Console.WriteLine("=================\n");
            Console.WriteLine("the challenge\n");
            Console.WriteLine(" Operand 1 : {0}  \n Operand 2 : {1}  \n\n addition : {2} \n subtraction : {3} \n division : {4} \n multiplication : {5} \n Rest of division : {6} \n",MY_var1,MY_var2,TEMP1,TEMP2,TEMP3,TEMP4,TEMP5);


            string STR1 = " \"I am";
            string STR2 = " smart\"";

            string smart = STR1+ STR2 ;
            Console.WriteLine("{0}", smart);

             Console.ReadKey();




        }
    }
}
