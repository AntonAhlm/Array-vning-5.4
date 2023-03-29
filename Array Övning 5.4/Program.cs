using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Årtal = {1990,2000,1500,1990,2024 };

            Console.Write("Skriv in ett årtal : ");
            int År=Convert.ToInt32(Console.ReadLine());
            int fanns=0;

            for(int i = 0; i <4 ;i++)
                if (År ==Årtal[i])
                {
                    Console.WriteLine("Ditt årtal finns på index " + i);
                    fanns++;
                
                }
            if (fanns == 0)
                Console.WriteLine("Årtalet fanns inte");

        }
    }
}
