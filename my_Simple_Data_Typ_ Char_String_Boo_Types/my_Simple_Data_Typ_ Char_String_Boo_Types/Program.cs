using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Simple_Data_Typ__Char_String_Boo_Types
{
    class Program
    {
        static void Main(string[] args)
        {   
             
            int my_max_char = char.MaxValue;
            int my_min_char = char.MinValue;

            char my_char = 'a';

            string my_string = "my first string";

           char my_convert_tochar =  Convert.ToChar(97);

            Console.WriteLine("\n my_max_char= {0}\n my_min_char= {1}\n my_char= {2}\n my_string= {3}\n my_convert_tochar= {4}", my_max_char, my_min_char, my_char, my_string, my_convert_tochar);
            Console.ReadKey();
        }
    }
}
