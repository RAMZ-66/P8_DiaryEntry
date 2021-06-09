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

            string todayAsStr = today.ToString(culture);

            string nombreDocumento = todayAsStr.Substring(0,10);

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

                // No se que pasa con la variable de tiempo "todayAsStr", si la utilizo para el nombre con el que se va a guardar 
                // el atchivo .txt, me sale un error y el programa no se ejecuta correctamente, por lo que nombro el 
                // archivo directamente con un string para que funcione
                // No sé si estoy haciendo algo mal

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
