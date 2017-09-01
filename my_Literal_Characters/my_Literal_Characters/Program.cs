using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {// المعرفات الحرفية بلغة السي شارب
            int my_int_literat = 100;   //لا تستعمل المعارف الحرفية في نوع انتجر
            uint my_uint_literal = 100u;//ليس من الضروري وضع التعريف الحرفي
            long my_long_literal = 100;//ليس من الضروري وضع التعريف الحرفي

            //المعارف الحرفية في نوعع الفلوت  
            float my_float_literal = 100f;//يجب وضع المعارف الحرفية
            double my_double_literal =100d;//يجب وضع المعارف الحرفية
            decimal my_desimal_literal =100m;//يجب وضع المعارف الحرفية
         
            Console.WriteLine("my_int_literat= {0}\n my_uint_literal= {1}\n my_long_literal= {2}\n my_float_literal= {3}\n my_double_literal= {4}\n my_desimal_literal= {5}", my_int_literat, my_uint_literal, my_long_literal, my_float_literal, my_double_literal, my_desimal_literal);
            Console.ReadKey();

        }
    }
}
