using System;
using System.IO;
namespace secao13_trabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Aula 195 - File, FileInfo, IOException */

            /*string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }*/

            /*Aula 196 - FileStream e StremReader*/
            /* string path = @"c:\temp\file1.txt";
             FileStream fs = null;
             StreamReader sr = null;
             try
             {
                 fs = new FileStream(path, FileMode.Open);
                 sr = new StreamReader(fs);
                 string line = sr.ReadLine();
                 Console.WriteLine(line);
             }
             catch (IOException e)
             {

                 Console.WriteLine("An error occurred");
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 if (sr != null) sr.Close();
                 if (fs != null) fs.Close();
             }*/
            /*Aula 197 - Bloco Using*/

            /*string path = @"c:\temp\file1.txt";
             try
             {
                 using (FileStream fs = new FileStream(path, FileMode.Open))
                 {
                     using (StreamReader sr = new StreamReader(fs))
                     {
                         while (!sr.EndOfStream)
                         {
                             string line = sr.ReadLine();
                             Console.WriteLine(line);
                         }
                     }
                 }
             } catch(IOException e)
             {
                 Console.WriteLine("An Error Occurred");
                 Console.WriteLine(e.Message);
             }
            try
            {
                  using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }*/

            /*Aula 198 - StreamWriter*/
            /* string sourcePath = @"c:\temp\file1.txt";
             string targetPath = @"c:\temp\file2.txt";

             try
             {
                 string[] lines = File.ReadAllLines(sourcePath);
                 using(StreamWriter sw = File.AppendText(targetPath))
                 {
                     foreach(string line in lines)
                     {
                         sw.WriteLine(line.ToUpper()); 
                     }
                 }
             }
             catch (IOException e)
             {

                 Console.WriteLine("An Error Occurred");
                 Console.WriteLine(e.Message);
             }*/

            /*Aula 199 Directory, DirectoryFile*/

            /*string path = @"c:\temp\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (var s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }

                // Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message); 
            }*/

            /*Aula 200 - path*/
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath" + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath" + Path.GetTempPath());

        }
    }
}
