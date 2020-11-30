// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.2.0.0. www.xsd2code.com
//    {"TargetFramework":"Net20","NameSpace":"Models.TopoModels.Eulynx","CollectionObjectType":"Array","CollectionBase":"","ExcludeImportedTypes":true,"Properties":{"LazyLoading":true,"PrivateFieldCustomPrefix":""},"XmlAttribute":{"Enabled":true,"GenerateOrderXmlAttributes":true},"ClassParams":{"GenerateInSeparateFilesDirectory":""},"Miscellaneous":{"EnableDebug":true,"EnableSummaryComment":true},"CustomUsings":[{"NameSpace":"Models.TopoModels.Eulynx.Common"},{"NameSpace":"Models.TopoModels.Eulynx.EULYNX_Signalling"},{"NameSpace":"Models.TopoModels.Eulynx.DB"},{"NameSpace":"Models.TopoModels.Eulynx.EULYNX_XSD"},{"NameSpace":"Models.TopoModels.Eulynx.NetEntity"},{"NameSpace":"Models.TopoModels.Eulynx.NR"},{"NameSpace":"Models.TopoModels.Eulynx.ProRail"},{"NameSpace":"Models.TopoModels.Eulynx.RFI"},{"NameSpace":"Models.TopoModels.Eulynx.Signalling"},{"NameSpace":"Models.TopoModels.Eulynx.SNCF"},{"NameSpace":"Models.TopoModels.Eulynx.TRV"}]}
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Models.TopoModels.Eulynx.NetEntity
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Models.TopoModels.Eulynx.Common;
    using System.Xml;
    
    
    /// <summary>
    /// Parent class for information that can definitely be localised, which is the case of most infrastructure-related objects.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
    [XmlRootAttribute("locatedNetEntity", Namespace="http://www.railtopomodel.org/schemas/NetEntity", IsNullable=false)]
    public partial class LocatedNetEntity : NetEntity
    {
        #region Private fields
        private tElementWithIDref[] _locations;
        #endregion
        
        /// <summary>
        /// A net entity is located in space. This location can be expressed in different location systems, each with its own coordinate system.
        /// </summary>
        [XmlElement("locations", Order=0)]
        public tElementWithIDref[] locations
        {
            get
            {
                return _locations;
            }
            set
            {
                _locations = value;
            }
        }
    }
    
    /// <summary>
    /// Anchor point for any infrastructure element that has a topological position
    /// </summary>
    [XmlIncludeAttribute(typeof(LocatedNetEntity))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
    [XmlRootAttribute("netEntity", Namespace="http://www.railtopomodel.org/schemas/NetEntity", IsNullable=false)]
    public partial class NetEntity : NetworkResource
    {
    }
    
    [XmlIncludeAttribute(typeof(Slope))]
    [XmlIncludeAttribute(typeof(SpeedLimit))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
    [XmlRootAttribute("netProperty", Namespace="http://www.railtopomodel.org/schemas/NetEntity", IsNullable=false)]
    public partial class NetProperty : NetworkResource
    {
        #region Private fields
        private BaseLocation[] _location;
        #endregion
        
        [XmlElement("location", Order=0)]
        public BaseLocation[] location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
    [XmlRootAttribute("slope", Namespace="http://www.railtopomodel.org/schemas/NetEntity", IsNullable=false)]
    public partial class Slope : NetProperty
    {
        #region Private fields
        private double _slope;
        #endregion
        
        [XmlElement(Order=0)]
        public double slope
        {
            get
            {
                return _slope;
            }
            set
            {
                _slope = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/NetEntity")]
    [XmlRootAttribute("speedLimit", Namespace="http://www.railtopomodel.org/schemas/NetEntity", IsNullable=false)]
    public partial class SpeedLimit : NetProperty
    {
        #region Private fields
        private double _speed;
        #endregion
        
        [XmlElement(Order=0)]
        public double speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
    }
}
#pragma warning restore