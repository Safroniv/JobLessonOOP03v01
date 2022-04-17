using System;

namespace JobLessonOOP03v01Part02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("АбВгДеЖз"));
            Console.WriteLine(Reverse("String To Reverse TEST 002"));
            while (Console.ReadLine() != "qwit")
            {
                Console.WriteLine(Reverse(Convert.ToString(Console.ReadLine())));
            }
        }
        static string Reverse(string string1)
        {

            char[] arrayChars = string1.ToCharArray();
            string reverse = "";
            for (int i = arrayChars.Length; i > 0; i--)
            {

                reverse += arrayChars[i - 1];
            }
            //Можно было и так сделать:
            //char[] arrayChars = string1.ToCharArray();
            //Array.Reverse(arrayChars);
            return reverse;
        }
    }
}
