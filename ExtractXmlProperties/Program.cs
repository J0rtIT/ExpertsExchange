using System;
using System.Collections.Generic;
using System.Xml;

namespace ExtractXmlProperties
{

    class Program
    {
        private static string OName { get; set; }
        private static string OPhysicaladdress { get; set; }
        private static string ODatasource { get; set; }
        private static string OResident { get; set; }

        static void Main()
        {
            List<FinalObject> foArray = new List<FinalObject>();
            XmlDocument xml = new XmlDocument();
            //Would need to update this line to where the file lies in your system
            xml.LoadXml(
                System.IO.File.ReadAllText(
                    @"C:\Users\Jose\source\repos\ExpertsExchange\ExtractXmlProperties\DataSources.xml"));

            XmlNodeList xnList = xml.SelectNodes("/Application/DataSourceRepository/DataObjects/DataObject");

            if (xnList != null)
                foreach (XmlNode test in xnList)
                {
                    if (test.Attributes != null)
                        foreach (XmlAttribute prop in test.Attributes)
                        {
                            switch (prop.Name)
                            {
                                case "PhysicalName":
                                    OPhysicaladdress = prop.Value;
                                    break;

                                case "OResident":
                                    OResident = prop.Value;
                                    break;
                                case "data_source":
                                    ODatasource = prop.Value;
                                    break;
                                case "name":
                                    OName = prop.Value;
                                    break;
                            }
                        }

                    FinalObject obj = new FinalObject
                    {
                        Name = OName,
                        PhysicalAddress = OPhysicaladdress,
                        DataSource = ODatasource,
                        Resident = OResident
                    };
                    foArray.Add(obj);
                }

            Print(foArray);
            Console.ReadLine();
        }

        public static void Print(List<FinalObject> fo)
        {
            int i = 1;
            foreach (var obj in fo)
            {
                Console.WriteLine($"{i} ---> Name:{obj.Name}\tPhysicalAddress={obj.PhysicalAddress}\tDataSource={obj.DataSource}");
                i++;
            }
        }
    }
}