namespace XmlIntoClass
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://bacnet.org/csml/1.2", IsNullable = false)]
    public partial class Collection
    {

        private CollectionCollection[] collection1Field;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Collection")]
        public CollectionCollection[] Collection1
        {
            get
            {
                return this.collection1Field;
            }
            set
            {
                this.collection1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollection
    {

        private CollectionCollectionStruct[] structField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Struct")]
        public CollectionCollectionStruct[] Struct
        {
            get
            {
                return this.structField;
            }
            set
            {
                this.structField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStruct
    {

        private CollectionCollectionStructEnumerated[] enumeratedField;

        private CollectionCollectionStructCollection collectionField;

        private CollectionCollectionStructString[] stringField;

        private CollectionCollectionStructStruct structField;

        private string nameField;

        private string nodeTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Enumerated")]
        public CollectionCollectionStructEnumerated[] Enumerated
        {
            get
            {
                return this.enumeratedField;
            }
            set
            {
                this.enumeratedField = value;
            }
        }

        /// <remarks/>
        public CollectionCollectionStructCollection Collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("String")]
        public CollectionCollectionStructString[] String
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }

        /// <remarks/>
        public CollectionCollectionStructStruct Struct
        {
            get
            {
                return this.structField;
            }
            set
            {
                this.structField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nodeType
        {
            get
            {
                return this.nodeTypeField;
            }
            set
            {
                this.nodeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructEnumerated
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructCollection
    {

        private CollectionCollectionStructCollectionStruct[] structField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Struct")]
        public CollectionCollectionStructCollectionStruct[] Struct
        {
            get
            {
                return this.structField;
            }
            set
            {
                this.structField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructCollectionStruct
    {

        private CollectionCollectionStructCollectionStructString stringField;

        private string nameField;

        /// <remarks/>
        public CollectionCollectionStructCollectionStructString String
        {
            get
            {
                return this.stringField;
            }
            set
            {
                this.stringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructCollectionStructString
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructString
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructStruct
    {

        private CollectionCollectionStructStructReal[] realField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Real")]
        public CollectionCollectionStructStructReal[] Real
        {
            get
            {
                return this.realField;
            }
            set
            {
                this.realField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://bacnet.org/csml/1.2")]
    public partial class CollectionCollectionStructStructReal
    {

        private string nameField;

        private decimal valueField;

        private string displayNameField;

        private string descriptionField;

        private string physicalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string physical
        {
            get
            {
                return this.physicalField;
            }
            set
            {
                this.physicalField = value;
            }
        }
    }


}
