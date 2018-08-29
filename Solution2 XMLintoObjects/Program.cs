using System.Xml;

namespace Solution2_XMLintoObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            string xml = @"
<prd_acks>
  <prd_ack>
    <owner_code>AA</owner_code>
    <prod_code>988</prod_code>
    <status>Failed</status>
    <error>Total Error: 1 Error Msg:Unable to find message no : 2763</error>
  </prd_ack>
</prd_acks>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            /*
            foreach (var item in doc.ChildNodes)
            {

            }

            XmlSerializer serializer = new XmlSerializer();
            */
        }
    }
}
