using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_FloatPoint_Type_end_value
{
    class Program
    {
        static void Main(string[] args)
        {
            float my_max_float = float.MaxValue;
            float my_min_float = float.MinValue;
            double my_max_double = double.MaxValue;
            double my_min_double = double.MinValue;
            decimal my_max_decimal = decimal.MaxValue;
            decimal my_min_decimal = decimal.MinValue;


            float float_value = 1f / 3;
            double double_value = 1d / 3;
            decimal decimal_value = 1m / 3;

            Console.WriteLine("<<<====FloatPointType====>>>");
            Console.WriteLine(" my_max_float= {0} \n my_min_float= {1} \n my_max_double= {2} \n my_min_double= {3}\n my_max_decimal= {4}\n my_min_decimal= {5}", my_max_float, my_min_float, my_max_double,my_min_double, my_max_decimal, my_min_decimal);
            Console.WriteLine("=============================");
            Console.WriteLine(" float_value ={0} \n double_value= {1}\n decimal_value= {2}",float_value,double_value,decimal_value);
            Console.ReadKey();

        }
    }
}
