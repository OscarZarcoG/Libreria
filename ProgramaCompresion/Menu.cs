using System;


namespace ProgramaCompresion
{
    public class Menu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Comprimir una carpeta");
            Console.WriteLine("2. Comprimir un archivo");
            //Console.WriteLine("3. Comprimir una lista de archivos");
            Console.WriteLine("3. Descomprimir un archivo .zip");
            Console.WriteLine("4. Salir \n");
            Console.Write("Elije una opción (1-4):");
        }
    }
}
