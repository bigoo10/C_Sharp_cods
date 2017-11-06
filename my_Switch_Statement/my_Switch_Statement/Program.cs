using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace my_Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch Statement جملة التبديل لفحص حالة المتغيرات
            //===========Example1==========


            Console.WriteLine("===========Example1==========");
            string my_animal = "dog";
          
            switch (my_animal)
            {

                case "cat":
                    Console.WriteLine("my animal \"cat\"");
                    break;
                case " camel":
                    Console.WriteLine("my animal it's \"camel\"");
                    break;
                    case "dog":
                    Console.WriteLine("my animal it's \"dog\"");
                    break;
                default:
                    Console.WriteLine("no one");
                    break;                  
            }



            //===========Example2==========
            Console.WriteLine("===========Example2==========");


            int my_id_nember = 5555;

            switch (my_id_nember)
            {
                
                case 4444:
                    Console.WriteLine("my id nember it's equal : 4444");
                    break;
                case 3333:
                    Console.WriteLine("my id nember it's equal : 3333");
                    break;
                case 2222:
                    Console.WriteLine("my id nember it's equal : 2222");                
                    break;
                case 5555:
                    Console.WriteLine("my id nember it's equal : 5555");
                    break;
                default:
                    Console.WriteLine("my id nember it's not available");
                    break;

            }
            //===========the chalenge==========
            Console.WriteLine("===========the chalenge==========");


            string WahtHeSay = "Hello";

            switch (WahtHeSay)
            {
                case  "hello":
                    Console.WriteLine("hello");
                    break;
                case "bey":
                    Console.WriteLine("bey");
                    break;
                case "welcome":
                    Console.WriteLine("welcome");
                    break;
                default:
                    Console.WriteLine("NoOne");
                    break;

                    //  (default) حالات الكايس كلها غي مطابقة للقيمة المتغير لذا تختار ايقيمة نهم وستذهب لي



            }




            Console.ReadKey();












        }
    }
}
