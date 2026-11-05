using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("   SISTEMA - PROYECTO NARANJA   ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Ejecutar módulo principal");
            Console.WriteLine("2. Ver información del equipo");
            Console.WriteLine("3. Salir");
            Console.Write("\nSelecciona una opción: ");

            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\nEjecutando módulo principal... Presiona una tecla para continuar.");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\nProyecto desarrollado por Equipo Naranja. Presiona una tecla.");
                    Console.ReadKey();
                    break;
                case "3":
                    salir = true;
                    Console.WriteLine("\n¡Saliendo del programa!");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Presiona una tecla para intentar de nuevo.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
