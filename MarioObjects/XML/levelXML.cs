﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace MarioObjects
{

    // 
    // This source code was auto-generated by xsd, Version=2.0.50727.42.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {

        private rootObject[] objectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public rootObject[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootObject
    {

        private string oNameField;

        private int xField;

        private int yField;

        private int int1Field;

        private int int2Field;

        private int int3Field;

        private bool bool1Field;

        private bool bool2Field;

        private bool bool3Field;

        /// <remarks/>
        public string OName
        {
            get
            {
                return this.oNameField;
            }
            set
            {
                this.oNameField = value;
            }
        }

        /// <remarks/>
        public int X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public int Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public int Int1
        {
            get
            {
                return this.int1Field;
            }
            set
            {
                this.int1Field = value;
            }
        }

        /// <remarks/>
        public int Int2
        {
            get
            {
                return this.int2Field;
            }
            set
            {
                this.int2Field = value;
            }
        }

        /// <remarks/>
        public int Int3
        {
            get
            {
                return this.int3Field;
            }
            set
            {
                this.int3Field = value;
            }
        }

        /// <remarks/>
        public bool Bool1
        {
            get
            {
                return this.bool1Field;
            }
            set
            {
                this.bool1Field = value;
            }
        }

        /// <remarks/>
        public bool Bool2
        {
            get
            {
                return this.bool2Field;
            }
            set
            {
                this.bool2Field = value;
            }
        }

        /// <remarks/>
        public bool Bool3
        {
            get
            {
                return this.bool3Field;
            }
            set
            {
                this.bool3Field = value;
            }
        }
    }
}