using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace LibreriaDeCompresion
{
    public class Descomprimir
    {
        //Descomprimir el archivo
        public static void Descomp(string archivoOri, string carpetaDestino)
        {
            try
            {
                //*****************************************************************
                // Verificar si el archivo ZIP existe
                if (!File.Exists(archivoOri))
                {
                    Console.WriteLine("El archivo ZIP no existe.");
                    return;
                }


                //*****************************************************************
                // Descomprimir el archivo ZIP
                ZipFile.ExtractToDirectory(archivoOri, carpetaDestino);

                Console.WriteLine($"Archivo ZIP '{archivoOri}' descomprimido correctamente en '{carpetaDestino}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descomprimir el archivo: {ex.Message}");
            }
        }
    }
}
