using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;

namespace LibreriaDeCompresion
{
    public class ComprimirArchivos
    {
        public static void ComprimirArchivoIndividual(string archivoOrigen, string archivoDestino = "")
        {
            string nombreArchivo = Path.GetFileName(archivoOrigen);

            try
            {
                //*****************************************************************
                // Primero tengo que verificar si se especificó un nombre de archivo
                if (string.IsNullOrWhiteSpace(archivoDestino))
                {
                    archivoDestino = nombreArchivo + ".zip";
                }
                else
                {
                    // Y si es que si se especificó, asegurarse de que la terminación sea .zip
                    if (!archivoDestino.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                    {
                        archivoDestino += ".zip";
                    }
                }


                //*****************************************************************
                // Verificar si el archivo comprimido ya existe
                if (File.Exists(archivoDestino))
                {
                    Console.WriteLine("No se pudo crear el archivo ZIP porque ya existe");
                    return;
                }


                //*****************************************************************
                // Comprimir el archivo individual
                using (ZipArchive archive = ZipFile.Open(archivoDestino, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(archivoOrigen, nombreArchivo);
                }

                Console.WriteLine($"Archivo '{nombreArchivo}' comprimido correctamente como '{archivoDestino}'.");
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al comprimir el archivo: {ex.Message}");
            }
        }
    }
}


























/*
 
 public static void ComprimirListaArchivos(List<string> archivosOrigen, string archivoDestino = "")
        {
            try
            {
                // Verificar si se especificó un nombre de archivo de destino, sino, usar el nombre predeterminado
                if (string.IsNullOrWhiteSpace(archivoDestino))
                {
                    archivoDestino = "ListaArchivos_comprimidos.zip";
                }
                else
                {
                    // Asegurar que la extensión .zip esté presente en el nombre del archivo
                    if (!archivoDestino.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                    {
                        archivoDestino += ".zip";
                    }
                }

                // Verificar si el archivo comprimido ya existe
                if (File.Exists(archivoDestino))
                {
                    Console.WriteLine("No se pudo crear el archivo ZIP porque ya existe");
                    return;
                }

                // Comprimir la lista de archivos
                using (ZipArchive archive = ZipFile.Open(archivoDestino, ZipArchiveMode.Create))
                {
                    foreach (string archivoOrigen in archivosOrigen)
                    {
                        string nombreArchivo = Path.GetFileName(archivoOrigen);
                        archive.CreateEntryFromFile(archivoOrigen, nombreArchivo);
                    }
                }

                Console.WriteLine($"Archivos comprimidos correctamente como '{archivoDestino}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al comprimir los archivos: {ex.Message}");
            }
        }
 
 */