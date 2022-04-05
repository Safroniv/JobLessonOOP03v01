using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonOOP03v01Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            string string001 = "АбВгДеЖз";
            Console.WriteLine(Reverse(string001));
            string string002 = "String To Reverse TEST 002";
            Console.WriteLine(Reverse(string002));
            string string003 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Reverse(string003));
            Console.ReadLine();
        }
        static string Reverse (string string1)
        {
            char[] arrayChars = string1.ToCharArray();
            Array.Reverse(arrayChars);
            return new string(arrayChars);
        }
    }
}
