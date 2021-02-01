 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using db = Models.TopoModels.EULYNX.db;

namespace Models.TopoModels.EULYNX.db {
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LevelCrossingLocalOperationUiElement: sig.LevelCrossingLocalOperationUiElement
        {
            [XmlElementAttribute("hasFunctionType", Order=1)]
            public LevelCrossingUiFunctionTypes hasFunctionType {get; set;} = new LevelCrossingUiFunctionTypes();
                
             
        }  
    
        /** 
        DB level crossing system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LevelCrossingSystem: sig.LevelCrossingSystem
        {
            [XmlElementAttribute("isOfLxProtectionType", Order=1)]
            public LevelCrossingProtectionTypes isOfLxProtectionType {get; set;} = new LevelCrossingProtectionTypes();
                
            [XmlElementAttribute("isOfLxTechnologyType", Order=2)]
            public LevelCrossingTechnologyTypes isOfLxTechnologyType {get; set;} = new LevelCrossingTechnologyTypes();
                
             
        }  
    
        /** 
        Set of configurable level crossing timers. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LevelCrossingTimerSet: sig.LevelCrossingTimerSet
        {
            [XmlElementAttribute("hasAdditionalTimer", Order=1)]
            public rtmCommon.Duration hasAdditionalTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasLeadTimer", Order=2)]
            public rtmCommon.Duration hasLeadTimer {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        de-DE: F&#252;-B&#220;, Fern&#252;berwachter Bahn&#252;bergang 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SelfSupervisedLevelCrossingSystem: sig.SelfSupervisedLevelCrossing
        {
            [XmlElementAttribute("automaticAuxiliaryActivation", Order=1)]
            public Boolean automaticAuxiliaryActivation {get; set;} = new Boolean();
                
            [XmlElementAttribute("connectionLostIndicator", Order=2)]
            public Boolean connectionLostIndicator {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasTimeOut", Order=3)]
            public rtmCommon.Duration hasTimeOut {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("malfunctionSignalClosure", Order=4)]
            public Boolean malfunctionSignalClosure {get; set;} = new Boolean();
                
            [XmlElementAttribute("reportsBatteryStatus", Order=5)]
            public Boolean reportsBatteryStatus {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        de-DE: B&#252; Zeitverhalten 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LevelCrossingActivationDelaySet: sig.LevelCrossingActivationDelaySet
        {
            [XmlElementAttribute("hasDefaultPartialTimer", Order=1)]
            public rtmCommon.Duration hasDefaultPartialTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasSupplierSpecificActivationDelay", Order=2)]
            public rtmCommon.Duration hasSupplierSpecificActivationDelay {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasSupplierSpecificSignalDelay", Order=3)]
            public rtmCommon.Duration hasSupplierSpecificSignalDelay {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        de-DE: B&#220; mit deckendem Signal (Haupt-/LS-Signal)  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class MainSignalProtectedLevelCrossing: sig.MainSignalProtectedLevelCrossing
        {
            [XmlElementAttribute("hasOperationPlug", Order=1)]
            public LevelCrossingOperationalPlugTypes hasOperationPlug {get; set;} = new LevelCrossingOperationalPlugTypes();
                
            [XmlElementAttribute("hasShortTrainCircuitry", Order=2)]
            public Boolean hasShortTrainCircuitry {get; set;} = new Boolean();
                
            [XmlElementAttribute("reportsBatteryState", Order=3)]
            public Boolean reportsBatteryState {get; set;} = new Boolean();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LocalOperationDevice: sig.LocalOperationDevice
        {
            [XmlElementAttribute("hasBuzzerSoundingDuration", Order=1)]
            public rtmCommon.Duration hasBuzzerSoundingDuration {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        de-DE: Bedienelement Taste 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LocalOperationUiButton: sig.LocalOperationUiButton
        {
            [XmlElementAttribute("hasFunctionType", Order=1)]
            public ButtonFunctionTypes hasFunctionType {get; set;} = new ButtonFunctionTypes();
                
             
        }  
    
        /** 
        de-DE: Melder 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LocalOperationUiIndicator: sig.LocalOperationUiIndicator
        {
            [XmlElementAttribute("hasFunctionType", Order=1)]
            public IndicatorFunctionTypes hasFunctionType {get; set;} = new IndicatorFunctionTypes();
                
             
        }  
    
        /** 
        de-DE: Bedienelement Schalter 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LocalOperationUiSwitch: sig.LocalOperationUiSwitch
        {
            [XmlElementAttribute("hasFunctionType", Order=1)]
            public SwitchFunctionTypes hasFunctionType {get; set;} = new SwitchFunctionTypes();
                
             
        }  
    
        /** 
        This is a fa&#231;ade to the nodes in the communication network. Also known as communication participant.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class CommunicationNode
        {
            [XmlElementAttribute("appliesToControlledTrackAsset", Order=1)]
            public tElementWithIDref appliesToControlledTrackAsset {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToController", Order=2)]
            public tElementWithIDref appliesToController {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToHousing", Order=3)]
            public tElementWithIDref appliesToHousing {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Informs about the communication relation between two nodes.
The communication technology can be described in the inherited description property.
de-DE: Physikalischer/logischer &#220;bertragungsweg zwischen zwei Objekten f&#252;r eine erforderliche Informations&#252;bertragung. Die Angabe erfolgt, wenn der &#220;bertragungsweg vom Betreiber beigestellt wird oder die Informations&#252;bertragung vom Lieferanten zus&#228;tzlich zu schalten ist. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class CommunicationRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasDescriptionForEndPointA", Order=1)]
            public sig.Attachment hasDescriptionForEndPointA {get; set;} = new sig.Attachment();
                
            [XmlElementAttribute("hasDescriptionForEndPointB", Order=2)]
            public sig.Attachment hasDescriptionForEndPointB {get; set;} = new sig.Attachment();
                
            [XmlElementAttribute("isPartOfCommunicationLevel", Order=3)]
            public CommunicationLevelTypes isPartOfCommunicationLevel {get; set;} = new CommunicationLevelTypes();
                
            [XmlElementAttribute("needsBandwidth", Order=4)]
            public BandwidthTypes needsBandwidth {get; set;} = new BandwidthTypes();
                
            [XmlElementAttribute("nodeA", Order=5)]
            public CommunicationNode nodeA {get; set;} = new CommunicationNode();
                
            [XmlElementAttribute("nodeB", Order=6)]
            public CommunicationNode nodeB {get; set;} = new CommunicationNode();
                
            [XmlElementAttribute("usesCommunicationMedium", Order=7)]
            public CommunicationMediumTypes usesCommunicationMedium {get; set;} = new CommunicationMediumTypes();
                
            [XmlElementAttribute("usesCommunicationNetworkType", Order=8)]
            public CommunicationNetworkTypes usesCommunicationNetworkType {get; set;} = new CommunicationNetworkTypes();
                
            [XmlElementAttribute("usesCommunicationTechnology", Order=9)]
            public CommunicationTechnologyTypes usesCommunicationTechnology {get; set;} = new CommunicationTechnologyTypes();
                
             
        }  
    
        /** 
        Cabinet housing a drive of a movable component or level crossing.
DE: Schranken- oder Weichenantrieb. Eine Au&#223;enelementansteuerung kann in einem Schranken- oder Weichenantrieb untergebracht sein. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class DriveCabinet: sig.Cabinet
        {
             
        }  
    
        /** 
        The IP address in CIDR notation. This allows defining a block of one or more IP-addresses. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class IpAddressBlock
        {
            [XmlElementAttribute("isOfIpVersion", Order=1)]
            public IPversions isOfIpVersion {get; set;} = new IPversions();
                
            [XmlElementAttribute("value", Order=2)]
            public String value= "";
                
             
        }  
    
        /** 
        A collection of blocks of IP address.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class IpAddressCollection: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasPriority", Order=1)]
            public List<NetworkPriority> hasPriority { get; set; } = new List<NetworkPriority>(); 
                
            [XmlElementAttribute("includesBlock", Order=2)]
            public List<IpAddressBlock> includesBlock { get; set; } = new List<IpAddressBlock>(); 
                
             
        }  
    
        /** 
        The equipment has no housing but has housing-properties such as the spot location and position description. 

de-DE: Unterbringung_Art : keine 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class NoHousing: sig.Housing
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PlatformEdge: sig.PlatformEdge
        {
            [XmlElementAttribute("hasPredefinedHeight", Order=1)]
            public PlatformHeights hasPredefinedHeight {get; set;} = new PlatformHeights();
                
             
        }  
    
        /** 
        de-DE: Gleissperre 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class DerailerComponent: sig.DerailerComponent
        {
            [XmlElementAttribute("hasDerailerIndicatorOfType", Order=1)]
            public DerailerIndicatorTypes hasDerailerIndicatorOfType {get; set;} = new DerailerIndicatorTypes();
                
             
        }  
    
        /** 
        de-DE: Geschalteter Teil des Signalbegriffes. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ActiveAspect: sig.ActiveAspect
        {
            [XmlElementAttribute("monitored", Order=1)]
            public Boolean monitored {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        de-DE: Fiktive Signale sind als Start- oder Zielpunkte in den Zug- oder Rangierstra&#223;entabellen erkennbar. Ihre Funktion ist nicht unmittelbar dargestellt, sie ergibt sich aus der Verwendung. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class FictitiousSignal: sig.FictitiousSignal
        {
            [XmlElementAttribute("hasFunction", Order=1)]
            public List<FictitiousSignalFunctionTypes> hasFunction { get; set; } = new List<FictitiousSignalFunctionTypes>(); 
                
             
        }  
    
        /** 
        DB lens diffuser. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LensDiffuserWithOrientation))]     
        public  partial class LensDiffuser: sig.LensDiffuser
        {
            [XmlElementAttribute("isOfDiffuserType", Order=1)]
            public LensDiffuserTypes isOfDiffuserType {get; set;} = new LensDiffuserTypes();
                
             
        }  
    
        /** 
        de-DE: Stellung des Streuscheibe eines Schirm-Signals. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LensDiffuserWithOrientation: db.LensDiffuser
        {
            [XmlElementAttribute("isOfOrientationType", Order=1)]
            public LensDiffuserOrientationTypes isOfOrientationType {get; set;} = new LensDiffuserOrientationTypes();
                
             
        }  
    
        /** 
        de-DE: Lichtsignal mit Typangabe.
In Germany, one <i>may </i>wish to associate a signal system with the signal. It is also possible to use the EULYNX DP light signal if the signal system type isn't needed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LightSignalTyped: sig.LightSignal
        {
            [XmlElementAttribute("isOfSignalSystemType", Order=1)]
            public SignalSystemTypes isOfSignalSystemType {get; set;} = new SignalSystemTypes();
                
             
        }  
    
        /** 
        Release the remainder of a shunting route.
de-DE: Aufloesung einer nicht angefahrenen Rangierstra&#223;e bei einer wendenden Rangierfahrt &#252;ber mehrere Rangierstra&#223;en.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class RemainingShuntingRouteRelease: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A shunting route towards the referenced exit signal is allowed only when the referenced block is set in direction of the open line. 
de-DE: Eine Rangierstra&#223;e mit diesem Zielsignal ist nur einstellbar, wenn die Erlaubnis des Streckenblocks in Richtung Strecke zeigt. Abhaengigkeit einer auf ein Signal zufuehrenden Rangierstra&#223;e von der Stellung der Erlaubnis einer Block Anlage.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ShuntingTargetAuthorityDependent: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToBlockElement", Order=2)]
            public tElementWithIDref refersToBlockElement {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        DB Signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class Signal: sig.Signal
        {
            [XmlElementAttribute("isValidInArea", Order=1)]
            public AreaValidityTypes isValidInArea {get; set;} = new AreaValidityTypes();
                
             
        }  
    
        /** 
        Signal function as defined by DB 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SignalFunction: sig.SignalFunction
        {
            [XmlElementAttribute("isOfSignalFunctionType", Order=1)]
            public SignalFunctionTypes isOfSignalFunctionType {get; set;} = new SignalFunctionTypes();
                
             
        }  
    
        /** 
        Type of signal as defined by DB 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SignalType: sig.SignalType
        {
            [XmlElementAttribute("isOfSignalTypeType", Order=1)]
            public SignalTypeTypes isOfSignalTypeType {get; set;} = new SignalTypeTypes();
                
             
        }  
    
        /** 
        DB listing of special system arrangements.
See parent-class for further description.
de-DE: Anordnung von Aktiven Signalen bei mehreren parallelen Strecken oder beim Zusammenlauf von Strecken. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SpecialPositionArrangement: sig.SpecialPositionArrangement
        {
            [XmlElementAttribute("isOfSpecialSignalArrangementType", Order=1)]
            public SpecialSignalArrangementTypes isOfSpecialSignalArrangementType {get; set;} = new SpecialSignalArrangementTypes();
                
             
        }  
    
        /** 
        Specific DB gauges.
de-DE: Bereich wo besondere Lichtraumbedingungen vorhanden sind. Es werden nur die Bereiche angegeben, in denen von der EBO abweichende und LST-relevante Lichtraumbedingungen vorhanden oder zu beachten sind.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SpecialGauge: sig.SpecialGauge
        {
            [XmlElementAttribute("isOfSpecialGaugeType", Order=1)]
            public SpecialGaugeTypes isOfSpecialGaugeType {get; set;} = new SpecialGaugeTypes();
                
             
        }  
    
        /** 
        de-DE: durchgehendes Hauptgleis 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ThroughTrack: sig.MainTrack
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class TriggerAssignment: sig.TriggerAssignment
        {
            [XmlElementAttribute("triggersActionOfType", Order=1)]
            public List<TriggeredActionTypes> triggersActionOfType { get; set; } = new List<TriggeredActionTypes>(); 
                
             
        }  
    
        /** 
        Attachment, adorned with document type information.
de-DE: Anhang 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class Attachment: sig.Attachment
        {
            [XmlElementAttribute("isOfDocumentType", Order=1)]
            public DocumentTypes isOfDocumentType {get; set;} = new DocumentTypes();
                
             
        }  
    
        /** 
        Designation of DB track assets.
zB. Weiche 5 in P-Hausen 
<ul>
 <li>index (Kennzahl) = 60</li>
</ul>
<ul>
 <li>localName = 5</li>
 <li>shortNameLayoutPlan = W5</li>
 <li>longNameLayoutPlan = 60W5</li>
 <li>nameInTable = 60W5 </li>
 <li>nameOnSite = 60W5</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.TdsDesignation))]     
        public  partial class Designation: sig.Designation
        {
            [XmlElementAttribute("index", Order=1)]
            public Int32 index {get; set;} = new Int32();
                
            [XmlElementAttribute("localName", Order=2)]
            public String localName= "";
                
            [XmlElementAttribute("longNameLayoutPlan", Order=3)]
            public String longNameLayoutPlan= "";
                
            [XmlElementAttribute("nameInTable", Order=4)]
            public String nameInTable= "";
                
            [XmlElementAttribute("nameOnSite", Order=5)]
            public String nameOnSite= "";
                
            [XmlElementAttribute("shortNameLayoutPlan", Order=6)]
            public String shortNameLayoutPlan= "";
                
             
        }  
    
        /** 
        Bezeichnung einer FMA Anlage (Train detection section).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class TdsDesignation: db.Designation
        {
            [XmlElementAttribute("hasCodeLetter", Order=1)]
            public CodeLetter hasCodeLetter {get; set;} = new CodeLetter();
                
             
        }  
    
        /** 
        Binary dataset as sent over airgap from balise to the train. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class AirgapDataFile: db.BinaryDataFile
        {
            [XmlElementAttribute("hasAuxiliaryDataFile", Order=1)]
            public tElementWithIDref hasAuxiliaryDataFile {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("implementsEtcsTelegram", Order=2)]
            public tElementWithIDref implementsEtcsTelegram {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("implementsPredefinedEtcsTelegramSet", Order=3)]
            public tElementWithIDref implementsPredefinedEtcsTelegramSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isSentByEtcsBalise", Order=4)]
            public tElementWithIDref isSentByEtcsBalise {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Information for labelling the balise group.
de-DE: Anwendungssystem 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ApplicationSystem
        {
            [XmlElementAttribute("isOfApplicationSystemType", Order=1)]
            public ApplicationSystemTypes isOfApplicationSystemType {get; set;} = new ApplicationSystemTypes();
                
            [XmlElementAttribute("isPartOfBaliseLabelInfo", Order=2)]
            public tElementWithIDref isPartOfBaliseLabelInfo {get; set;} = new tElementWithIDref();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class BaliseGroup: sig.BaliseGroup
        {
            [XmlElementAttribute("bgType", Order=1)]
            public Int32 bgType {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Balise groups for level transitions. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class BaliseGroupeTypeLt: db.BaliseGroupFunctionLabels
        {
            [XmlElementAttribute("isOfLtFunctionType", Order=1)]
            public LtFunctionTypes isOfLtFunctionType {get; set;} = new LtFunctionTypes();
                
             
        }  
    
        /** 
        Balise group functions and labels. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.BaliseGroupeTypeLt))]
        [XmlIncludeAttribute(typeof(db.BaliseGroupTypeL2))]     
        public  partial class BaliseGroupFunctionLabels: sig.BaliseGroupFunction
        {
            [XmlElementAttribute("preferenceRanking", Order=1)]
            public Int32 preferenceRanking {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Balise group for level 2.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class BaliseGroupTypeL2: db.BaliseGroupFunctionLabels
        {
            [XmlElementAttribute("bgTypeL2Number", Order=1)]
            public Int32 bgTypeL2Number {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Used when the balise group cannot have a text label that sources information from track, chainage, signal or line. 
E.g. Grunewald BGRU 023. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class BaliseLabellingInformation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("labelTakesInfoFrom", Order=1)]
            public SourceOfLabelInformationTypes labelTakesInfoFrom {get; set;} = new SourceOfLabelInformationTypes();
                
            [XmlElementAttribute("otherLabelText", Order=2)]
            public String otherLabelText= "";
                
            [XmlElementAttribute("refersToBaliseGroup", Order=3)]
            public tElementWithIDref refersToBaliseGroup {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Binary file, not-executable. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.AirgapDataFile))]
        [XmlIncludeAttribute(typeof(db.EtcsProgrammingFile))]     
        public  partial class BinaryDataFile: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("data", Order=1)]
            public String data= "";
                
            [XmlElementAttribute("fileType", Order=2)]
            public String fileType= "";
                
            [XmlElementAttribute("hasFileProperties", Order=3)]
            public FileProperties hasFileProperties {get; set;} = new FileProperties();
                
            [XmlElementAttribute("name", Order=4)]
            public String name= "";
                
             
        }  
    
        /** 
        Meta-data used when programming the balise. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class EtcsProgrammingAuxiliaryFile: db.EtcsProgrammingFile
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.EtcsProgrammingAuxiliaryFile))]
        [XmlIncludeAttribute(typeof(db.EtcsTelegramLoadFile))]     
        public  partial class EtcsProgrammingFile: db.BinaryDataFile
        {
            [XmlElementAttribute("configurationLabel", Order=1)]
            public String configurationLabel= "";
                
            [XmlElementAttribute("displayText", Order=2)]
            public String displayText= "";
                
            [XmlElementAttribute("usageCode", Order=3)]
            public Int32 usageCode {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Set of binary data files that are used for programming electronic equipment such as balises or LEU.
A set of load and auxiliary files. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class EtcsProgrammingFileSet
        {
            [XmlElementAttribute("appliesToEtcsBalise", Order=1)]
            public tElementWithIDref appliesToEtcsBalise {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasEtcsTelegramFile", Order=2)]
            public List<tElementWithIDref> hasEtcsTelegramFile { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Binary data file for loading into the balise data segment. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class EtcsTelegramLoadFile: db.EtcsProgrammingFile
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class FileProperties
        {
            [XmlElementAttribute("checksum", Order=1)]
            public String checksum= "";
                
            [XmlElementAttribute("checksumType", Order=2)]
            public String checksumType= "";
                
            [XmlElementAttribute("deliveryDate", Order=3)]
            public DateTime deliveryDate {get; set;} = new DateTime();
                
            [XmlElementAttribute("deliveryVersion", Order=4)]
            public String deliveryVersion= "";
                
             
        }  
    
        /** 
        Provides the reference point with respect to which the position of the balise group has been measured.
This can be used to validate the measure.
de-DE: Einmesspunkt 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PositioningMeasurementInfo: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("extraInfo", Order=1)]
            public String extraInfo= "";
                
            [XmlElementAttribute("refersToBaliseGroup", Order=2)]
            public tElementWithIDref refersToBaliseGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToLocation", Order=3)]
            public tElementWithIDref refersToLocation;
                
             
        }  
    
        /** 
        A predefined set of ETCS telegrams that a balise group sends in a given context such as a signal aspect. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PredefinedEtcsTelegramSet: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToBaliseGroup", Order=1)]
            public tElementWithIDref appliesToBaliseGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToEtcsTelegram", Order=2)]
            public List<tElementWithIDref> appliesToEtcsTelegram { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("index", Order=3)]
            public Int32 index {get; set;} = new Int32();
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                    case db.CommunicationRelation myCommunicationRelation:
                        if (!ownsCommunicationRelation.Contains(myCommunicationRelation)) ownsCommunicationRelation.Append(myObject);
                        break;
                
                    case db.DualFlankProtection myDualFlankProtection:
                        if (!ownsDualFlankProtection.Contains(myDualFlankProtection)) ownsDualFlankProtection.Append(myObject);
                        break;
                
                    case db.PzbRouteRelation myPzbRouteRelation:
                        if (!ownsPzbRouteRelation.Contains(myPzbRouteRelation)) ownsPzbRouteRelation.Append(myObject);
                        break;
                
                    case db.RemainingShuntingRouteRelease myRemainingShuntingRouteRelease:
                        if (!ownsRemainingShuntingRouteRelease.Contains(myRemainingShuntingRouteRelease)) ownsRemainingShuntingRouteRelease.Append(myObject);
                        break;
                
                    case db.RouteSignalling myRouteSignalling:
                        if (!ownsRouteSignalling.Contains(myRouteSignalling)) ownsRouteSignalling.Append(myObject);
                        break;
                
                    case db.ShuntingTargetAuthorityDependent myShuntingTargetAuthorityDependent:
                        if (!ownsShuntingTargetAuthDep.Contains(myShuntingTargetAuthorityDependent)) ownsShuntingTargetAuthDep.Append(myObject);
                        break;
                
                    case db.TpsToPointRelation myTpsToPointRelation:
                        if (!ownsTpsToPointRelation.Contains(myTpsToPointRelation)) ownsTpsToPointRelation.Append(myObject);
                        break;
                
                }
                return id;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
            [XmlElementAttribute("ownsCommunicationRelation", Order=1)]
            public List<CommunicationRelation> ownsCommunicationRelation { get; set; } = new List<CommunicationRelation>(); 
                
            [XmlElementAttribute("ownsDualFlankProtection", Order=2)]
            public List<DualFlankProtection> ownsDualFlankProtection { get; set; } = new List<DualFlankProtection>(); 
                
            [XmlElementAttribute("ownsPzbRouteRelation", Order=3)]
            public List<PzbRouteRelation> ownsPzbRouteRelation { get; set; } = new List<PzbRouteRelation>(); 
                
            [XmlElementAttribute("ownsRemainingShuntingRouteRelease", Order=4)]
            public List<RemainingShuntingRouteRelease> ownsRemainingShuntingRouteRelease { get; set; } = new List<RemainingShuntingRouteRelease>(); 
                
            [XmlElementAttribute("ownsRouteSignalling", Order=5)]
            public List<RouteSignalling> ownsRouteSignalling { get; set; } = new List<RouteSignalling>(); 
                
            [XmlElementAttribute("ownsShuntingTargetAuthDep", Order=6)]
            public List<ShuntingTargetAuthorityDependent> ownsShuntingTargetAuthDep { get; set; } = new List<ShuntingTargetAuthorityDependent>(); 
                
            [XmlElementAttribute("ownsTpsToPointRelation", Order=7)]
            public List<TpsToPointRelation> ownsTpsToPointRelation { get; set; } = new List<TpsToPointRelation>(); 
                
             
        }  
    
        /** 
        Points has no distinct position that offers flank protection.
de-DE: Zwieschutz 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class DualFlankProtection: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToPoint", Order=1)]
            public tElementWithIDref appliesToPoint {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("autoRestoration", Order=2)]
            public Boolean autoRestoration {get; set;} = new Boolean();
                
            [XmlElementAttribute("isOfDualFlankProtectionType", Order=3)]
            public DualFlankProtectionTypes isOfDualFlankProtectionType {get; set;} = new DualFlankProtectionTypes();
                
            [XmlElementAttribute("measureForPositionLeft", Order=4)]
            public DualFlankProtectionMeasureTypes measureForPositionLeft {get; set;} = new DualFlankProtectionMeasureTypes();
                
            [XmlElementAttribute("measureForPositionRight", Order=5)]
            public DualFlankProtectionMeasureTypes measureForPositionRight {get; set;} = new DualFlankProtectionMeasureTypes();
                
            [XmlElementAttribute("requiresRemoteFlankProtectionLeft", Order=6)]
            public tElementWithIDref requiresRemoteFlankProtectionLeft {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("requiresRemoteFlankProtectionRight", Order=7)]
            public tElementWithIDref requiresRemoteFlankProtectionRight {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        For DB only one signal (via isProvidedBySignal) or one point (isProvidedByPointInPosition) can provide flank protection.
In case the track diverges between requestor and provider, the request is transmitted from the diverging point. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.FlankProtectionNone))]     
        public  partial class FlankProtection: sig.FlankProtection
        {
            [XmlElementAttribute("inhibitShuntingRouteExit", Order=1)]
            public Boolean inhibitShuntingRouteExit {get; set;} = new Boolean();
                
            [XmlElementAttribute("transmitsFlankProtectionRequest", Order=2)]
            public List<tElementWithIDref> transmitsFlankProtectionRequest { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Indicates that non-technical measures provide flank protection.
This indicates that the system implements non-technical measures to achieve flank protection such as rejecting particular shunting movements or parking. 
<i>The supplier must mark this in the system.</i>

de-DE: Auswahl der Ma&#223;nahme "Verzicht": Der Flankenschutz wird durch betriebliche Ma&#223;nahmen hergestellt (mittelbarer Flankenschutz). Die Ma&#223;nahmen "unmittelbar" und "Weitergabe" sind aus der Bef&#252;llung anderer Attribute erkennbar, deshalb muss nur die Ma&#223;nahme "Verzicht" explizit angegeben werden. DB-Regelwerk Flankenschutztabelle, Spalte 8 "Flankenschutzumkehr, Verzicht"

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class FlankProtectionNone: db.FlankProtection
        {
             
        }  
    
        /** 
        de-DE: Nahbedienbereich 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class LocalOperatingArea: sig.LocalOperatingArea
        {
            [XmlElementAttribute("hasNbrFunctionality", Order=1)]
            public List<NbrFunctionalityTypes> hasNbrFunctionality { get; set; } = new List<NbrFunctionalityTypes>(); 
                
            [XmlElementAttribute("isOfLocalControlType", Order=2)]
            public LocalControlTypes isOfLocalControlType {get; set;} = new LocalControlTypes();
                
             
        }  
    
        /** 
        de-DE: Zugfahrstra&#223;e 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class MainRoute: sig.MainRoute
        {
            [XmlElementAttribute("isOfMainRouteType", Order=1)]
            public MainRouteTypes isOfMainRouteType {get; set;} = new MainRouteTypes();
                
             
        }  
    
        /** 
        Per Route, the signal aspect that cannot be derived trivially from the interlocking functionality.
de-DE: Je Fahrstra&#223;e zu zeigende Signalisierung, die sich nicht eindeutig aus den Stellwerksfunktionen ergibt. Der Verweis auf targetAspect ist optional da es nur bei verk&#252;rztem Signalabstand eine Abh&#228;ngigkeit zum Signalbegriff des Zielsignals gibt.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class RouteSignalling: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRoute", Order=1)]
            public tElementWithIDref appliesToRoute;
                
            [XmlElementAttribute("entryAspect", Order=2)]
            public tElementWithIDref entryAspect {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("targetAspect", Order=3)]
            public tElementWithIDref targetAspect {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        de-DE: Rangierfahrstrasse. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ShuntingRoute: sig.ShuntingRoute
        {
            [XmlElementAttribute("isOfShuntingRouteType", Order=1)]
            public ShuntingRouteTypes isOfShuntingRouteType {get; set;} = new ShuntingRouteTypes();
                
             
        }  
    
        /** 
        PZB Magnet. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PzbDevice: sig.TpsSpotDevice
        {
             
        }  
    
        /** 
        Set of properties that apply to a PZB device. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PzbDeviceProperties: sig.TpsDeviceProperties
        {
            [XmlElementAttribute("InaCalculation", Order=1)]
            public Boolean InaCalculation {get; set;} = new Boolean();
                
            [XmlElementAttribute("appliesToPlatformEdge", Order=2)]
            public tElementWithIDref appliesToPlatformEdge;
                
            [XmlElementAttribute("hasDecisiveDangerpoint", Order=3)]
            public tElementWithIDref hasDecisiveDangerpoint;
                
            [XmlElementAttribute("hasFrequency", Order=4)]
            public PzbFrequencyTypes hasFrequency {get; set;} = new PzbFrequencyTypes();
                
             
        }  
    
        /** 
        Informs whether the PZB magnet is active which depends on the route.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PzbRouteRelation
        {
            [XmlElementAttribute("appliesToPzbDevice", Order=1)]
            public tElementWithIDref appliesToPzbDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToRoute", Order=2)]
            public tElementWithIDref appliesToRoute;
                
            [XmlElementAttribute("hasRelationType", Order=3)]
            public PzbRouteRelationTypes hasRelationType {get; set;} = new PzbRouteRelationTypes();
                
             
        }  
    
        /** 
        For PZB speed checking configurations with a speed checking section (also known as Overspeed sensor, OSS). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class PzbSpeedCheckingSystemProperties: sig.SpeedCheckingSystemProperties
        {
            [XmlElementAttribute("hasSpeedCheckingSystemType", Order=1)]
            public PzbSpeedCheckingSystemTypes hasSpeedCheckingSystemType {get; set;} = new PzbSpeedCheckingSystemTypes();
                
             
        }  
    
        /** 
        The TPS speed checking system protects a given point. 
de-DE: PZB Element Bezugspunkt Weiche. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class TpsToPointRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("refersToMovableElement", Order=1)]
            public tElementWithIDref refersToMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSpeedCheckingSystem", Order=2)]
            public tElementWithIDref refersToSpeedCheckingSystem {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Area equipped with ATP specific to Berlin S-Bahn.
de-DE: Zugbeeinflussungssystem Berlin S-Bahn. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/DB")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/DB",IsNullable=false)] 
             
        public  partial class ZbsArea: sig.TpArea
        {
             
        }  
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LevelCrossingUiFunctionTypes : int {
        /* de-DE: AT Ausschalttaste */deactivationSwitch,/* de-DE: ET Einschalttaste */activationSwitch,/* de-DE: HAT Hilfsausschalttaste */auxiliaryDeactivationSwitch,/* de-DE: HET Hilfseinschalttaste */auxiliaryActivationSwitch,/* de-DE: RS Rangierschalter */shuntingSwitch,/* Shunting button variant 1: first key press on, second key press off.

de-DE: RT ein aus */shuntingButton1,/* Shunting button variant 2: shunting switch on and shunting switch off.
de-DE: RT ein RT aus
 */shuntingButton2,/* de-DE: UT Unwirksamheitstaste, z.B. f&#252;r B&#220; Kontakt. */neutralisationSwitch
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LevelCrossingProtectionTypes : int {
        /* de-DE: A und Lf */callBarrierAndSpeedReduction,/* de-DE: A und Sprechverbindung */callBarrierAndVoiceCommunication,/* de-DE: Lz */lightSignal,/* de-DE: LzH */lightSignalAndHalfBarrier,/* Light signal and half barrier and two separate foot/cycle paths with own barrier.

de-DE: LzH_2F */pathWithBarrierLzH_2F,/* Light signal and half barrier and separate footpath/cycle path with own barrier.

de-DE: LzH_F */pathWithBarrierLzH_F,/* Light signal and two half barriers.

de-DE: LzH_F */lightSignalWithHalfBarriers,/* Light signal and full barrier.

de-DE: LzV */lightSignalWithFullBarrier,/* de-DE: P */whistlePost,/* de-DE: P und Lf */whistlePostAndSpeedReduction,/* de-DE: schl&#252;sselabh&#228;ngig */keyDependent,/* de-DE: sonstige */other,/* de-DE: Ue */overview,/* de-DE: Ue und P */overviewAndWhistlePost
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LevelCrossingTechnologyTypes : int {
        /* de-DE: Anrufschranke */callBarrier,/*  */buep_93,/*  */buess_72d,/*  */bues_72z,/*  */bues2000,/*  */ebuet_80,/*  */ebuet_80_vb,/*  */fue_58,/*  */fue_60,/*  */hl_64_b,/*  */hl_64_c,/*  */hs_64_b,/*  */hs_64_c,/*  */lo1,/*  */lo1_57,/*  */ne_bue_90,/*  */rbuet,/*  */simis_lc,/* de-DE: keine
 */none,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LevelCrossingOperationalPlugTypes : int {
        /* de-DE: gesperrt */blocked,/* de-DE: Betrieb */normalOperation
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum ButtonFunctionTypes : int {
        other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum IndicatorFunctionTypes : int {
        /* de-DE: Anforderungsempfang */receivingRequest,/* de-DE: Anzeige Betriebszustand */operationalStatus,/* de-DE: Leuchtmelder Zp10 */zp10,/* de-DE: Leuchtmelder Zp9
 */zp9,/* de-DE: Signalanforderung empfangen */receivedSignalRequest,/* de-DE: Signalhaltmelder */signalClosed,/* de-DE: Signalfahrtmelder */signalOpen,/* de-DE: Sperrmelder */blocking,/* de-DE: Vorbereitungsmeldung */preparing,/* de-DE: Weichenmeldung */point,/* de-DE: Zielmelder */target,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SwitchFunctionTypes : int {
        other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum BandwidthTypes : int {
        /*  */_24kbit_s,/*  */_2Mbit_s,/*  */_10Mbit_s,/*  */_100Mbit_s,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum CommunicationLevelTypes : int {
        /* de-DE: B&#252; */levelCrossing,/* de-DE: Diagnose */diagnostics,/* de-DE: Elektronisches Stellwerk (ESTW) */interlocking,/* de-DE: zentrales Bediensystem (ZBS) */centralOperationSystem,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum CommunicationMediumTypes : int {
        /* de-DE: Kupfer ADO8 */cuAdo8,/* de-DE: Kupfer KAG */cuKag,/* de-DE: Kupfer LSA Plus */cuLsaPlus,/* de-DE: Kupfer RJ45 */cuRj45,/* de-DE: LWL DIN */lwlDin,/* de-DE: LWL E2000 */lwlE2000,/* de-DE: LWL SC LC */lwlScLc,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum CommunicationNetworkTypes : int {
        /* de-DE: geschlossenes Netz */closedNetwork,/* de-DE: offenes Netz */openNetwork,/* de-DE: Kommunikationsinfrastruktur f&#252;r sicherheitsrelevante Anwendungen */kisa,/* de-DE: SBI-Intern */supplierProprietary,/*  */sg,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum CommunicationTechnologyTypes : int {
        /* de-DE: analog FSK */analogueFsk,/*  */ethernet,/* ITU-T G.703 */g703,/* de-DE: SBI intern Kupferkabel. */cuSupplierProprietary,/* Supplier-proprietary Fibre optical cable 
de-DE: SBI-intern LWL-Faser */focSupplierProprietary,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum IPversions : int {
        /*  */IPv4,/*  */IPv6
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum NetworkPriority : int {
        /* Primary network addresses. */primary,/* 
Secondary IP-addresses, i.e. used for back-up */secondary,/* Second level of backup address. */tertiary,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum PlatformHeights : int {
        /* de-DE: 38 cm: niedrigste zul&#228;ssige H&#246;he */cm38,/* de-DE: 55 cm: Zwischenh&#246;he */cm55,/* de-DE: 76 cm: Regelh&#246;he */cm76,/* de-DE: 96 cm: gr&#246;sste zul&#228;ssige H&#246;he (nur f&#252;r ausschliesslich daf&#252;r vorgesehene S-Bahnfahrzeuge) */cm96,/* de-DE: Sonderh&#246;he: Abweichende H&#246;hen sind m&#246;glich, vor allem aeltere Bahnsteigkanten k&#246;nnen auch andere H&#246;hen aufweisen.  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum DerailerIndicatorTypes : int {
        /* de-DE: reflektierend einseitig */reflectiveOneSided,/* de-DE: reflektierend beidseitig */reflectiveDoubleSided,/* de-DE: innenbeleuchtet einseitig */backlitOneSided,/* de-DE: innenbeleuchtet beidseitig  */backlitDoubleSided
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum AreaValidityTypes : int {
        /* de-DE: Gebiet der ehemaligen Deutschen Bundesbahn */formerWestGermanRailways,/* de-DE: Gebiet der ehemaligen Deutschen Reichsbahn */formerEastGermanRailways,/* de-DE: Gebiet der S-Bahn Hamburg */subUrbanRailwaysHamburg,/* de-DE: Gebiet der S-Bahn Berlin */subUrbanRailwaysBerlin
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum FictitiousSignalFunctionTypes : int {
        /* de-DE: FAP Start
 */entryInterlockingControlArea,/* de-DE: FAP Ziel */exitInterlockingControlArea,/* de-DE: Rangierfahrstart/-ziel ohne Signal */shuntingEntryOrExit,/* de-DE: Start Zugfahrt Awanst */shuntingSidingEntry,/* de-DE: Ziel Zugfahrt Awanst */shuntingSidingExit,/* de-DE: Start Zugfahrt Mittelweiche */trainEntryIntermediatePoint,/* de-DE: Start Zugfahrt ohne Signal */trainEntryWithoutSignal,/* de-DE: Ziel Zugfahrt ohne Signal */trainExitWithoutSignal,/* de-DE: Ziel Zugfahrt Strecke */trainExitOpenLine,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LensDiffuserOrientationTypes : int {
        /*  */HG1,/*  */HG1_gw,/*  */HG2,/*  */HG2_gw,/*  */HG3,/*  */HG3_gw,/*  */HG4,/*  */HG4_gw,/*  */HL,/*  */HR,/*  */OL,/*  */OR,/*  */VL,/*  */VR,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LensDiffuserTypes : int {
        /* de-DE: Streuscheibegattungen */HRL,/*  */HG,/*  */HN,/*  */ORL,/*  */VRL,/*  */LED,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SignalFunctionTypes : int {
        /* de-DE: Einfahrsignal */entry,/* de-DE: Ausfahrsignal */exit,/* de-DE: Zwischensignal */intermediate,/* de-DE: Nachruecksignal */advance,/* de-DE: Blocksignal */block,/* de-DE: Deckungssignal */protection,/* de-DE: Zugdeckungssignal */trainProtection,/* de-DE: Gruppenausfahrsignal */groupMain,/* de-DE: Gruppenzwischensignal */groupIntermediate,/* de-DE: Gruppenausfahr- und Gruppenzwischensignal */groupMainAndIntermediate,/* de-DE: Alleinstehendes Zusatzsignal */standAloneIndicator,/* de-DE: Zug_Ziel_Signal */trainDestinationOnlySignal,/* de-DE: Ausfahrzwischensignal */intermediateExitSignal,/* de-DE: Einfahr und Ausfahrsignal */entryAndExit,/* de-DE: Einfahr Block Signal */entryAndBlock,/* de-DE: Andere Signalfunktionen, die nicht explizit aufgef&#252;hrt werden m&#252;ssen. */further,/* de-DE: B&#220;-&#220;berwachungssignal */lxProtectionSignal,/* de-DE: Vorsignal oder Vorsignalwiederholer */distantOrRepeater
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SignalSystemTypes : int {
        /* de-DE: Ks - Kombinationssignal */combined,/* de-DE: H/V - Haupt-/Vorsignal */mainDistant,/* de-DE: Hl - Hauptlichtsignal */mainLight,/*  */other,/* de-DE: SV - Haupt- und Vorsignalverbindungen */joined
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SignalTypeTypes : int {
        /* de-DE: Hauptsignal */main,/* de-DE: Hauptsperrsignal */mainShunting,/* de-DE: Mehrabschnittssignal */multiSection,/* de-DE: Mehrabschnittssperrsignal */multiSectionShunting,/* de-DE: Sperrsignal */shunting,/* de-DE: Vorsignal */distant,/* de-DE: Vorsignalwiederholer */repeater,/* de-DE: Zugdeckungssignal */trainProtection
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SpecialSignalArrangementTypes : int {
        /* de-DE: Anordnung des Signals rechts am Gleis.
 */signalOnRightSide,/* de-DE: Anordnung des Signals rechts am Gleis ohne Schachbretttafel. */signalOnRightSideWithoutCheckerBoardSign,/* de-DE: Nichtgeltung f&#252;r Fahrten auf dem Gegengleis. */notValidForOppositeTrack
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SpecialGaugeTypes : int {
        /* 1SMDR */_1SMDR,/*  */SBahn_80003,/*  */sBahn_Berlin,/*  */GC,/* In case 'other' is chosen, a reference drawing must be referred to.
de-DE: sonstige; bei Auswahl des Werts 'sonstige' ist eine Profilzeichnung als Reference Drawing beizulegen.  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum TriggeredActionTypes : int {
        /* de-DE: ARM */approachIndicator,/* de-DE: Awanst */toRefugeSiding,/* de-DE: EIN_BUE */levelCrossingActivation,/* de-DE: Signalhaltfall */signalClosing,/* Automatic Route Setting
de-DE: ZL_Anstoss */arsTrigger,/* de-DE: sonstige. */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum CodeLetter : int {
        /* de-DE: Gleisabschnitt B im Bereich mit Streckenblocksicherung. */B,/* de-DE: Gleisabschnitt G im Bereich mit Fahrstrassensicherung (Bahnh&#246;fe, Abzweigstellen). */G,/* de-DE: Kreuzungsabschnitt K mit mindestens einer Kreuzung. */K,/* de-DE: Weichenabschnitt W mit mindestens einer Weiche. */W
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum DocumentTypes : int {
        /* de-DE: Abnahmeniederschrift */documentationOfAcceptance,/* de-DE: Anbindung_IB2 */connectionIntegrityZone2,/* de-DE: Anbindung_IB3 */connectionIntegrityZone3,/* de-DE: Betriebliche Aufgabenstellung */BAST,/* de-DE: BELU */areaOverviewAndDetailedView,/* de-DE: Benutzeroberfl&#228;che */UserSurface,/* de-DE: Best&#228;tig_Gleichstellung */documentationOfEquality,/* de-DE: Best&#228;tig Qualit&#228;tspr&#252;fung */documentationOfQualityCheck,/* de-DE: Best&#228;tig_&#220;bernahme */documentationOfTakingOver,/* de-DE: &#220;bertragungswegeplan */transmissionRoutePlan,/* de-DE: DWS */digitalPointSketch,/* de-DE: Erl&#228;uterungsbericht */explanatoryReport,/* de-DE: Freigabe Bvb */approvalOfBuildingDocumentAuthority,/* de-DE: Genehmigung AG Bh Bhv */approvalOfAwardingAuthority,/* de-DE: Material Besonders */specialInformationForMaterials,/* de-DE: Planverzeichnis */listOfPlans,/* de-DE: Pr&#252;fbericht */checkReport,/* de-DE: Regelwerksstand Besonders */specialBaselineOfRulesAndStandards,/* de-DE: VzG */recordOfPermittedLinespeeds,/* de-DE: ZN Raumplan Bedienraum */traindescribersystemOperationRoomplan,/* de-DE: ZN Raumplan Rechnerraum */traindescribersystemComputerRoomplan,/* de-DE: GEO */geo,/* de-DE: INA */INA,/* de-DE: M&#246;belaufstellplan Aufriss */furniturePlan,/* de-DE: M&#246;belaufstellplan Grundriss */furniturePlanGroundplot,/* de-DE: Monitoraufteilung */monitorSubdivision,/* de-DE: Raumplan Bedienr&#228;ume */operationRoomPlan,/* de-DE: Raumplan Rechnerr&#228;ume */computerRoomPlan,/* de-DE: Richtungssinn */senseOfDirection,/* de-DE: sonstige */other,/* de-DE: Steuerbezirks&#252;bersicht */operationAreaOverview,/* de-DE: UiG */companyInternalPermission,/* de-DE: Vorgabe */specification,/* de-DE: Vorgabe GBT */specificationTrackOccupancyTable,/* de-DE: ZiE */acceptanceInSingleCase
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum ApplicationSystemTypes : int {
        /* ETCS Level Limited Supervision */level1LS,/*  */level2WithSignals,/*  */level2WithoutSignals
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LtFunctionTypes : int {
        /* de-DE: Ank&#252;ndigungsdatenpunkt */announcement,/* de-DE: Transitionsdatenpunkt */transition,/* de-DE: Sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum SourceOfLabelInformationTypes : int {
        /*  */trackAndChainage,/*  */trackAndSignal,/*  */signal,/* de-DE: Strecke und sonstiger Standort */lineAndOtherPosition
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum DualFlankProtectionMeasureTypes : int {
        /* de-DE: Verschluss
Die Flankenschutzweiche wird in der Linkslage verschlossen.  */locking,/* When flank protection measure is remote, the remote flank protection measure is given. 
de-DE: Fernschutz. Der Flankenschutz wird durch das n&#228;chste Flankenschutzelement hergestellt. (Ersatzschutzma&#223;nahme) 
                                                    */remote,/* In case of "locked or remote" the first route gets the direct flank protection by the related point position; the second route gets the indirect flank protection, e.g. given by a signal.

de-DE: Verschluss/Fernschutz */lockingOrRemote,/* de-DE: Verzicht
Der Flankenschutz wird durch betriebliche Ma&#223;nahmen hergestellt; technisch wird darauf verzichtet */none
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum DualFlankProtectionTypes : int {
        /* de-DE: Echte Zwieschutzweiche
 Flankenschutzweiche, die durch unabh&#228;ngige Fahrten in beiden Stellungen angefordert wird. Ohne spezielle Behandlung kann nur eine der beiden Fahrten zu einem Zeitpunkt eingestellt sein, da sich durch die Zwieschutzweiche ein Fahrstra&#223;enausschluss ergibt. */real,/* de-DE: Eigenzwieschutzweiche
Flankenschutzweiche, die durch die gleiche Fahrt in beiden Stellungen angefordert wird. Ohne spezielle Behandlung kann die Fahrt nicht eingestellt werden */selfSelective,/* Ede-DE: ine Zwieschutzweiche kann gleichzeitig beide Charaktere annehmen.  */realAndSelfSelective
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum LocalControlTypes : int {
        /* Signals show Kl/Sh1, Only locally-operated points can be thrown, Level crossing operation with shunting switch.

de-DE: NB-G: Signale zeigen Kl/Sh1; nur ortsbediente Weichen umstellbar; B&#220;-Bedienung mit Rangierschalter. */nb_g,/* Like NB-G but also powered points can be operated.
de-DE: NB-W: wie G, zus&#228;tzlich Umstellung von mit Antrieben ausger&#252;steter Weichen m&#246;glich. */nb_w,/* Like NB-W, but including shunting routes.
de-DE: NB-R: wie W, zus&#228;tzlich Fahren mit Rangierstra&#223;en innerhalb des NB. Nahbedienbereich mit abgesetzen Rangierstellwerk. */nb_r
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum NbrFunctionalityTypes : int {
        /* Control trailed point.
de-DE: Bedienkommando „Aufgefahrene Weiche umstellen“. */awu,/* Call a route on non-electrified track.
de-DE: Bedienkommando „Fahrstra&#223;e in ein Gleis ohne Oberleitung einstellen“ (nur beim &#220;bergang in nicht &#252;berspannte Bereiche relevant).  */f_st_z,/* (Partially) release route.
de-DE: Bedienkommando „Fahrstra&#223;e aufl&#246;sen“ und „Fahrwegelement einzeln aufl&#246;sen“. */fa_fae,/* Issue command „SBUE“.
de-DE: Bedienkommando „SBUE“. */sbue,/* Release and block key lock.
de-DE: Bedienkommando „Schl&#252;sselsperre entsperren“ (freigeben) und „Schl&#252;sselsperre sperren“ (Freigabe zur&#252;cknehmen). */sle_sls,/* Auxiliary point control command.
de-DE: Bedienkommando „Weiche hilfsweise umstellen“.  */whu,/* Block point.
de-DE: Bedienkommando „Weiche gegen umstellen sperren“.  */wus
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum MainRouteTypes : int {
        /* de-DE: Zugregel */zr,/* de-DE: ZugUmfahr */zu,/* de-DE: ZugZentralblock
Anwendung im Zentralblock oder an Schnittstellen zu anderen Stellwerkstechniken bei Mehrabschnittssignalisierung, Signalabh&#228;ngigkeiten von Fahrwegelementen auf der freien Strecke oder bei Bedienung einer Awanst. DB-Regelwerk Zug-/Rangierstra&#223;entabelle, Spalte 2 */zz,/* de-DE: Zughilfs */zh,/* de-DE: ZugMittelweichenteil */zm,/* de-DE: ZugUmfahrhilfs */zuh,/* de-DE: ZugUmfahrmittelweichenteil */zum,/* de-DE: ZugTeil */zt,/* de-DE: ZugTeilUmfahr */ztu
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum ShuntingRouteTypes : int {
        /* de-DE: RangierRegel */rr,/* de-DE: RangierUmfahr */ru,/* de-DE: RangierTeil */rt,/* de-DE: RangierTeilUmfahr */rtu
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum PzbFrequencyTypes : int {
        /*  */Hz_1000,/*  */Hz_2000,/*  */Hz_1000_2000,/*  */Hz_500
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum PzbRouteRelationTypes : int {
        /* Schaltbar von Signal. */signalSwitched,/* St&#228;ndig wirksam wenn Fahrstrasse eingestellt. */permanentlyWithRoute,/* Unwirksam when Fahrstrasse eingestellt. */ineffectiveWithRoute,/* St&#228;ndig wirksam. */permanentlyActive,/* Sonstige.
de-DE:  ein Bearbeitungsvermerk mit entsprechenden Erl&#228;uterungen ist anzuf&#252;gen. */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/DB")]
    public enum PzbSpeedCheckingSystemTypes : int {
        /* EA: In Fahrtrichtung zuerst Einschaltmagnet (GSE), dann Wirkmagnet, dann Ausschaltmagnet (GSA) */activation_deactivation,/* AE: in Fahrtrichtung zuerst Ausschaltmagnet (GSA) dann Einschaltmagnet (GSE), dann Wirkmagnet */deactivation_activation
    }
    
} 
            