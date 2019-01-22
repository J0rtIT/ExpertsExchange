using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Combining2Csvs
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ErrorsCsv> values = File.ReadAllLines(@"D:\ghcode\j0rt3g4\ExpertsExchange\Combining2Csvs\Errors.csv")
                .Skip(1)
                .Select(ErrorsCsv.FromCsv)
                .ToList();

            ErrorsCsv.Printcsv(values);

            List<ErrorsTxt> txts = File.ReadAllLines(@"D:\ghcode\j0rt3g4\ExpertsExchange\Combining2Csvs\Errors.txt")
                .Select(ErrorsTxt.FromCsv)
                .ToList();

            ErrorsTxt.Printtxt(txts);

            List<FinalClass> final = new List<FinalClass>();

            int i = 0;
            foreach (var item in values)
            {

                final.Add(new FinalClass
                {
                    Employee = item.Employee,
                    JobNum = item.JobNum,
                    TranQty = item.TranQty,
                    DateTime = txts[i].DateTime,
                    Message = txts[i].Message
                });
                i++;
            }

            FinalClass.PrintFinal(final);

            Console.ReadKey();

        }


    }

    public class ErrorsCsv
    {
        public int Employee { get; set; }
        public string JobNum { get; set; }
        public int TranQty { get; set; }

        public static ErrorsCsv FromCsv(string s)
        {
            string[] values = s.Split(',');
            return new ErrorsCsv()
            {
                Employee = Convert.ToInt32(values[0]),
                JobNum = values[1],
                TranQty = Convert.ToInt32(values[2])
            };
        }

        public static void Printcsv(List<ErrorsCsv> lcsv)
        {
            Console.WriteLine("Employee\tJobNum\tTranQty")
                ;
            foreach (var item in lcsv)
            {
                Console.WriteLine($"{item.Employee}\t\t{item.JobNum}\t{item.TranQty}");
            }
        }
    }

    public class ErrorsTxt
    {
        public DateTime DateTime { get; set; }
        public string Message { get; set; }

        public static ErrorsTxt FromCsv(string s)
        {
            string[] values = s.Split(new[] { ' ' }, 2);

            return new ErrorsTxt()
            {
                DateTime = Convert.ToDateTime(values[0]),
                Message = values[1]
            };

        }

        public static void Printtxt(List<ErrorsTxt> ltxt)
        {
            Console.WriteLine("DateTime\t\t\tMessage")
                ;
            foreach (var item in ltxt)
            {
                Console.WriteLine($"{item.DateTime}\t{item.Message}");
            }
        }
    }

    class FinalClass : ErrorsCsv
    {
        public DateTime DateTime { get; set; }
        public string Message { get; set; }

        public static void PrintFinal(List<FinalClass> Total)
        {
            Console.WriteLine("DateTime\t\t\tEmployee\tJobNum\tTranQty\tMessage")
                ;
            foreach (var item in Total)
            {
                Console.WriteLine($"{item.DateTime}\t{item.Employee}\t\t{item.JobNum}\t{item.TranQty}\t{item.Message}");
            }
        }
    }
}
