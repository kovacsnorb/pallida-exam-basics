using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You should add your favourite animals as string after ./FavouriteAnimals.exe [animal] [animal]");
            }
            else
            {
                string path = "./favourites.txt";
                int counter = 0;
                try
                {
                    string[] content = File.ReadAllLines(path);
                    for (int i = 0; i < args.Length; i++)
                    {
                        for (int j = 0; j < content.Length; j++)
                        {
                            if (args[i] == content[j])
                            {
                                counter++;
                            }
                        }

                        if (counter == 0)
                        {
                            using (StreamWriter writer = File.AppendText(path))
                                writer.WriteLine(args[i]);
                        }
                        counter = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not read the file!");
                    return;
                }
            }
        }
    }
}
