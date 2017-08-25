using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Integer_Type_end_value
{
    class Program
    {
        static void Main(string[] args)
        { sbyte my_max_sbyte = sbyte.MaxValue;
            sbyte my_min_sbyte = sbyte.MinValue;
            byte my_max_byte = byte.MaxValue;
            byte my_min_byte = byte.MinValue;
            short my_max_short = short.MaxValue;
            short my_min_short = short.MinValue;
            ushort my_max_ushort = ushort.MaxValue;
            ushort my_min_ushort = ushort.MinValue;
            int my_max_int = int.MinValue;
            int my_min_int = int.MinValue;
            uint my_max_uint = uint.MinValue;
            uint my_min_uint = uint.MinValue;
            long my_max_long = long.MaxValue;
            long my_min_long = long.MinValue;
            ulong my_max_ulong = ulong.MaxValue;
            ulong my_min_ulong = ulong.MinValue;

            Console.WriteLine("<<<====DataTypes Integer Type====>>>");
            Console.WriteLine("  my_max_sbyte= {0}\n  my_min_sbyte= {1}\n  my_max_byte={2}\n  my_min_byte= {3}\n  my_max_short= {4}\n  my_min_short= {5}\n  my_max_ushort= {6}\n  my_min_ushort= {7}", my_max_sbyte, my_min_sbyte, my_max_byte, my_min_byte, my_max_short, my_min_short, my_max_ushort, my_min_ushort);
            Console.WriteLine("  my_max_int= {0}\n  my_min_int= {1}\n  my_max_uint= {2}\n  my_min_uint= {3}\n  my_max_long= {4}\n  my_min_long= {5}\n  my_max_ulong= {6}\n  my_min_ulong= {7}", my_max_int, my_min_int, my_max_uint, my_min_uint, my_max_long, my_min_long, my_max_ulong, my_min_ulong);
            Console.ReadKey();





        }
    }
}
