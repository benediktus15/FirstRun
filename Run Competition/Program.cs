using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total=0;

            // Looping
            while (true)
            {
                // Keluarkan pertanyaan
                Console.WriteLine("Berapa Lama Berolahraga ?");

                // Minta inout dari user 
                input = Console.ReadLine();

                // Menambahkan inputny
                total = total + Int32.Parse(input);                                
                                 
                // Keluar bila user input "quit"
                if (input == "quit")
                {
                    break;
                }

                // Keluar inputnya
                Console.WriteLine("anda berolahraga sebanyak " + input + " menit. ");
                
            }


        }

       
    }
}
