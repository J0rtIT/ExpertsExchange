using System;
using System.Linq;

namespace ListorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.experts-exchange.com/questions/29121134/C-list-or-array-maybe-output-to-xml.html
            /*
             ID       Name                         BulkData
            1      1 - Shippensburg         s038,Store 038
            1      1 - Shippensburg         s056,Store 056
            2      2 - State College         s033,Store 033
            2      2 - State College         s051,Store 051
            2      2 - State College         s137,Store 137
            2      2 - State College         s187,Store 187
            3      3 - Wellsboro         s198,Store 198
            */

            SqLInfo[] infoarray = new SqLInfo[7];
            infoarray[0] = new SqLInfo(1, "1 - Shippensburg", "s038,Store 038");
            infoarray[1] = new SqLInfo(1, "1 - Shippensburg", "s056,Store 056");
            infoarray[2] = new SqLInfo(2, "2 - State College", "s033,Store 033");
            infoarray[3] = new SqLInfo(2, "2 - State College", "s051,Store 051");
            infoarray[4] = new SqLInfo(2, "2 - State College", "s137,Store 137");
            infoarray[5] = new SqLInfo(2, "2 - State College", "s187,Store 187");
            infoarray[6] = new SqLInfo(3, "3 - Wellsboro", "s198,Store 198");

            PrintSqlInfos(infoarray);


            var order = from p in infoarray
                        group p.BulkData by p.Id into g
                        select new OrderedInfo { Id = g.Key, BulkData = string.Join(",", g.ToList()) };


            foreach (var item in order)
            {
                Console.WriteLine($"{item.Id}\t{item.BulkData}");
            }





            Console.ReadKey();

        }


        public static void PrintSqlInfos(SqLInfo[] array)
        {
            Console.WriteLine("Id\tName\t\t\tBulkData");
            foreach (var item in array)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.BulkData}");
            }

            Console.WriteLine("================================\n");

        }

        public class SqLInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string BulkData { get; set; }

            public SqLInfo()
            {
            }

            public SqLInfo(int id, string name, string bulk)
            {
                Id = id;
                Name = name;
                BulkData = bulk;
            }
        }

        public class OrderedInfo
        {
            public int Id { get; set; }
            public string BulkData { get; set; }

        }
    }
}
