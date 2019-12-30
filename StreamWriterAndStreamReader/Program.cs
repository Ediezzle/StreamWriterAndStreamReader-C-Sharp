using System;
using System.IO;

namespace StreamWriterAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            //equivalent of try with resources in java
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string line;
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
