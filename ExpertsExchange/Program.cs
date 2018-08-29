using System;
using System.Collections.Generic;

namespace ExpertsExchange
{
    class Program
    {
        static void Main()
        {
            List<ComponentModel> cm = new List<ComponentModel>();
            List<LeadTimeModel> lt = new List<LeadTimeModel>();

            //Filling up the Classes
            for (int i = 0; i < 10; i++)
            {
                cm.Add(new ComponentModel
                {
                    Cost = Convert.ToString(10 * i),
                    PartNo = Convert.ToString(100 * i),
                    LeadTime = "0",
                });

                lt.Add(new LeadTimeModel
                {
                    PartNo = Convert.ToString(100 * i),
                    LeadTime = i
                });

            }

            Console.WriteLine("ComponentModelList");
            PrintC(cm);
            Console.WriteLine("LeadTime");
            Print(lt);

            /* var fm = (from c in cm
                       from x in lt
                       where (c.PartNo == x.PartNo)
                       select new ComponentModel
                       {
                           Cost = c.Cost,
                           PartNo = c.PartNo,
                           LeadTime = Convert.ToString(x.LeadTime)
                       }).ToList();

             from c in cm
                 from x in lt
                 where (c.PartNo == x.PartNo)
                 select c.LeadTime = Convert.ToString(x.LeadTime);
                 */

            Console.WriteLine("Final Model");
            PrintC(cm);
            Console.ReadLine();


        }
        static void PrintC(List<ComponentModel> list)
        {
            Console.WriteLine("Cost\tPartNo\tLeadTime");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Cost}\t{item.PartNo}\t{item.LeadTime}");
            }
        }
        static void Print(List<LeadTimeModel> list)
        {
            Console.WriteLine("PartNo\tLeadTime");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.PartNo}\t{item.LeadTime}");
            }
        }

    }
}
