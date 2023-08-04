using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Pasta = @"C:\MinhaPasta";

            try {
               IEnumerable <string> Folder = Directory.EnumerateDirectories(Pasta, "*.*",SearchOption.AllDirectories);

                Console.WriteLine("Listagem de Pastas:\n ");

                foreach (string folder in Folder)
                {
                    Console.WriteLine(folder);
                }
                Console.WriteLine();
                var Files = Directory.EnumerateFiles(Pasta, "*.*", SearchOption.AllDirectories);


                Console.WriteLine("Listas de Arquivos:\n ");

                foreach (string files in Files)
                {
                    Console.WriteLine(files);
                }
                //criando uma pasta dentro do repositorio
                Directory.CreateDirectory(Pasta + "\\NewFolder");


            }

            catch(IOException e) { 

                Console.WriteLine("Erro na execução");
                Console.WriteLine(e.Message);
            
            }


        }
    }
}
