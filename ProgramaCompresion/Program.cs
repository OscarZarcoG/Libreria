using System;
using System.Collections.Generic;

namespace ProgramaCompresion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, usuario!");
            Console.WriteLine("Este es un programa de compresión de archivos.");
            while (true)
            {
                Menu oMenu = new Menu();
                oMenu.MostrarMenu();

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa la ruta de la carpeta a comprimir: ");
                        string carpetaOrigen = Console.ReadLine();

                        Console.Write("Ingresa el nombre del archivo comprimido (.zip): ");
                        string archivoDestino = Console.ReadLine();

                        Console.Write("Ingresa la ruta de la carpeta donde se guardará el archivo: ");
                        string lugarGuardarCarpeta = Console.ReadLine();

                        LibreriaDeCompresion.ComprimirCarpetas.CompCarpetas(carpetaOrigen, archivoDestino, lugarGuardarCarpeta);
                        break;

                    case "2":
                        Console.Write("Ingresa la ruta del archivo a comprimir: ");
                        string archivoOrigen = Console.ReadLine();

                        Console.Write("Ingresa el nombre del archivo comprimido (.zip): ");
                        string archivoDestinoInd = Console.ReadLine();

                        LibreriaDeCompresion.ComprimirArchivos.ComprimirArchivoIndividual(archivoOrigen, archivoDestinoInd);
                        break;

                    case "3":
                        Console.Write("Ingresa el nombre del archivo a descomprimir: ");
                        string archivoOrigen2 = Console.ReadLine();

                        Console.Write("Ingresa el nombre del archivo descomprimido: ");
                        string carpetaDestino = Console.ReadLine();
                        LibreriaDeCompresion.ComprimirCarpetas.DescompCarpetas(archivoOrigen2, carpetaDestino);
                        break;
                    case "4":
                        Console.WriteLine("Hasta luego usuario!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }
    }
}







/*
 VIDEOS Y SITIOS DE GUÍA PARA HACER LA LIBRERÍA:
https://youtu.be/nNKAXf9B1qo?si=svWOTf1razzfGiED
https://youtu.be/cbUWbQq2kYw?si=WIHfmwYut4xL4wbW
https://youtu.be/qv6iIky5r4U?si=CnMhGpmONMaymv5c
https://youtu.be/soQJ2nsqFpA?si=i1cltXMzQ88LNc7c
https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.zipfile?view=net-8.0
https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.zipfile?view=net-8.0
https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.ziparchiveentry?view=net-8.0
https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.ziparchive?view=net-8.0
https://barcelonageeks.com/metodo-console-clear-en-c/
 */


