using System;
using System.Globalization;
using System.IO;

namespace P8_DiaryEntry
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Now;

            CultureInfo culture = new CultureInfo("es-MX");

            string todayAsStr = today.ToString("d/M/yyyy");

            string nombreDocumento = todayAsStr.Replace("/","-");

            string opcion = "";

            while (opcion != "cerrar")
            {

                Console.WriteLine(todayAsStr);

                Console.WriteLine("Porfavor introduce el texto por agregar a la entrada del diario, o introduce la palabra \"cerrar\" para dejar de escribir en el diario");

                Console.WriteLine("");

                string input = Console.ReadLine();

                if (input == "cerrar")
                {
                    opcion = "cerrar";
                    Console.WriteLine("\"Cerrando diario...\"");
                }

                else
                {
                    string DiaryEntry = input;

                    using (StreamWriter streamWriter = new StreamWriter ($"{nombreDocumento}.txt"))
                    {
                        streamWriter.WriteLine(DiaryEntry);
                    }
                }


            }



        }
    }
}
