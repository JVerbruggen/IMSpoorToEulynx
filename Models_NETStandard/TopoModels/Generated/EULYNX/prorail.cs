 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using prorail = Models.TopoModels.EULYNX.prorail;

namespace Models.TopoModels.EULYNX.prorail {
    
        /** 
        Aspects that ProRail light signals can show.
nl-NL: de aspecten die Nederlandse lichtseinen kunnen tonen. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class ActiveAspect: sig.ActiveAspect
        {
            [XmlElementAttribute("flashing", Order=1)]
            public Boolean flashing {get; set;} = new Boolean();
                
            [XmlElementAttribute("showsLight", Order=2)]
            public SignalColourTypes showsLight {get; set;} = new SignalColourTypes();
                
             
        }  
    
        /** 
        Fictieve sein 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class FictitiousSignal: sig.FictitiousSignal
        {
            [XmlElementAttribute("hasFunction", Order=1)]
            public FictitiousSignalFunctionTypes hasFunction {get; set;} = new FictitiousSignalFunctionTypes();
                
             
        }  
    
        /** 
        nl-NL: een route exit, doorgaans een sein, voorzien van een RV-timer. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class RouteExit: sig.RouteExit
        {
            [XmlElementAttribute("hasResidualRouteReleaseTimer", Order=1)]
            public rtmCommon.Duration hasResidualRouteReleaseTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasSpadDetection", Order=2)]
            public tElementWithIDref hasSpadDetection {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Set of regulations describing ProRail signals, signalled messages and aspects.
nl-NL: seinenboek 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class Signalbook: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("ownsAspect", Order=1)]
            public List<sig.Aspect> ownsAspect { get; set; } = new List<sig.Aspect>(); 
                
            [XmlElementAttribute("ownsAspectSet", Order=2)]
            public List<sig.SignalMessage> ownsAspectSet { get; set; } = new List<sig.SignalMessage>(); 
                
            [XmlElementAttribute("usesEulynxSignalVector", Order=3)]
            public List<tElementWithIDref> usesEulynxSignalVector { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Symbols shown on ProRail signals.
nl-NL: symbolen die op Nederlandse seinen getoond kunnen worden. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class Symbol: sig.Symbol
        {
            [XmlElementAttribute("hasSpeedSymbolType", Order=1)]
            public SignalSpeedRestrictionTypes hasSpeedSymbolType {get; set;} = new SignalSpeedRestrictionTypes();
                
            [XmlElementAttribute("hasSymbolType", Order=2)]
            public SignalRestrictionTypes hasSymbolType {get; set;} = new SignalRestrictionTypes();
                
             
        }  
    
        /** 
        A set of properties that applies to a ProRail TVP section. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class TvpSectionConfiguration: sig.TvpSectionConfiguration
        {
            [XmlElementAttribute("appliesIndirection", Order=1)]
            public rtmCommon.ApplicationDirection appliesIndirection {get; set;} = new rtmCommon.ApplicationDirection();
                
            [XmlElementAttribute("hasRouteReleaseType", Order=2)]
            public RouteReleaseTypes hasRouteReleaseType {get; set;} = new RouteReleaseTypes();
                
             
        }  
    
        /** 
        Line Block information used by ProRail.
nl-NL: informatievelden in gebruik bij ProRail. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class LineBlockInformation: sig.LineBlockInformation
        {
            [XmlElementAttribute("hasLH", Order=1)]
            public Boolean hasLH {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasStopDoor", Order=2)]
            public Boolean hasStopDoor {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasXG", Order=3)]
            public Boolean hasXG {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Dutch track assets are labeled with a series of strings:
areaname + areatype + assetname + assettype

E.g.  areaname="Ut", areatype="Wisselgebied", assetname="41A", assettype="Wissel" 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class Designation: sig.Designation
        {
            [XmlElementAttribute("areaName", Order=1)]
            public String areaName= "";
                
            [XmlElementAttribute("areaType", Order=2)]
            public String areaType= "";
                
            [XmlElementAttribute("assetName", Order=3)]
            public String assetName= "";
                
            [XmlElementAttribute("assetType", Order=4)]
            public String assetType= "";
                
             
        }  
    
        /** 
        Departure track in an area that is centrally controlled.
nl-NL: vertrekspoor in CBG 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class CentralControlledAreaDepartureTrack: prorail.DepartureTrack
        {
            [XmlElementAttribute("driveOnSightPossible", Order=1)]
            public Boolean driveOnSightPossible {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasTimerValue", Order=2)]
            public rtmCommon.Duration hasTimerValue {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasUsableLength", Order=3)]
            public List<rtmCommon.Length> hasUsableLength { get; set; } = new List<rtmCommon.Length>(); 
                
            [XmlElementAttribute("isReverseTrack", Order=4)]
            public Boolean isReverseTrack {get; set;} = new Boolean();
                
            [XmlElementAttribute("refersToSections", Order=5)]
            public List<tElementWithIDref> refersToSections { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Track equipped to allow trains to depart and enter ETCS supervision. One instance is created per departure direction.
nl-NL: Een vertrekspoor in de context van ERTMS is een spoor waarbij een Movement Authority nodig is voor een vertrek op basis van een vervolgrijweg (in dezelfde richting of voor een kerende trein).
Een spoor – en daarmee ook een vertrekspoor – bestaat uit een verzameling secties en een sein dat de begrenzing van het vertrekspoor vormt.    
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.CentralControlledAreaDepartureTrack))]
        [XmlIncludeAttribute(typeof(prorail.NotCentralControlledAreaDepartureTrack))]
        [XmlIncludeAttribute(typeof(prorail.TemporaryShuntingAreaDepartureTrack))]
        [XmlIncludeAttribute(typeof(prorail.WorkzoneDepartureTrack))]     
        public  partial class DepartureTrack: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasDepartureTrackExtension", Order=1)]
            public List<tElementWithIDref> hasDepartureTrackExtension { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSignal", Order=3)]
            public tElementWithIDref refersToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Extension area of a departure track.
nl-NL: Een vertrekspooruitbreiding breidt een vertrekspoor uit. Het spoorgedeelte mag maximaal &#233;&#233;n sectie ten behoeve van treindetectie bevatten. Er mogen wissels in voorkomen, maar geen overwegen of beweegbare bruggen. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class DepartureTrackExtension: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Configuration for a Dutch ETCS level crossing. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class EtcslLevelCrossingSystem: sig.EtcsLevelCrossingSystem
        {
            [XmlElementAttribute("hasLxDepartureDetection", Order=1)]
            public List<tElementWithIDref> hasLxDepartureDetection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLxMalfunction", Order=2)]
            public List<sig.LevelCrossingMalfunction> hasLxMalfunction { get; set; } = new List<sig.LevelCrossingMalfunction>(); 
                
            [XmlElementAttribute("hasRestrictedSpeed", Order=3)]
            public rtmCommon.Speed hasRestrictedSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("hasStopZone", Order=4)]
            public tElementWithIDref hasStopZone {get; set;} = new tElementWithIDref();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class HybridLevel3Timers
        {

                
            [XmlElementAttribute("ghostTrainPropagationTimer", Order=3)]
            public List<rtmCommon.Duration> ghostTrainPropagationTimer { get; set; } = new List<rtmCommon.Duration>(); 
                
             
        }  
    
        /** 
        nl-NL: Een vertrekspoor NCBG in de context van ERTMS is een spoor waarbij een Movement Authority nodig is voor een vertrek op basis van een vervolgrijweg (in dezelfde richting of voor een kerende trein). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class NotCentralControlledAreaDepartureTrack: prorail.DepartureTrack
        {
            [XmlElementAttribute("hasMaxSpeed", Order=1)]
            public rtmCommon.Speed hasMaxSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("refersToBaliseGroup", Order=2)]
            public tElementWithIDref refersToBaliseGroup {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Departure track from a temporary shunting area.
nl-NL: Vertrekspoor VR-Gebied 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class TemporaryShuntingAreaDepartureTrack: prorail.DepartureTrack
        {
             
        }  
    
        /** 
        A virtual subsection (VSS) is part of the track-side train detection (TTD) used for positioning trains by means of reported position and length. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class VirtualSubSection: sig.TdsSection
        {
            [XmlElementAttribute("disconnectPropagationTimer", Order=1)]
            public List<rtmCommon.Duration> disconnectPropagationTimer { get; set; } = new List<rtmCommon.Duration>(); 
                
            [XmlElementAttribute("integrityLossPropagationTimer", Order=2)]
            public List<rtmCommon.Duration> integrityLossPropagationTimer { get; set; } = new List<rtmCommon.Duration>(); 
                
             
        }  
    
        /** 
        Virtual subsection limit 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class VssLimit: sig.TdsComponent
        {
             
        }  
    
        /** 
        Selective slow/stop-order for heavy freight trains. Used only for transition areas for connecting to legacy signalling.
NL: Een H- of L-lichtbak. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class WeightLimitMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("isOfTypeLorH", Order=1)]
            public WeightLimitMarkerTypes isOfTypeLorH {get; set;} = new WeightLimitMarkerTypes();
                
            [XmlElementAttribute("refersToLightSignal", Order=2)]
            public tElementWithIDref refersToLightSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Departure track from a work zone.
nl-NL: Vertrekspoor van werkzone 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class WorkzoneDepartureTrack: prorail.DepartureTrack
        {
            [XmlElementAttribute("hasMaxSpeed", Order=1)]
            public rtmCommon.Speed hasMaxSpeed {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                    case prorail.DepartureTrack myDepartureTrack:
                        if (!ownsDepartureTrack.Contains(myDepartureTrack)) ownsDepartureTrack.Append(myObject);
                        break;
                
                    case prorail.DepartureTrackExtension myDepartureTrackExtension:
                        if (!ownsDepartureTrackExtension.Contains(myDepartureTrackExtension)) ownsDepartureTrackExtension.Append(myObject);
                        break;
                
                }
                return id;
            }
        }
        
        /** 
        Container for classes needed for signalling engineering and the Data Preparation. This translates into the XSD as an XML-element that contains ProRail-specific signalling entities. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
            [XmlElementAttribute("ownsDepartureTrack", Order=1)]
            public List<DepartureTrack> ownsDepartureTrack { get; set; } = new List<DepartureTrack>(); 
                
            [XmlElementAttribute("ownsDepartureTrackExtension", Order=2)]
            public List<DepartureTrackExtension> ownsDepartureTrackExtension { get; set; } = new List<DepartureTrackExtension>(); 
                
             
        }  
    
        /** 
        ProRail on-sight route
nl-NL: Rijden op zicht rijweg (ROZ) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class OnSightRoute: sig.OnSightRoute
        {
            [XmlElementAttribute("allowedWhenSectionOccupied", Order=1)]
            public Boolean allowedWhenSectionOccupied {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        ProRail Route 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class Route: sig.Route
        {
            [XmlElementAttribute("usedByRouteLevelType", Order=1)]
            public RouteLevelTypes usedByRouteLevelType {get; set;} = new RouteLevelTypes();
                
             
        }  
    
        /** 
        ProRail route body 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class RouteBody: sig.RouteBody
        {
            [XmlElementAttribute("hasMovableOverheadLine", Order=1)]
            public Boolean hasMovableOverheadLine {get; set;} = new Boolean();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class RouteSettingProperties: sig.RouteProperty
        {
            [XmlElementAttribute("hasCargoCriteriumOption", Order=1)]
            public Boolean hasCargoCriteriumOption {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasExtraControlOption", Order=2)]
            public Boolean hasExtraControlOption {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasNormalControlOption", Order=3)]
            public Boolean hasNormalControlOption {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasStopSignalControlOption", Order=4)]
            public Boolean hasStopSignalControlOption {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A loop in the ATB EG train protection system.
NL: ATB EG lus 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbEgLoop: prorail.AtbLoop
        {
             
        }  
    
        /** 
        A loop in the ATB train protection system.
NL: ATB lus 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.AtbEgLoop))]
        [XmlIncludeAttribute(typeof(prorail.AtbngLoop))]
        [XmlIncludeAttribute(typeof(prorail.AtbvvLoop))]     
        public abstract partial class AtbLoop: sig.TpsLinearDevice
        {
            [XmlElementAttribute("hasSwitchOffTimer", Order=1)]
            public rtmCommon.Duration hasSwitchOffTimer {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        Transponder for the ATB NG system.
nl-NL: ATB NG baken 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbngBeacon: sig.TpsSpotDevice
        {
            [XmlElementAttribute("isPsrBeacon", Order=1)]
            public Boolean isPsrBeacon {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A loop in the ATB NG train protection system.
NL: ATB NG lus 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbngLoop: prorail.AtbLoop
        {
            [XmlElementAttribute("intersectionCount", Order=1)]
            public Int32 intersectionCount {get; set;} = new Int32();
                
             
        }  
    
        /** 
        A transponder for the ATB VV system.
NL: ATB VV baken
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbvvBeacon: sig.TpsSpotDevice
        {
             
        }  
    
        /** 
        Small line-side cabinet for housing the ATB VV controller. It is spot located.
nl-NL: Aansluitkast (ASK) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbvvConnectionCabinet: sig.Cabinet
        {
             
        }  
    
        /** 
        Controller of the ATB VV system, housed in an ASK cabinet. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbVvController: sig.Controller
        {
             
        }  
    
        /** 
        Installation consisting of ATB VV beacons (transponders) and an optional loop. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbVvInstallation: sig.TpsDataTransmissionSystem
        {
             
        }  
    
        /** 
        A loop for the ATB VV system.
NL: ATB VV lus 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/ProRail")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/ProRail",IsNullable=false)] 
             
        public  partial class AtbvvLoop: prorail.AtbLoop
        {
             
        }  
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum FictitiousSignalFunctionTypes : int {
        /* stootjuk. */bufferstop,/* S-bord (stop-bord). */stop,/* Hoofdsein bediend (kan fictief geprojecteerd worden). */operatedMainSignal,/* Einde beveiligd gebied. Aan de andere zijde is een opstelterrein of terra incognita. */limitOfProtectedArea,/* Facultatief stopbord. */optionalStop
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum SignalColourTypes : int {
        /* Red
nl-NL: Rood */RD,/* Yellow
nl-NL: Geel */GL,/* Green
nl-NL: groen */GR,/* White: released voor shunting
nl-NL: wit; vrijgave rangeren */WIT
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum SignalRestrictionTypes : int {
        /*  */G,/* Letters in lichtbakken. */X,/*  */L,/*  */H,/*  */A,/*  */E,/*  */V
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum SignalSpeedRestrictionTypes : int {
        /*  */_4,/*  */_6,/*  */_8,/*  */_10,/*  */_12,/*  */_14
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum RouteReleaseTypes : int {
        /* Sections are crossed in direction x-y-z. Section x is released if y has been released, x turns vacant and z is occupied.
nl-NL: Actief, de sectie y wordt vrijgereden als de voorgaande sectie x vrijgereden is, de eigen sectie y niet meer bezet is en de volgende sectie z wel.  */active,/* The section is released together with the route's last active section.
nl-NL: Passief: De sectie wordt vrijgereden samen met de laatste actieve sectie van die rijweg.  */passive,/* nl-NL: vereenvoudigd actief. De sectie wordt vrijgereden als de vorige sectie vrijgereden is, de eigen sectie vervolgens gelijktijdig bezet is met de volgende sectie. */simplifiedActive
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum WeightLimitMarkerTypes : int {
        /* Announces H-signal
nl-NL: Langzaam */L,/* Halt for freight trains.
nl-NL: stoppen voor het sein. */H
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/ProRail")]
    public enum RouteLevelTypes : int {
        /* TB route */signalling,/* Route voor treinbeheersing  */trainControl
    }
    
} 
            