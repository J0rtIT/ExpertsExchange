using System;
using System.IO;

namespace FormatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"D:\ghcode\j0rt3g4\ExpertsExchange\FormatingText\backup_files.log.txt");

            string date;
            string time;
            string error;
            //var sb = new StringBuilder();
            foreach (var line in lines)
            {

                if (line.StartsWith("W"))
                {
                    String[] test = line.Split(new char[] { ' ' }, 6);
                    date = test[1];
                    time = test[2];
                    error = test[5];

                    //sb.AppendLine(line);
                }
            }


        }
    }
}
