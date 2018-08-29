namespace Solution2_XMLintoObjects
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class prd_acks
    {

        private prd_acksPrd_ack prd_ackField;

        /// <remarks/>
        public prd_acksPrd_ack prd_ack
        {
            get
            {
                return this.prd_ackField;
            }
            set
            {
                this.prd_ackField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class prd_acksPrd_ack
    {

        private string owner_codeField;

        private ushort prod_codeField;

        private string statusField;

        private string errorField;

        /// <remarks/>
        public string owner_code
        {
            get
            {
                return this.owner_codeField;
            }
            set
            {
                this.owner_codeField = value;
            }
        }

        /// <remarks/>
        public ushort prod_code
        {
            get
            {
                return this.prod_codeField;
            }
            set
            {
                this.prod_codeField = value;
            }
        }

        /// <remarks/>
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }


}
