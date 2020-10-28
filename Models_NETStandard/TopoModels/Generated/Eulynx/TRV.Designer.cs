// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.2.0.0. www.xsd2code.com
//    {"TargetFramework":"Net20","NameSpace":"Models.TopoModels.Eulynx","CollectionObjectType":"Array","CollectionBase":"","ExcludeImportedTypes":true,"Properties":{"LazyLoading":true,"PrivateFieldCustomPrefix":""},"XmlAttribute":{"Enabled":true,"GenerateOrderXmlAttributes":true},"ClassParams":{"GenerateInSeparateFilesDirectory":""},"Miscellaneous":{"EnableDebug":true,"EnableSummaryComment":true},"CustomUsings":[{"NameSpace":"Models.TopoModels.Eulynx.Common"},{"NameSpace":"Models.TopoModels.Eulynx.EULYNX_Signalling"},{"NameSpace":"Models.TopoModels.Eulynx.DB"},{"NameSpace":"Models.TopoModels.Eulynx.EULYNX_XSD"},{"NameSpace":"Models.TopoModels.Eulynx.NetEntity"},{"NameSpace":"Models.TopoModels.Eulynx.NR"},{"NameSpace":"Models.TopoModels.Eulynx.ProRail"},{"NameSpace":"Models.TopoModels.Eulynx.RFI"},{"NameSpace":"Models.TopoModels.Eulynx.Signalling"},{"NameSpace":"Models.TopoModels.Eulynx.SNCF"},{"NameSpace":"Models.TopoModels.Eulynx.TRV"}]}
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace Models.TopoModels.Eulynx.TRV
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using Models.TopoModels.Eulynx.EULYNX_Signalling;
    using System.Xml;
    
    
    /// <summary>
    /// EBICAB balise.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="http://www.railtopomodel.org/schemas/TRV")]
    [XmlRootAttribute("atcBalise", Namespace="http://www.railtopomodel.org/schemas/TRV", IsNullable=false)]
    public partial class AtcBalise : Balise
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="MovableElement", Namespace="http://www.railtopomodel.org/schemas/TRV")]
    [XmlRootAttribute("movableElement", Namespace="http://www.railtopomodel.org/schemas/TRV", IsNullable=false)]
    public partial class MovableElement1 : MovableElement
    {
        #region Private fields
        private bool _canReportDegradedStatus;
        #endregion
        
        [XmlAttribute]
        public bool canReportDegradedStatus
        {
            get
            {
                return _canReportDegradedStatus;
            }
            set
            {
                _canReportDegradedStatus = value;
            }
        }
    }
}
#pragma warning restore
