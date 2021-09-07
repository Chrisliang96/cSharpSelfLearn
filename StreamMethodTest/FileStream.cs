using System.IO;
using System.Text;
using static System.Console;

namespace cSharpSelfLearn.Stream
{
    public class FileStreamDemo
    {
        

        static void ReadFileByUsingStream()
        {
            string line;

            try
            {
                var fileStream = new FileStream("Log.txt",FileMode.Open);
                StreamReader sr = new StreamReader(fileStream,Encoding.UTF8);
                line = sr.ReadLine();
                // Read data in line by line.
                while (line != null)
                {
                    WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException e)
            {
                WriteLine("An IO exception has been thrown!");
                WriteLine(e.ToString());
                //return;
            }
            ReadKey();
        }
    }
}