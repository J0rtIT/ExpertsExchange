namespace ExtractXmlProperties
{
    public class FinalObject
    {
        public string PhysicalAddress { get; set; }
        public string Resident { get; set; }
        public string DataSource { get; set; }
        public string Name { get; set; }

        public FinalObject()
        {

        }

        public FinalObject(string phy, string res, string data, string name)
        {
            PhysicalAddress = phy;
            Resident = res;
            DataSource = data;
            Name = name;
        }
    }
}
