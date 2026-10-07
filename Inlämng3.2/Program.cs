using System;

namespace Inlämng3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara j = ja, n = nej");
            string gy = (Console.ReadLine());

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gy == "j" && ålder <= 22)
            {
                Console.WriteLine("Vi vill anställa dig;)");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal;(");
            }

        }
    }
}