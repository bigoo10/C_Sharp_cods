using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_String_Type_and_Escape_Characters
{
    class Program
    {
        //النوع الحرفي وحروف الهروب
        static void Main(string[] args)
        {

            // \' \" \\ \0 \a \b \n \r \t \v \f

            string my_Backslash = "my \"Backslash\"";        //تستعمل العلامة  في تجاهل علامات التنصيص                
            string my_Double_Backslash = "//comment";              //تستعمل قبل اي نص لدلالة على تعليق من المبرمج 
            string my_Backslash_ero = "my Backslash ero\0";   // تستعمل لدلالة على انتهاء السترينج
            string my_Backslash_a = "my \aBackslash a ";     //عند تشغيل البرنامج نسمع نغمة موسيقية
            string my_Backslash_b = "myy\b Backslash b";     //يستعمل في مسح او حذف الحرف الذي قبله
            string my_Backslash_n = "my Backslash n \n -----";    //تستعمل في الانتقال لسطر جديد
            string my_Backslash_r = " my \r my Backslash r";           //يستعمل في مسح ما قبله
            string my_Backslash_t = "my \tBackslash t";               //يترك خمسة مسافات بعده
            string my_Backslash_v = "my Backslash v \v";           //يضهر علامة مذكر 
            string my_Backslash_f = "my\fBackslash f ";            //يضهر علامة مؤنث
            string my_At_sign = @" my ,""At sign"" " ;           //يطبع كل مابعده

            Console.Title = ("my_String_Type_and_Escape_Characters"); 

            Console.WriteLine(" {0}\n {1}\n {2} \n {3} \n {4} \n {5} \n {6} \n {7} \n {8} \n {9} \n {10}", my_Backslash, my_Double_Backslash,my_Backslash_ero,my_Backslash_a,my_Backslash_b,my_Backslash_n,my_Backslash_r,my_Backslash_t,my_Backslash_v,my_Backslash_f,my_At_sign);
            Console.ReadKey();
        }
        

    }
}
