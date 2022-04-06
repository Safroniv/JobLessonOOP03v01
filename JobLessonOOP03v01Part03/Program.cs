using System;
using System.IO;


namespace JobLessonOOP03v01Part03
{
    class Program
    {
        public static void SearchMail(ref string s)
        {
            int pos = s.IndexOf("&");
            s = s.Substring(pos + 2);
            Console.WriteLine(s);

        }
        static void Main()
        {
            string[] arrayStringsFormFile = File.ReadAllLines(@"Emails.txt");
            for (int i = 0; i < arrayStringsFormFile.Length; i++)
            {
                int position = arrayStringsFormFile[i].IndexOf("&");
                string stringsFormFile = arrayStringsFormFile[i].Substring(position + 2);
                File.AppendAllText("newEmails.txt", stringsFormFile + Environment.NewLine);
                string s = arrayStringsFormFile[i];
                SearchMail(ref s);
            }
            Console.ReadLine();
        }
    }
}
