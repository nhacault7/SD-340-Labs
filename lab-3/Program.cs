using System;
using System.IO;
using System.Linq;

namespace IntroToIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"D:\User\Documents";
            string outputPath = @"D:\User\Documents\TelegramCopy.txt";

            if (Directory.Exists(sourceDirectory))
            {
                try
                {
                    Directory.SetCurrentDirectory(sourceDirectory);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            string[] filesInDir = Directory.GetFiles(sourceDirectory);

            try
            {
                FileInfo inputFile = new FileInfo(filesInDir.First(f => f == sourceDirectory + @"\theMachineStops.txt"));
                FileInfo outputFile = new FileInfo(outputPath);

                if (outputFile.Exists)
                {
                    outputFile.Delete();
                }

                try
                {
                    string outputString = ReplacePeriodsWithSTOP(inputFile);

                    using (StreamWriter writer = outputFile.CreateText())
                    {
                        writer.WriteLine(outputString);
                    }
                } catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Could not locate file in directory {0}: {1}", sourceDirectory, e);
            }
        }

        public static string ReplacePeriodsWithSTOP(FileInfo inputFile)
        {
            using (StreamReader reader = inputFile.OpenText())
            {
                string line = reader.ReadToEnd();
                line = line.Replace(".", " STOP");

                return line;
            }
        }
    }
}