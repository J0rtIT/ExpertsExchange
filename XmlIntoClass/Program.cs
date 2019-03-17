using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlIntoClass
{
    class Program
    {

        public static StringBuilder ReturnXmlwithout1stLine(string path)
        {
            //read the files by line:
            var lines = File.ReadAllLines(path);
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var line in lines)
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    sb.AppendLine(line);
                }
            }

            return sb;
        }
        public void ReadRecursively(XmlDocument doc)
        {
            StringBuilder MainXml = new StringBuilder();
            doc.LoadXml(MainXml.ToString());
            if (doc.HasChildNodes)
            {





            }
                


        }
        static void Main(string[] args)
        {

            StringBuilder docstring =  ReturnXmlwithout1stLine(@"D:\ghcode\j0rt3g4\ExpertsExchange\XmlIntoClass\file2.xml");

            //All the information of the file is on sb

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sb.ToString());
            //string json =  JsonConvert.SerializeXmlNode(doc);

            var allchildsInTop = doc.ChildNodes;


            foreach (XmlNode dc in doc.ChildNodes)
            {
                foreach (XmlNode sc in dc.ChildNodes)
                {
                    StringBuilder attributes = new StringBuilder();
                    foreach (XmlAttribute atr in sc.Attributes)
                    {
                        attributes.AppendLine($"{atr.Name}\t{atr.Value}");
                    }

                    Console.WriteLine($"Value:{sc.Value}\tName:{attributes}");

                    if (sc.HasChildNodes)
                    {
                        foreach (XmlNode other in sc.ChildNodes)
                        {
                            StringBuilder attribs = new StringBuilder();
                            foreach (XmlAttribute atr in other.Attributes)
                            {
                                attribs.AppendLine($"Value:{other.Value}\tName:{attribs}");
                            }
                            Console.WriteLine($"Value:{other.Value}\tName:{attribs}");
                        }
                    }


                }



            }

            // Console.WriteLine(json);

            /*


            var xml = XDocument.Load(@"D:\ghcode\j0rt3g4\ExpertsExchange\XmlIntoClass\file.mxl");


            string json = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(json);

            /*
            string NewTextFile = @"D:\ghcode\j0rt3g4\ExpertsExchange\XmlIntoClass\tmpfile.xml";
            StreamWriter sw;

            if (!File.Exists(NewTextFile))
            {
                //create
                sw = File.CreateText(NewTextFile);

            }
            else
            {
                // delete and create
                File.Delete(NewTextFile);
                sw = File.CreateText(NewTextFile);
            }


            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = lines[i];
                if (i == 1 || (i == lines.Length - 1))
                {
                    if (i == 1)
                    {
                        sw.WriteLine(@"<Collections name=""Test"" xmlns=""http://bacnet.org/csml/1.2"">");
                    }
                    else
                    {
                        sw.WriteLine("</Collections>");
                    }

                    //<Collections name="Test" xmlns="http://bacnet.org/csml/1.2">
                }
                else
                {
                    sw.WriteLine(line);
                }
                // Process line
            }
            sw.Close();
            


            var xml = XDocument.Load(@"D:\ghcode\j0rt3g4\ExpertsExchange\XmlIntoClass\file.mxl");
            /*
            using (XmlReader reader = XmlReader.Create(@"D:\ghcode\j0rt3g4\ExpertsExchange\XmlIntoClass\file.mxl"))
            {
                //get initial collection
                reader.Read();

                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        //Top level collection
                        case "Collection":
                            {
                                Console.WriteLine("Start <Collection> element.");

                                if (reader.Read())
                                {

                                    reader.Read();
                                    //this read would be next collection
                                    switch (reader.Name)
                                    {
                                        case "Collection":
                                            {
                                                Console.WriteLine("  Text node: " + reader.Value.Trim());
                                                break;
                                            }
                                    }

                                }

                                break;
                            }


                        case "article":
                            // Detect this article element.
                            Console.WriteLine("Start <article> element.");
                            // Search for the attribute name on this current node.
                            string attribute = reader["name"];
                            if (attribute != null)
                            {
                                Console.WriteLine("  Has attribute name: " + attribute);
                            }
                            // Next read will contain text.
                            if (reader.Read())
                            {
                                Console.WriteLine("  Text node: " + reader.Value.Trim());
                            }
                            break;
                    }
                }
            }

            var xml2 = new XmlTextReader(@"");

            // Query the data and write out a subset of contacts
            //var query = from c in xml.Root.Descendants("Collection")
            //.Descendants("Collection")
            //            from d in c.Descendants("Collection")
            //where (int)c.Attribute("id") < 4
            //          select c.Descendants("Struct");
            /*select c.Element("firstName").Value + " " +
                   c.Element("lastName").Value;

            



foreach (string name in query)
{
    Console.WriteLine("Contact's Full Name: {0}", name);
}


            var test = from s in xml
                    .Descendants("Collection")
                       select s.Name;
                       */

            Console.ReadKey();
        }
        public static T DeserializeAndUnwrap<T>(string json)
        {
            JObject jo = JObject.Parse(json);
            return jo.Properties().First().Value.ToObject<T>();
        }
    }
}
