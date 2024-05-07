using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace LibreriaDeCompresion
{
    public class ComprimirCarpetas
    {
        public static void CompCarpetas(string carpetaOrigen, string archivoDestino = "", string LugarGuardarCarpeta = "")
        {
            try
            {
                //*****************************************************************
                // Verificamos si el usuario puso un nombre sino le damos uno por defecto
                if (string.IsNullOrWhiteSpace(archivoDestino))
                {
                    // Nombre predeterminado
                    archivoDestino = "Carpeta_comprimida.zip";
                }
                else
                {
                    if (!archivoDestino.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                    {
                        archivoDestino += ".zip";
                    }
                }


                //*****************************************************************
                // Verificar si hay otra carpeta, sino aqui vamos a usar la carpeta que dimos antes
                if (string.IsNullOrWhiteSpace(LugarGuardarCarpeta))
                {
                    LugarGuardarCarpeta = Path.GetDirectoryName(carpetaOrigen); // Usar la carpeta original

                }
                // Con esto vamos a verificar que la carpeta que dió el usuario si existe, y si es que no se crea una nueva
                if (!Directory.Exists(LugarGuardarCarpeta))
                {
                    Directory.CreateDirectory(LugarGuardarCarpeta);
                }


                //*****************************************************************
                // Validamos que el archivo no existe, si ya está no se crea, porqué aún no se como sobreeescribirlo
                string rutaArchivoDestino = Path.Combine(LugarGuardarCarpeta, archivoDestino);

                if (File.Exists(rutaArchivoDestino))
                {
                    Console.WriteLine("No se pudo crear el archivo ZIP porque ya existe");
                    return;
                }


                //*****************************************************************
                // Comprimir la carpeta
                ZipFile.CreateFromDirectory(carpetaOrigen, rutaArchivoDestino);

                Console.WriteLine($"Archivo ZIP '{rutaArchivoDestino}' creado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al comprimir archivos: {ex.Message}");
            }
        }


        public static void DescompCarpetas(string archivoOrigen2, string carpetaDestino = "")
        {
            try
            {
                //*****************************************************************
                if (string.IsNullOrWhiteSpace(carpetaDestino))
                {
                    carpetaDestino = Directory.GetCurrentDirectory();
                }


                //*****************************************************************
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }


                //*****************************************************************
                ZipFile.ExtractToDirectory(archivoOrigen2, carpetaDestino);

                Console.WriteLine($"Carpeta descomprimida en '{carpetaDestino}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al descomprimir archivos: {ex.Message}");
            }
        }
    }
}
