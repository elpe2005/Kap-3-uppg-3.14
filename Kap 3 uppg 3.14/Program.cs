using System;
namespace Uppgift313
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiumet? svara j för ja och n för nej." );
            string svar = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder =int.Parse(Console.ReadLine());
            

            if (ålder < 22 && svar.ToLower == "j")
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }

        }
    }
}