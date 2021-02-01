 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.rtmSig;
     
using sig = Models.TopoModels.EULYNX.sig;

namespace Models.TopoModels.EULYNX.sig {
    
        /** 
        Tangible asset installed on, near or as part of the track. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ReleaseInstrument))]
        [XmlIncludeAttribute(typeof(sig.Controller))]
        [XmlIncludeAttribute(typeof(sig.PlatformEdge))]
        [XmlIncludeAttribute(typeof(sig.PlatformFacility))]
        [XmlIncludeAttribute(typeof(sig.PlatformRoof))]
        [XmlIncludeAttribute(typeof(sig.Mechanism))]
        [XmlIncludeAttribute(typeof(sig.MovableComponent))]
        [XmlIncludeAttribute(typeof(sig.MovableElement))]
        [XmlIncludeAttribute(typeof(sig.MovableSystem))]
        [XmlIncludeAttribute(typeof(sig.SignalPostTelephone))]
        [XmlIncludeAttribute(typeof(sig.ConductorRail))]
        [XmlIncludeAttribute(typeof(sig.ExpansionJoint))]
        [XmlIncludeAttribute(typeof(sig.VehicleStop))]
        [XmlIncludeAttribute(typeof(sig.TcConnector))]
        [XmlIncludeAttribute(typeof(sig.TcFeederReceiverElement))]
        [XmlIncludeAttribute(typeof(sig.VehiclePassageDetector))]
        [XmlIncludeAttribute(typeof(sig.CompoundLogicalObject))]
        [XmlIncludeAttribute(typeof(sig.TpsDevice))]     
        public abstract partial class PhysicalTrackAsset: sig.TrackAsset
        {
             
        }  
    
        /** 
        An intangible asset.
Virtual track assets can be composed of or derived from physical track assets. They might be visualized on user interfaces for signaller.
Logical entities such as routes are transient, thus not considered track assets. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TrackCrossing))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingSystem))]
        [XmlIncludeAttribute(typeof(sig.TdsSection))]
        [XmlIncludeAttribute(typeof(sig.TvpSection))]
        [XmlIncludeAttribute(typeof(sig.TpsDataTransmissionSystem))]     
        public abstract partial class VirtualTrackAsset: sig.TrackAsset
        {
             
        }  
    
        /** 
        Named physical or virtual permanent (non-transient) field element that is relevant to signalling. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PhysicalTrackAsset))]
        [XmlIncludeAttribute(typeof(sig.VirtualTrackAsset))]
        [XmlIncludeAttribute(typeof(sig.Signal))]     
        public abstract partial class TrackAsset: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasLocalDatumReference", Order=1)]
            public LocalDatumReference hasLocalDatumReference {get; set;} = new LocalDatumReference();
                
             
        }  
    
        /** 
        The extremity of the block system. A track that is equipped with a block system has two matching block elements.
de-DE: Element am Ende einer Blockstrecke/Blockanlage.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BlockElement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasBlockClearanceTrigger", Order=1)]
            public tElementWithIDref hasBlockClearanceTrigger {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasLineBlockParameters", Order=2)]
            public tElementWithIDref hasLineBlockParameters {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasTrainRearConfirmation", Order=3)]
            public TrainRearConfirmation hasTrainRearConfirmation {get; set;} = new TrainRearConfirmation();
                
            [XmlElementAttribute("refersToBlockEntrySignal", Order=4)]
            public tElementWithIDref refersToBlockEntrySignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("type", Order=5)]
            public String type= "";
                
             
        }  
    
        /** 
        The configuration of the line block working. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BlockElementConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToLineBlockElement", Order=1)]
            public tElementWithIDref appliesToLineBlockElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasBlockNormalisingWarning", Order=2)]
            public Boolean hasBlockNormalisingWarning {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasBlockSettingType", Order=3)]
            public List<BlockSettingTypes> hasBlockSettingType { get; set; } = new List<BlockSettingTypes>(); 
                
            [XmlElementAttribute("hasTrainOnLineWarning", Order=4)]
            public Boolean hasTrainOnLineWarning {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Installation for block working on open line, stretching from the last controlled signal to the next station. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BlockSystem: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTrack", Order=1)]
            public tElementWithIDref appliesToTrack {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasBlockElementA", Order=2)]
            public BlockElement hasBlockElementA {get; set;} = new BlockElement();
                
            [XmlElementAttribute("hasBlockElementB", Order=3)]
            public BlockElement hasBlockElementB {get; set;} = new BlockElement();
                
            [XmlElementAttribute("hasBlockWorkingType", Order=4)]
            public LineBlockWorkingTypes hasBlockWorkingType {get; set;} = new LineBlockWorkingTypes();
                
            [XmlElementAttribute("needsGalvanicSeparation", Order=5)]
            public Boolean needsGalvanicSeparation {get; set;} = new Boolean();
                
            [XmlElementAttribute("usesBlockCircuitry", Order=6)]
            public BlockCircuitryTypes usesBlockCircuitry {get; set;} = new BlockCircuitryTypes();
                
             
        }  
    
        /** 
        Set of general attributes for the block line, viewed from a station. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.LineBlockInformation))]     
        public  partial class LineBlockInformation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isDesignedForBrakingDistance", Order=1)]
            public rtmCommon.Length isDesignedForBrakingDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("isDesignedForSpeed", Order=2)]
            public rtmCommon.Speed isDesignedForSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("leadsToNextMainOperationalLocality", Order=3)]
            public tElementWithIDref leadsToNextMainOperationalLocality {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("leadsToNextOperationalLocality", Order=4)]
            public tElementWithIDref leadsToNextOperationalLocality {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A switch or button allowing line-side staff to confirm that the rear of the train has cleared the block section.
de-DE: Zugschlussmeldung  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrainRearConfirmation: sig.LocalOperationUiElement
        {
             
        }  
    
        /** 
        A (physical) key to unlock a device. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Key: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("code", Order=1)]
            public String code= "";
                
            [XmlElementAttribute("group", Order=2)]
            public String group= "";
                
             
        }  
    
        /** 
        A device that releases control over an asset by releasing a key.
When the key is released, the interlocking gets no status information about the track asset, and the staff can use the key to mechanically unlock and work the asset locally.
The instrument "hides" the locked element from the interlocking. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ShutInSidingKeyReleaseInstrument))]     
        public  partial class KeyReleaseInstrument: sig.ReleaseInstrument
        {
            [XmlElementAttribute("isOfAccessabilityType", Order=1)]
            public AccessabilityTypes isOfAccessabilityType {get; set;} = new AccessabilityTypes();
                
             
        }  
    
        /** 
        The lock accepts a key and locks out one or more track assets from interlocking control.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PointLock))]     
        public  partial class Lock: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("acceptsKey", Order=1)]
            public tElementWithIDref acceptsKey {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("captiveKey", Order=2)]
            public Boolean captiveKey {get; set;} = new Boolean();
                
            [XmlElementAttribute("isDependentLockInLockCombination", Order=3)]
            public tElementWithIDref isDependentLockInLockCombination {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isInKeyReleaseInstrument", Order=4)]
            public tElementWithIDref isInKeyReleaseInstrument {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isMasterLockInLockCombination", Order=5)]
            public tElementWithIDref isMasterLockInLockCombination {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("locksAssetInState", Order=6)]
            public tElementWithIDref locksAssetInState;
                
             
        }  
    
        /** 
        A combination of one master lock and a set of dependent locks.
Either the master lock or all dependent locks are unlocked. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LockCombination: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isHousedIn", Order=1)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Lock attached to a clamp that prevents point blades from moving.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointLock: sig.Lock
        {
            [XmlElementAttribute("isMountedOnSide", Order=1)]
            public LeftRight isMountedOnSide {get; set;} = new LeftRight();
                
            [XmlElementAttribute("type", Order=2)]
            public String type= "";
                
             
        }  
    
        /** 
        A device that releases control of an asset.
nl-NL: Grendel 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.KeyReleaseInstrument))]     
        public  partial class ReleaseInstrument: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isHousedIn", Order=1)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("releasesTrackAsset", Order=2)]
            public List<tElementWithIDref> releasesTrackAsset { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Key release instrument particular to shunting sidings on open line.
It isolates (or <i>shuts in</i>) the shunting yard from the main running line.
de-DE: Ausweichanschlussstelle 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ShutInSidingKeyReleaseInstrument: sig.KeyReleaseInstrument
        {
             
        }  
    
        /** 
        Stretch of track where rail and road conflict.
The full level crossing protection zone is described by one or more danger area tracks. 
The track can be named in the inherited Designation class.
de-DE: Gleisbezogener Gefahrraum 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DangerAreaTrack: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTrackCrossing", Order=1)]
            public tElementWithIDref appliesToTrackCrossing {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDangerArea", Order=2)]
            public tElementWithIDref hasDangerArea {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A footpath crossing the railway. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FootpathCrossing: sig.TrackCrossing
        {
             
        }  
    
        /** 
        Level crossing system integrated into the IL logic.
Derive from controlled track asset pattern.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MainSignalProtectedLevelCrossing))]
        [XmlIncludeAttribute(typeof(sig.SelfSupervisedLevelCrossing))]     
        public  partial class InterlockingIntegratedLevelCrossing: sig.LevelCrossingSystem
        {
             
        }  
    
        /** 
        Activation of the level crossing means that the barriers start closing and/or the road user gets a warning.
This class stores parameters relevant to the activation process. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingActivation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("activatesDangerAreaTrack", Order=1)]
            public List<tElementWithIDref> activatesDangerAreaTrack { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLevelCrossingActivationDelaySet", Order=2)]
            public LevelCrossingActivationDelaySet hasLevelCrossingActivationDelaySet {get; set;} = new LevelCrossingActivationDelaySet();
                
            [XmlElementAttribute("isOfLxActivationType", Order=3)]
            public LevelCrossingActivationTypes isOfLxActivationType {get; set;} = new LevelCrossingActivationTypes();
                
            [XmlElementAttribute("speedDiscrimination", Order=4)]
            public Boolean speedDiscrimination {get; set;} = new Boolean();
                
            [XmlElementAttribute("stoppingTrain", Order=5)]
            public Boolean stoppingTrain {get; set;} = new Boolean();
                
            [XmlElementAttribute("usesTriggerAssignment", Order=6)]
            public tElementWithIDref usesTriggerAssignment {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Allows storing a set of activation delays. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LevelCrossingActivationDelaySet))]     
        public  partial class LevelCrossingActivationDelaySet
        {
            [XmlElementAttribute("hasCalculatedActivationDelay", Order=1)]
            public rtmCommon.Duration hasCalculatedActivationDelay {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasCalculatedSignalDelay", Order=2)]
            public rtmCommon.Duration hasCalculatedSignalDelay {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("allowsLocalControl", Order=1)]
            public Boolean allowsLocalControl {get; set;} = new Boolean();
                
            [XmlElementAttribute("appliesToLxSystem", Order=2)]
            public tElementWithIDref appliesToLxSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasBarriers", Order=3)]
            public Boolean hasBarriers {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasPreferredPosition", Order=4)]
            public LxStateTypes hasPreferredPosition {get; set;} = new LxStateTypes();
                
            [XmlElementAttribute("hasWarningInstallation", Order=5)]
            public Boolean hasWarningInstallation {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Deactivation of the level crossing means that the barriers open and/or the road user gets an all-clear.
This class stores parameters relevant to the de-activation process.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingDeactivation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliestoDangerAreaTrack", Order=1)]
            public tElementWithIDref appliestoDangerAreaTrack {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("usesTriggerAssignment", Order=2)]
            public tElementWithIDref usesTriggerAssignment {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A component of the user interface for local operation of a level crossing. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LevelCrossingLocalOperationUiElement))]     
        public  partial class LevelCrossingLocalOperationUiElement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("affectsLxActivation", Order=1)]
            public tElementWithIDref affectsLxActivation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("affectsLxDeactivation", Order=2)]
            public tElementWithIDref affectsLxDeactivation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("affectsLxSystem", Order=3)]
            public tElementWithIDref affectsLxSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToLocalOperationUiElement", Order=4)]
            public tElementWithIDref appliesToLocalOperationUiElement {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The activation process can depend on the route. This allows delaying level crossing closure depending on the route, or preventing the level crossing from closing if the route leads the train away from it.

de-DE: Fahrstra&#223;enabh&#228;ngige Wirksamkeitsschaltung 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingRouteRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesForRoute", Order=1)]
            public List<tElementWithIDref> appliesForRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("appliesToLxActivation", Order=2)]
            public tElementWithIDref appliesToLxActivation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("getsInputsFromTriggerAssignments", Order=3)]
            public List<tElementWithIDref> getsInputsFromTriggerAssignments { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Relation between the signal, e.g. protection signal, or sign, and the level crossing activation or track crossing.
The signal/sign is specific to level crossing, e.g. 
<ul>
 <li>en-UK: whistle</li>
 <li>fr-FR: siffler</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingSignalRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToLxActivation", Order=1)]
            public tElementWithIDref appliesToLxActivation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToSignal", Order=2)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTrackCrossing", Order=3)]
            public tElementWithIDref appliesToTrackCrossing {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDistanceToCrossing", Order=4)]
            public rtmCommon.Length hasDistanceToCrossing {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasTimeToTrackCrossing", Order=5)]
            public rtmCommon.Duration hasTimeToTrackCrossing {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        Placeholder for nationally specific timers. 
E.g. minimum road open time: time during which a level crossing is guaranteed to be available to road traffic. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LevelCrossingTimerSet))]
        [XmlIncludeAttribute(typeof(nr.LevelCrossingTimerSet))]     
        public abstract partial class LevelCrossingTimerSet: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToILintegratedLX", Order=1)]
            public tElementWithIDref appliesToILintegratedLX {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The level crossing status is locally monitored by the driver, and not integrated with IL logic: a level crossing system failure affects a signal that the driver observes.
Failure and health status can be monitored and transmitted to a unspecified system (other than the IL logic).
de-DE: &#220;S-B&#220; (&#220;berwachungssignalB&#220;) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocallyMonitoredLevelCrossing: sig.LevelCrossingSystem
        {
             
        }  
    
        /** 
        Level crossing system integrated with a route and protected by a signal, normally a main signal.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.MainSignalProtectedLevelCrossing))]     
        public  partial class MainSignalProtectedLevelCrossing: sig.InterlockingIntegratedLevelCrossing
        {
             
        }  
    
        /** 
        Warns and/or closes the barriers when activated by train approach detection. When this function fails, it guarantees to report failure to the interlocking.
Also known as autonomous level crossing.
de-DE: F&#252;-B&#220;, Fern&#252;berwachter Bahn&#252;bergang 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.SelfSupervisedLevelCrossingSystem))]     
        public  partial class SelfSupervisedLevelCrossing: sig.InterlockingIntegratedLevelCrossing
        {
             
        }  
    
        /** 
        Informs that vehicles or pedestrians cross railway tracks <b><i>at the same level</i></b>.
This class allows naming the street, road or path according to national rules (e.g. NR informs streetname nor type).
The track crossing can, <i>but need not</i>, be protected by a level crossing system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FootpathCrossing))]     
        public  partial class TrackCrossing: sig.VirtualTrackAsset
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public List<tElementWithIDref> isLocatedAt { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("streetName", Order=2)]
            public String streetName= "";
                
            [XmlElementAttribute("type", Order=3)]
            public String type= "";
                
             
        }  
    
        /** 
        The facility that protects a track crossing. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.InterlockingIntegratedLevelCrossing))]
        [XmlIncludeAttribute(typeof(sig.LocallyMonitoredLevelCrossing))]
        [XmlIncludeAttribute(typeof(sig.EtcsLevelCrossingSystem))]
        [XmlIncludeAttribute(typeof(db.LevelCrossingSystem))]
        [XmlIncludeAttribute(typeof(nr.LevelCrossingSystem))]     
        public  partial class LevelCrossingSystem: sig.VirtualTrackAsset
        {
            [XmlElementAttribute("dependsOnRoadTrafficLights", Order=1)]
            public Boolean dependsOnRoadTrafficLights {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasObstacleDetector", Order=2)]
            public Boolean hasObstacleDetector {get; set;} = new Boolean();
                
            [XmlElementAttribute("protectionType", Order=3)]
            public String protectionType= "";
                
            [XmlElementAttribute("protectsTrackCrossing", Order=4)]
            public tElementWithIDref protectsTrackCrossing {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("technologyType", Order=5)]
            public String technologyType= "";
                
             
        }  
    
        /** 
        Part of the interlocking area that a local operator can control on site, notably for directing shunting movements. The procedure of handing over control between signaller and local operator is supported by switches, keys and indicators on a local operating device.
nl-NL: Vrijgave Rangeren gebied 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LocalOperatingArea))]     
        public  partial class LocalOperatingArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("containsLoz", Order=1)]
            public List<tElementWithIDref> containsLoz { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Associates a button, switch or pull cord with a given function allowing local staff to interact with a local operating zone. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalOperatingAreaUiElement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("affectsLocalOperatingZone", Order=1)]
            public tElementWithIDref affectsLocalOperatingZone {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToLocalOperationUiElement", Order=2)]
            public tElementWithIDref appliesToLocalOperationUiElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasFunctionType", Order=3)]
            public UiElementFunctionTypes hasFunctionType {get; set;} = new UiElementFunctionTypes();
                
             
        }  
    
        /** 
        A local operating area consists of at least one local operating zone. The zone groups elements that can be worked locally. 
Zones can be disjoint, touch or even overlap. Adjacent zones can be independent, or can merge into a bigger zone to allow seamless shunting movement between them. Local control over the zones is taken in a given order, given by rank, e.g. 1-2-3. Handing back control is the inverse- operation, e.g. 3-2-1. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalOperatingZone: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("rank", Order=1)]
            public Int32 rank {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Outer limit of the local control area. 
This limit is flank protected.
The limit is represented by a signal, point or derailer
de-DE: Grenze der NB Zone gegen&#252;ber dem der Zone angrenzenden Bereich. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalOperatingZoneLimit: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isDefinedByLocationProxy", Order=1)]
            public tElementWithIDref isDefinedByLocationProxy;
                
            [XmlElementAttribute("isOfLocalOperatingZoneLimitType", Order=2)]
            public LocalOperatingZoneLimitTypes isOfLocalOperatingZoneLimitType {get; set;} = new LocalOperatingZoneLimitTypes();
                
            [XmlElementAttribute("limitsLocalOperatingZone", Order=3)]
            public tElementWithIDref limitsLocalOperatingZone {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Informs about the relation between local operation zones A and B. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalOperatingZoneRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToZoneA", Order=1)]
            public tElementWithIDref appliesToZoneA {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToZoneB", Order=2)]
            public tElementWithIDref appliesToZoneB {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfLocalOperatingZoneRelationType", Order=3)]
            public LocalOperatingZoneRelationTypes isOfLocalOperatingZoneRelationType {get; set;} = new LocalOperatingZoneRelationTypes();
                
             
        }  
    
        /** 
        Relates an asset to a local operating zone.
Optionally defines the condition for returning the zone to the signaller. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.LozDerailerRelation))]
        [XmlIncludeAttribute(typeof(sig.LozKeyReleaseInstrumentRelation))]
        [XmlIncludeAttribute(typeof(sig.LozPointRelation))]
        [XmlIncludeAttribute(typeof(sig.LozSignalRelation))]
        [XmlIncludeAttribute(typeof(sig.LozTdsSection))]     
        public abstract partial class LozAssetRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("controllable", Order=1)]
            public Boolean controllable {get; set;} = new Boolean();
                
            [XmlElementAttribute("isPartOfLoz", Order=2)]
            public List<tElementWithIDref> isPartOfLoz { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A derailer within the local operating zone. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LozDerailerRelation: sig.LozAssetRelation
        {
            [XmlElementAttribute("appliesToDerailerElement", Order=1)]
            public tElementWithIDref appliesToDerailerElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("needsPositionForReturn", Order=2)]
            public DerailingPositionTypes needsPositionForReturn {get; set;} = new DerailingPositionTypes();
                
             
        }  
    
        /** 
        A key release instrument within the local operating zone.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LozKeyReleaseInstrumentRelation: sig.LozAssetRelation
        {
            [XmlElementAttribute("appliesToKeyReleaseInstrument", Order=1)]
            public tElementWithIDref appliesToKeyReleaseInstrument {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("needsKeyPresenceForReturn", Order=2)]
            public Boolean needsKeyPresenceForReturn {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A point within the local operating zone.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LozPointRelation: sig.LozAssetRelation
        {
            [XmlElementAttribute("appliesToPointElement", Order=1)]
            public tElementWithIDref appliesToPointElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("needsPositionForReturn", Order=2)]
            public LeftRight needsPositionForReturn {get; set;} = new LeftRight();
                
             
        }  
    
        /** 
        A signal within the local operating zone. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LozSignalRelation: sig.LozAssetRelation
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("needsAspectForReturn", Order=2)]
            public tElementWithIDref needsAspectForReturn {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A TDS section within the local operating zone.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LozTdsSection: sig.LozAssetRelation
        {
            [XmlElementAttribute("mustBeVacantForReturn", Order=1)]
            public tElementWithIDref mustBeVacantForReturn {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("showsOnLocalDisplay", Order=2)]
            public tElementWithIDref showsOnLocalDisplay {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The terminal for locally working line-side elements. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LocalOperationDevice))]
        [XmlIncludeAttribute(typeof(nr.ControlFrame))]     
        public  partial class LocalOperationDevice: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("UiDesignAttachment", Order=1)]
            public tElementWithIDref UiDesignAttachment {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("composedOfUiElement", Order=2)]
            public List<LocalOperationUiElement> composedOfUiElement { get; set; } = new List<LocalOperationUiElement>(); 
                
            [XmlElementAttribute("hasOperatorPosition", Order=3)]
            public OperatorPosition hasOperatorPosition {get; set;} = new OperatorPosition();
                
            [XmlElementAttribute("isOfLocalOperationDeviceType", Order=4)]
            public LocalOperationDeviceTypes isOfLocalOperationDeviceType {get; set;} = new LocalOperationDeviceTypes();
                
            [XmlElementAttribute("isSupportedBy", Order=5)]
            public tElementWithIDref isSupportedBy {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToController", Order=6)]
            public tElementWithIDref refersToController {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A user interface element of type button. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LocalOperationUiButton))]     
        public  partial class LocalOperationUiButton: sig.LocalOperationUiElement
        {
             
        }  
    
        /** 
        A user interface component such as a button, knob, switch, lever, indicator, lamp, buzzer or pull cord that is mounted in a local operation device and that fulfills a given function.
The UI element interacts with (the state of) a signal or movable element (to request a movement). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TrainRearConfirmation))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationUiButton))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationUiIndicator))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationUiLever))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationUiSwitch))]     
        public  partial class LocalOperationUiElement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("affectsMovableComponent", Order=1)]
            public tElementWithIDref affectsMovableComponent {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("affectsMovableElement", Order=2)]
            public tElementWithIDref affectsMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("affectsSignal", Order=3)]
            public tElementWithIDref affectsSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A user interface element; visual or audible indicator, i.e. lamp or buzzer. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LocalOperationUiIndicator))]     
        public  partial class LocalOperationUiIndicator: sig.LocalOperationUiElement
        {
             
        }  
    
        /** 
        The type of lever can be specialised.
E.g. SNCF has levers that act differently depending on the phase of the movement of the lever. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalOperationUiLever: sig.LocalOperationUiElement
        {
             
        }  
    
        /** 
        A user interface element of type switch. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LocalOperationUiSwitch))]     
        public  partial class LocalOperationUiSwitch: sig.LocalOperationUiElement
        {
             
        }  
    
        /** 
        The part of the interlocking where the core route logic runs.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CentralInterlocking: sig.Interlocking
        {
             
        }  
    
        /** 
        The list of field elements plus the interlocking in a control area.
Also useful for defining areas under control of a substation or controller.
<ul>
 <li>de-DE: Stellbereich</li>
 <li>NR: signal box</li>
 <li>ProRail: PPLG Primair Procesleidingsgebied of CSS-gebied</li>
 <li>SNCF: zone d'action d'un poste ou controleur d'objets</li>
 <li>RFI: zona, o limite, di batteria</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ControlArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("containsTrackAsset", Order=1)]
            public List<tElementWithIDref> containsTrackAsset { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isControlledByController", Order=2)]
            public tElementWithIDref isControlledByController {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedAt", Order=3)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Controlled track assets is the subset of track assets that 
<ul>
 <li>are <b>controlled </b>by, and/or</li>
 <li>are <b>powered </b>by, and/or</li>
 <li><b>exchange </b>information with a controller.</li>
</ul>
There has to be one instance of this class for each associated track asset instance. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ControlledTrackAsset: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToActiveSignal", Order=1)]
            public tElementWithIDref appliesToActiveSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToCompoundLogicalObject", Order=2)]
            public tElementWithIDref appliesToCompoundLogicalObject {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToILIntegratedLevelCrossing", Order=3)]
            public tElementWithIDref appliesToILIntegratedLevelCrossing {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToMovableElement", Order=4)]
            public tElementWithIDref appliesToMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToReleaseInstrument", Order=5)]
            public tElementWithIDref appliesToReleaseInstrument {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTpsDevice", Order=6)]
            public tElementWithIDref appliesToTpsDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTrainDetectionSection", Order=7)]
            public tElementWithIDref appliesToTrainDetectionSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToVehiclePassageDetector", Order=8)]
            public tElementWithIDref appliesToVehiclePassageDetector;
                
            [XmlElementAttribute("getsBackupPowerFrom", Order=9)]
            public List<PowerSupplyTypes> getsBackupPowerFrom { get; set; } = new List<PowerSupplyTypes>(); 
                
            [XmlElementAttribute("isPoweredBy", Order=10)]
            public PowerSupplyTypes isPoweredBy {get; set;} = new PowerSupplyTypes();
                
            [XmlElementAttribute("reportsToDiagnosticsCollector", Order=11)]
            public List<tElementWithIDref> reportsToDiagnosticsCollector { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Term for constructing the hierarchy of types of objects that control the field elements. 
This controller class can be instantiated when no other appropriate sub-class is available, e.g. when a new kind of controller is introduced. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FieldObjectController))]
        [XmlIncludeAttribute(typeof(sig.TrafficControlSystem))]
        [XmlIncludeAttribute(typeof(sig.VirtualController))]
        [XmlIncludeAttribute(typeof(sig.Interlocking))]
        [XmlIncludeAttribute(typeof(sig.RBC))]
        [XmlIncludeAttribute(typeof(prorail.AtbVvController))]     
        public  partial class Controller: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("hasBackupPowerSupplyType", Order=1)]
            public List<PowerSupplyTypes> hasBackupPowerSupplyType { get; set; } = new List<PowerSupplyTypes>(); 
                
            [XmlElementAttribute("hasPowerSupplyType", Order=2)]
            public PowerSupplyTypes hasPowerSupplyType {get; set;} = new PowerSupplyTypes();
                
            [XmlElementAttribute("isHousedIn", Order=3)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("operatesLocality", Order=4)]
            public List<tElementWithIDref> operatesLocality { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("reportsToDiagnosticsCollector", Order=5)]
            public List<tElementWithIDref> reportsToDiagnosticsCollector { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("technology", Order=6)]
            public String technology= "";
                
             
        }  
    
        /** 
        Association class informing about the control relation between two controllers.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ControllerRelation: sig.ControlRelation
        {
            [XmlElementAttribute("endPointA", Order=1)]
            public tElementWithIDref endPointA {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("endPointB", Order=2)]
            public tElementWithIDref endPointB {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Association class informing about the control relation between two controllers or between a controller and a controlled track asset.
End point A and B in combination with the navigability inform about the direction of the flow.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ControllerRelation))]     
        public  partial class ControlRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("backupPowerFlowsFromTo", Order=1)]
            public rtmCommon.Navigability backupPowerFlowsFromTo {get; set;} = new rtmCommon.Navigability();
                
            [XmlElementAttribute("controlFlowsFromTo", Order=2)]
            public rtmCommon.Navigability controlFlowsFromTo {get; set;} = new rtmCommon.Navigability();
                
            [XmlElementAttribute("exchangeInformation", Order=3)]
            public Boolean exchangeInformation {get; set;} = new Boolean();
                
            [XmlElementAttribute("powerFlowsFromTo", Order=4)]
            public rtmCommon.Navigability powerFlowsFromTo {get; set;} = new rtmCommon.Navigability();
                
            [XmlElementAttribute("secondaryControlFlowsFromTo", Order=5)]
            public rtmCommon.Navigability secondaryControlFlowsFromTo {get; set;} = new rtmCommon.Navigability();
                
            [XmlElementAttribute("usesCable", Order=6)]
            public List<tElementWithIDref> usesCable { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Fa&#231;ade to a (set of) data centre(s). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DaCloud: sig.DataCentre
        {
             
        }  
    
        /** 
        Facility that houses computing systems. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DaCloud))]     
        public  partial class DataCentre: sig.Housing
        {
             
        }  
    
        /** 
        Decentral part of the interlocking, running a sub-area of the interlocking area. Typically placed as close as possible to the field elements that it controls.
DB: Gleisfeldkonzentrator (Gfk) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DecentralInterlocking: sig.Interlocking
        {
             
        }  
    
        /** 
        A device that exchanges commands, information, power with one or a few individual field objects like signal, point, etc.
Is in control of active track assets. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.IoController))]
        [XmlIncludeAttribute(typeof(sig.SignalController))]
        [XmlIncludeAttribute(typeof(sig.TdsEvaluator))]
        [XmlIncludeAttribute(typeof(sig.LeuSystem))]     
        public  partial class FieldObjectController: sig.Controller
        {
             
        }  
    
        /** 
        Controller for receiving binary inputs and sending binary outputs.
<ul>
 <li>Inputs, typically received from relay contacts, are packed into telegrams and sent to the interlocking.</li>
</ul>
<ul>
 <li>Telegrams received from the interlocking are converted to outputs.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class IoController: sig.FieldObjectController
        {
             
        }  
    
        /** 
        Object controller for a signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalController: sig.FieldObjectController
        {
             
        }  
    
        /** 
        Controller for one or more TDS sections.
The type of evaluator depends on the connected TDS section technology, typically axle count evaluation unit or track circuit evaluator.
Can be in the field or near the interlocking. Provides the logical vacancy status to the IL.
de-DE: Gleisfreimelde-Innenanlage 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TdsEvaluator: sig.FieldObjectController
        {
             
        }  
    
        /** 
        A Traffic Control System is located in the
<ul>
 <li>fr-FR: Poste de commande &#224; distance</li>
 <li>Betriebszentrale in DACH</li>
 <li>en-UK: signalbox</li>
 <li>nl-NL: VL-Post</li>
 <li>it-IT: Posto centrale/locale</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrafficControlSystem: sig.Controller
        {
             
        }  
    
        /** 
        Placeholder for a control object used when the architecture is not known (yet) or irrelevant. Useful during a tendering or design phase.
Once the architecture is known, this object would be replaced by controllers that match its particular architecture. 
For instance: 
<ul>
 <li>central interlocking and some decentral sub-interlockings</li>
 <li>central interlocking and many field object controllers (EULYNX style)</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class VirtualController: sig.Controller
        {
             
        }  
    
        /** 
        An interlocking system that has a control relationship with track-assets and/or controllers in a yard. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CentralInterlocking))]
        [XmlIncludeAttribute(typeof(sig.DecentralInterlocking))]     
        public  partial class Interlocking: sig.Controller
        {
             
        }  
    
        /** 
        The spot from where trains can be dispatched, i.e. the spot where the dispatcher can sight train(s) and signals. Extra equipment like plungers can be installed here. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DispatchPosition: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        All of the platform edge adjacent to a track. Includes ramps, stairs, fenced off or restricted areas where trains don't normally stop. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class InfrastructuralPlatformEdge: sig.PlatformEdge
        {
             
        }  
    
        /** 
        Where passenger can access trains.
The definition is national. It depends on signal sighting, length of train, position of doors, height of steps, presence of barriers or signs.
It is possible to define an edge <i>per direction</i>, which can be relevant to coupling, splitting or turn-operations (NR and ProRail).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OperationalPlatformEdge: sig.PlatformEdge
        {
             
        }  
    
        /** 
        Means of platform access. Relevant for positioning operational stops. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PlatformAccess: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isOfPlatformAccessType", Order=1)]
            public PlatformAccessTypes isOfPlatformAccessType {get; set;} = new PlatformAccessTypes();
                
            [XmlElementAttribute("isPrimaryAccess", Order=2)]
            public Boolean isPrimaryAccess {get; set;} = new Boolean();
                
            [XmlElementAttribute("leadsPassengersToPlatformEdgeAccessPoint", Order=3)]
            public List<PlatformEdgeAccessPoint> leadsPassengersToPlatformEdgeAccessPoint { get; set; } = new List<PlatformEdgeAccessPoint>(); 
                
             
        }  
    
        /** 
        Part of the platform facility adjacent to a track.
The designation of the platform edge is for passenger information systems, typically a number plus a letter e.g. <i>platform 6</i> or <i>platform 10a/b</i>.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.InfrastructuralPlatformEdge))]
        [XmlIncludeAttribute(typeof(sig.OperationalPlatformEdge))]
        [XmlIncludeAttribute(typeof(sig.UsablePlatformEdge))]
        [XmlIncludeAttribute(typeof(db.PlatformEdge))]     
        public abstract partial class PlatformEdge: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("hasDispatchPosition", Order=1)]
            public List<DispatchPosition> hasDispatchPosition { get; set; } = new List<DispatchPosition>(); 
                
            [XmlElementAttribute("hasHeight", Order=2)]
            public rtmCommon.Length hasHeight {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("isLocatedAt", Order=3)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isPartOfPlatformEdge", Order=4)]
            public List<tElementWithIDref> isPartOfPlatformEdge { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isSituatedToSide", Order=5)]
            public rtmCommon.LateralSide isSituatedToSide {get; set;} = new rtmCommon.LateralSide();
                
             
        }  
    
        /** 
        The spot, projected on the platform edge, where passengers tend to cluster, typically near the stairs, escalator or elevator. This helps to determine where the train should stop. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PlatformEdgeAccessPoint: sig.BaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOnPlatformEdge", Order=2)]
            public tElementWithIDref isOnPlatformEdge;
                
             
        }  
    
        /** 
        Allows passengers to board and alight from trains. Has one or more edges and passenger accesses.  
The platform designation is usually composed of the names of the platform edges,<i> </i>e.g. <i>Platform 3 and 4</i>. Sometimes, a name like <i>Platform A with tracks 102 and 103</i> may occur. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PlatformFacility: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("containsPlatformEdge", Order=1)]
            public List<tElementWithIDref> containsPlatformEdge { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasPlatformAccess", Order=2)]
            public List<PlatformAccess> hasPlatformAccess { get; set; } = new List<PlatformAccess>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PlatformRoof: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("appliesToPlatformEdge", Order=1)]
            public tElementWithIDref appliesToPlatformEdge;
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Where trains are allowed to stand.
Notes:
<ul>
 <li>NR and SNCF: ends at signal minus sighting distance.</li>
</ul>
<ul>
 <li>NR: platform standage.</li>
</ul>
<ul>
 <li>ProRail: bruikbare lengte.</li>
 <li>RFI only use operational platform edge.</li>
 <li>DB design rules consider the <i>usable </i>length only.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class UsablePlatformEdge: sig.PlatformEdge
        {
             
        }  
    
        /** 
        A derailer consists of one derailer component. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.DerailerComponent))]     
        public  partial class DerailerComponent: sig.MovableComponent
        {
            [XmlElementAttribute("derailsInDirection", Order=1)]
            public LeftRightCentreTypes derailsInDirection {get; set;} = new LeftRightCentreTypes();
                
            [XmlElementAttribute("hasGuardRail", Order=2)]
            public Boolean hasGuardRail {get; set;} = new Boolean();
                
            [XmlElementAttribute("isLocatedAt", Order=3)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Properties that apply to a derailer.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DerailerElementConfiguration: sig.MovableElementConfiguration
        {
            [XmlElementAttribute("derailerIsFixedInPosition", Order=1)]
            public DerailingPositionTypes derailerIsFixedInPosition {get; set;} = new DerailingPositionTypes();
                
             
        }  
    
        /** 
        A diamond is the lozenge shape where the rails intersect in a crossing. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DiamondHalf))]     
        public  partial class Diamond: sig.BaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Crossing diamond component A or B.
The diamond divides into a half A and half B.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DiamondHalf: sig.Diamond
        {
            [XmlElementAttribute("atSide", Order=1)]
            public DiamondComponentSide atSide {get; set;} = new DiamondComponentSide();
                
            [XmlElementAttribute("imposesSpeedRestrictionLeft", Order=2)]
            public rtmCommon.Speed imposesSpeedRestrictionLeft {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("imposesSpeedRestrictionRight", Order=3)]
            public rtmCommon.Speed imposesSpeedRestrictionRight {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        Electric point machine.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ElectricDrive: sig.PoweredMechanism
        {
             
        }  
    
        /** 
        A movable lock that keeps the point blade(s) in place.
<ul>
 <li>en-GB: Facing Point Lock (FPL). The scheme design provides the label for the designation. The label maps to the inherited designation class.</li>
</ul>
<ul>
 <li>fr-FR: Verrou Carter Coussinet.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FacingPointLock: sig.MovableComponent
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The train detector within a fouling track dictates which movable element positions must be checked and which section must be clear as a consequence (if any).
Typically used in Germany.
de-DE: Nicht-grenzzeichenfreie Freimeldung 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FoulTrackControl
        {
            [XmlElementAttribute("alsoCheckMovableElement", Order=1)]
            public tElementWithIDref alsoCheckMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("alsoCheckPointElementInPosition", Order=2)]
            public tElementWithIDref alsoCheckPointElementInPosition {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("alsoCheckTdsSection", Order=3)]
            public tElementWithIDref alsoCheckTdsSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToPointElementInPosition", Order=4)]
            public tElementWithIDref appliesToPointElementInPosition {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The part of a turnout, a crossing, or a gantlet, where the rails have an intersection which allows the wheel flanges to cross the running rail. The frog may be fixed or moveable.
Also known as movable nose or swing nose. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Frog: sig.MovableComponent
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Worked by hand locally. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class HandOperatedMechanism: sig.Mechanism
        {
             
        }  
    
        /** 
        Point machine that uses hydraulic pressure to throw the point. 
Note that a point machine equipped with an electric pump that builds up hydraulic pressure is considered an electric drive.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class HydraulicDrive: sig.PoweredMechanism
        {
             
        }  
    
        /** 
        Worked by means of wires or rods, at some distance. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MechanicalMechanism: sig.Mechanism
        {
             
        }  
    
        /** 
        Mechanism that drives movable components:
<ul>
 <li>point machine, also known as drive</li>
 <li>hydraulic drive</li>
 <li>manual levers for hand points</li>
 <li>wires</li>
 <li>rods</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.HandOperatedMechanism))]
        [XmlIncludeAttribute(typeof(sig.MechanicalMechanism))]
        [XmlIncludeAttribute(typeof(sig.PoweredMechanism))]     
        public  partial class Mechanism: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("drivesTurnoutComponent", Order=1)]
            public List<tElementWithIDref> drivesTurnoutComponent { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A railway bridge that can be opened or closed to train traffic. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MovableBridge: sig.MovableSystem
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MovableBufferStop: sig.MovableSystem
        {
             
        }  
    
        /** 
        The smallest mobile part of a movable element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DerailerComponent))]
        [XmlIncludeAttribute(typeof(sig.FacingPointLock))]
        [XmlIncludeAttribute(typeof(sig.Frog))]
        [XmlIncludeAttribute(typeof(sig.PointBlades))]     
        public  partial class MovableComponent: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("refersToReferenceDrawing", Order=1)]
            public List<tElementWithIDref> refersToReferenceDrawing { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A set of properties that applies to a movable component.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.TurnoutComponentConfiguration))]     
        public  partial class MovableComponentConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToTurnoutComponent", Order=1)]
            public tElementWithIDref appliesToTurnoutComponent {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isDrivenByMechanismType", Order=2)]
            public MechanismTypes isDrivenByMechanismType {get; set;} = new MechanismTypes();
                
            [XmlElementAttribute("mechanismPositionedToSide", Order=3)]
            public LeftRightCentreTypes mechanismPositionedToSide {get; set;} = new LeftRightCentreTypes();
                
            [XmlElementAttribute("numberOfMechanism", Order=4)]
            public Int32 numberOfMechanism {get; set;} = new Int32();
                
             
        }  
    
        /** 
        The set of components that are controlled and set simultaneously to one of two positions.

The movable element is an abstraction that associates the underlying movable components. The signaller selects and operates one movable element and needs not be concerned with the individual components of the movable element. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(trv.MovableElement))]     
        public  partial class MovableElement: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("associatesMechanism", Order=1)]
            public List<tElementWithIDref> associatesMechanism { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasClearancePointLocatedAt", Order=2)]
            public tElementWithIDref hasClearancePointLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasFoulingPointIndicator", Order=3)]
            public tElementWithIDref hasFoulingPointIndicator {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasFoulingPointLocatedAt", Order=4)]
            public tElementWithIDref hasFoulingPointLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isComposedOfMovableComponent", Order=5)]
            public List<MovableComponent> isComposedOfMovableComponent { get; set; } = new List<MovableComponent>(); 
                
            [XmlElementAttribute("isLogicallyCoupledWithMovableElement", Order=6)]
            public List<tElementWithIDref> isLogicallyCoupledWithMovableElement { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToPositionIndicator", Order=7)]
            public tElementWithIDref refersToPositionIndicator {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToReferenceDrawing", Order=8)]
            public List<tElementWithIDref> refersToReferenceDrawing { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A set of as built properties that applies to a movable element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MovableElementAsBuiltConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToMovableElement", Order=1)]
            public tElementWithIDref appliesToMovableElement {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A set of properties that applies to a movable element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DerailerElementConfiguration))]
        [XmlIncludeAttribute(typeof(sig.PointCrossingElementConfiguration))]     
        public abstract partial class MovableElementConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToMovableElement", Order=1)]
            public tElementWithIDref appliesToMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasMaxOperationDuration", Order=2)]
            public rtmCommon.Duration hasMaxOperationDuration {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("isInControlMode", Order=3)]
            public ControlModes isInControlMode {get; set;} = new ControlModes();
                
            [XmlElementAttribute("isInOperatingMode", Order=4)]
            public MovableElementOperatingModes isInOperatingMode {get; set;} = new MovableElementOperatingModes();
                
             
        }  
    
        /** 
        The movable element returns to the preferred position when it is no longer claimed by a route, typically because the passing train has cleared the movable element. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Normalisation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToMovableElement", Order=1)]
            public tElementWithIDref appliesToMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfNormalisationType", Order=2)]
            public NormalisationTypes isOfNormalisationType {get; set;} = new NormalisationTypes();
                
             
        }  
    
        /** 
        Point machine that uses pneumatic pressure to throw the point. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PneumaticDrive: sig.PoweredMechanism
        {
             
        }  
    
        /** 
        Individual switch rail (NetworkRail can separately control the blades in some cases). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointBlade: sig.PointBlades
        {
             
        }  
    
        /** 
        The pair of switch rails of a point that are secured together by a stretcher bar.
The location is given by the origin of the associated RSM Turnout. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PointBlade))]     
        public  partial class PointBlades: sig.MovableComponent
        {
            [XmlElementAttribute("branchTowardsCrossing", Order=1)]
            public LeftRight branchTowardsCrossing {get; set;} = new LeftRight();
                
            [XmlElementAttribute("hasExternalDetectors", Order=2)]
            public Boolean hasExternalDetectors {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasExternalLock", Order=3)]
            public Boolean hasExternalLock {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasPointIndicatorOfType", Order=4)]
            public PointIndicatorTypes hasPointIndicatorOfType {get; set;} = new PointIndicatorTypes();
                
            [XmlElementAttribute("imposesSpeedRestrictionLeft", Order=5)]
            public rtmCommon.Speed imposesSpeedRestrictionLeft {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("imposesSpeedRestrictionRight", Order=6)]
            public rtmCommon.Speed imposesSpeedRestrictionRight {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("numberOfExternalDetectors", Order=7)]
            public Int32 numberOfExternalDetectors {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Generic term for point or crossing installation. Typically a complete replaceable track assembly. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.Crossing))]
        [XmlIncludeAttribute(typeof(sig.Point))]     
        public  partial class PointCrossing: sig.Turnout
        {
            [XmlElementAttribute("hasHeating", Order=1)]
            public PointHeating hasHeating {get; set;} = new PointHeating();
                
            [XmlElementAttribute("hasSwitchedNose", Order=2)]
            public Boolean hasSwitchedNose {get; set;} = new Boolean();
                
            [XmlElementAttribute("insulationType", Order=3)]
            public String insulationType= "";
                
            [XmlElementAttribute("refersToSignalShowingDetection", Order=4)]
            public tElementWithIDref refersToSignalShowingDetection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("typeDescription", Order=5)]
            public String typeDescription= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointCrossingElementConfiguration: sig.MovableElementConfiguration
        {
            [XmlElementAttribute("clampType", Order=1)]
            public String clampType= "";
                
            [XmlElementAttribute("hasTrailingDetection", Order=2)]
            public Boolean hasTrailingDetection {get; set;} = new Boolean();
                
            [XmlElementAttribute("isTrailable", Order=3)]
            public Boolean isTrailable {get; set;} = new Boolean();
                
            [XmlElementAttribute("pointIsFixedInPosition", Order=4)]
            public LeftRight pointIsFixedInPosition {get; set;} = new LeftRight();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointHeating
        {
            [XmlElementAttribute("heatSource", Order=1)]
            public String heatSource= "";
                
             
        }  
    
        /** 
        Powered mechanism that drives turnout components, typically a point machine. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ElectricDrive))]
        [XmlIncludeAttribute(typeof(sig.HydraulicDrive))]
        [XmlIncludeAttribute(typeof(sig.PneumaticDrive))]     
        public  partial class PoweredMechanism: sig.Mechanism
        {
             
        }  
    
        /** 
        Movable barrier that can be opened or closed to <i>railway </i>traffic. 
For instance a water barrier in a tunnel or dike. 

For barriers that block <i>road traffic</i>, refer to Level Crossings. 
Gated level crossings have a dual function, blocking either road or rail traffic. These are detected much like level crossing and therefore considered Level Crossings in our model. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RailwayBarrier: sig.MovableSystem
        {
             
        }  
    
        /** 
        A system where tracks divert, cross or that derails railway traffic.
A generic term for point-, crossing- and derailer-systems.
<ul>
 <li>de-DE: Weichen-, Kreuzungs- und Gleissperrenanlagen.</li>
 <li>fr-FR: Aiguillages, travers&#233;es obliques, taquet d&#233;railleurs.</li>
 <li>it-IT: Deviatoio, incrocio.</li>
 <li>nl-NL: Wissels, kruisingen, stopontspoorblokken.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PointCrossing))]
        [XmlIncludeAttribute(typeof(sig.Derailer))]     
        public  partial class Turnout: sig.MovableSystem
        {
            [XmlElementAttribute("refersToRsmPoint", Order=1)]
            public tElementWithIDref refersToRsmPoint {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Glossary definition: "A safety device attached to a rail, that will, when operated, cause a derailment of a train making an unauthorised movement."
Not to be confused with trap points.
The derailment direction (direction in which the train is ejected from the rails) is an attribute of the individual derailer component(s). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Derailer: sig.Turnout
        {
             
        }  
    
        /** 
        An interlocking can throw an overhead catenary just like a point or a crossing with movable frog. A movable overhead catenary is always situated over a point or a crossing. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MovableCatenary: sig.MovableSystem
        {
            [XmlElementAttribute("preferredPosition", Order=1)]
            public LeftRight preferredPosition {get; set;} = new LeftRight();
                
             
        }  
    
        /** 
        A crossing installation.
Some crossings, especially high speed ones, have a switched diamond to close the gap at the crossing (DE: Flachkreuzung mit beweglichen Herzst&#252;ckspitzen, NL: kruising met beweegbaar puntstuk). 
Strictly speaking such a crossing isn't a turnout because the movable frog will not send the train left or right. This said, it does guide the train and its position is essential for avoiding derailment.
The slip points, if any, to which the crossing connects are separate instances of the Point class. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Crossing: sig.PointCrossing
        {
            [XmlElementAttribute("hasDiamond", Order=1)]
            public List<Diamond> hasDiamond { get; set; } = new List<Diamond>(); 
                
            [XmlElementAttribute("isOfCrossingType", Order=2)]
            public CrossingTypes isOfCrossingType {get; set;} = new CrossingTypes();
                
             
        }  
    
        /** 
        Abstract class for systems that have movable elements. Movable systems either divert, halt or derail railway traffic. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MovableBridge))]
        [XmlIncludeAttribute(typeof(sig.MovableBufferStop))]
        [XmlIncludeAttribute(typeof(sig.RailwayBarrier))]
        [XmlIncludeAttribute(typeof(sig.Turnout))]
        [XmlIncludeAttribute(typeof(sig.MovableCatenary))]     
        public  partial class MovableSystem: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isComposedOfMovableElement", Order=1)]
            public List<MovableElement> isComposedOfMovableElement { get; set; } = new List<MovableElement>(); 
                
             
        }  
    
        /** 
        en-GB: point
en-US: switch
fr-FR: aiguillage
nl-NL: wissel
de-DE: Weiche 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Point: sig.PointCrossing
        {
            [XmlElementAttribute("isOfPointType", Order=1)]
            public PointTypes isOfPointType {get; set;} = new PointTypes();
                
             
        }  
    
        /** 
        A signal with an actively controlled aspect. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.LightSignal))]
        [XmlIncludeAttribute(typeof(sig.MechanicalSignal))]     
        public  partial class ActiveSignal: sig.PhysicalSignal
        {
             
        }  
    
        /** 
        A software object in the interlocking. It may be visible on the signaller control display but not on the driver's DMI. Trains don't stop at a fictitious signal.
Also called cross-boundary signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.FictitiousSignal))]
        [XmlIncludeAttribute(typeof(prorail.FictitiousSignal))]
        [XmlIncludeAttribute(typeof(sncf.FictitiousSignal))]     
        public  partial class FictitiousSignal: sig.NonPhysicalSignal
        {
            [XmlElementAttribute("isAssociatedWithVehicleStop", Order=1)]
            public tElementWithIDref isAssociatedWithVehicleStop {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A signal with lamps that transmit information to the driver.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LightSignalTyped))]
        [XmlIncludeAttribute(typeof(nr.LightSignal))]     
        public  partial class LightSignal: sig.ActiveSignal
        {
            [XmlElementAttribute("hasLuminosity", Order=1)]
            public LuminosityTypes hasLuminosity {get; set;} = new LuminosityTypes();
                
             
        }  
    
        /** 
        Also known as semaphore. The aspect is given by the position of the arms. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MechanicalSignal: sig.ActiveSignal
        {
             
        }  
    
        /** 
        Simple wayside sign marking mileage/kilometrage/hectometre.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Milepost: sig.Sign
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
            [XmlElementAttribute("valueShown", Order=2)]
            public String valueShown= "";
                
             
        }  
    
        /** 
        A signal without a physical line-side appearance. 
The non-physical signal need not send information to the train driver as opposed to a physical signal.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FictitiousSignal))]
        [XmlIncludeAttribute(typeof(sig.VirtualSignal))]     
        public  partial class NonPhysicalSignal: sig.Signal
        {
            [XmlElementAttribute("hasPhysicalRepresentation", Order=1)]
            public tElementWithIDref hasPhysicalRepresentation {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A signal with a physical line-side appearance. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ActiveSignal))]
        [XmlIncludeAttribute(typeof(sig.Sign))]
        [XmlIncludeAttribute(typeof(nr.PhysicalSignal))]     
        public  partial class PhysicalSignal: sig.Signal
        {
             
        }  
    
        /** 
        Indicates that the train may proceed.

Note: the end user can specialise this class to adapt it to national needs. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ProceedMessage: sig.AspectSet
        {
             
        }  
    
        /** 
        A signal with a passive aspect, <i><u>not controlled </u></i>by the signalling system. 
A sign (or board) sends a permanent message to the driver. Its message and physical appearance (shape, colour, patterns) are normalised.

Note: A sign can carry a lamp showing one single aspect, and the interlocking can <i><u>only read </u></i>the status of the lamp (e.g. a sign with a lamp marking the end of the track). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.Milepost))]     
        public  partial class Sign: sig.PhysicalSignal
        {
             
        }  
    
        /** 
        Generic term for the information-carriers: sign, board, nameplates, lamp-frames, notice boards. 
It is most often part of a signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.SignalFrame))]     
        public  partial class SignalFrame: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasAspect", Order=1)]
            public List<tElementWithIDref> hasAspect { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasPosition", Order=2)]
            public List<OffsetOfReferencePoint> hasPosition { get; set; } = new List<OffsetOfReferencePoint>(); 
                
            [XmlElementAttribute("isFixed", Order=3)]
            public Boolean isFixed {get; set;} = new Boolean();
                
            [XmlElementAttribute("isOfSignalFrameType", Order=4)]
            public SignalFrameTypes isOfSignalFrameType {get; set;} = new SignalFrameTypes();
                
            [XmlElementAttribute("refersToCoActingSignalFrame", Order=5)]
            public List<tElementWithIDref> refersToCoActingSignalFrame { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToSubordinatedSignalFrame", Order=6)]
            public List<tElementWithIDref> refersToSubordinatedSignalFrame { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        E.g. Lamp, light spot, or indicator that is part of a signal frame. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.SignalFrameComponent))]     
        public  partial class SignalFrameComponent: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasAspect", Order=1)]
            public List<tElementWithIDref> hasAspect { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        General class for describing the signal type. National types can be described in the national domains. 
For instance: signal head type as defined by NR. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.SignalType))]     
        public  partial class SignalType: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=2)]
            public String value= "";
                
             
        }  
    
        /** 
        Indicates that the train must stop.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class StopMessage: sig.AspectSet
        {
            [XmlElementAttribute("imperative", Order=1)]
            public Boolean imperative {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Limits a virtual block in systems such as Hybrid Level 3 or LZB. A train may be stopped at a virtual signal. The signal may be visible only on the signaller's control display and driver's DMI.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class VirtualSignal: sig.NonPhysicalSignal
        {
             
        }  
    
        /** 
        A Signal is a line side element that sends a message to driver. The signal can consist of several frames each of which carries part of the message to the driver.
The signal in the EULYNX DP namespace enriches the RSM information with signalling information. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.NonPhysicalSignal))]
        [XmlIncludeAttribute(typeof(sig.PhysicalSignal))]
        [XmlIncludeAttribute(typeof(db.Signal))]     
        public  partial class Signal: sig.TrackAsset
        {
            [XmlElementAttribute("hasLocation", Order=1)]
            public tElementWithIDref hasLocation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasSignalFrame", Order=2)]
            public List<tElementWithIDref> hasSignalFrame { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isDesignedForFixingType", Order=3)]
            public FixingTypes isDesignedForFixingType {get; set;} = new FixingTypes();
                
            [XmlElementAttribute("refersToOverlapsForDisplay", Order=4)]
            public List<tElementWithIDref> refersToOverlapsForDisplay { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToRsmSignal", Order=5)]
            public tElementWithIDref refersToRsmSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSafetyDistance", Order=6)]
            public List<tElementWithIDref> refersToSafetyDistance { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("showsDefaultActiveAspectSet", Order=7)]
            public tElementWithIDref showsDefaultActiveAspectSet {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Atomic dynamic information displayed by the signal. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.ActiveAspect))]
        [XmlIncludeAttribute(typeof(prorail.ActiveAspect))]     
        public  partial class ActiveAspect: sig.Aspect
        {
            [XmlElementAttribute("hasTimedDeactivation", Order=1)]
            public rtmCommon.Duration hasTimedDeactivation {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("isOfAspectDeactivationType", Order=2)]
            public AspectDeactivationTypes isOfAspectDeactivationType {get; set;} = new AspectDeactivationTypes();
                
             
        }  
    
        /** 
        A set of actively controlled signal aspects. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ActiveAspectSet: sig.SignalMessage
        {
            [XmlElementAttribute("isComposedOfActiveAspect", Order=1)]
            public List<tElementWithIDref> isComposedOfActiveAspect { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresSynchedFlashing", Order=2)]
            public tElementWithIDref requiresSynchedFlashing;
                
             
        }  
    
        /** 
        Aspects flash alternately, i.e. in counter-phase.
Note: RFI uses flashing in phase or counter-phase to distinguish signal messages. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AlternateFlash: sig.SynchedFlashing
        {
             
        }  
    
        /** 
        Atomic information displayed by the signal, conveyed by means of light, shape, text, symbol, form, colour.
de-DE: Signalbegriff 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ActiveAspect))]
        [XmlIncludeAttribute(typeof(sig.PassiveAspect))]     
        public  partial class Aspect: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTrainCategory", Order=1)]
            public List<tElementWithIDref> appliesToTrainCategory { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("aspectId", Order=2)]
            public String aspectId= "";
                
            [XmlElementAttribute("hasSymbol", Order=3)]
            public Symbol hasSymbol {get; set;} = new Symbol();
                
            [XmlElementAttribute("hasTextInformation", Order=4)]
            public TextInformation hasTextInformation {get; set;} = new TextInformation();
                
            [XmlElementAttribute("indicatesRouteDirection", Order=5)]
            public Boolean indicatesRouteDirection {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A set of active and/or passive aspects representing a message sent by a signal. 
Typically, the meaning of the message is defined in a rule book. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ProceedMessage))]
        [XmlIncludeAttribute(typeof(sig.StopMessage))]     
        public  partial class AspectSet: sig.SignalMessage
        {
            [XmlElementAttribute("isComposedOfActiveAspectSet", Order=1)]
            public tElementWithIDref isComposedOfActiveAspectSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isComposedOfPassiveAspect", Order=2)]
            public List<tElementWithIDref> isComposedOfPassiveAspect { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Aspects flash in phase.
Note: RFI uses flashing in phase or counter-phase to distinguish signal messages. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FlashInPhase: sig.SynchedFlashing
        {
             
        }  
    
        /** 
        Atomic static information displayed by the signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PassiveAspect: sig.Aspect
        {
             
        }  
    
        /** 
        Provides signal aspect degradation information that is associated with a given light signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalAspectDegradation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToActiveAspectSet", Order=1)]
            public tElementWithIDref appliesToActiveAspectSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToLightSignal", Order=2)]
            public tElementWithIDref appliesToLightSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesWhenAspectFails", Order=3)]
            public tElementWithIDref appliesWhenAspectFails {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("degradesToActiveAspectSet", Order=4)]
            public tElementWithIDref degradesToActiveAspectSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isMostRestrictive", Order=5)]
            public Boolean isMostRestrictive {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A message to the train driver represented by a set of active/passive signal aspects. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ActiveAspectSet))]
        [XmlIncludeAttribute(typeof(sig.AspectSet))]     
        public abstract partial class SignalMessage: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("semantic", Order=1)]
            public String semantic= "";
                
             
        }  
    
        /** 
        The EULYNX signal vector is defined by the SCI-LS cluster and conveys active aspect controls from the interlocking to the signal controller. It consists of 6 bytes of information (Eu.DK.254) mapped to integers.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalVector: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("basicAspectType", Order=1)]
            public Int32 basicAspectType {get; set;} = new Int32();
                
            [XmlElementAttribute("commandsActiveAspectSet", Order=2)]
            public tElementWithIDref commandsActiveAspectSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("directionIndicator", Order=3)]
            public Int32 directionIndicator {get; set;} = new Int32();
                
            [XmlElementAttribute("directionIndicatorAnnouncements", Order=4)]
            public Int32 directionIndicatorAnnouncements {get; set;} = new Int32();
                
            [XmlElementAttribute("extensionBasicAspectType", Order=5)]
            public Int32 extensionBasicAspectType {get; set;} = new Int32();
                
            [XmlElementAttribute("speedIndicator", Order=6)]
            public Int32 speedIndicator {get; set;} = new Int32();
                
            [XmlElementAttribute("speedIndicatorAnnouncement", Order=7)]
            public Int32 speedIndicatorAnnouncement {get; set;} = new Int32();
                
             
        }  
    
        /** 
        A symbol that sends a message to the driver. E.g. a fixed letter, an arrow, a letter or a number that can be switched on. 
The symbol is normalised in the signalling rules and regulations. If the text is not or less regulated, use the class TextInformation.
This is a display value and shouldn't be interpreted e.g. by simulation programs or speed profile designers.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.Symbol))]     
        public  partial class Symbol
        {
            [XmlElementAttribute("value", Order=1)]
            public String value= "";
                
             
        }  
    
        /** 
        Two light aspects that flash in synch. 
The frequency and phase difference of flashing are given by national rules.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.AlternateFlash))]
        [XmlIncludeAttribute(typeof(sig.FlashInPhase))]     
        public abstract partial class SynchedFlashing: sig.BaseObject
        {
            [XmlElementAttribute("appliesToAspect", Order=1)]
            public List<tElementWithIDref> appliesToAspect { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Text legend written on the signal frame. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TextInformation
        {
            [XmlElementAttribute("value", Order=1)]
            public String value= "";
                
             
        }  
    
        /** 
        A signal-message relation is composed of two pairs master(signal,message) and dependent(signal,message).
The message of the master signal dictates the message of the dependent signal. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalMessageRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRoute", Order=1)]
            public List<tElementWithIDref> appliesToRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("entrySpeed", Order=2)]
            public rtmCommon.Speed entrySpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("exitSpeed", Order=3)]
            public rtmCommon.Speed exitSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("hasDependentMessage", Order=4)]
            public tElementWithIDref hasDependentMessage {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasEndSectionTimer", Order=5)]
            public rtmCommon.Duration hasEndSectionTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasMasterMessage", Order=6)]
            public tElementWithIDref hasMasterMessage {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("representsSpeedProfile", Order=7)]
            public tElementWithIDref representsSpeedProfile {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        If a signal fails to show a given aspect, then another signal is forced to show another, typically more restrictive, aspect. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AspectProving
        {
            [XmlElementAttribute("bestAllowedAspect", Order=1)]
            public tElementWithIDref bestAllowedAspect {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("checksAspect", Order=2)]
            public tElementWithIDref checksAspect {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Signal is part of an autoworking route.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Automatic: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfAutomaticType", Order=2)]
            public AutomaticTypes isOfAutomaticType {get; set;} = new AutomaticTypes();
                
             
        }  
    
        /** 
        Applies to two signals and, if applicable, all designated tracks in between these signals.
When one of the two signals is opened, the other remains closed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BackToBackLocking
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public List<tElementWithIDref> appliesToSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("appliesToTrackDesignation", Order=2)]
            public List<tElementWithIDref> appliesToTrackDesignation { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isOfCategory", Order=3)]
            public RouteCategoryTypes isOfCategory {get; set;} = new RouteCategoryTypes();
                
             
        }  
    
        /** 
        The entry signal is associated either with
<ul>
 <li>a light signal informing train staff to prepare for imminent departure (de-DE: Fahrtank&#252;nder - wei&#223;es Dreieck)</li>
 <li>a counter indicating the remaining time to planned departure (ProRail)</li>
</ul>
<ul>
 <li>a system that messages the train staff mobile device (de-DE: dann entf&#228;llt der physische Fahrtank&#252;nder).</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DispatchAnnouncerAssignment: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToDispatchAnnouncer", Order=1)]
            public List<tElementWithIDref> appliesToDispatchAnnouncer { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("appliesToEntrySignal", Order=2)]
            public List<tElementWithIDref> appliesToEntrySignal { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        <u>Illumination </u>refers to signals or individual signal frames that are lit by an external light source. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Illumination: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToSignalFrame", Order=2)]
            public tElementWithIDref appliesToSignalFrame {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfIlluminationType", Order=3)]
            public IlluminationTypes isOfIlluminationType {get; set;} = new IlluminationTypes();
                
             
        }  
    
        /** 
        The line-side system can switch the light signal to intentionally dark when a cab signalling ATP system such as LZB or ETCS is leading. 
The signal lamps are intentionally turned off and the driver disregards the light signal.
This avoids conflict between line-side aspect and cab aspect in dual signalling environments.

Not to be used when a signal is switched to a special aspect (white lamp or white cross), indicating that the signal should be disregarded. The other signal lamps are dark but this is not meant by intentionally dark.

Notes about dark signals:
<ul>
 <li>A light signal that is dark because it has failed represents danger.</li>
 <li>In the UK, dark mode applies to LX warning light that switch to dark on purpose, e.g. a failed level crossing in the UK because a permanent warning light invites undesirable behaviour by motorists.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class IntentionallyDarkAllowed
        {
            [XmlElementAttribute("appliesToLightSignal", Order=1)]
            public tElementWithIDref appliesToLightSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Indicates whether the signal is equipped with a lens diffuser. 
It can be specialised and associated with a set of diffuser types. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.LensDiffuser))]
        [XmlIncludeAttribute(typeof(nr.LensDiffuser))]
        [XmlIncludeAttribute(typeof(rfi.LensDiffuser))]     
        public  partial class LensDiffuser
        {
            [XmlElementAttribute("appliesToLightSignal", Order=1)]
            public tElementWithIDref appliesToLightSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Indicates whether the signal allows manual release of the overlap. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ManualOverlapRelease: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Indicates whether the train may proceed beyond the signal with or without stopping. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NonStopMovement: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasCondition", Order=2)]
            public NonStopMovementAllowedTypes hasCondition {get; set;} = new NonStopMovementAllowedTypes();
                
             
        }  
    
        /** 
        Applies to a signal whose direction is opposite to the normal direction of traffic, that is a signal applying to trains travelling on the opposite track.

Applies to double track lines only.
Not to be confused with the topological direction of the linear element, which is not related to the direction of traffic. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OppositeTrackSignal: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.SignalAlignmentPointDescription))]
        [XmlIncludeAttribute(typeof(sig.SignalAlignmentPointOnTrack))]     
        public abstract partial class SignalAlignment: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToLightSignal", Order=1)]
            public tElementWithIDref appliesToLightSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToSignalFrame", Order=2)]
            public tElementWithIDref appliesToSignalFrame {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Description of the alignment point, i.e. the spot that is targeted when orienting the signal head. 
Can be used in exceptional cases such as tight curves to describe a target that is situated off- track, for instance "line-side radio mast".

NR normally targets the signal's  AWS magnet and alternatively a given distance from the signal, or a spot on the track at a given distance from the signal. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalAlignmentPointDescription: sig.SignalAlignment
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
             
        }  
    
        /** 
        The signal must be aligned such that the driver can see it. This class describes the position (upstream on the track) of the target of the signal: distance, and optionally height.
This information is typically checked during the installation and testing phases. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(rfi.SignalAlignment))]     
        public  partial class SignalAlignmentPointOnTrack: sig.SignalAlignment
        {
            [XmlElementAttribute("distance", Order=1)]
            public rtmCommon.Length distance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("height", Order=2)]
            public rtmCommon.Length height {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Operational function of the signal, e.g. entry or exit signal, block signal, bridge warning signal. These functions are nationally defined and can be described in the national domains (outside the common EULYNX DP scope).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.SignalFunction))]     
        public  partial class SignalFunction: sig.BaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=2)]
            public String value= "";
                
             
        }  
    
        /** 
        Telephone for communication between train driver and signaller. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.SignalPostTelephone))]     
        public  partial class SignalPostTelephone: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public List<tElementWithIDref> appliesToSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("position", Order=3)]
            public String position= "";
                
            [XmlElementAttribute("telephoneType", Order=4)]
            public String telephoneType= "";
                
             
        }  
    
        /** 
        Reading distance defined following national rules. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.SignalSightingDistance))]     
        public  partial class SignalSightingDistance: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasAvailableDistance", Order=2)]
            public rtmCommon.Length hasAvailableDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasMinimumDistance", Order=3)]
            public rtmCommon.Length hasMinimumDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasPreferredDistance", Order=4)]
            public rtmCommon.Length hasPreferredDistance {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Signals are placed at regulated positions. In exceptional circumstances, the signal is placed differently which may require additional documentation, eg. a 3D BIM model, and dispensation.
This common EULYNX DP class can therefore be tailored to national needs. For instance:
<ul>
 <li>Germany: two double-track arrangements would lead to confusing situations so the signals can be placed at the other side of the track. A checkered sign points out this fact to the driver.</li>
</ul>
<ul>
 <li>France: signals in Alsace - Lorraine region are placed on the other side as in other French regions. </li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.SpecialPositionArrangement))]     
        public abstract partial class SpecialPositionArrangement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Indicates that a signal from a terminal track can be cleared even when the section in advance of that signal is occupied.
de-DE: Besetzte Ausfahrt 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class StandOutControl: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Signal placed in tunnels, typically used to indicate special fixing requirements and/or light intensity.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TunnelSignal: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToLightSignal", Order=1)]
            public tElementWithIDref appliesToLightSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The signalplan describes a set of aspect relations between subsequent signals. This expresses a relation such as: 
signal Y shows red, then the upstream signal Y shows yellow. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Signalplan
        {
            [XmlElementAttribute("aspectRelation", Order=1)]
            public List<SignalMessageRelation> aspectRelation { get; set; } = new List<SignalMessageRelation>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class HorizontalOffsetOfReferencePoint: sig.OffsetOfReferencePoint
        {
             
        }  
    
        /** 
        To support track workers in locating the asset, the local datum combines a reference point easily identified in the field, and a distance and direction to the asset.
Not for computing the position of the asset.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocalDatumReference: sig.BaseObject
        {
            [XmlElementAttribute("direction", Order=1)]
            public String direction= "";
                
            [XmlElementAttribute("longitudinalMeasure", Order=2)]
            public Double longitudinalMeasure {get; set;} = new Double();
                
            [XmlElementAttribute("refersToLocalDatum", Order=3)]
            public tElementWithIDref refersToLocalDatum;
                
             
        }  
    
        /** 
        Description of the location where maintenance personnel can gain access to the track asset. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NearestAccessPoint: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
            [XmlElementAttribute("isRelatedToTrackAsset", Order=2)]
            public tElementWithIDref isRelatedToTrackAsset;
                
             
        }  
    
        /** 
        A signal frame has a reference point that is nationally defined:
<ul>
 <li>a lamp, typically the red lamp, or</li>
 <li>the centre of a set of lamps, or</li>
 <li>the edge of a frame nearest to train gauge.</li>
</ul>
This reference point has:
<ul>
 <li>a spot location.</li>
 <li>an horizontal offset, e.g. 1,8 metres from the nearest rail.</li>
 <li>a vertical offset, e.g. 3,6 metres above the top of the highest rail.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.HorizontalOffsetOfReferencePoint))]
        [XmlIncludeAttribute(typeof(sig.VerticalOffsetOfReferencePoint))]     
        public  partial class OffsetOfReferencePoint
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=2)]
            public rtmCommon.Length value {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Description of the area where the signal is located, to help maintenance workers to find the signal in the field.
Can be an informal description (e.g. near junction x) or depend on national regulations (e.g. DE Bezeichnung nach Ril 100).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalLocation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class VerticalOffsetOfReferencePoint: sig.OffsetOfReferencePoint
        {
             
        }  
    
        /** 
        A boolean equation.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.StdCondition))]     
        public  partial class Condition: sig.BaseObject
        {
            [XmlElementAttribute("assetAndState", Order=1)]
            public List<tElementWithIDref> assetAndState { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("condition", Order=2)]
            public tElementWithIDref condition {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("description", Order=3)]
            public String description= "";
                
            [XmlElementAttribute("op", Order=4)]
            public MathematicalOperators op {get; set;} = new MathematicalOperators();
                
             
        }  
    
        /** 
        A pair (movable element, position).  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MovableSystemElementAndPosition))]
        [XmlIncludeAttribute(typeof(sig.CrossingElementAndPosition))]
        [XmlIncludeAttribute(typeof(sig.DerailerElementAndPosition))]
        [XmlIncludeAttribute(typeof(sig.PointElementAndPosition))]     
        public  partial class MovableElementAndPosition: sig.AssetAndState
        {
            [XmlElementAttribute("normal", Order=1)]
            public Boolean normal {get; set;} = new Boolean();
                
            [XmlElementAttribute("preferred", Order=2)]
            public Boolean preferred {get; set;} = new Boolean();
                
            [XmlElementAttribute("refersToMovableElement", Order=3)]
            public tElementWithIDref refersToMovableElement {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Generic construction to describe the state of the elements of uncommon movable systems like movable bridges, railway barriers, movable catenaries and movable buffer stops. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MovableSystemElementAndPosition: sig.MovableElementAndPosition
        {
            [XmlElementAttribute("inState", Order=1)]
            public MovableElementPassableTypes inState {get; set;} = new MovableElementPassableTypes();
                
             
        }  
    
        /** 
        A condition in a State Transition Diagram is a boolean condition that triggers a transition from start-state to target-state. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class StdCondition: sig.Condition
        {
            [XmlElementAttribute("gotoTargetState", Order=1)]
            public List<tElementWithIDref> gotoTargetState { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasStartState", Order=2)]
            public tElementWithIDref hasStartState {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A set of (asset,state) pairs that describes the state of the signalling system.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SystemState: sig.BaseObject
        {
            [XmlElementAttribute("definedByAssetAndState", Order=1)]
            public List<tElementWithIDref> definedByAssetAndState { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The interlocking puts and proves assets in a given state for securing routes. 
The AssetAndState class is a generic pair of (asset, state). It inherits an identifier from BaseObject that other classes can refer to. 
This base class is abstract and must be specialised. The specialisation contains a reference to a track asset (signal, section, point, etc.) plus the given status of that asset. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MovableElementAndPosition))]
        [XmlIncludeAttribute(typeof(sig.CompoundLogicalObjectAndState))]
        [XmlIncludeAttribute(typeof(sig.LxAndState))]
        [XmlIncludeAttribute(typeof(sig.SectionAndVacancy))]
        [XmlIncludeAttribute(typeof(sig.SignalAndMessage))]     
        public abstract partial class AssetAndState: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("proving", Order=1)]
            public ProvingTypes proving {get; set;} = new ProvingTypes();
                
             
        }  
    
        /** 
        A pair (Compound Logical Object, boolean). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CompoundLogicalObjectAndState: sig.AssetAndState
        {
            [XmlElementAttribute("HighOrLow", Order=1)]
            public Boolean HighOrLow {get; set;} = new Boolean();
                
            [XmlElementAttribute("refersToCompoundLogicalObject", Order=2)]
            public tElementWithIDref refersToCompoundLogicalObject {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A pair (movable crossing, state). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CrossingElementAndPosition: sig.MovableElementAndPosition
        {
            [XmlElementAttribute("inPosition", Order=1)]
            public LeftRight inPosition {get; set;} = new LeftRight();
                
             
        }  
    
        /** 
        A pair (derailer element, position).

The derailer element is the movable part of a derailer and no model class strictly speaking.

Used for expressing concepts like: the derailer has to be in the non-derailing position. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DerailerElementAndPosition: sig.MovableElementAndPosition
        {
            [XmlElementAttribute("inPosition", Order=1)]
            public DerailingPositionTypes inPosition {get; set;} = new DerailingPositionTypes();
                
             
        }  
    
        /** 
        A pair (level crossing<i><sub>i</sub></i>, state<i><sub>j</sub></i>) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LxAndState: sig.AssetAndState
        {
            [XmlElementAttribute("inState", Order=1)]
            public LxStateTypes inState {get; set;} = new LxStateTypes();
                
            [XmlElementAttribute("refersToLx", Order=2)]
            public tElementWithIDref refersToLx {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A pair (section, vacancy).
Expresses whether a train detection section is vacant or occupied. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SectionAndVacancy: sig.AssetAndState
        {
            [XmlElementAttribute("inVacancyState", Order=1)]
            public SectionVacancyTypes inVacancyState {get; set;} = new SectionVacancyTypes();
                
            [XmlElementAttribute("refersToTdsSection", Order=2)]
            public tElementWithIDref refersToTdsSection {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A pair (signal, message). 
When instantiated, this provides a list of all possible (signal, message) pairs needed for constructing <u>signal plans</u>. Pairs that are not in the list are disallowed.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalAndMessage: sig.AssetAndState
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("showsMessage", Order=2)]
            public tElementWithIDref showsMessage;
                
             
        }  
    
        /** 
        A pair (point element, position).

The point element is the movable part of a point and no model class strictly speaking.

The positions that a point can adopt are left or right. Three-way points are rare and modelled as two consecutive points.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointElementAndPosition: sig.MovableElementAndPosition
        {
            [XmlElementAttribute("inPosition", Order=1)]
            public LeftRight inPosition {get; set;} = new LeftRight();
                
             
        }  
    
        /** 
        A larger building, not necessarily purpose-built for signalling, that can house cabinets or equipment rooms
<ul>
 <li>NR: a signal box maps to a building.</li>
</ul>
<ul>
 <li>de-DE: Geb&#228;ude, z.B. Bahnhofsgeb&#228;ude.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EquipmentHouse))]     
        public  partial class Building: sig.Housing
        {
             
        }  
    
        /** 
        A casing for active electronic components and wiring. Size can vary from cupboard to shoebox size.
Indoor cabinets are typically housed within a container or a building. Outdoor cabinets are mounted on a post or on the ground.
As opposed to an equipment room, a person cannot enter into a cabinet.
<ul>
 <li>en-UK: (location) cabinet or case</li>
 <li>fr-FR: armoire &#233;lectrique</li>
 <li>nl-NL: schakelkast</li>
 <li>de-DE: Schaltkasten/-schrank</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CabinetGroup))]
        [XmlIncludeAttribute(typeof(sig.LeuCabinet))]
        [XmlIncludeAttribute(typeof(db.DriveCabinet))]
        [XmlIncludeAttribute(typeof(prorail.AtbvvConnectionCabinet))]     
        public  partial class Cabinet: sig.Housing
        {
            [XmlElementAttribute("hasOperatorPosition", Order=1)]
            public OperatorPosition hasOperatorPosition {get; set;} = new OperatorPosition();
                
            [XmlElementAttribute("type", Order=2)]
            public String type= "";
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CabinetGroup: sig.Cabinet
        {
            [XmlElementAttribute("numberOfCabinets", Order=1)]
            public Int32 numberOfCabinets {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Civil engineering object known in a (external) data base, e.g. an asset management system for bridges, tunnels and other rail infrastructure.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CivilStructure: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        A large shippable box. Typically prefabricated and wired in a factory and shipped to site. 
de-DE: Modulgeb&#228;ude 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Container: sig.Housing
        {
             
        }  
    
        /** 
        Room in a building housing operational control and command equipment.

DE: Leitstelle
NL: VL-ruimte
FR: Poste de controle 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ControlRoom: sig.EquipmentRoom
        {
             
        }  
    
        /** 
        A purpose-built trackside building housing signalling equipment.
de-DE: Schalthaus
nl-NL: relaishuis 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EquipmentHouse: sig.Building
        {
             
        }  
    
        /** 
        Room inside a building or a purpose-built trackside housing. 
<ul>
 <li>nl-NL: relaisruimte of relaishuis</li>
</ul>
<ul>
 <li>fr-FR: salle d'appareillage</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ControlRoom))]     
        public  partial class EquipmentRoom: sig.Housing
        {
             
        }  
    
        /** 
        Generalization of fixings and housings, defined as civil structures that can support (or house) signalling equipment.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.Fixing))]
        [XmlIncludeAttribute(typeof(sig.Housing))]     
        public  partial class EquipmentSupport: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isCivilStructure", Order=1)]
            public List<tElementWithIDref> isCivilStructure { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public List<tElementWithIDref> isLocatedAt { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("supports", Order=3)]
            public List<tElementWithIDref> supports { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Generic term for a line-side structure that supports signalling equipment or another fixing. For instance:
- Fixing Post supports frame Sign.
- Fixing Foundation supports fixing Post.
- Fixing Rail supports fixing Cantilever. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.OverheadLineMast))]     
        public  partial class Fixing: sig.EquipmentSupport
        {
            [XmlElementAttribute("isOfFixingType", Order=1)]
            public FixingTypes isOfFixingType {get; set;} = new FixingTypes();
                
            [XmlElementAttribute("refersToReferenceDrawing", Order=2)]
            public List<tElementWithIDref> refersToReferenceDrawing { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToReferenceDrawingForMarkerBoard", Order=3)]
            public tElementWithIDref refersToReferenceDrawingForMarkerBoard {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("supportsSignalFrame", Order=4)]
            public List<tElementWithIDref> supportsSignalFrame { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Describes the housing, ranging from a control centre building to a keybox mounted on a trackside post. 
Can be used if the type of housing is (yet) unknown, e.g. during an early design phase. Can also be used if the type of housing does not fit any of the available subtypes.
<ul>
 <li>de-DE: Unterbringung</li>
 <li>fr-FR: logement</li>
 <li>nl-NL: behuizing</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DataCentre))]
        [XmlIncludeAttribute(typeof(sig.Building))]
        [XmlIncludeAttribute(typeof(sig.Cabinet))]
        [XmlIncludeAttribute(typeof(sig.Container))]
        [XmlIncludeAttribute(typeof(sig.EquipmentRoom))]
        [XmlIncludeAttribute(typeof(sig.Panel))]
        [XmlIncludeAttribute(typeof(db.NoHousing))]     
        public  partial class Housing: sig.EquipmentSupport
        {
            [XmlElementAttribute("isSupportedByFixingType", Order=1)]
            public List<FixingTypes> isSupportedByFixingType { get; set; } = new List<FixingTypes>(); 
                
            [XmlElementAttribute("positionDescription", Order=2)]
            public String positionDescription= "";
                
             
        }  
    
        /** 
        A panel to which switching equipment such as key release instruments or other control equipment can be affixed.
May be mounted indoors. When outdoors, it is typically fixed to a post and covered by a simple roof. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Panel: sig.Housing
        {
             
        }  
    
        /** 
        Access is only possible by special procedure, similar to shunting.
de-DE: gesperrt 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BlockedTrack: sig.RestrictedArea
        {
             
        }  
    
        /** 
        A device to prevent railway vehicles from going past the end of a physical section of track. 
<ul>
 <li>de-DE: Prellbock</li>
 <li>fr-FR: heurtoir</li>
 <li>nl-NL: stootjuk</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BufferStop: sig.VehicleStop
        {
            [XmlElementAttribute("isOfBufferStopType", Order=1)]
            public BufferStopTypes isOfBufferStopType {get; set;} = new BufferStopTypes();
                
             
        }  
    
        /** 
        A physical section of conductor rail that is placed to the left, right or centre.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConductorRail: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isPartOf", Order=2)]
            public tElementWithIDref isPartOf {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isPlacedAt", Order=3)]
            public List<LeftRightCentreTypes> isPlacedAt { get; set; } = new List<LeftRightCentreTypes>(); 
                
             
        }  
    
        /** 
        A gap in the conductor rail traction.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConductorRailGap: sig.ElectrificationGap
        {
             
        }  
    
        /** 
        A section of the track equipped with conductor rail, often referred to as third rail. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConductorRailSection: sig.ElectrificationSection
        {
            [XmlElementAttribute("isOfConductorVoltageType", Order=1)]
            public List<ConductorVoltageTypes> isOfConductorVoltageType { get; set; } = new List<ConductorVoltageTypes>(); 
                
             
        }  
    
        /** 
        Track area under construction.
de-DE: Baugleis
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConstructionArea: sig.RestrictedArea
        {
             
        }  
    
        /** 
        Trackway that is equipped with derailment containment device. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DerailmentContainment: sig.Trackway
        {
            [XmlElementAttribute("isMadeOfMaterial", Order=1)]
            public MaterialTypes isMadeOfMaterial {get; set;} = new MaterialTypes();
                
            [XmlElementAttribute("isMountedOnSide", Order=2)]
            public DerailmentContainmentLocationTypes isMountedOnSide {get; set;} = new DerailmentContainmentLocationTypes();
                
             
        }  
    
        /** 
        Gap in the traction system where no traction power can ever be drawn.
UK: neutral section in overhead line systems, gap in third rail systems.
DE: Trennstelle
NL: spanningsloze sectie
FR: section de s&#233;paration 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ConductorRailGap))]
        [XmlIncludeAttribute(typeof(sig.OverheadLineGap))]     
        public  partial class ElectrificationGap: sig.ElectrificationSegment
        {
             
        }  
    
        /** 
        Section where overhead lines overlap. When a train stops in the overlap, chances are that current runs through and damages the pantograph. Trains should therefore not stop here. 
fr-FR: sectionnement critique
nl-NL: open spaninrichting. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ElectrificationOverlap: sig.ElectrificationSegment
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
             
        }  
    
        /** 
        Elementary section allowing electric train traction to be switched on or off
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ConductorRailSection))]
        [XmlIncludeAttribute(typeof(sig.OverheadLineSection))]     
        public  partial class ElectrificationSection: sig.ElectrificationSegment
        {
             
        }  
    
        /** 
        Electrification segment with information relevant to signalling. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ElectrificationGap))]
        [XmlIncludeAttribute(typeof(sig.ElectrificationOverlap))]
        [XmlIncludeAttribute(typeof(sig.ElectrificationSection))]     
        public abstract partial class ElectrificationSegment: sig.TrackProperty
        {
             
        }  
    
        /** 
        A rail component designed to absorb lengthening or shortening of rail, for instance thermal expansion. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ExpansionJoint: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedOnRail", Order=2)]
            public List<LeftRight> isLocatedOnRail { get; set; } = new List<LeftRight>(); 
                
             
        }  
    
        /** 
        Spot where the infrastructure managers assets end. The working direction points towards the IM territory. Beyond is uncharted territories. Hic Leones Sunt. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class InfrastructureBorder: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Main track in a station under control of an interlocking <i>as opposed to </i>open line.
de-DE: Hauptgleis
en-GB: Passengerline, thick line on drawing
nl-NL: hoofdspoor in CBG
fr-FR: voie principale en gare 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.ThroughTrack))]     
        public  partial class MainTrack: sig.TrackType
        {
             
        }  
    
        /** 
        Section of track on open line, i.e. not controlled by an interlocking. 
de-DE: Streckengleis
nl-NL: vrije baan
fr-FR: pleine voie hors poste (non applicable en France) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OpenLineTrack: sig.TrackType
        {
             
        }  
    
        /** 
        A gap in the overhead traction. The wired attribute indicates whether or not a (neutral) line is present.

A bascule bridge would typically have a gap with open wire and no type.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OverheadLineGap: sig.ElectrificationGap
        {
            [XmlElementAttribute("isOfOverheadLineGapType", Order=1)]
            public OverheadLineGapTypes isOfOverheadLineGapType {get; set;} = new OverheadLineGapTypes();
                
            [XmlElementAttribute("wired", Order=2)]
            public Boolean wired {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A section of the track where traction power is provided by an overhead line. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OverheadLineSection: sig.ElectrificationSection
        {
            [XmlElementAttribute("isOfTractionVoltageType", Order=1)]
            public List<TractionVoltageTypes> isOfTractionVoltageType { get; set; } = new List<TractionVoltageTypes>(); 
                
             
        }  
    
        /** 
        Area removed or earmarked for removal. At some stage during the construction process the track is physically removed but the (topological) information about the area is retained so that it can still be shown in the diagrams or  restored at a later stage, e.g. after track bed renewal.
de-DE: ausgebaut
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RemovedTrack: sig.RestrictedArea
        {
             
        }  
    
        /** 
        Track area not usable for normal operation <i>over longer periods</i>. Construction activities are planned or taking place. The process and the time frames when activities take place are separated from the area.
en-GB: Track area under possession
en-GB: SDEF blue area during a given time frame 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BlockedTrack))]
        [XmlIncludeAttribute(typeof(sig.ConstructionArea))]
        [XmlIncludeAttribute(typeof(sig.RemovedTrack))]     
        public  partial class RestrictedArea: sig.TrackProperty
        {
             
        }  
    
        /** 
        A sand hump, drag or other pile of sand designed to stop an overrunning vehicle.
Do not use the attribute isOfVehicleStopType when using sand hump. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SandHump: sig.VehicleStop
        {
            [XmlElementAttribute("hasLength", Order=1)]
            public rtmCommon.Length hasLength {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        en-UK: freight, shows as dotted line in operations drawing
de-DE: Nebengleis
nl-NL: Opstelspoor - gebruik SidingSection
fr-FR: voie de service - utilisez SidingSection 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SecondaryTrack: sig.TrackType
        {
             
        }  
    
        /** 
        de-DE: not used as a special track type
nl-NL: rangeerterrein Kijfhoek
fr-FR: gare de triage
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ShuntingTrack: sig.TrackType
        {
             
        }  
    
        /** 
        Track not considered part of the main infrastructure
de-DE: Anschlussgleis, Werksgleis
en-GB: used for shunting
nl-NL: raccordement, opstelspoor
fr-FR: voie de service 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SidingTrack: sig.TrackType
        {
             
        }  
    
        /** 
        Concrete, ballastless track bed.
DE: feste Fahrbahn 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SlabTrack: sig.Trackway
        {
            [XmlElementAttribute("isFloating", Order=1)]
            public Boolean isFloating {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Track with sleepers resting on ballast. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SleeperTrack: sig.Trackway
        {
            [XmlElementAttribute("hasSleepersMadeOf", Order=1)]
            public MaterialTypes hasSleepersMadeOf {get; set;} = new MaterialTypes();
                
             
        }  
    
        /** 
        Area(s) where a non-standard gauge applies. Standard gauges can be found in the national domain or indicated by reference drawings. 
Structure gauge is the envelope.
Track gauge is the distance between the rails.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.SpecialStructureGauge))]
        [XmlIncludeAttribute(typeof(sig.SpecialTrackGauge))]
        [XmlIncludeAttribute(typeof(db.SpecialGauge))]     
        public abstract partial class SpecialGauge: sig.TrackProperty
        {
             
        }  
    
        /** 
        The structure gauge is the outline within which there are no obstacles.
de-DE: Lichtraumprofil
nl-NL: profiel van vrije ruimte. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SpecialStructureGauge: sig.SpecialGauge
        {
            [XmlElementAttribute("gaugeName", Order=1)]
            public String gaugeName= "";
                
            [XmlElementAttribute("hasReferenceDrawing", Order=2)]
            public List<tElementWithIDref> hasReferenceDrawing { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Area with non-standard gauge, i.e. other than 1435 mm. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SpecialTrackGauge: sig.SpecialGauge
        {
            [XmlElementAttribute("hasValue", Order=1)]
            public List<rtmCommon.Length> hasValue { get; set; } = new List<rtmCommon.Length>(); 
                
             
        }  
    
        /** 
        Name of the section that the signaller can refer to for operational purpose (e.g. track 1/2) or a name that appears on signalling plans.
Use the Designation class inherited from the Configured Base Object to set the name.
en-GB: line name
de-DE: Gleisbezeichner
nl-NL: spoornaam
fr-FR: nom de la ligne 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrackDesignation: sig.TrackProperty
        {
             
        }  
    
        /** 
        Abstract super class for areas of track with particular properties. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ElectrificationSegment))]
        [XmlIncludeAttribute(typeof(sig.RestrictedArea))]
        [XmlIncludeAttribute(typeof(sig.SpecialGauge))]
        [XmlIncludeAttribute(typeof(sig.TrackDesignation))]
        [XmlIncludeAttribute(typeof(sig.TrackType))]
        [XmlIncludeAttribute(typeof(sig.Trackway))]     
        public abstract partial class TrackProperty: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public List<tElementWithIDref> isLocatedAt { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Operational classification that applies to track.
In case no suitable specialisation of this class is available, instantiate a TrackType with an appropriate Annotation or Description inherited from the Configured Base Object and that describes the needed type. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MainTrack))]
        [XmlIncludeAttribute(typeof(sig.OpenLineTrack))]
        [XmlIncludeAttribute(typeof(sig.SecondaryTrack))]
        [XmlIncludeAttribute(typeof(sig.ShuntingTrack))]
        [XmlIncludeAttribute(typeof(sig.SidingTrack))]     
        public  partial class TrackType: sig.TrackProperty
        {
             
        }  
    
        /** 
        Type of track, given if relevant for mounting signalling equipment. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DerailmentContainment))]
        [XmlIncludeAttribute(typeof(sig.SlabTrack))]
        [XmlIncludeAttribute(typeof(sig.SleeperTrack))]     
        public  partial class Trackway: sig.TrackProperty
        {
             
        }  
    
        /** 
        Installation for physically stopping trains. The track may continue beyond the device.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BufferStop))]
        [XmlIncludeAttribute(typeof(sig.SandHump))]     
        public  partial class VehicleStop: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isOfVehicleStopType", Order=1)]
            public VehicleStopTypes isOfVehicleStopType {get; set;} = new VehicleStopTypes();
                
            [XmlElementAttribute("refersToRsmVehicleStop", Order=2)]
            public tElementWithIDref refersToRsmVehicleStop {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("stopsVehicleAtLocation", Order=3)]
            public tElementWithIDref stopsVehicleAtLocation {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Indicates the project phase during which the configuration item is defined. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ProjectPhase
        {
            [XmlElementAttribute("isOfProjectPhase", Order=1)]
            public ProjectPhaseTypes isOfProjectPhase {get; set;} = new ProjectPhaseTypes();
                
             
        }  
    
        /** 
        Store for properties and configuration items that were determined during design, engineering or production. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BlockElementConfiguration))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingConfiguration))]
        [XmlIncludeAttribute(typeof(sig.MovableComponentConfiguration))]
        [XmlIncludeAttribute(typeof(sig.MovableElementAsBuiltConfiguration))]
        [XmlIncludeAttribute(typeof(sig.MovableElementConfiguration))]
        [XmlIncludeAttribute(typeof(sig.TdsComponentConfiguration))]
        [XmlIncludeAttribute(typeof(sig.TdsSectionAsBuiltConfiguration))]
        [XmlIncludeAttribute(typeof(sig.TdsSectionConfiguration))]
        [XmlIncludeAttribute(typeof(sig.TvpSectionConfiguration))]     
        public  partial class TrackAssetConfiguration: sig.BaseObject
        {
            [XmlElementAttribute("phaseOfDefinition", Order=1)]
            public List<ProjectPhase> phaseOfDefinition { get; set; } = new List<ProjectPhase>(); 
                
             
        }  
    
        /** 
        de-DE: Tonfrequenz-Gleisstromkreis
nl-NL:  toonfrequente spoorstroomloop  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FtgsTrackCircuit))]     
        public  partial class AudioFrequencyTrackCircuit: sig.TrackCircuitSection
        {
            [XmlElementAttribute("channel", Order=1)]
            public String channel= "";
                
             
        }  
    
        /** 
        The sender plus receiver of an individual axle counter head mounted on or very near the rail.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AxleCountingHead: sig.TdsComponent
        {
            [XmlElementAttribute("railType", Order=1)]
            public String railType= "";
                
            [XmlElementAttribute("separatePowerAndData", Order=2)]
            public Boolean separatePowerAndData {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        An Axle counting system detects rolling stock in a logical section by counting incoming and outgoing wheels. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AxleCountingSection: sig.TdsSection
        {
             
        }  
    
        /** 
        A cable needed for the correct functioning of train detection and traction current return.
Bonds connect pieces of track and are designed to (dis)allow:
<ul>
 <li>traction return current</li>
 <li>train detection signal</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ImpedanceBond))]     
        public  partial class Bond: sig.TcConnector
        {
            [XmlElementAttribute("connectsToBond", Order=1)]
            public List<tElementWithIDref> connectsToBond { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isOfTcBondType", Order=2)]
            public TcBondTypes isOfTcBondType {get; set;} = new TcBondTypes();
                
             
        }  
    
        /** 
        A friction buffer stop can be equipped with a sensor that detects when an impact has shifted the buffer. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BufferSensor: sig.VehicleSensor
        {
            [XmlElementAttribute("monitorsBufferStop", Order=1)]
            public tElementWithIDref monitorsBufferStop {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        DC voltage track circuit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DcVoltageTrackCircuit: sig.TrackCircuitSection
        {
             
        }  
    
        /** 
        A mechanical bar that is depressed by a passing train wheel. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DepressionBar: sig.VehicleSensor
        {
             
        }  
    
        /** 
        Limit of a audio frequency section.
The rail isn't cut.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ElectricJoint: sig.TdsComponent
        {
             
        }  
    
        /** 
        Electromagnetic train sensor. 
A sensor with two heads can also detect the direction of a passing train.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EMSensor: sig.VehicleSensor
        {
            [XmlElementAttribute("numberOfHeads", Order=1)]
            public Int32 numberOfHeads {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Ferngespeister codierter Tonfrequenz-Gleisstromkreis von Siemens (FTG S) audio frequency track section technology. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FtgsTrackCircuit: sig.AudioFrequencyTrackCircuit
        {
             
        }  
    
        /** 
        Properties that apply to the FTG S track circuit.
Cut section length E1, E2, E3 are given only if there are at least 2,3 or 4 cut sections.
de-DE: Elektrische Laenge des Teilabschnitts E<i><sub>n</sub></i>.
Ermittlung entsprechend Anwendungsrichtlinie. Angabe des Attributs erfolgt nur, wenn mindestens 2,3 oder 4 Teillaengen existieren, sonst ist die Angabe des Attributs FMA Laenge hinreichend).

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FtgsTrackCircuitProperties: sig.TrackCircuitProperties
        {
            [XmlElementAttribute("hasLengthE", Order=1)]
            public List<rtmCommon.Length> hasLengthE { get; set; } = new List<rtmCommon.Length>(); 
                
            [XmlElementAttribute("hasLengthS", Order=2)]
            public rtmCommon.Length hasLengthS {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        High Voltage Impulse track circuit.
fr-FR: Impulsion de tension &#233;lev&#233;e (ITE)
nl-NL: prikspanningsspoorstroomloop. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class HviTrackCircuit: sig.TrackCircuitSection
        {
            [XmlElementAttribute("channel", Order=1)]
            public String channel= "";
                
             
        }  
    
        /** 
        A choke (coil) that filters certain frequencies. This separates TC signals from traction currents.
<ul>
 <li>de-DE: Drosselspule</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ImpedanceBond: sig.Bond
        {
            [XmlElementAttribute("internalFilterTuning", Order=1)]
            public Boolean internalFilterTuning {get; set;} = new Boolean();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Electric (galvanic) separation joint. The rail is cut.
These joints can be situated at the extremity of a track circuit. 
They are also used <i>inside </i>TDS sections, where they do not limit a track circuit. For instance point sections where track return current needs a change of the earth rail.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class InsulatedRailJoint: sig.TdsComponent
        {
            [XmlElementAttribute("singleRail", Order=1)]
            public Boolean singleRail {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A loop that senses train passage.
NR puts the spot location of the loop in the centre. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Loop: sig.VehicleSensor
        {
            [XmlElementAttribute("singleDoubleTriple", Order=1)]
            public Int32 singleDoubleTriple {get; set;} = new Int32();
                
             
        }  
    
        /** 
        de-DE: Niedrigfrequenzgleiskreis
nl-NL:  laagfrequent spoorstroomloop 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LowFrequencyTrackCircuit: sig.TrackCircuitSection
        {
             
        }  
    
        /** 
        Low frequency track circuit properties. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LowFrequencyTrackCircuitProperties: sig.TrackCircuitProperties
        {
            [XmlElementAttribute("hasInfluencedLength", Order=1)]
            public rtmCommon.Length hasInfluencedLength {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        A connector used by track circuits. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.Bond))]
        [XmlIncludeAttribute(typeof(sig.TcFeedingReceivingCable))]     
        public abstract partial class TcConnector: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("cableType", Order=1)]
            public String cableType= "";
                
            [XmlElementAttribute("connectsToRail", Order=2)]
            public List<LeftRight> connectsToRail { get; set; } = new List<LeftRight>(); 
                
            [XmlElementAttribute("isConnectedToRailAt", Order=3)]
            public tElementWithIDref isConnectedToRailAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("numberOfStrands", Order=4)]
            public Int32 numberOfStrands {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Track side devices for feeding AC signals into and receiving the same from track circuits. 
A feeder and receiver can share a spot location. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TcFeederReceiverElement: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("connectsToRailVia", Order=1)]
            public tElementWithIDref connectsToRailVia {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfFeederReceiverType", Order=3)]
            public List<TcFeederReceiverTypes> isOfFeederReceiverType { get; set; } = new List<TcFeederReceiverTypes>(); 
                
             
        }  
    
        /** 
        A cable that feeds signals into or receives signals from the track circuit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TcFeedingReceivingCable: sig.TcConnector
        {
            [XmlElementAttribute("bondsTrackCircuit", Order=1)]
            public tElementWithIDref bondsTrackCircuit {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("feeding", Order=2)]
            public Boolean feeding {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A very short track circuit that is exclusively used for detecting train passage.
Typically used where axle counters are deployed or in the absence of other train detection.
DE: isolierte Schiene 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TcSensorCombined))]     
        public  partial class TcSensor: sig.VehicleSensor
        {
             
        }  
    
        /** 
        Track circuit that is both used for vacancy detection and train approach detection.
de-DE: isolierte Schiene, FMA mitbenutzt. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TcSensorCombined: sig.TcSensor
        {
             
        }  
    
        /** 
        Line-side component of a train detection installation, typically a rail joint or axle counter head. 
It is located at a spot location at one TVP boundary, i.e. the spot up to where the train detection can safely detect train vacancy. The TVP section extremities must coincide exactly with these spot locations. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.AxleCountingHead))]
        [XmlIncludeAttribute(typeof(sig.ElectricJoint))]
        [XmlIncludeAttribute(typeof(sig.InsulatedRailJoint))]
        [XmlIncludeAttribute(typeof(prorail.VssLimit))]     
        public  partial class TdsComponent: sig.VehiclePassageDetector
        {
            [XmlElementAttribute("limitsTdsSection", Order=1)]
            public List<tElementWithIDref> limitsTdsSection { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A set of properties that applies to a TDS component. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TdsComponentConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToTdsComponent", Order=1)]
            public tElementWithIDref appliesToTdsComponent {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("canBeActivated", Order=2)]
            public Boolean canBeActivated {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        A set of TDS sections for which the occupancy status can be overridden (a degraded mode operational procedure).
The override procedure allows the signaller to open a signal that is closed because the TDS section reports (presumably false) occupied.
fr-FR: autorisation d'annulation de transit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TdsOccupancyOverrideGroup: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTdsSectionOverridable", Order=1)]
            public List<tElementWithIDref> appliesToTdsSectionOverridable { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The logical section detected by a Train Detection System and that is associated with a TVP section. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.AxleCountingSection))]
        [XmlIncludeAttribute(typeof(sig.TrackCircuitSection))]
        [XmlIncludeAttribute(typeof(prorail.VirtualSubSection))]     
        public  partial class TdsSection: sig.VirtualTrackAsset
        {
            [XmlElementAttribute("appliesToTvpSection", Order=1)]
            public tElementWithIDref appliesToTvpSection {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A set of as built properties that applies to a TDS section. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TdsSectionAsBuiltConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToTdsSection", Order=1)]
            public tElementWithIDref appliesToTdsSection {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A set of properties that applies to a TDS section.
The class <a href="$element://{7B328390-6A51-4bc6-A2A2-1B6DAAB21DA4}"><font color="#0000ff"><u>insulated rail joint</u></font></a> informs which rail is cut for insulation.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TdsSectionConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToTdsSection", Order=1)]
            public tElementWithIDref appliesToTdsSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasAntiToggleTime", Order=2)]
            public rtmCommon.Duration hasAntiToggleTime {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasDelayOfNotificationOfAvailability", Order=3)]
            public rtmCommon.Duration hasDelayOfNotificationOfAvailability {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasMaxResponseTimeFCP", Order=4)]
            public rtmCommon.Duration hasMaxResponseTimeFCP {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasMaxResponseTimeFCPA", Order=5)]
            public rtmCommon.Duration hasMaxResponseTimeFCPA {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasMaxResponseTimeFCPAForAcknowledgment", Order=6)]
            public rtmCommon.Duration hasMaxResponseTimeFCPAForAcknowledgment {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasResetStrategy", Order=7)]
            public ResetStrategy hasResetStrategy {get; set;} = new ResetStrategy();
                
            [XmlElementAttribute("hasTdpDelay", Order=8)]
            public rtmCommon.Duration hasTdpDelay {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("isOverridable", Order=9)]
            public Boolean isOverridable {get; set;} = new Boolean();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FtgsTrackCircuitProperties))]
        [XmlIncludeAttribute(typeof(sig.LowFrequencyTrackCircuitProperties))]     
        public  partial class TrackCircuitProperties: sig.BaseObject
        {
            [XmlElementAttribute("ballastResistance", Order=1)]
            public Int32 ballastResistance {get; set;} = new Int32();
                
            [XmlElementAttribute("hasElectricLength", Order=2)]
            public rtmCommon.Length hasElectricLength {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        A train detection system that detects rolling stock axles shunting the rails. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.AudioFrequencyTrackCircuit))]
        [XmlIncludeAttribute(typeof(sig.DcVoltageTrackCircuit))]
        [XmlIncludeAttribute(typeof(sig.HviTrackCircuit))]
        [XmlIncludeAttribute(typeof(sig.LowFrequencyTrackCircuit))]     
        public  partial class TrackCircuitSection: sig.TdsSection
        {
            [XmlElementAttribute("cutSectionIndex", Order=1)]
            public String cutSectionIndex= "";
                
            [XmlElementAttribute("hasProperties", Order=2)]
            public TrackCircuitProperties hasProperties {get; set;} = new TrackCircuitProperties();
                
            [XmlElementAttribute("hasTcFeederReceiver", Order=3)]
            public List<TcFeederReceiverElement> hasTcFeederReceiver { get; set; } = new List<TcFeederReceiverElement>(); 
                
            [XmlElementAttribute("individualAssesment", Order=4)]
            public Boolean individualAssesment {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Detector of train passage. The treadle can be electronic or mechanical. 
<ul>
 <li>fr-FR: p&#233;dale</li>
 <li>de-DE: Schienenkontakt</li>
 <li>nl-NL: pedaal</li>
</ul>
The working direction of the treadle can be given by the spot location's application direction. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Treadle: sig.VehicleSensor
        {
            [XmlElementAttribute("normallyOpen", Order=1)]
            public Boolean normallyOpen {get; set;} = new Boolean();
                
            [XmlElementAttribute("singleRail", Order=2)]
            public Boolean singleRail {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Assigns a trigger to vehicle detection.
The trigger is typically a Vehicle Passage Detector. It can also be an approach zone, either all sections or only the extremity (fr-FR: zone d'approche).
Even if no train detection is given, a condition can still apply.
de-DE: Schaltmittelzuordnung
en-UK: strike-in or strike-out; the trigger is closely associated with vehicle detection
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.TriggerAssignment))]     
        public  partial class TriggerAssignment: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("clearsSignal", Order=1)]
            public tElementWithIDref clearsSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("closesSignal", Order=2)]
            public List<tElementWithIDref> closesSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("functionDescription", Order=3)]
            public String functionDescription= "";
                
            [XmlElementAttribute("hasCondition", Order=4)]
            public Condition hasCondition {get; set;} = new Condition();
                
            [XmlElementAttribute("isAssignedToTdsSection", Order=5)]
            public tElementWithIDref isAssignedToTdsSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isAssignedToVpDetector", Order=6)]
            public tElementWithIDref isAssignedToVpDetector;
                
             
        }  
    
        /** 
        A set of properties that applies to a TVP section. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.TvpSectionConfiguration))]     
        public  partial class TvpSectionConfiguration: sig.TrackAssetConfiguration
        {
            [XmlElementAttribute("appliesToTvpSection", Order=1)]
            public tElementWithIDref appliesToTvpSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("berthingTrack", Order=2)]
            public Boolean berthingTrack {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Line-side device for detecting passage of a rail vehicle.

en-UK: strike-in or strike-out detector. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TdsComponent))]
        [XmlIncludeAttribute(typeof(sig.VehicleSensor))]     
        public abstract partial class VehiclePassageDetector: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("isConstrainedByPositionOf", Order=1)]
            public List<tElementWithIDref> isConstrainedByPositionOf { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("occupiesTdsSection", Order=2)]
            public tElementWithIDref occupiesTdsSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToRsmTrainPassageDetector", Order=3)]
            public tElementWithIDref refersToRsmTrainPassageDetector {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Vehicle-worked actuator: line-side installation that senses vehicle passage and subsequently switches other equipment. This class can be instantiated in case no appropriate subtype is available or the type is unknown during design. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BufferSensor))]
        [XmlIncludeAttribute(typeof(sig.DepressionBar))]
        [XmlIncludeAttribute(typeof(sig.EMSensor))]
        [XmlIncludeAttribute(typeof(sig.Loop))]
        [XmlIncludeAttribute(typeof(sig.TcSensor))]
        [XmlIncludeAttribute(typeof(sig.Treadle))]
        [XmlIncludeAttribute(typeof(nr.DerailmentDetector))]     
        public  partial class VehicleSensor: sig.VehiclePassageDetector
        {
             
        }  
    
        /** 
        Reset strategy of a TDS section.
If strategy is not defined, reset is not possible.
de-DE: Grundstellf&#228;higkeit 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ResetStrategy
        {
            [XmlElementAttribute("isOfResetStrategyType", Order=1)]
            public ResetStrategyTypes isOfResetStrategyType {get; set;} = new ResetStrategyTypes();
                
            [XmlElementAttribute("monitorRfcForFcaAndFcap", Order=2)]
            public Boolean monitorRfcForFcaAndFcap {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Section of track that must be proven vacant for safe train operations. Vacancy proving is accomplished either by a TDS or by procedure. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TvpSection: sig.VirtualTrackAsset
        {
            [XmlElementAttribute("imposesSpeedRestriction", Order=1)]
            public rtmCommon.Speed imposesSpeedRestriction {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        For storing remarks in form of text or attached documents.
For instance: <i>according to minutes of meeting 03.12.2019</i>.
Not to be confused with description.

DE: Bearbeitungsvermerk 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Annotation: sig.BaseObject
        {
            [XmlElementAttribute("comment", Order=1)]
            public String comment= "";
                
            [XmlElementAttribute("createdByRole", Order=2)]
            public String createdByRole= "";
                
            [XmlElementAttribute("dateTimeStamp", Order=3)]
            public DateTime dateTimeStamp {get; set;} = new DateTime();
                
            [XmlElementAttribute("refersToAttachment", Order=4)]
            public List<tElementWithIDref> refersToAttachment { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("shortComment", Order=5)]
            public String shortComment= "";
                
            [XmlElementAttribute("validity", Order=6)]
            public String validity= "";
                
             
        }  
    
        /** 
        The party that uses the asset and may be affected if changes are made to the asset.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AssetUser: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
             
        }  
    
        /** 
        Additional source of information. 
For instance:  approval document, drawing, sketches, calculations, d&#233;rogation (Fr). 
This should be enriched at the national level with types according to document types such as as-built validation document, etc.

Do not use as a convenience class for storing information covered by existing attributes. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.Attachment))]
        [XmlIncludeAttribute(typeof(nr.ImageAttachment))]     
        public  partial class Attachment: sig.BaseObject
        {
            [XmlElementAttribute("content", Order=1)]
            public String content= "";
                
            [XmlElementAttribute("contentType", Order=2)]
            public String contentType= "";
                
            [XmlElementAttribute("fileName", Order=3)]
            public String fileName= "";
                
             
        }  
    
        /** 
        The configuration is associated with a date. The configuration, to which this date-stamp applies, is valid from the given date onwards.
Note that no expiry date is given. 
(DE: Regelwerk) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BaselineOfRuleSet: sig.BaseObject
        {
            [XmlElementAttribute("dateOfRuleSet", Order=1)]
            public DateTime dateOfRuleSet {get; set;} = new DateTime();
                
             
        }  
    
        /** 
        The EULYNX base object inherits an identity from the RSM base object. This identity acts as an unique anchor that other objects can refer to.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(dp.RtmEntities))]
        [XmlIncludeAttribute(typeof(dp.SignallingEntities))]
        [XmlIncludeAttribute(typeof(sig.PlatformEdgeAccessPoint))]
        [XmlIncludeAttribute(typeof(sig.Diamond))]
        [XmlIncludeAttribute(typeof(sig.SignalType))]
        [XmlIncludeAttribute(typeof(sig.SynchedFlashing))]
        [XmlIncludeAttribute(typeof(sig.Automatic))]
        [XmlIncludeAttribute(typeof(sig.ManualOverlapRelease))]
        [XmlIncludeAttribute(typeof(sig.NonStopMovement))]
        [XmlIncludeAttribute(typeof(sig.OppositeTrackSignal))]
        [XmlIncludeAttribute(typeof(sig.SignalFunction))]
        [XmlIncludeAttribute(typeof(sig.LocalDatumReference))]
        [XmlIncludeAttribute(typeof(sig.Condition))]
        [XmlIncludeAttribute(typeof(sig.SystemState))]
        [XmlIncludeAttribute(typeof(sig.TrackAssetConfiguration))]
        [XmlIncludeAttribute(typeof(sig.TrackCircuitProperties))]
        [XmlIncludeAttribute(typeof(sig.Annotation))]
        [XmlIncludeAttribute(typeof(sig.Attachment))]
        [XmlIncludeAttribute(typeof(sig.BaselineOfRuleSet))]
        [XmlIncludeAttribute(typeof(sig.Configuration))]
        [XmlIncludeAttribute(typeof(sig.ConfigurationProperty))]
        [XmlIncludeAttribute(typeof(sig.ConfiguredBaseObject))]
        [XmlIncludeAttribute(typeof(sig.ModificationInformation))]
        [XmlIncludeAttribute(typeof(sig.OperationalLocality))]
        [XmlIncludeAttribute(typeof(sig.ReferenceDrawingParameter))]
        [XmlIncludeAttribute(typeof(sig.TimeFrame))]
        [XmlIncludeAttribute(typeof(sig.CableProperties))]
        [XmlIncludeAttribute(typeof(sig.BaliseGroupLinking))]
        [XmlIncludeAttribute(typeof(sig.EtcsDangerpoint))]
        [XmlIncludeAttribute(typeof(sig.EtcsPacket))]
        [XmlIncludeAttribute(typeof(sig.LeuPort))]
        [XmlIncludeAttribute(typeof(sig.LxDepartureDetection))]
        [XmlIncludeAttribute(typeof(sig.DiagnosticsCollector))]
        [XmlIncludeAttribute(typeof(sig.RouteExtremity))]
        [XmlIncludeAttribute(typeof(sig.RouteProperty))]
        [XmlIncludeAttribute(typeof(sig.NotUpgradeableSpeedRestriction))]
        [XmlIncludeAttribute(typeof(nr.PopGroupAssociation))]
        [XmlIncludeAttribute(typeof(sncf.KvbInformationField))]     
        public abstract partial class BaseObject: rtmCommon.BaseObject
        {
             
        }  
    
        /** 
        Configuration information. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Configuration: sig.BaseObject
        {
            [XmlElementAttribute("appliesToBaselineOfRuleSet", Order=1)]
            public tElementWithIDref appliesToBaselineOfRuleSet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasConfigurationProperty", Order=2)]
            public List<ConfigurationProperty> hasConfigurationProperty { get; set; } = new List<ConfigurationProperty>(); 
                
            [XmlElementAttribute("lastModifiedBy", Order=3)]
            public tElementWithIDref lastModifiedBy {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToAnnotation", Order=4)]
            public List<tElementWithIDref> refersToAnnotation { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToBaselineDocument", Order=5)]
            public tElementWithIDref refersToBaselineDocument {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToOperationalLocality", Order=6)]
            public tElementWithIDref refersToOperationalLocality {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToTimeFrame", Order=7)]
            public tElementWithIDref refersToTimeFrame {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A configuration property that typically applies to an individual object.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ControlCode))]
        [XmlIncludeAttribute(typeof(sig.Description))]
        [XmlIncludeAttribute(typeof(sig.Designation))]
        [XmlIncludeAttribute(typeof(sig.ForeignKey))]
        [XmlIncludeAttribute(typeof(sig.ObjectStatus))]
        [XmlIncludeAttribute(typeof(sig.SupplierInformation))]
        [XmlIncludeAttribute(typeof(nr.EquipmentLocation))]
        [XmlIncludeAttribute(typeof(nr.SignallingEquivalentUnit))]     
        public abstract partial class ConfigurationProperty: sig.BaseObject
        {
             
        }  
    
        /** 
        Provides an identity plus a configuration. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TrackAsset))]
        [XmlIncludeAttribute(typeof(sig.BlockElement))]
        [XmlIncludeAttribute(typeof(sig.BlockSystem))]
        [XmlIncludeAttribute(typeof(sig.LineBlockInformation))]
        [XmlIncludeAttribute(typeof(sig.Key))]
        [XmlIncludeAttribute(typeof(sig.Lock))]
        [XmlIncludeAttribute(typeof(sig.LockCombination))]
        [XmlIncludeAttribute(typeof(sig.DangerAreaTrack))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingActivation))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingDeactivation))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingLocalOperationUiElement))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingRouteRelation))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingSignalRelation))]
        [XmlIncludeAttribute(typeof(sig.LevelCrossingTimerSet))]
        [XmlIncludeAttribute(typeof(sig.LocalOperatingArea))]
        [XmlIncludeAttribute(typeof(sig.LocalOperatingAreaUiElement))]
        [XmlIncludeAttribute(typeof(sig.LocalOperatingZone))]
        [XmlIncludeAttribute(typeof(sig.LocalOperatingZoneLimit))]
        [XmlIncludeAttribute(typeof(sig.LocalOperatingZoneRelation))]
        [XmlIncludeAttribute(typeof(sig.LozAssetRelation))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationDevice))]
        [XmlIncludeAttribute(typeof(sig.LocalOperationUiElement))]
        [XmlIncludeAttribute(typeof(sig.ControlArea))]
        [XmlIncludeAttribute(typeof(sig.ControlledTrackAsset))]
        [XmlIncludeAttribute(typeof(sig.ControlRelation))]
        [XmlIncludeAttribute(typeof(sig.DispatchPosition))]
        [XmlIncludeAttribute(typeof(sig.PlatformAccess))]
        [XmlIncludeAttribute(typeof(sig.Normalisation))]
        [XmlIncludeAttribute(typeof(sig.SignalFrame))]
        [XmlIncludeAttribute(typeof(sig.SignalFrameComponent))]
        [XmlIncludeAttribute(typeof(sig.Aspect))]
        [XmlIncludeAttribute(typeof(sig.SignalAspectDegradation))]
        [XmlIncludeAttribute(typeof(sig.SignalMessage))]
        [XmlIncludeAttribute(typeof(sig.SignalVector))]
        [XmlIncludeAttribute(typeof(sig.SignalMessageRelation))]
        [XmlIncludeAttribute(typeof(sig.DispatchAnnouncerAssignment))]
        [XmlIncludeAttribute(typeof(sig.Illumination))]
        [XmlIncludeAttribute(typeof(sig.SignalAlignment))]
        [XmlIncludeAttribute(typeof(sig.SignalSightingDistance))]
        [XmlIncludeAttribute(typeof(sig.SpecialPositionArrangement))]
        [XmlIncludeAttribute(typeof(sig.StandOutControl))]
        [XmlIncludeAttribute(typeof(sig.TunnelSignal))]
        [XmlIncludeAttribute(typeof(sig.NearestAccessPoint))]
        [XmlIncludeAttribute(typeof(sig.SignalLocation))]
        [XmlIncludeAttribute(typeof(sig.AssetAndState))]
        [XmlIncludeAttribute(typeof(sig.CivilStructure))]
        [XmlIncludeAttribute(typeof(sig.EquipmentSupport))]
        [XmlIncludeAttribute(typeof(sig.InfrastructureBorder))]
        [XmlIncludeAttribute(typeof(sig.TrackProperty))]
        [XmlIncludeAttribute(typeof(sig.TdsOccupancyOverrideGroup))]
        [XmlIncludeAttribute(typeof(sig.TriggerAssignment))]
        [XmlIncludeAttribute(typeof(sig.AssetUser))]
        [XmlIncludeAttribute(typeof(sig.Edge))]
        [XmlIncludeAttribute(typeof(sig.LineSideInstallation))]
        [XmlIncludeAttribute(typeof(sig.LocationProxy))]
        [XmlIncludeAttribute(typeof(sig.Node))]
        [XmlIncludeAttribute(typeof(sig.ReferenceDrawing))]
        [XmlIncludeAttribute(typeof(sig.Segment))]
        [XmlIncludeAttribute(typeof(sig.FlankProtection))]
        [XmlIncludeAttribute(typeof(sig.SectionsForFlankProtection))]
        [XmlIncludeAttribute(typeof(sig.Cable))]
        [XmlIncludeAttribute(typeof(sig.CableJointInstallation))]
        [XmlIncludeAttribute(typeof(sig.CableRoute))]
        [XmlIncludeAttribute(typeof(sig.BaliseGroupFunction))]
        [XmlIncludeAttribute(typeof(sig.EtcsMaSection))]
        [XmlIncludeAttribute(typeof(sig.EtcsNationalValueSet))]
        [XmlIncludeAttribute(typeof(sig.EtcsPointCrossing))]
        [XmlIncludeAttribute(typeof(sig.EtcsSignal))]
        [XmlIncludeAttribute(typeof(sig.EtcsSystemVersion))]
        [XmlIncludeAttribute(typeof(sig.EtcsTelegram))]
        [XmlIncludeAttribute(typeof(sig.EtcsTelegramConditionRelation))]
        [XmlIncludeAttribute(typeof(sig.LeuModule))]
        [XmlIncludeAttribute(typeof(sig.RbcInterlockingGroup))]
        [XmlIncludeAttribute(typeof(sig.RbcWatchdog))]
        [XmlIncludeAttribute(typeof(sig.TempShuntingArea))]
        [XmlIncludeAttribute(typeof(sig.WorkZone))]
        [XmlIncludeAttribute(typeof(sig.PowerSupplyModule))]
        [XmlIncludeAttribute(typeof(sig.RastaPropertySet))]
        [XmlIncludeAttribute(typeof(sig.DiagnosticsOpcUaConfiguration))]
        [XmlIncludeAttribute(typeof(sig.MaintenanceDataManagement))]
        [XmlIncludeAttribute(typeof(sig.StartUpProcedureConfiguration))]
        [XmlIncludeAttribute(typeof(sig.LockoutArea))]
        [XmlIncludeAttribute(typeof(sig.LockoutDevice))]
        [XmlIncludeAttribute(typeof(sig.WarningArea))]
        [XmlIncludeAttribute(typeof(sig.WarningComponent))]
        [XmlIncludeAttribute(typeof(sig.WarningSystem))]
        [XmlIncludeAttribute(typeof(sig.CompositeRoute))]
        [XmlIncludeAttribute(typeof(sig.ConditionSectionsClear))]
        [XmlIncludeAttribute(typeof(sig.NonReplacement))]
        [XmlIncludeAttribute(typeof(sig.Route))]
        [XmlIncludeAttribute(typeof(sig.RouteApproachLocking))]
        [XmlIncludeAttribute(typeof(sig.RouteBodyProperty))]
        [XmlIncludeAttribute(typeof(sig.ConflictingRoute))]
        [XmlIncludeAttribute(typeof(sig.RouteCondition))]
        [XmlIncludeAttribute(typeof(sig.ShuntingRouteSectionProving))]
        [XmlIncludeAttribute(typeof(sig.DirectionAuthorityDependentOverlap))]
        [XmlIncludeAttribute(typeof(sig.SafetyDistance))]
        [XmlIncludeAttribute(typeof(sig.SwingingOverlap))]
        [XmlIncludeAttribute(typeof(sig.SpeedProfile))]
        [XmlIncludeAttribute(typeof(sig.TrainCategory))]
        [XmlIncludeAttribute(typeof(sig.ChangeMarker))]
        [XmlIncludeAttribute(typeof(sig.TpArea))]
        [XmlIncludeAttribute(typeof(sig.TpsDataTransmissionSystemProperties))]
        [XmlIncludeAttribute(typeof(sig.TpsDeviceProperties))]
        [XmlIncludeAttribute(typeof(sig.TpsProtectionDistance))]
        [XmlIncludeAttribute(typeof(sig.TpsRelation))]
        [XmlIncludeAttribute(typeof(sig.TrackConditionArea))]
        [XmlIncludeAttribute(typeof(db.CommunicationRelation))]
        [XmlIncludeAttribute(typeof(db.IpAddressCollection))]
        [XmlIncludeAttribute(typeof(db.RemainingShuntingRouteRelease))]
        [XmlIncludeAttribute(typeof(db.ShuntingTargetAuthorityDependent))]
        [XmlIncludeAttribute(typeof(db.BaliseLabellingInformation))]
        [XmlIncludeAttribute(typeof(db.BinaryDataFile))]
        [XmlIncludeAttribute(typeof(db.PositioningMeasurementInfo))]
        [XmlIncludeAttribute(typeof(db.PredefinedEtcsTelegramSet))]
        [XmlIncludeAttribute(typeof(db.DualFlankProtection))]
        [XmlIncludeAttribute(typeof(db.RouteSignalling))]
        [XmlIncludeAttribute(typeof(db.TpsToPointRelation))]
        [XmlIncludeAttribute(typeof(nr.Obscuration))]
        [XmlIncludeAttribute(typeof(nr.PopGroup))]
        [XmlIncludeAttribute(typeof(nr.BoosterTransformer))]
        [XmlIncludeAttribute(typeof(nr.PowerLineCrossing))]
        [XmlIncludeAttribute(typeof(nr.SwitchGear))]
        [XmlIncludeAttribute(typeof(nr.TractionFeed))]
        [XmlIncludeAttribute(typeof(prorail.Signalbook))]
        [XmlIncludeAttribute(typeof(prorail.DepartureTrack))]
        [XmlIncludeAttribute(typeof(prorail.DepartureTrackExtension))]
        [XmlIncludeAttribute(typeof(sncf.OpposingRouteLocking))]
        [XmlIncludeAttribute(typeof(sncf.Transit))]     
        public abstract partial class ConfiguredBaseObject: sig.BaseObject
        {
            [XmlElementAttribute("hasConfiguration", Order=1)]
            public Configuration hasConfiguration {get; set;} = new Configuration();
                
             
        }  
    
        /** 
        The string that is typed on the control console to call a route or more generally to control an track asset.
This can be used if the string can't be generated from the designation of the asset, designation of the route or entry/exit signals
de-De: Bedienstring
en-GB: console code 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ControlCode: sig.ConfigurationProperty
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
             
        }  
    
        /** 
        The asset that owns this configuration-status is made invisible to the driver or train. It typically applies to signals or balises. If the asset is a controlled asset, the signalling system still controls the asset. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CoveredObject: sig.ObjectStatus
        {
             
        }  
    
        /** 
        To give a detailed description of the object under configuration.
Not to be confused with annotation. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Description: sig.ConfigurationProperty
        {
            [XmlElementAttribute("text", Order=1)]
            public String text= "";
                
             
        }  
    
        /** 
        Abstract class for defining labels or complex names to designate a track asset. Alternatively, use the SimpleDesignation class.

Note: Labels and national labelling rules should be defined in the national namespace.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.SimpleDesignation))]
        [XmlIncludeAttribute(typeof(db.Designation))]
        [XmlIncludeAttribute(typeof(nr.Designation))]
        [XmlIncludeAttribute(typeof(prorail.Designation))]
        [XmlIncludeAttribute(typeof(rfi.Designation))]     
        public abstract partial class Designation: sig.ConfigurationProperty
        {
             
        }  
    
        /** 
        The asset that owns this configuration-status has been replaced by a dummy, i.e. a stubbed object that mimics the real object such that the signalling system can operate normally. The dummy has no role other than providing the I/O that the signalling system expects.
Typically used for points or level crossings.
(German  "Betriebsartenstecker") 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DummyMode: sig.ObjectStatus
        {
             
        }  
    
        /** 
        An edge in a topological network. Used to express networks that overlay the existing track topology.
This edge can map to a linear element in the track topology or to a linear location if there is no one-to-one mapping.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsEdge))]     
        public  partial class Edge: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToLinearElement", Order=1)]
            public tElementWithIDref appliesToLinearElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasNodeA", Order=2)]
            public tElementWithIDref hasNodeA {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasNodeB", Order=3)]
            public tElementWithIDref hasNodeB {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedOnTrackTopology", Order=4)]
            public tElementWithIDref isLocatedOnTrackTopology {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Key to an entry in a foreign database, e.g. SAP or GIS. Also known as secondary key or alias. Useful for creating links to asset management systems. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ForeignKey: sig.ConfigurationProperty
        {
            [XmlElementAttribute("key", Order=1)]
            public String key= "";
                
            [XmlElementAttribute("source", Order=2)]
            public String source= "";
                
             
        }  
    
        /** 
        Technical line-side installation relevant to but not planned by signalling. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.LineSideLinearConstruction))]
        [XmlIncludeAttribute(typeof(sig.LineSideSpotDevice))]     
        public abstract partial class LineSideInstallation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("refersToCivilStructure", Order=1)]
            public tElementWithIDref refersToCivilStructure {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Facade for linear located constructions like
<ul>
 <li>Bridge</li>
 <li>Tunnel</li>
 <li>Noise protection barrier</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LineSideLinearConstruction: sig.LineSideInstallation
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Line-side detector, typically used to detect dangerous situations.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LineSideSpotDetector: sig.LineSideSpotDevice
        {
            [XmlElementAttribute("isOfType", Order=1)]
            public List<LineSideDetectorTypes> isOfType { get; set; } = new List<LineSideDetectorTypes>(); 
                
             
        }  
    
        /** 
        Facade for spot located devices like
<ul>
 <li>hot axle box detector</li>
 <li>Telecom antenna</li>
 <li>Catenary post</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.LineSideSpotDetector))]     
        public  partial class LineSideSpotDevice: sig.LineSideInstallation
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Describes a location by an asset that is not part of the data set but referenced within an other data set (outside the current EULYNX XML). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocationDescription: sig.LocationProxy
        {
            [XmlElementAttribute("referencePoint", Order=1)]
            public String referencePoint= "";
                
             
        }  
    
        /** 
        Point of interest to the signalling system.
Often a location that is well-identifiable, e.g. as to attract attention to a dangerpoint, e.g. to the tip of a point or gauge conflict or end of platform. 
Can be used for specifying dangerpoints, end of overlap or ATP protected location, a location where speed changes.
fr-FR: point remarquable 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocationOfInterest: sig.LocationProxy
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToBigMetalMassArea", Order=2)]
            public tElementWithIDref refersToBigMetalMassArea {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToDangerAreaTrack", Order=3)]
            public tElementWithIDref refersToDangerAreaTrack {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToPlatformEdge", Order=4)]
            public tElementWithIDref refersToPlatformEdge;
                
             
        }  
    
        /** 
        Facade for a location that may, or not, be associated with an asset. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.LocationDescription))]
        [XmlIncludeAttribute(typeof(sig.LocationOfInterest))]
        [XmlIncludeAttribute(typeof(sig.LocationReference))]     
        public abstract partial class LocationProxy: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        Reference to the protected infrastructure object <i>e.g. a signal or fouling point.</i> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LocationReference: sig.LocationProxy
        {
            [XmlElementAttribute("refersToTrackAsset", Order=1)]
            public tElementWithIDref refersToTrackAsset;
                
             
        }  
    
        /** 
        Informs about the tooling used to modify the object. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ModificationInformation: sig.BaseObject
        {
            [XmlElementAttribute("toolName", Order=1)]
            public String toolName= "";
                
            [XmlElementAttribute("toolVersion", Order=2)]
            public String toolVersion= "";
                
             
        }  
    
        /** 
        Node in a graph model. 
This allows mapping a node to the underlying track topology that is defined in terms of RSM. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsNode))]     
        public  partial class Node: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedOnTrackTopology", Order=1)]
            public tElementWithIDref isLocatedOnTrackTopology {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        An object-configuration can reflect a particular status, typically in construction phases.
For instance, a signal can be disconnected so drivers disregard the signal. The signal would then own a configuration associated with an out-of-service status.
This abstract class reflects an object status and the IM can specialise the object status that describes national needs. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CoveredObject))]
        [XmlIncludeAttribute(typeof(sig.DummyMode))]
        [XmlIncludeAttribute(typeof(sig.OutOfService))]     
        public abstract partial class ObjectStatus: sig.ConfigurationProperty
        {
             
        }  
    
        /** 
        Yard, region or zone for administrative purposes, without further technical definitions.
<ul>
 <li>DB: &#214;rtlichkeit, z.B. Hamburg Airport ("AAI"). Controller X operates Hamburg Airport and Hamburg Reeperbahn</li>
 <li>ProRail: emplacementen, gebieden, aansluitingen Dt, UT, Ams, Amf, Amfa...</li>
 <li>SBB: Betriebspunkt</li>
 <li>RFI: Area di giurisdizione</li>
 <li>SNCF: zone ou sous-zone d'action d'un poste</li>
 <li>NR: not used in SDEF; instead use signalbox which maps to a control area</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OperationalLocality: sig.BaseObject
        {
            [XmlElementAttribute("abbreviation", Order=1)]
            public String abbreviation= "";
                
            [XmlElementAttribute("isPartOfOperationalLocality", Order=2)]
            public tElementWithIDref isPartOfOperationalLocality {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("longName", Order=3)]
            public String longName= "";
                
            [XmlElementAttribute("shortName", Order=4)]
            public String shortName= "";
                
            [XmlElementAttribute("type", Order=5)]
            public String type= "";
                
             
        }  
    
        /** 
        The asset that owns this configuration-status is decommissioned: the element is physically present but disconnected or no longer controlled from the signalling installation (logically disconnected through software). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.OutOfServicePreparative))]     
        public  partial class OutOfService: sig.ObjectStatus
        {
             
        }  
    
        /** 
        The asset that owns this configuration-status has been physically modified or built in preparation for a later phase of construction. The signalling system is unaware of this modification and does not control it. Typical example is the addition of a speed indicator that will be taken into service at a later date. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OutOfServicePreparative: sig.OutOfService
        {
             
        }  
    
        /** 
        Pointer to (a set of) reference drawings (aka control drawings) for civil and mechanical engineering purposes. May range from a reference to paper documents to 3D CAD-files.
National end-users can tailor this class to their needs.
Not to be used for drawings of <i>specific </i>objects: instantiate an Attachment class instead. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ReferenceDrawing: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
            [XmlElementAttribute("parameterizedBy", Order=2)]
            public List<ReferenceDrawingParameter> parameterizedBy { get; set; } = new List<ReferenceDrawingParameter>(); 
                
            [XmlElementAttribute("subtitle", Order=3)]
            public String subtitle= "";
                
            [XmlElementAttribute("title", Order=4)]
            public String title= "";
                
            [XmlElementAttribute("variant", Order=5)]
            public String variant= "";
                
             
        }  
    
        /** 
        Some reference drawings contain parameterised sketches that need a specific value in a concrete engineering planning. This concrete value is stored as a key-value pair where the key is the name of the parameter in the drawing and the value is the applicable value. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ReferenceDrawingParameter: sig.BaseObject
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
            [XmlElementAttribute("value", Order=2)]
            public Double value {get; set;} = new Double();
                
             
        }  
    
        /** 
        A stretch of track where a given property like speed or gradient applies. The property is constant in the segment. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.SpeedSegment))]     
        public abstract partial class Segment: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasTracksideSignal", Order=1)]
            public List<tElementWithIDref> hasTracksideSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Useful for short names and abbreviations, like  "Derby" for  "Derby interlocking".
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SimpleDesignation: sig.Designation
        {
            [XmlElementAttribute("name", Order=1)]
            public String name= "";
                
             
        }  
    
        /** 
        Information about OEM and supplier. For instance:
<ul>
 <li>Movares <i>supplies </i>an interlocking manufactured by <i>OEM </i>Hima.</li>
</ul>
<ul>
 <li>Siemens <i>supplies </i>axle counters from <i>OEM </i>Frauscher</li>
</ul>
Useful if a resignalling project needs the as-built information.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SupplierInformation: sig.ConfigurationProperty
        {
            [XmlElementAttribute("oemName", Order=1)]
            public String oemName= "";
                
            [XmlElementAttribute("oemProductName", Order=2)]
            public String oemProductName= "";
                
            [XmlElementAttribute("supplierName", Order=3)]
            public String supplierName= "";
                
             
        }  
    
        /** 
        Time frame during which the configured base object is in operation. 
If a date isn't given, it is open-ended.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TimeFrame: sig.BaseObject
        {
            [XmlElementAttribute("end", Order=1)]
            public DateTime end {get; set;} = new DateTime();
                
            [XmlElementAttribute("start", Order=2)]
            public DateTime start {get; set;} = new DateTime();
                
             
        }  
    
        /** 
        Flank protection prevents rolling stock from unintentionally entering the train's route body.
Flank protection is given when selected elements, notably points, prove a given state. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.FlankProtection))]     
        public  partial class FlankProtection: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isProvidedByDerailerInPosition", Order=1)]
            public List<tElementWithIDref> isProvidedByDerailerInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isProvidedByPointElementInPosition", Order=2)]
            public List<tElementWithIDref> isProvidedByPointElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isProvidedBySignal", Order=3)]
            public List<tElementWithIDref> isProvidedBySignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isRequestedByCrossingElementInPosition", Order=4)]
            public List<tElementWithIDref> isRequestedByCrossingElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isRequestedByLocalOperatingZoneLimit", Order=5)]
            public tElementWithIDref isRequestedByLocalOperatingZoneLimit {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isRequestedByLoz", Order=6)]
            public tElementWithIDref isRequestedByLoz {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isRequestedByPointElementInPosition", Order=7)]
            public tElementWithIDref isRequestedByPointElementInPosition {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isRequestedByToeOfPointElement", Order=8)]
            public tElementWithIDref isRequestedByToeOfPointElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("requiresSectionVacant", Order=9)]
            public List<tElementWithIDref> requiresSectionVacant { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        List of TVP sections required for flank protection of a given route. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SectionsForFlankProtection: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRoute", Order=1)]
            public List<tElementWithIDref> appliesToRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresSectionVacant", Order=2)]
            public List<tElementWithIDref> requiresSectionVacant { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Cable, wire or core. 
A cable provides the physical connection. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Cable: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("enclosesCable", Order=1)]
            public List<tElementWithIDref> enclosesCable { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLength", Order=2)]
            public rtmCommon.Length hasLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("isLocatedAt", Order=3)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Structure for guiding cables over track or other obstacle. Can be integral part of an existing bridge or viaduct. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.CableBridge))]     
        public  partial class CableBridge: sig.CableRoute
        {
             
        }  
    
        /** 
        The capacity of the cable in terms of number of included strands. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableCapacity
        {
            [XmlElementAttribute("isOfStrandType", Order=1)]
            public StrandTypes isOfStrandType {get; set;} = new StrandTypes();
                
            [XmlElementAttribute("numberOfStrands", Order=2)]
            public Int32 numberOfStrands {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Cable distributor is a device where one set of cables terminates and (mostly) connect to another greater set of cables that lead to other terminators.
Typically <u>housed </u>in a track side cable disconnection box (lineside "mushroom" disconnection box).
Often contains a disconnector.
<ul>
 <li>en-UK: Cable disconnector</li>
 <li>it-IT: sezionamento cavi</li>
 <li>nl-NL: aansluitkastje, wisselaansluitkast</li>
 <li>de-DE: Kabelverteiler</li>
 <li>fr-FR: r&#233;partiteur de cables</li>
 <li>se-SE: kopplingsplint</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableDistributorDisconnector: sig.CableJointInstallation
        {
             
        }  
    
        /** 
        A cable joint is where cable terminations are distributed, joined, spliced.
As opposed to the cable joint installation, the cable joint is not housed. The linear location of the cables provide the position inside the cable route.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MouldedCableJoint))]     
        public  partial class CableJoint
        {
            [XmlElementAttribute("realisesCableJoints", Order=1)]
            public List<CableJointRelation> realisesCableJoints { get; set; } = new List<CableJointRelation>(); 
                
             
        }  
    
        /** 
        Device where one set of <i>n</i> cables/wires terminates and connects to another set of <i>m</i> cables/wires.
Number <i>n</i> is not necessarily equal to <i>m</i>. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CableDistributorDisconnector))]
        [XmlIncludeAttribute(typeof(sig.CableJointRack))]
        [XmlIncludeAttribute(typeof(sig.CableTerminationRack))]     
        public  partial class CableJointInstallation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("containsCableJoint", Order=1)]
            public List<CableJointRelation> containsCableJoint { get; set; } = new List<CableJointRelation>(); 
                
            [XmlElementAttribute("isHousedIn", Order=2)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A rack in the field where cables arrive and cores are dispatched to endpoints.
DE: Kabelverbindungsgestell, streckenseitiger Kabelverteiler, d.h. nicht im Stw-Gebaeude. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableJointRack: sig.CableJointInstallation
        {
             
        }  
    
        /** 
        Individual relation between two cables. Describes a logical tie between cable A and B. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableJointRelation
        {
            [XmlElementAttribute("joinsCableA", Order=1)]
            public tElementWithIDref joinsCableA {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("joinsCableB", Order=2)]
            public tElementWithIDref joinsCableB {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A pipe conduct for a cable, not being an Under Track Crossing (UTX). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CablePipe: sig.CableRoute
        {
             
        }  
    
        /** 
        Pit adjacent to the track at the end of a UTX.
A UTX joins two cable pits, as per the cable duct topology.

de-DE: Kabelschacht 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CablePit: sig.CableRouteJunction
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableProperties: sig.BaseObject
        {
            [XmlElementAttribute("appliesToCable", Order=1)]
            public List<tElementWithIDref> appliesToCable { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("capacitiveCoupling", Order=2)]
            public Int32 capacitiveCoupling {get; set;} = new Int32();
                
            [XmlElementAttribute("category", Order=3)]
            public String category= "";
                
            [XmlElementAttribute("crossSectionalArea", Order=4)]
            public Double crossSectionalArea {get; set;} = new Double();
                
            [XmlElementAttribute("diameter", Order=5)]
            public Double diameter {get; set;} = new Double();
                
            [XmlElementAttribute("hasCableCapacity", Order=6)]
            public CableCapacity hasCableCapacity {get; set;} = new CableCapacity();
                
            [XmlElementAttribute("hasSpareCapacity", Order=7)]
            public CableCapacity hasSpareCapacity {get; set;} = new CableCapacity();
                
            [XmlElementAttribute("modeltype", Order=8)]
            public String modeltype= "";
                
            [XmlElementAttribute("numberOfCores", Order=9)]
            public Int32 numberOfCores {get; set;} = new Int32();
                
            [XmlElementAttribute("operatingVoltage", Order=10)]
            public Int32 operatingVoltage {get; set;} = new Int32();
                
            [XmlElementAttribute("ratingPerCore", Order=11)]
            public Int32 ratingPerCore {get; set;} = new Int32();
                
            [XmlElementAttribute("resistancePerCore", Order=12)]
            public Int32 resistancePerCore {get; set;} = new Int32();
                
            [XmlElementAttribute("strandedElements", Order=13)]
            public Int32 strandedElements {get; set;} = new Int32();
                
            [XmlElementAttribute("strandingCode", Order=14)]
            public String strandingCode= "";
                
            [XmlElementAttribute("testingVoltage", Order=15)]
            public Int32 testingVoltage {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Linear structure for guiding cables. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CableBridge))]
        [XmlIncludeAttribute(typeof(sig.CablePipe))]
        [XmlIncludeAttribute(typeof(sig.CableTray))]
        [XmlIncludeAttribute(typeof(sig.CableTrench))]
        [XmlIncludeAttribute(typeof(sig.CableTrough))]
        [XmlIncludeAttribute(typeof(sig.FreeCableRoute))]
        [XmlIncludeAttribute(typeof(sig.FreeHangingCableRoute))]
        [XmlIncludeAttribute(typeof(sig.RaisedCableTrough))]
        [XmlIncludeAttribute(typeof(sig.TemporaryCableRoute))]
        [XmlIncludeAttribute(typeof(sig.UnderTrackCrossing))]     
        public  partial class CableRoute: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isMadeOfMaterial", Order=2)]
            public List<MaterialTypes> isMadeOfMaterial { get; set; } = new List<MaterialTypes>(); 
                
            [XmlElementAttribute("isUsedByParty", Order=3)]
            public List<tElementWithIDref> isUsedByParty { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Where cable can exit or enter the duct, typically a simple hole. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableRouteExit: sig.CableRouteJunction
        {
             
        }  
    
        /** 
        Where cable routes join (not being a cable pit).
de-DE: Trassenabzweig 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableRouteJoin: sig.CableRouteJunction
        {
             
        }  
    
        /** 
        A physical node in the cable route network where cables can enter/exit a cable route. From this hub the cable route goes to controller, controlled track asset, cable distributor or housing.
This class can be instantiated if no appropriate specialised class is available, for instance at an early planning stage. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CablePit))]
        [XmlIncludeAttribute(typeof(sig.CableRouteExit))]
        [XmlIncludeAttribute(typeof(sig.CableRouteJoin))]     
        public  partial class CableRouteJunction
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("joinsCableDistributor", Order=2)]
            public List<tElementWithIDref> joinsCableDistributor { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("joinsControlledTrackAsset", Order=3)]
            public List<tElementWithIDref> joinsControlledTrackAsset { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("joinsController", Order=4)]
            public List<tElementWithIDref> joinsController { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("joinsHousing", Order=5)]
            public List<tElementWithIDref> joinsHousing { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A rack in the relay room/signal box where field cables arrive and cores are dispatched to the interlocking or other systems.
de-DE: Kabelabschlussgestell im Stw Gebaeude 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableTerminationRack: sig.CableJointInstallation
        {
             
        }  
    
        /** 
        A tray, attached to a wall or ceiling in buildings or tunnels, for guiding cables.
<ul>
 <li>de-DE: Kabelrinne</li>
 <li>nl-NL: kabelgoot</li>
 <li>fr-FR: goulotte de cablage</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableTray: sig.CableRoute
        {
             
        }  
    
        /** 
        A trench in the earth where the cable is buried.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableTrench: sig.CableRoute
        {
             
        }  
    
        /** 
        Rigid Structure with a rectangular cross section for guiding cables. Typical materials are concrete or synthetics. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CableTrough: sig.CableRoute
        {
             
        }  
    
        /** 
        The cable lies on top of the earth. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FreeCableRoute: sig.CableRoute
        {
             
        }  
    
        /** 
        A pseudo cable duct where the cable hangs freely. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FreeHangingCableRoute: sig.CableRoute
        {
             
        }  
    
        /** 
        A cable joint connect two cable ends. It is not housed but lies in the cable route. Typically used when one runs out of cable or to repair sectioned cable. It is often molded in a resin.
<ul>
 <li>de-DE: Kabelmuffe</li>
 <li>it-IT: muffola</li>
 <li>nl-NL: kabelmof</li>
 <li>fr-FR: manchon de cable</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MouldedCableJoint: sig.CableJoint
        {
             
        }  
    
        /** 
        Cable trough supported by pillars.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RaisedCableTrough: sig.CableRoute
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TemporaryCableRoute: sig.CableRoute
        {
             
        }  
    
        /** 
        A cable duct for guiding cables crossing underneath the track. Mostly a pipe.
UTX joins two cable pits, as per the cable duct topology.
<ul>
 <li>en-UK: UTX</li>
</ul>
<ul>
 <li>de-DE: Kabelrohr</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class UnderTrackCrossing: sig.CableRoute
        {
             
        }  
    
        /** 
        Allows refining the function of a balise group, e.g. "L2 balise group".
Typically refined in the national domain.
The balise group function determines whether or not the BG is controlled via other assets, i.e. IL, point, RBC. Eg. speed control.

E.g. Call RBC, open doors, stop if in SR, nat vals, speed control 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.BaliseGroupFunctionLabels))]     
        public  partial class BaliseGroupFunction: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("implementedByEtcsBaliseGroup", Order=1)]
            public tElementWithIDref implementedByEtcsBaliseGroup {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Informs about linking between subsequent balise groups. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TiltingTrainBgLinking))]
        [XmlIncludeAttribute(typeof(sig.ZbsBgLinking))]     
        public  partial class BaliseGroupLinking: sig.BaseObject
        {
            [XmlElementAttribute("fromBaliseGroup", Order=1)]
            public tElementWithIDref fromBaliseGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDistance", Order=2)]
            public rtmCommon.Length hasDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasLinkReaction", Order=3)]
            public LinkReactionTypes hasLinkReaction {get; set;} = new LinkReactionTypes();
                
            [XmlElementAttribute("hasTargetOrientation", Order=4)]
            public Orientation hasTargetOrientation {get; set;} = new Orientation();
                
            [XmlElementAttribute("refersToTelegram", Order=5)]
            public List<tElementWithIDref> refersToTelegram { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("toBaliseGroup", Order=6)]
            public tElementWithIDref toBaliseGroup {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The type of balise group that may depend on Level and/or TPS to which it applies.
Can be specialised in the national domain with enumerations. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BaliseGroupType
        {
            [XmlElementAttribute("appliesToBaliseGroup", Order=1)]
            public tElementWithIDref appliesToBaliseGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=2)]
            public String value= "";
                
             
        }  
    
        /** 
        Tuple of cant deficiency and speed.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CantDeficiencySpeed
        {
            [XmlElementAttribute("nc_cddiff", Order=1)]
            public Int32 nc_cddiff {get; set;} = new Int32();
                
            [XmlElementAttribute("v_diff", Order=2)]
            public Int32 v_diff {get; set;} = new Int32();
                
             
        }  
    
        /** 
        The Central Safety System (CSS) groups interlocking and RBC functionality. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CentralSafetySystem: sig.RbcInterlockingGroup
        {
             
        }  
    
        /** 
        Defines the length of the acknowledgement area (L_MAMODE). The design parameters are typically derived by national rules depending on duration and distance. 

The <i><u>designed </u></i>duration during which the transition acknowledgement is requested. Given this duration this value, one computes the L_ACKLEVELTR or L_ACKMAMODE.

These parameters can be stored with the data. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsAcknowledgementLT))]
        [XmlIncludeAttribute(typeof(sig.EtcsAcknowledgementMode))]     
        public  partial class EtcsAcknowledgement
        {
            [XmlElementAttribute("hasAckDuration", Order=1)]
            public rtmCommon.Duration hasAckDuration {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        Defines the length of the acknowledgement area for transition into a Level 2/3 area. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsAcknowledgementLT: sig.EtcsAcknowledgement
        {
            [XmlElementAttribute("l_ackleveltr", Order=1)]
            public Double l_ackleveltr {get; set;} = new Double();
                
             
        }  
    
        /** 
        Defines the acknowledgement area in rear of the start of the required mode. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsAcknowledgementMode: sig.EtcsAcknowledgement
        {
            [XmlElementAttribute("l_ackmamode", Order=1)]
            public Double l_ackmamode {get; set;} = new Double();
                
             
        }  
    
        /** 
        Area with ETCS supervision. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsArea: sig.TpArea
        {
            [XmlElementAttribute("allowsTrainsWithEtcsVersion", Order=1)]
            public List<tElementWithIDref> allowsTrainsWithEtcsVersion { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasEntryLtMarker", Order=2)]
            public List<tElementWithIDref> hasEntryLtMarker { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasEtcsLevel", Order=3)]
            public EtcsLevelTypes hasEtcsLevel {get; set;} = new EtcsLevelTypes();
                
            [XmlElementAttribute("isFittedWithEtcsVersion", Order=4)]
            public tElementWithIDref isFittedWithEtcsVersion {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Eurobalise in an ETCS system.
The model type as defined by the manufacturer can be described in the <a href="$feature://{3D2A1B2D-BBA0-4bce-8064-8F86DBA8783F}"><font color="#0000ff"><u>Supplier Information class.</u></font></a>
Variable N_PIG is inherited from attribute "positionInSystem". 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBalise: sig.Balise
        {
            [XmlElementAttribute("duplicatesEtcsBalise", Order=1)]
            public tElementWithIDref duplicatesEtcsBalise {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isControlledByLeuPort", Order=2)]
            public tElementWithIDref isControlledByLeuPort {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Group of one or more ETCS balises that share a balise group identifier.
nl-NL: ProRail slaat de waarde van M_VERSION op in de balisegroep. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBaliseGroup: sig.BaliseGroup
        {
            [XmlElementAttribute("isControlledBy", Order=1)]
            public List<tElementWithIDref> isControlledBy { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isKnownByRbc", Order=2)]
            public List<tElementWithIDref> isKnownByRbc { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("m_version", Order=3)]
            public Int32 m_version {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_bg", Order=4)]
            public Int32 nid_bg {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_c", Order=5)]
            public Int32 nid_c {get; set;} = new Int32();
                
            [XmlElementAttribute("q_link", Order=6)]
            public Int32 q_link {get; set;} = new Int32();
                
            [XmlElementAttribute("q_media", Order=7)]
            public Int32 q_media {get; set;} = new Int32();
                
            [XmlElementAttribute("q_updown", Order=8)]
            public Int32 q_updown {get; set;} = new Int32();
                
             
        }  
    
        /** 
        ETCS Hybrid Level 3 properties. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBaliseGroupHL3: sig.EtcsBaliseGroupProperties
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBaliseGroupL1LS: sig.EtcsBaliseGroupProperties
        {
            [XmlElementAttribute("brakingDistance", Order=1)]
            public Int32 brakingDistance {get; set;} = new Int32();
                
            [XmlElementAttribute("index", Order=2)]
            public Int32 index {get; set;} = new Int32();
                
            [XmlElementAttribute("individuallyProgrammed", Order=3)]
            public Boolean individuallyProgrammed {get; set;} = new Boolean();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBaliseGroupLevel1: sig.EtcsBaliseGroupProperties
        {
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsBaliseGroupLevel2: sig.EtcsBaliseGroupProperties
        {
             
        }  
    
        /** 
        ETCS properties that apply to an ETCS balise group. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroupHL3))]
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroupL1LS))]
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroupLevel1))]
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroupLevel2))]     
        public  partial class EtcsBaliseGroupProperties: sig.TpsDataTransmissionSystemProperties
        {
             
        }  
    
        /** 
        The condition for issuing a CES. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsCesPointCondition))]
        [XmlIncludeAttribute(typeof(sig.EtcsCesSectionCondition))]     
        public  partial class EtcsCesCondition
        {
             
        }  
    
        /** 
        The CES is issued when point element(s) is in the given position.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsCesPointCondition: sig.EtcsCesCondition
        {
            [XmlElementAttribute("appliesWhenPointElementInPosition", Order=1)]
            public List<tElementWithIDref> appliesWhenPointElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The CES is issued when TVP section(s) is occupied.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsCesSectionCondition: sig.EtcsCesCondition
        {
            [XmlElementAttribute("appliesWhenSectionIsOccupied", Order=1)]
            public List<tElementWithIDref> appliesWhenSectionIsOccupied { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The change applies when a condition defined by this class applies. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsChangeOtherCondition))]
        [XmlIncludeAttribute(typeof(sig.EtcsPointCondition))]
        [XmlIncludeAttribute(typeof(sig.EtcsSignalCondition))]
        [XmlIncludeAttribute(typeof(sig.EtcsWorkZoneCondition))]     
        public  partial class EtcsChangeCondition
        {
             
        }  
    
        /** 
        A change condition that applies under other conditions such as night-time speed restriction. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsChangeOtherCondition: sig.EtcsChangeCondition
        {
            [XmlElementAttribute("isTriggeredByObject", Order=1)]
            public tElementWithIDref isTriggeredByObject;
                
             
        }  
    
        /** 
        Condition under which an ETCS telegram is sent. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.OtherCondition))]
        [XmlIncludeAttribute(typeof(sig.PointCondition))]
        [XmlIncludeAttribute(typeof(sig.SignalAspectCondition))]
        [XmlIncludeAttribute(typeof(sig.SpecialCondition))]
        [XmlIncludeAttribute(typeof(sig.TempShuntingCondition))]
        [XmlIncludeAttribute(typeof(sig.TpsCondition))]
        [XmlIncludeAttribute(typeof(sig.WorkZoneCondition))]     
        public abstract partial class EtcsCondition
        {
            [XmlElementAttribute("appliesToPlanningPhase", Order=1)]
            public PlanningPhase appliesToPlanningPhase {get; set;} = new PlanningPhase();
                
             
        }  
    
        /** 
        Marks a signal or stop marker board where a CES is issued.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsConditionalEmergencyStopMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasCesCondition", Order=2)]
            public EtcsCesCondition hasCesCondition {get; set;} = new EtcsCesCondition();
                
            [XmlElementAttribute("hasCesHandOverRbc", Order=3)]
            public tElementWithIDref hasCesHandOverRbc {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasOffset", Order=4)]
            public rtmCommon.Length hasOffset {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        ETCS dangerpoint marks the spot beyond the EoA up to where a train can advance without danger. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsDangerpoint: sig.BaseObject
        {
            [XmlElementAttribute("automaticReleaseSpeedCalculation", Order=1)]
            public Boolean automaticReleaseSpeedCalculation {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasAllowedTrainCategorySpeed", Order=2)]
            public EtcsTrainCategorySpeed hasAllowedTrainCategorySpeed {get; set;} = new EtcsTrainCategorySpeed();
                
            [XmlElementAttribute("isAttLocationProxy", Order=3)]
            public tElementWithIDref isAttLocationProxy;
                
             
        }  
    
        /** 
        An edge in the ETCS topology.
de-DE: Kante in ETCS Topologie 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsEdge: sig.Edge
        {
            [XmlElementAttribute("isKnownToRbc", Order=1)]
            public List<tElementWithIDref> isKnownToRbc { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        ETCS End Of Authority (EoA) marks the end of an ETCS Movement Authority. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsEndOfAuthority
        {
            [XmlElementAttribute("hasDistanceInRearOfSignal", Order=1)]
            public rtmCommon.Length hasDistanceInRearOfSignal {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasEtcsDangerpoint", Order=2)]
            public EtcsDangerpoint hasEtcsDangerpoint {get; set;} = new EtcsDangerpoint();
                
            [XmlElementAttribute("hasOverlap", Order=3)]
            public EtcsOverlap hasOverlap {get; set;} = new EtcsOverlap();
                
            [XmlElementAttribute("hasPermittedSpeed", Order=4)]
            public rtmCommon.Speed hasPermittedSpeed {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a line kilometer ribbon applies.
The new counter starts at this position.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsGeoPosMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("countingUp", Order=1)]
            public Boolean countingUp {get; set;} = new Boolean();
                
            [XmlElementAttribute("m_position", Order=2)]
            public Int32 m_position {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a given gradient applies. Can be associated with a gradient sign (UK). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsGradientChangeMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("g_a", Order=1)]
            public Int32 g_a {get; set;} = new Int32();
                
            [XmlElementAttribute("q_gdir", Order=2)]
            public Int32 q_gdir {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Provides the condition under which a text is displayed or stops being displayed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsLevelCondition
        {
            [XmlElementAttribute("m_leveltextdisplay", Order=1)]
            public Int32 m_leveltextdisplay {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_ntc", Order=2)]
            public Int32 nid_ntc {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Level crossing information associated with ETCS operations. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.EtcslLevelCrossingSystem))]     
        public  partial class EtcsLevelCrossingSystem: sig.LevelCrossingSystem
        {
             
        }  
    
        /** 
        At this spot and in the given direction, the level given by M_LEVELTR takes over. 
This includes Level NTC such as PZB, ATB, etc. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsLevelTransitionMarker: sig.EtcsTransitionMarker
        {
            [XmlElementAttribute("hasAccessControlSignal", Order=1)]
            public List<tElementWithIDref> hasAccessControlSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLtProperties", Order=2)]
            public List<LtProperties> hasLtProperties { get; set; } = new List<LtProperties>(); 
                
            [XmlElementAttribute("leadsToEtcsAreaFittedWithVersion", Order=3)]
            public tElementWithIDref leadsToEtcsAreaFittedWithVersion {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("maxTrainLength", Order=4)]
            public rtmCommon.Length maxTrainLength {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        An ETCS marker is a spot on the track where an event occurs or a property changes that is relevant to ETCS signalling:
<ul>
 <li>Change in National Values</li>
 <li>Change of gradient</li>
 <li>Change of speed</li>
 <li>Change of track condition</li>
 <li>Start of text display</li>
</ul>

An ETCS profile is an ordered sequence of markers. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsConditionalEmergencyStopMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsGeoPosMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsGradientChangeMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsNationalValueChangeMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsSpeedChangeMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsTextMessageMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsTrackConditionMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsTransitionMarker))]
        [XmlIncludeAttribute(typeof(prorail.WeightLimitMarker))]     
        public  partial class EtcsMarker: sig.TpMarker
        {
            [XmlElementAttribute("limitsTcArea", Order=1)]
            public List<tElementWithIDref> limitsTcArea { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The Movement Authority (MA) section has an entry location and optionally a timer start and/or stop location.
ETCS variable D_SECTIONTIMERSTOPLOC is the distance between start and stop location. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsMaSection: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasSectionEntryLocation", Order=1)]
            public tElementWithIDref hasSectionEntryLocation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasTimerStartLocation", Order=2)]
            public tElementWithIDref hasTimerStartLocation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasTimerStopLocation", Order=3)]
            public tElementWithIDref hasTimerStopLocation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("t_sectiontimer", Order=4)]
            public Int32 t_sectiontimer {get; set;} = new Int32();
                
             
        }  
    
        /** 
        At this spot, in the given direction, a mode transition procedure applies.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsModeTransitionMarker: sig.EtcsTransitionMarker
        {
            [XmlElementAttribute("l_mamode", Order=1)]
            public Double l_mamode {get; set;} = new Double();
                
            [XmlElementAttribute("m_mamode", Order=2)]
            public Int32 m_mamode {get; set;} = new Int32();
                
            [XmlElementAttribute("needsEtcsAck", Order=3)]
            public EtcsAcknowledgementMode needsEtcsAck {get; set;} = new EtcsAcknowledgementMode();
                
            [XmlElementAttribute("q_mamode", Order=4)]
            public Boolean q_mamode {get; set;} = new Boolean();
                
            [XmlElementAttribute("v_mamode", Order=5)]
            public Int32 v_mamode {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a given <i>set </i>of national values applies.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsNationalValueChangeMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("appliesEtcsNationalValueSet", Order=1)]
            public tElementWithIDref appliesEtcsNationalValueSet {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A National Value pair of a <i>key, </i>the name of the National Value, and its <i>value.</i> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsNationalValuePair
        {
            [XmlElementAttribute("hasSubset", Order=1)]
            public List<EtcsNationalValuePair> hasSubset { get; set; } = new List<EtcsNationalValuePair>(); 
                
            [XmlElementAttribute("key", Order=2)]
            public String key= "";
                
            [XmlElementAttribute("value", Order=3)]
            public String value= "";
                
             
        }  
    
        /** 
        Set of National Values that can be reused, e.g. at (national) borders. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsNationalValueSet: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesForEtcsBaseline", Order=1)]
            public List<tElementWithIDref> appliesForEtcsBaseline { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasNvElement", Order=2)]
            public List<EtcsNationalValuePair> hasNvElement { get; set; } = new List<EtcsNationalValuePair>(); 
                
             
        }  
    
        /** 
        Node in the ETCS topology.
de-DE: ETCS Knoten f&#252;r Streckenende/wechsel im ETCS Knoten-Kanten Modell 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsNode: sig.Node
        {
            [XmlElementAttribute("mapsToDiamond", Order=1)]
            public tElementWithIDref mapsToDiamond {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("mapsToEtcsMarker", Order=2)]
            public tElementWithIDref mapsToEtcsMarker {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A stretch of track beyond EoA.
The RBC can release the ETCS overlap when it deems that the approaching train is slow enough such that overshoot is sufficiently unlikely. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsOverlap
        {
            [XmlElementAttribute("automaticReleaseSpeedCalculation", Order=1)]
            public Boolean automaticReleaseSpeedCalculation {get; set;} = new Boolean();
                
            [XmlElementAttribute("endsAtLocation", Order=2)]
            public tElementWithIDref endsAtLocation {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasAllowedTrainCategorySpeed", Order=3)]
            public EtcsTrainCategorySpeed hasAllowedTrainCategorySpeed {get; set;} = new EtcsTrainCategorySpeed();
                
            [XmlElementAttribute("hasOverlapTimer", Order=4)]
            public rtmCommon.Duration hasOverlapTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasTimerStartLocation", Order=5)]
            public tElementWithIDref hasTimerStartLocation {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        ETCS packet as defined in subset-026.
Used by either balise telegrams or RBC messages.
The end-user can use an existing XSD such as <a href="$inet://https://github.com/openETCS/dataDictionary/blob/master/Artifacts/subset-026-7/Decoder/Delivery/SubsetFromWord/SubSet026_7.xml"><font color="#0000ff"><u>this</u></font></a> to instantiate XML of ETCS packets. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public abstract partial class EtcsPacket: sig.BaseObject
        {
             
        }  
    
        /** 
        The change applies when the given points are in the given position.
When no point condition is given, the ETCS marker doesn't depend on the path. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsPointCondition: sig.EtcsChangeCondition
        {
            [XmlElementAttribute("appliesWhenPointElementInPosition", Order=1)]
            public List<tElementWithIDref> appliesWhenPointElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The DB ETCS Point/Crossing  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsPointCrossing: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isRepresentedByEtcsNode", Order=1)]
            public tElementWithIDref isRepresentedByEtcsNode {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToPointCrossing", Order=2)]
            public tElementWithIDref refersToPointCrossing {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Set of properties that apply to DB points and crossings.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsPointCrossingProperties
        {
            [XmlElementAttribute("appliesToEtcsPointCrossing", Order=1)]
            public tElementWithIDref appliesToEtcsPointCrossing {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("groupId", Order=2)]
            public String groupId= "";
                
            [XmlElementAttribute("subGroupId", Order=3)]
            public Int32 subGroupId {get; set;} = new Int32();
                
             
        }  
    
        /** 
        An area where a given set of position report parameters applies. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsPositionReportParametersArea
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("t_cycloc", Order=2)]
            public Int32 t_cycloc {get; set;} = new Int32();
                
             
        }  
    
        /** 
        At this spot and in the given direction, a RBC transition applies. This is the border between the areas controlled by two different RBCs.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsRbcTransitionMarker: sig.EtcsTransitionMarker
        {
            [XmlElementAttribute("hasBtsPosition", Order=1)]
            public List<tElementWithIDref> hasBtsPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToAcceptingRbc", Order=2)]
            public tElementWithIDref refersToAcceptingRbc {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToHovRbc", Order=3)]
            public tElementWithIDref refersToHovRbc {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A route specialised for ETCS purposes.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsRoute: sig.Route
        {
            [XmlElementAttribute("disallowsStopIfInSrBaliseGroup", Order=1)]
            public List<tElementWithIDref> disallowsStopIfInSrBaliseGroup { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("excludesBaliseGroup", Order=2)]
            public List<tElementWithIDref> excludesBaliseGroup { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasMaSection", Order=3)]
            public List<tElementWithIDref> hasMaSection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasSrBalise", Order=4)]
            public List<tElementWithIDref> hasSrBalise { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasTempShuntingArea", Order=5)]
            public StandstillDetectionForShunting hasTempShuntingArea {get; set;} = new StandstillDetectionForShunting();
                
            [XmlElementAttribute("shuntingModeRoute", Order=6)]
            public Boolean shuntingModeRoute {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        ETCS marker board. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsSignal: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasEoA", Order=1)]
            public EtcsEndOfAuthority hasEoA {get; set;} = new EtcsEndOfAuthority();
                
            [XmlElementAttribute("hasEtcsDangerpoint", Order=2)]
            public tElementWithIDref hasEtcsDangerpoint {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSignal", Order=3)]
            public tElementWithIDref refersToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The change applies when the given signal(s) show(s) the given message(s). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsSignalCondition: sig.EtcsChangeCondition
        {
            [XmlElementAttribute("appliesWhenSignalShowsMessage", Order=1)]
            public List<tElementWithIDref> appliesWhenSignalShowsMessage { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsSignalProperties
        {
            [XmlElementAttribute("EpsReportingPoint", Order=1)]
            public Boolean EpsReportingPoint {get; set;} = new Boolean();
                
            [XmlElementAttribute("EpsTunnelSignal", Order=2)]
            public Boolean EpsTunnelSignal {get; set;} = new Boolean();
                
            [XmlElementAttribute("acceptsRbcDarkModeCommand", Order=3)]
            public Boolean acceptsRbcDarkModeCommand {get; set;} = new Boolean();
                
            [XmlElementAttribute("allowsEtcsBlockageExit", Order=4)]
            public EtcsBlockageExitTypes allowsEtcsBlockageExit {get; set;} = new EtcsBlockageExitTypes();
                
            [XmlElementAttribute("appliesToEtcsSignal", Order=5)]
            public tElementWithIDref appliesToEtcsSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("groupId", Order=6)]
            public String groupId= "";
                
            [XmlElementAttribute("isEtcsEntry", Order=7)]
            public Boolean isEtcsEntry {get; set;} = new Boolean();
                
            [XmlElementAttribute("isStoppingPointForDetector", Order=8)]
            public List<tElementWithIDref> isStoppingPointForDetector { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("protectsTunnelOfLength", Order=9)]
            public rtmCommon.Length protectsTunnelOfLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("shortestOverlap200", Order=10)]
            public rtmCommon.Length shortestOverlap200 {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("shortestOverlap50", Order=11)]
            public rtmCommon.Length shortestOverlap50 {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("shortestOverlap50_200", Order=12)]
            public rtmCommon.Length shortestOverlap50_200 {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("subGroupId", Order=13)]
            public String subGroupId= "";
                
             
        }  
    
        /** 
        From this spot and in the given direction, a speed applies. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsSpeedChangeMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("hasCantDeficiencySpeed", Order=1)]
            public List<CantDeficiencySpeed> hasCantDeficiencySpeed { get; set; } = new List<CantDeficiencySpeed>(); 
                
            [XmlElementAttribute("hasChangeCondition", Order=2)]
            public EtcsChangeCondition hasChangeCondition {get; set;} = new EtcsChangeCondition();
                
            [XmlElementAttribute("hasEtcsTrainCategorySpeed", Order=3)]
            public List<EtcsTrainCategorySpeed> hasEtcsTrainCategorySpeed { get; set; } = new List<EtcsTrainCategorySpeed>(); 
                
            [XmlElementAttribute("q_diff", Order=4)]
            public Int32 q_diff {get; set;} = new Int32();
                
            [XmlElementAttribute("q_front", Order=5)]
            public Boolean q_front {get; set;} = new Boolean();
                
            [XmlElementAttribute("v_static", Order=6)]
            public Int32 v_static {get; set;} = new Int32();
                
             
        }  
    
        /** 
        The ETCS system version. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsSystemVersion: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasEtcsBaseline", Order=1)]
            public EtcsBaselines hasEtcsBaseline {get; set;} = new EtcsBaselines();
                
            [XmlElementAttribute("hasEtcsBaselineVersion", Order=2)]
            public EtcsBaselineVersions hasEtcsBaselineVersion {get; set;} = new EtcsBaselineVersions();
                
            [XmlElementAttribute("hasEtcsSystemVersion", Order=3)]
            public EtcsSystemVersions hasEtcsSystemVersion {get; set;} = new EtcsSystemVersions();
                
             
        }  
    
        /** 
        ETCS Eurobalise telegram as specified in subset-026. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTelegram: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("containsPacket", Order=1)]
            public List<tElementWithIDref> containsPacket { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("informsAboutEtcsMarker", Order=2)]
            public List<tElementWithIDref> informsAboutEtcsMarker { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isSentByEtcsBalise", Order=3)]
            public tElementWithIDref isSentByEtcsBalise {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isSentByEtcsBaliseGroup", Order=4)]
            public tElementWithIDref isSentByEtcsBaliseGroup {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("m_mcount", Order=5)]
            public Int32 m_mcount {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Relates a set of telegrams that is sent when a given set of conditions applies.
Used for switchable balises.

The SRS versions allows selecting telegrams of a given version. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTelegramConditionRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToEtcsTelegram", Order=1)]
            public List<tElementWithIDref> appliesToEtcsTelegram { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("sentConditionally", Order=2)]
            public List<EtcsCondition> sentConditionally { get; set; } = new List<EtcsCondition>(); 
                
            [XmlElementAttribute("srsSubversion", Order=3)]
            public String srsSubversion= "";
                
            [XmlElementAttribute("srsVersion", Order=4)]
            public String srsVersion= "";
                
             
        }  
    
        /** 
        Defines the end conditions for displaying a text message. The conditions are 
<ul>
 <li>length or duration, as described in the subset</li>
 <li>ERTMS level</li>
 <li>mode</li>
</ul>
Q_TEXTDISPLAY defines how the conditions are to be used. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTextDisplayEndCondition
        {
            [XmlElementAttribute("hasEtcsLevelCondition", Order=1)]
            public EtcsLevelCondition hasEtcsLevelCondition {get; set;} = new EtcsLevelCondition();
                
            [XmlElementAttribute("l_textdisplay", Order=2)]
            public Double l_textdisplay {get; set;} = new Double();
                
            [XmlElementAttribute("m_modetextdisplay", Order=3)]
            public Int32 m_modetextdisplay {get; set;} = new Int32();
                
            [XmlElementAttribute("t_textdisplay", Order=4)]
            public Int32 t_textdisplay {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Defines the start conditions for displaying a text message. The conditions are 
<ul>
 <li>location (location of the marker plus an offset, as described in the subset)</li>
 <li>ERTMS level</li>
 <li>mode</li>
</ul>
Q_TEXTDISPLAY defines how the conditions are to be used.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTextDisplayStartCondition
        {
            [XmlElementAttribute("d_textdisplay", Order=1)]
            public Double d_textdisplay {get; set;} = new Double();
                
            [XmlElementAttribute("hasEtcsLevelCondition", Order=2)]
            public EtcsLevelCondition hasEtcsLevelCondition {get; set;} = new EtcsLevelCondition();
                
            [XmlElementAttribute("m_modetextdisplay", Order=3)]
            public Int32 m_modetextdisplay {get; set;} = new Int32();
                
             
        }  
    
        /** 
        A spot on the track from where a text message to the train turns valid. This marker defines:
<ul>
 <li>the message string</li>
 <li>the conditions under which the message shall be displayed.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTextMessageMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("hasDisplayEndCondition", Order=1)]
            public EtcsTextDisplayEndCondition hasDisplayEndCondition {get; set;} = new EtcsTextDisplayEndCondition();
                
            [XmlElementAttribute("hasDisplayStartCondition", Order=2)]
            public EtcsTextDisplayStartCondition hasDisplayStartCondition {get; set;} = new EtcsTextDisplayStartCondition();
                
            [XmlElementAttribute("l_text", Order=3)]
            public Int32 l_text {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_c", Order=4)]
            public Int32 nid_c {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_rbc", Order=5)]
            public Int32 nid_rbc {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_textmessage", Order=6)]
            public Int32 nid_textmessage {get; set;} = new Int32();
                
            [XmlElementAttribute("q_conftextdisplay", Order=7)]
            public Int32 q_conftextdisplay {get; set;} = new Int32();
                
            [XmlElementAttribute("q_text", Order=8)]
            public Int32 q_text {get; set;} = new Int32();
                
            [XmlElementAttribute("q_textclass", Order=9)]
            public Int32 q_textclass {get; set;} = new Int32();
                
            [XmlElementAttribute("q_textconfirm", Order=10)]
            public Int32 q_textconfirm {get; set;} = new Int32();
                
            [XmlElementAttribute("q_textdisplay", Order=11)]
            public Int32 q_textdisplay {get; set;} = new Int32();
                
            [XmlElementAttribute("q_textreport", Order=12)]
            public Int32 q_textreport {get; set;} = new Int32();
                
            [XmlElementAttribute("text", Order=13)]
            public String text= "";
                
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a given track condition applies. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TC39_ChangeOfTractionSystem))]
        [XmlIncludeAttribute(typeof(sig.TC40_ChangeOfAllowedCurrentConsumption))]
        [XmlIncludeAttribute(typeof(sig.TC67_BigMetalMass))]
        [XmlIncludeAttribute(typeof(sig.TC68_TrackCondition))]
        [XmlIncludeAttribute(typeof(sig.TC69_StationPlatforms))]     
        public  partial class EtcsTrackConditionMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("q_trackinit", Order=1)]
            public Int32 q_trackinit {get; set;} = new Int32();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTrackToTrainPacket
        {
             
        }  
    
        /** 
        Tuple of ETCS train category and speed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTrainCategorySpeed
        {
            [XmlElementAttribute("nc_diff", Order=1)]
            public Int32 nc_diff {get; set;} = new Int32();
                
            [XmlElementAttribute("v_diff", Order=2)]
            public Int32 v_diff {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Marks a spot and direction, where an ETCS transition occurs. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsLevelTransitionMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsModeTransitionMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsRbcTransitionMarker))]
        [XmlIncludeAttribute(typeof(sig.EtcsTsiCssTransitionMarker))]     
        public  partial class EtcsTransitionMarker: sig.EtcsMarker
        {
            [XmlElementAttribute("hasNoRearSignal", Order=1)]
            public Boolean hasNoRearSignal {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasTransitionCondition", Order=2)]
            public EtcsPointCondition hasTransitionCondition {get; set;} = new EtcsPointCondition();
                
            [XmlElementAttribute("refersToBoundaryEtcsBg", Order=3)]
            public tElementWithIDref refersToBoundaryEtcsBg {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToBoundarySignal", Order=4)]
            public tElementWithIDref refersToBoundarySignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        At this spot, in the given direction, a transition procedure to another CSS applies. 
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsTsiCssTransitionMarker: sig.EtcsTransitionMarker
        {
            [XmlElementAttribute("m_version", Order=1)]
            public Int32 m_version {get; set;} = new Int32();
                
             
        }  
    
        /** 
        The change applies when the given work zone(s) is/are active.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class EtcsWorkZoneCondition: sig.EtcsChangeCondition
        {
            [XmlElementAttribute("appliesWhenWorkZoneIsActive", Order=1)]
            public List<tElementWithIDref> appliesWhenWorkZoneIsActive { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A cabinet for housing an LEU 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuCabinet: sig.Cabinet
        {
            [XmlElementAttribute("hasElectricProperties", Order=1)]
            public LeuElectricProperties hasElectricProperties {get; set;} = new LeuElectricProperties();
                
            [XmlElementAttribute("isAtLocation", Order=2)]
            public LeuCabinetLocation isAtLocation {get; set;} = new LeuCabinetLocation();
                
             
        }  
    
        /** 
        The location where a LEU is placed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuCabinetLocation
        {
            [XmlElementAttribute("hasRelativePosition", Order=1)]
            public LeuRelativePositionTypes hasRelativePosition {get; set;} = new LeuRelativePositionTypes();
                
            [XmlElementAttribute("refersToEquipmentSupport", Order=2)]
            public tElementWithIDref refersToEquipmentSupport {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSignal", Order=3)]
            public tElementWithIDref refersToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The electric properties of a LEU cabinet. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuElectricProperties
        {
            [XmlElementAttribute("getsPowerFromPS", Order=1)]
            public tElementWithIDref getsPowerFromPS;
                
            [XmlElementAttribute("maxPowerConsumption", Order=2)]
            public Int32 maxPowerConsumption {get; set;} = new Int32();
                
            [XmlElementAttribute("maxPowerInterruptDuration", Order=3)]
            public Double maxPowerInterruptDuration {get; set;} = new Double();
                
            [XmlElementAttribute("numberOfLeuSystems", Order=4)]
            public Int32 numberOfLeuSystems {get; set;} = new Int32();
                
            [XmlElementAttribute("usesNominalVoltage", Order=5)]
            public NominalVoltageTypes usesNominalVoltage {get; set;} = new NominalVoltageTypes();
                
             
        }  
    
        /** 
        Hardware module for controlling Eurobalises. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuModule: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("getsInputFromLeuModule", Order=1)]
            public List<tElementWithIDref> getsInputFromLeuModule { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("getsInputFromLeuSystem", Order=2)]
            public List<tElementWithIDref> getsInputFromLeuSystem { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("getsInputFromTrackAsset", Order=3)]
            public List<tElementWithIDref> getsInputFromTrackAsset { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLeuPort", Order=4)]
            public List<tElementWithIDref> hasLeuPort { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isClassifiedAs", Order=5)]
            public LeuModuleClassificationTypes isClassifiedAs {get; set;} = new LeuModuleClassificationTypes();
                
            [XmlElementAttribute("isHousedInLeuCabinet", Order=6)]
            public tElementWithIDref isHousedInLeuCabinet {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isPartOfLeuSystem", Order=7)]
            public tElementWithIDref isPartOfLeuSystem {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Port between LEU and individually-controlled balise.
The planned and as-built port may differ due to the planning process. Both numbers are stored. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuPort: sig.BaseObject
        {
            [XmlElementAttribute("asBuiltNumber", Order=1)]
            public Int32 asBuiltNumber {get; set;} = new Int32();
                
            [XmlElementAttribute("plannedNumber", Order=2)]
            public Int32 plannedNumber {get; set;} = new Int32();
                
             
        }  
    
        /** 
        A Lineside Electronic Unit (LEU) system controls zero or more ETCS balises. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LeuSystem: sig.FieldObjectController
        {
            [XmlElementAttribute("hasLeuPort", Order=1)]
            public List<LeuPort> hasLeuPort { get; set; } = new List<LeuPort>(); 
                
            [XmlElementAttribute("isHousedInCabinet", Order=2)]
            public List<tElementWithIDref> isHousedInCabinet { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isRelatedToMovableElement", Order=3)]
            public tElementWithIDref isRelatedToMovableElement {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isRelatedToSignal", Order=4)]
            public tElementWithIDref isRelatedToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Parameters governing behaviour when the level crossing malfunctions.
nl-NL: gedragsconfiguratie bij het defect raken van een overweg. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LevelCrossingMalfunction
        {
            [XmlElementAttribute("hasSpeedRestrictionArea", Order=1)]
            public tElementWithIDref hasSpeedRestrictionArea {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasStoppingArea", Order=2)]
            public tElementWithIDref hasStoppingArea {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Level transition properties including acknowledgement. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LtProperties
        {
            [XmlElementAttribute("hardExit", Order=1)]
            public Boolean hardExit {get; set;} = new Boolean();
                
            [XmlElementAttribute("m_leveltr", Order=2)]
            public Int32 m_leveltr {get; set;} = new Int32();
                
            [XmlElementAttribute("needsEtcsAck", Order=3)]
            public EtcsAcknowledgementLT needsEtcsAck {get; set;} = new EtcsAcknowledgementLT();
                
            [XmlElementAttribute("nid_ntc", Order=4)]
            public Int32 nid_ntc {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Parameters for activating the level crossing by detection of departure of an ETCS train. 
nl-NL: vertrekdetectiepunt 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LxDepartureDetection: sig.BaseObject
        {
            [XmlElementAttribute("hasDepartureDetectionPoint", Order=1)]
            public tElementWithIDref hasDepartureDetectionPoint {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasOperationalDepartureArea", Order=2)]
            public tElementWithIDref hasOperationalDepartureArea;
                
            [XmlElementAttribute("hasSpeedRestrictionLength", Order=3)]
            public rtmCommon.Length hasSpeedRestrictionLength {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        The ETCS telegram is sent when the given track asset is in the given state. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OtherCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("activeWhenAssetInState", Order=1)]
            public tElementWithIDref activeWhenAssetInState;
                
            [XmlElementAttribute("assetDescription", Order=2)]
            public String assetDescription= "";
                
            [XmlElementAttribute("conditionDescription", Order=3)]
            public String conditionDescription= "";
                
             
        }  
    
        /** 
        The ETCS telegram is sent when the point is in a given position. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PointCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("activeWhenPointElementInPosition", Order=1)]
            public tElementWithIDref activeWhenPointElementInPosition {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Radio Block Centre. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RBC: sig.Controller
        {
             
        }  
    
        /** 
        A group of one RBC and one or more interlocking that need to exchange signalling information. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RbcInterlockingCommGroup: sig.RbcInterlockingGroup
        {
             
        }  
    
        /** 
        An abstract grouping of RBC and interlocking systems. 

Specialisation shows the purpose of the grouping, i.e. for administrative purposes or communication. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.CentralSafetySystem))]
        [XmlIncludeAttribute(typeof(sig.RbcInterlockingCommGroup))]     
        public abstract partial class RbcInterlockingGroup: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("includesInterlocking", Order=1)]
            public List<tElementWithIDref> includesInterlocking { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("includesRbc", Order=2)]
            public List<tElementWithIDref> includesRbc { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Set of properties that apply to the RBC. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RbcProperties
        {
            [XmlElementAttribute("appliesToRbc", Order=1)]
            public tElementWithIDref appliesToRbc {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasAckTimer", Order=2)]
            public rtmCommon.Duration hasAckTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasGeneralMessageTimer", Order=3)]
            public rtmCommon.Duration hasGeneralMessageTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasPermShuntTimer", Order=4)]
            public rtmCommon.Duration hasPermShuntTimer {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("minUserDataRate", Order=5)]
            public Int32 minUserDataRate {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_c", Order=6)]
            public Int32 nid_c {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_radio", Order=7)]
            public String nid_radio= "";
                
            [XmlElementAttribute("nid_rbc", Order=8)]
            public Int32 nid_rbc {get; set;} = new Int32();
                
            [XmlElementAttribute("srsSubversion", Order=9)]
            public String srsSubversion= "";
                
            [XmlElementAttribute("srsVersion", Order=10)]
            public String srsVersion= "";
                
            [XmlElementAttribute("stopInShuntingSuppTimer", Order=11)]
            public rtmCommon.Duration stopInShuntingSuppTimer {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        Watchdog that checks the pulse of the inter-RBC connection.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RbcWatchdog: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRbc", Order=1)]
            public List<tElementWithIDref> appliesToRbc { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasLifeSignTimer", Order=2)]
            public rtmCommon.Duration hasLifeSignTimer {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        The ETCS telegram is sent when a signal sends a given message, or shows a given aspect. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SignalAspectCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("activeWhenShowingAspect", Order=1)]
            public tElementWithIDref activeWhenShowingAspect {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("activeWhenShowingMessage", Order=2)]
            public tElementWithIDref activeWhenShowingMessage {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("withExtraSignalCondition", Order=3)]
            public SignalFallbackTypes withExtraSignalCondition {get; set;} = new SignalFallbackTypes();
                
             
        }  
    
        /** 
        Allows defining a set of special conditions for sending an ETCS telegram. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SpecialCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("hasSpecialConditions", Order=1)]
            public SpecialConditionTypes hasSpecialConditions {get; set;} = new SpecialConditionTypes();
                
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a given speed applies. Often associated with a trackside sign.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SpeedChangeMarker: sig.ChangeMarker
        {
            [XmlElementAttribute("hasMaximumSpeed", Order=1)]
            public rtmCommon.Speed hasMaximumSpeed {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        A timer for measuring the time a train has been stationary before entering the temporary shunting area. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class StandstillDetectionForShunting
        {
            [XmlElementAttribute("appliestoTempShuntingArea", Order=1)]
            public tElementWithIDref appliestoTempShuntingArea {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasStandstillTimer", Order=2)]
            public rtmCommon.Duration hasStandstillTimer {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        An ETCS track condition referring to a Change of traction system (Track Condition 39). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TC39_ChangeOfTractionSystem: sig.EtcsTrackConditionMarker
        {
            [XmlElementAttribute("m_voltage", Order=1)]
            public Int32 m_voltage {get; set;} = new Int32();
                
            [XmlElementAttribute("nid_ctraction", Order=2)]
            public Int32 nid_ctraction {get; set;} = new Int32();
                
             
        }  
    
        /** 
        An ETCS track condition marking the location where the allowed power consumption changes. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TC40_ChangeOfAllowedCurrentConsumption: sig.EtcsTrackConditionMarker
        {
            [XmlElementAttribute("m_current", Order=1)]
            public Int32 m_current {get; set;} = new Int32();
                
             
        }  
    
        /** 
        An ETCS track condition referring to a Big Metall Mass (Track Condition 67).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TC67_BigMetalMass: sig.EtcsTrackConditionMarker
        {
             
        }  
    
        /** 
        The track condition marker limits an area. The effective direction of the marker is <i>into</i> the area. Maps to ETCS track Condition 68. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TC68_TrackCondition: sig.EtcsTrackConditionMarker
        {
            [XmlElementAttribute("hasTrackConditionAreaLocation", Order=1)]
            public rtmCommon.AreaLocation hasTrackConditionAreaLocation {get; set;} = new rtmCommon.AreaLocation();
                
            [XmlElementAttribute("m_trackcond", Order=2)]
            public Int32 m_trackcond {get; set;} = new Int32();
                
             
        }  
    
        /** 
        An ETCS track condition referring to a station platform edge (Track Condition 69). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TC69_StationPlatforms: sig.EtcsTrackConditionMarker
        {
            [XmlElementAttribute("m_platform", Order=1)]
            public Int32 m_platform {get; set;} = new Int32();
                
            [XmlElementAttribute("q_platform", Order=2)]
            public Int32 q_platform {get; set;} = new Int32();
                
            [XmlElementAttribute("refersToPlatformEdge", Order=3)]
            public tElementWithIDref refersToPlatformEdge;
                
             
        }  
    
        /** 
        Temporary shunting area. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TempShuntingArea: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        The ETCS telegram is sent when the temporary shunting zone is taken by local staff. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TempShuntingCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("activeWhenTempShuntingAreaTaken", Order=1)]
            public tElementWithIDref activeWhenTempShuntingAreaTaken {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Balise group linking specific to tilting trains. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TiltingTrainBgLinking: sig.BaliseGroupLinking
        {
             
        }  
    
        /** 
        The TPS condition is active when the given TPS device <i>or </i>TPS data transmission system is in the state indicated by the attribute <i>TpsActive.</i> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TpsCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("TpsActive", Order=1)]
            public Boolean TpsActive {get; set;} = new Boolean();
                
            [XmlElementAttribute("refersToTpsDevice", Order=2)]
            public tElementWithIDref refersToTpsDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToTpsTransmissionSystem", Order=3)]
            public tElementWithIDref refersToTpsTransmissionSystem {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Area that is under temporary possession, typically for maintenance activities. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class WorkZone: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        The ETCS telegram is sent when the workzone is taken by local staff. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class WorkZoneCondition: sig.EtcsCondition
        {
            [XmlElementAttribute("activeWhenWorkZoneTaken", Order=1)]
            public tElementWithIDref activeWhenWorkZoneTaken {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Balise group linking for Zugbeeinflussung Berliner S-Bahn (ZBS).

 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ZbsBgLinking: sig.BaliseGroupLinking
        {
            [XmlElementAttribute("isOfLinkingType", Order=1)]
            public ZbsLinkingTypes isOfLinkingType {get; set;} = new ZbsLinkingTypes();
                
             
        }  
    
        /** 
        A physical power supply field module. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PhysicalPowerSupplyModule: sig.PowerSupplyModule
        {
            [XmlElementAttribute("isHousedIn", Order=1)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isPsModuleType", Order=2)]
            public PowerSupplyModuleType isPsModuleType {get; set;} = new PowerSupplyModuleType();
                
             
        }  
    
        /** 
        The parameters of a power output channel. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PowerOutputChannelProperties
        {
            [XmlElementAttribute("appliesToPsModule", Order=1)]
            public List<tElementWithIDref> appliesToPsModule { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("channelNumber", Order=2)]
            public Int32 channelNumber {get; set;} = new Int32();
                
            [XmlElementAttribute("maxPower", Order=3)]
            public Int32 maxPower {get; set;} = new Int32();
                
            [XmlElementAttribute("maxPowerInterruptDuration", Order=4)]
            public Double maxPowerInterruptDuration {get; set;} = new Double();
                
            [XmlElementAttribute("maxVoltage", Order=5)]
            public Int32 maxVoltage {get; set;} = new Int32();
                
            [XmlElementAttribute("minVoltage", Order=6)]
            public Int32 minVoltage {get; set;} = new Int32();
                
            [XmlElementAttribute("nominalPower", Order=7)]
            public Int32 nominalPower {get; set;} = new Int32();
                
            [XmlElementAttribute("providesNominalVoltage", Order=8)]
            public NominalVoltageTypes providesNominalVoltage {get; set;} = new NominalVoltageTypes();
                
             
        }  
    
        /** 
        Describes the sourcing of power to a power supply.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PowerSourceRelation
        {
            [XmlElementAttribute("ProvidesPowerTo", Order=1)]
            public List<tElementWithIDref> ProvidesPowerTo { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("getsPowerFromPsModule", Order=2)]
            public tElementWithIDref getsPowerFromPsModule {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("getsPowerFromTrackAsset", Order=3)]
            public tElementWithIDref getsPowerFromTrackAsset;
                
            [XmlElementAttribute("hasPowerSourceType", Order=4)]
            public PowerSourceTypes hasPowerSourceType {get; set;} = new PowerSourceTypes();
                
            [XmlElementAttribute("isPrimarySource", Order=5)]
            public Boolean isPrimarySource {get; set;} = new Boolean();
                
            [XmlElementAttribute("isUps", Order=6)]
            public Boolean isUps {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Installation that supplies electric power to signalling subsystems and devices. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PhysicalPowerSupplyModule))]
        [XmlIncludeAttribute(typeof(sig.VirtualPowerSupplyModule))]     
        public abstract partial class PowerSupplyModule: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        Fa&#231;ade for a power supplied by an object such as controller or level crossing.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class VirtualPowerSupplyModule: sig.PowerSupplyModule
        {
             
        }  
    
        /** 
        The safety code is a byte array that ensures the integrity of a RaSTA message. 
The full MD4 as specified in RFC 1320 with a configurable initial value. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RaStaFullSafetyCode: sig.RaStaSafetyCode
        {
            [XmlElementAttribute("upperHalfMD4", Order=1)]
            public String upperHalfMD4= "";
                
             
        }  
    
        /** 
        Set of timers and counters that apply to the RaSTA upper communication layers. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RastaPropertySet: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSci", Order=1)]
            public List<EulynxSciTypes> appliesToSci { get; set; } = new List<EulynxSciTypes>(); 
                
            [XmlElementAttribute("hasRedundancyLayerConfiguration", Order=2)]
            public RedundancyLayerConfiguration hasRedundancyLayerConfiguration {get; set;} = new RedundancyLayerConfiguration();
                
            [XmlElementAttribute("hasSafetyRetransmissionLayerConfiguration", Order=3)]
            public SafetyRetransmissionLayerConfiguration hasSafetyRetransmissionLayerConfiguration {get; set;} = new SafetyRetransmissionLayerConfiguration();
                
             
        }  
    
        /** 
        The safety code is a byte array that ensures the integrity of a RaSTA message. 
This class matches option 2 of &#167;5.3.11 with a configurable lower half of the MD4 8 bytes as a string. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.RaStaFullSafetyCode))]     
        public  partial class RaStaSafetyCode
        {
            [XmlElementAttribute("lowerHalfMD4", Order=1)]
            public String lowerHalfMD4= "";
                
             
        }  
    
        /** 
        Configuration parameters of the EULYNX RaSTA redundancy layer. Table 7.3 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RedundancyLayerConfiguration
        {
            [XmlElementAttribute("hasCheckCode", Order=1)]
            public CheckCodeTypes hasCheckCode {get; set;} = new CheckCodeTypes();
                
            [XmlElementAttribute("hasMessagesCounters", Order=2)]
            public RedundancyMessageCounters hasMessagesCounters {get; set;} = new RedundancyMessageCounters();
                
            [XmlElementAttribute("hasTseq", Order=3)]
            public rtmCommon.Duration hasTseq {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("nPhysicalChannels", Order=4)]
            public Int32 nPhysicalChannels {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Counters for controlling the flow of messages in the redundancy layer.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RedundancyMessageCounters
        {
            [XmlElementAttribute("ndeferQueueSize", Order=1)]
            public Int32 ndeferQueueSize {get; set;} = new Int32();
                
            [XmlElementAttribute("ndiagnosis", Order=2)]
            public Int32 ndiagnosis {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Counters for controlling the flow of messages in the safety and retransmission layer. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SafetyMessageCounters
        {
            [XmlElementAttribute("mwa", Order=1)]
            public Int32 mwa {get; set;} = new Int32();
                
            [XmlElementAttribute("ndiagWindow", Order=2)]
            public Int32 ndiagWindow {get; set;} = new Int32();
                
            [XmlElementAttribute("nmaxPaket", Order=3)]
            public Int32 nmaxPaket {get; set;} = new Int32();
                
            [XmlElementAttribute("nsendmax", Order=4)]
            public Int32 nsendmax {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Configuration parameters of the EULYNX RaSTA Safety/Retransmission layer, Table 23. Used for safe communication. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SafetyRetransmissionLayerConfiguration
        {
            [XmlElementAttribute("hasMessageCounters", Order=1)]
            public SafetyMessageCounters hasMessageCounters {get; set;} = new SafetyMessageCounters();
                
            [XmlElementAttribute("hasTh", Order=2)]
            public rtmCommon.Duration hasTh {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasTmax", Order=3)]
            public rtmCommon.Duration hasTmax {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("usesSafetyCode", Order=4)]
            public RaStaSafetyCode usesSafetyCode {get; set;} = new RaStaSafetyCode();
                
             
        }  
    
        /** 
        Service function diagnostics collector that processes and channels diagnostic data.
Can be a separate hardware component or virtualised software such as a OPC-UA server. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DiagnosticsCollector: sig.BaseObject
        {
            [XmlElementAttribute("hasDiagnosticsConfiguration", Order=1)]
            public DiagnosticsOpcUaConfiguration hasDiagnosticsConfiguration {get; set;} = new DiagnosticsOpcUaConfiguration();
                
            [XmlElementAttribute("servesDiagDataToCollector", Order=2)]
            public List<tElementWithIDref> servesDiagDataToCollector { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A diagnostic collector is configured to acquire data points. 
The device-specific diagnostic configuration typically is an XML representing the OPC-UA address space.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DiagnosticsOpcUaConfiguration: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        Refer to the glossary entry  
 Subsystem - Maintenance and Data Management for the definition of the MDM in the EULYNX System.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.PhysicalMDM))]
        [XmlIncludeAttribute(typeof(sig.VirtualisedMDM))]     
        public  partial class MaintenanceDataManagement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasStartUpConfiguration", Order=1)]
            public List<StartUpProcedureConfiguration> hasStartUpConfiguration { get; set; } = new List<StartUpProcedureConfiguration>(); 
                
            [XmlElementAttribute("hostsDiagnosticsCollector", Order=2)]
            public List<DiagnosticsCollector> hostsDiagnosticsCollector { get; set; } = new List<DiagnosticsCollector>(); 
                
             
        }  
    
        /** 
        A physical MDM device that hosts any number of diagnostics collectors. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PhysicalMDM: sig.MaintenanceDataManagement
        {
            [XmlElementAttribute("isHousedIn", Order=1)]
            public tElementWithIDref isHousedIn {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The start-up configuration data that the MDM provides to the controller at boot time. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class StartUpProcedureConfiguration: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("configuresController", Order=1)]
            public tElementWithIDref configuresController {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasNonVitalDataFile", Order=2)]
            public Attachment hasNonVitalDataFile {get; set;} = new Attachment();
                
            [XmlElementAttribute("hasVitalDataFile", Order=3)]
            public Attachment hasVitalDataFile {get; set;} = new Attachment();
                
             
        }  
    
        /** 
        A virtualised MDM, e.g. running as a docker.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class VirtualisedMDM: sig.MaintenanceDataManagement
        {
             
        }  
    
        /** 
        System that warns workers on or near a railway bridge about an approaching train. 
ProRail: Can be equipped with a key that switches on an audible warning. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BridgeWarningSystem: sig.WarningSystem
        {
            [XmlElementAttribute("refersToBridge", Order=1)]
            public tElementWithIDref refersToBridge {get; set;} = new tElementWithIDref();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LockoutArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("composedOfLockoutArea", Order=1)]
            public List<tElementWithIDref> composedOfLockoutArea { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("locksOutRoute", Order=3)]
            public List<tElementWithIDref> locksOutRoute { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Device that allows line-side workers to lock out part of the network, thus claiming protection from trains.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(nr.LockoutDevice))]
        [XmlIncludeAttribute(typeof(sncf.LockoutDevice))]     
        public  partial class LockoutDevice: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToLockoutArea", Order=2)]
            public tElementWithIDref refersToLockoutArea {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        System that warns workers inside a tunnel about an approaching train.
nl-NL: WIT  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TunnelWarningSystem: sig.WarningSystem
        {
            [XmlElementAttribute("refersToTunnel", Order=1)]
            public tElementWithIDref refersToTunnel {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The warning system's warning area can have a designation, name and other configuration items.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class WarningArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Audible and/or visual alarm device. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class WarningComponent: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isDoubleSided", Order=1)]
            public Boolean isDoubleSided {get; set;} = new Boolean();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isOfAlarmType", Order=3)]
            public AlarmTypes isOfAlarmType {get; set;} = new AlarmTypes();
                
             
        }  
    
        /** 
        Train-activated warning system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BridgeWarningSystem))]
        [XmlIncludeAttribute(typeof(sig.TunnelWarningSystem))]     
        public  partial class WarningSystem: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("composedOfWarningComponents", Order=1)]
            public List<tElementWithIDref> composedOfWarningComponents { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("refersToWarningArea", Order=2)]
            public tElementWithIDref refersToWarningArea {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("type", Order=3)]
            public String type= "";
                
            [XmlElementAttribute("usesTriggerAssignment", Order=4)]
            public List<tElementWithIDref> usesTriggerAssignment { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A route that is composed of two or more elementary routes. The elementary routes are commonly referred to as atomic routes or subroutes. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CompositeRoute: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasSubroutes", Order=1)]
            public List<tElementWithIDref> hasSubroutes { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The condition for releasing the key release instrument, pertaining to the occupancy of the target track of a shunting route.
de-DE: Kriterium f&#252;r die Aufl&#246;sung von &#252;berwachten Schl&#252;sselsperren im Zielgleis von Rangierstra&#223;en. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConditionAffectingKRI: sig.ConditionAffectingRoute
        {
            [XmlElementAttribute("needsTargetTrackVacancyState", Order=1)]
            public TargetTrackConditionTypes needsTargetTrackVacancyState {get; set;} = new TargetTrackConditionTypes();
                
             
        }  
    
        /** 
        Condition required for the route to open, read from a compound logical object or a release instrument. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ConditionAffectingKRI))]     
        public  partial class ConditionAffectingRoute: sig.RouteCondition
        {
            [XmlElementAttribute("affectsRoute", Order=1)]
            public tElementWithIDref affectsRoute;
                
             
        }  
    
        /** 
        Condition required for the signal to show a given aspect, read from a compound logical object or a release instrument. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConditionAffectingSignal: sig.RouteCondition
        {
            [XmlElementAttribute("affectsSignal", Order=1)]
            public tElementWithIDref affectsSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        TVP section(s) proven clear to open the route entry signal. This check allows to send a second train into one signalling section. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ConditionSectionsClear: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("affectsRoute", Order=1)]
            public tElementWithIDref affectsRoute;
                
            [XmlElementAttribute("overrideable", Order=2)]
            public Boolean overrideable {get; set;} = new Boolean();
                
            [XmlElementAttribute("provesSection", Order=3)]
            public List<tElementWithIDref> provesSection { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A main route for typical train operations. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.MainRoute))]     
        public abstract partial class MainRoute: sig.Route
        {
             
        }  
    
        /** 
        Maximum (signalled) line speed, i.e. the speed allowed when the signals show 'proceed without restrictions'.
de-DE: Geschwindigkeit, die bei Zugstra&#223;en mit diesem befahrenen Teil ohne Einschr&#228;nkung durch Zs 3 gefahren w&#252;rde (Geschwindigkeit der Strecke). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class MaxRouteBodySpeed: sig.RouteBodyProperty
        {
            [XmlElementAttribute("hasMaxSpeed", Order=1)]
            public rtmCommon.Speed hasMaxSpeed {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        To prevent a signal from closing too early. The signal is replaced only after "<i>condition section occupied" </i>and "<i>last wheel" </i>apply.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NonReplacement: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRoute", Order=1)]
            public tElementWithIDref appliesToRoute;
                
            [XmlElementAttribute("appliesToSection", Order=2)]
            public List<tElementWithIDref> appliesToSection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("lastWheel", Order=3)]
            public Boolean lastWheel {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        An on sight route is called when track vacancy cannot be ascertained. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.OnSightRoute))]     
        public abstract partial class OnSightRoute: sig.Route
        {
             
        }  
    
        /** 
        A route is a predetermined path for a traffic movement, the route body, plus a set of properties. It is associated with flank protection and overlap.
A route is abstract and must be specialised, e.g. into main route, shunting route or on sight route.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsRoute))]
        [XmlIncludeAttribute(typeof(sig.MainRoute))]
        [XmlIncludeAttribute(typeof(sig.OnSightRoute))]
        [XmlIncludeAttribute(typeof(sig.ShuntingRoute))]
        [XmlIncludeAttribute(typeof(prorail.Route))]     
        public abstract partial class Route: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasPrecededRoute", Order=1)]
            public List<tElementWithIDref> hasPrecededRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("needsLxInState", Order=2)]
            public List<tElementWithIDref> needsLxInState { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresDerailerInPositionForFlankProtection", Order=3)]
            public List<tElementWithIDref> requiresDerailerInPositionForFlankProtection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresFlankProtection", Order=4)]
            public List<tElementWithIDref> requiresFlankProtection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresPointElementInPositionForFlankProtection", Order=5)]
            public List<tElementWithIDref> requiresPointElementInPositionForFlankProtection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("usesOverlap", Order=6)]
            public List<tElementWithIDref> usesOverlap { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("usesPreferredOverlap", Order=7)]
            public tElementWithIDref usesPreferredOverlap {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The route is locked when the approach section(s) turns from vacant to occupied. 
If the DelayedLock timer is not given (or zero), the lock applies immediately.

The route approach lock can apply to:
<ul>
 <li>an entry signal: the proceed aspect of the entry signal is locked.</li>
 <li>a (set of) route(s): in this case the triggering mechanism depends on the kind of route, e.g. entry speed.</li>
 <li>a route body, in case the aspect of the entry signal or the properties of the route are irrelevant.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteApproachLocking: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasDelayedLock", Order=1)]
            public rtmCommon.Duration hasDelayedLock {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("hasDelayedRelease", Order=2)]
            public rtmCommon.Duration hasDelayedRelease {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("locksEntrySignal", Order=3)]
            public tElementWithIDref locksEntrySignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("locksRoute", Order=4)]
            public List<tElementWithIDref> locksRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("locksRouteBody", Order=5)]
            public tElementWithIDref locksRouteBody {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("usesTriggerAssignment", Order=6)]
            public List<tElementWithIDref> usesTriggerAssignment { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Base class for additional route body properties. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.MaxRouteBodySpeed))]
        [XmlIncludeAttribute(typeof(sig.SectionList))]
        [XmlIncludeAttribute(typeof(sig.ViaLocation))]     
        public abstract partial class RouteBodyProperty: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToRouteBody", Order=1)]
            public tElementWithIDref appliesToRouteBody {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The route conflicts with overlap of the other route. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteConflictOverlap: sig.ConflictingRoute
        {
             
        }  
    
        /** 
        The conflicting routes have TVP sections in common. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteConflictOverlappingTvpSections: sig.ConflictingRoute
        {
             
        }  
    
        /** 
        Route B conflicts with route A because a train approaching on route A may violate the gauge. 
fr-FR: enclenchement de convergence. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteConvergencyConflict: sig.ConflictingRoute
        {
            [XmlElementAttribute("appliesToPointElementInPosition", Order=1)]
            public tElementWithIDref appliesToPointElementInPosition {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToSignal", Order=2)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDurationForCheck", Order=3)]
            public rtmCommon.Duration hasDurationForCheck {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("mustCheck", Order=4)]
            public tElementWithIDref mustCheck {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        An abstraction of either a route entry or a route exit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.RouteEntry))]
        [XmlIncludeAttribute(typeof(sig.RouteExit))]     
        public abstract partial class RouteExtremity: sig.BaseObject
        {
            [XmlElementAttribute("isAssociatedWithSignal", Order=1)]
            public tElementWithIDref isAssociatedWithSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        List of sections included in the route body, ordered from entry to exit. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SectionList: sig.RouteBodyProperty
        {
            [XmlElementAttribute("hasSection", Order=1)]
            public List<tElementWithIDref> hasSection { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A route for maneuvering on occupied track. TVP sections are not checked for vacancy before calling this type of route. 
If section proving is required, use the extension of this class defined in the related section proving diagram. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.ShuntingRoute))]     
        public abstract partial class ShuntingRoute: sig.Route
        {
             
        }  
    
        /** 
        To capture detours by defining alternative, or backup routes via a given distinctive location. Hint to the signaller to visualize via which location (track, section or signal) the train will travel.
The location proxy is placed on the topology on the track, section or signal of the route body. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ViaLocation: sig.RouteBodyProperty
        {
            [XmlElementAttribute("leadsViaLocation", Order=1)]
            public tElementWithIDref leadsViaLocation;
                
             
        }  
    
        /** 
        The compound logical object is a fa&#231;ade to a system or device implementing Boolean logic. It can represent anything from a simple relay contact to complex relay circuitry or a PLC that converts high/low electric input signals from any source into Boolean true/false outputs. 
It can exchange binary i/o with the interlocking. 
The description attribute can contain textual description of the field elements and Boolean relations that produce the Boolean output.
Use this for ancillary equipment connected to the interlocking, e.g. bascule bridges, tunnel equipment, detectors such as earthquake and flooding detectors. Also useful for reading inputs from field activated level crossings.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class CompoundLogicalObject: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("Description", Order=1)]
            public String Description= "";
                
            [XmlElementAttribute("isImplementedByDetector", Order=2)]
            public List<tElementWithIDref> isImplementedByDetector { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A table of mutually conflicting routes, that is, routes that may never be simultaneously allocated, because they utilise common track elements (Iness definition).

Before setting the requested route, the interlocking will check whether any conflicting routes are allocated.

Specialised classes are available to store the reason of the conflict if needed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.RouteConflictOverlap))]
        [XmlIncludeAttribute(typeof(sig.RouteConflictOverlappingTvpSections))]
        [XmlIncludeAttribute(typeof(sig.RouteConvergencyConflict))]     
        public  partial class ConflictingRoute: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasConflictType", Order=1)]
            public RouteConflictTypes hasConflictType {get; set;} = new RouteConflictTypes();
                
            [XmlElementAttribute("hasConflictsWithRoute", Order=2)]
            public List<tElementWithIDref> hasConflictsWithRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requestedRoute", Order=3)]
            public tElementWithIDref requestedRoute;
                
             
        }  
    
        /** 
        A route <i>body </i>is a path with an entry and an exit. The path is a closed topological subset of the network, without any branches.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.RouteBody))]
        [XmlIncludeAttribute(typeof(sncf.RouteBody))]     
        public  partial class RouteBody
        {
            [XmlElementAttribute("hasEntry", Order=1)]
            public RouteEntry hasEntry {get; set;} = new RouteEntry();
                
            [XmlElementAttribute("hasExit", Order=2)]
            public RouteExit hasExit {get; set;} = new RouteExit();
                
            [XmlElementAttribute("refersToRsmRouteBody", Order=3)]
            public tElementWithIDref refersToRsmRouteBody {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("requiresMovableElementInPositionInDepartureTrack", Order=4)]
            public List<tElementWithIDref> requiresMovableElementInPositionInDepartureTrack { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresMovableElementInPositionInRouteBody", Order=5)]
            public List<tElementWithIDref> requiresMovableElementInPositionInRouteBody { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A signal that protects the entry of the route.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteEntry: sig.RouteExtremity
        {
            [XmlElementAttribute("hasGroupMainSignal", Order=1)]
            public tElementWithIDref hasGroupMainSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        A signal that prevents a train from entering track beyond the route body. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.RouteExit))]     
        public  partial class RouteExit: sig.RouteExtremity
        {
             
        }  
    
        /** 
        A route condition states the conditions that must be fulfilled for a given signal <i>or </i>route to open.
If the track asset or compound logical object<font color="#ff0000"> </font><i>is in the given state then </i>the signal in this route relation is set to proceed or to the given aspect. The routeRelation is the <i>observer </i>of the aspect and its state. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.ConditionAffectingRoute))]
        [XmlIncludeAttribute(typeof(sig.ConditionAffectingSignal))]     
        public abstract partial class RouteCondition: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("readsLogicalValueFromCompondLogicalObject", Order=1)]
            public List<tElementWithIDref> readsLogicalValueFromCompondLogicalObject { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("readsLogicalValueFromReleaseInstrument", Order=2)]
            public List<tElementWithIDref> readsLogicalValueFromReleaseInstrument { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("readsLogicalValueFromUiElement", Order=3)]
            public List<tElementWithIDref> readsLogicalValueFromUiElement { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The interlocking calls this route automatically and again, immediately after the train has cleared the route. The operator has to intervene if he wishes to call another route.
<ul>
 <li>German: Selbststellbetrieb</li>
</ul>
<ul>
 <li>French: trace permanent </li>
</ul>
<ul>
 <li>UK: autoworking </li>
</ul>
Note: When this functionality is part of the control system, use the class RouteAvailableInARS instead. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AutoRoute: sig.RouteProperty
        {
             
        }  
    
        /** 
        This route has a point that imposes a speed reduction. Once the train has cleared the point, the speed reduction no longer applies.
de-DE: Geschwindigkeitseinschraenkung aufgrund Mittelweiche. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class IntermediatePointRelatedSpeedUpgrade: sig.RouteProperty
        {
             
        }  
    
        /** 
        This route is available in an Automatic Route Setting (ARS) system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteAvailableInARS: sig.RouteProperty
        {
             
        }  
    
        /** 
        Indicates the priority of the route 
<ul>
 <li>when there is only one route from entry to exit, priority=0</li>
 <li>when there are multiple routes from entry to exit, the lowest number has highest priority. Alternative routes are numbered 1..n</li>
</ul>
This allows a control system to attribute priorities to route setting. Whether or not the control system auto-selects lower priority routes when no higher priority route is available, depends on national rules and regulations.
de-DE: Regelfahrstra&#223;e 0, Umfahrstra&#223;en 1...n 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RoutePriority: sig.RouteProperty
        {
            [XmlElementAttribute("value", Order=1)]
            public Int32 value {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Base class for additional route properties. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.AutoRoute))]
        [XmlIncludeAttribute(typeof(sig.IntermediatePointRelatedSpeedUpgrade))]
        [XmlIncludeAttribute(typeof(sig.RouteAvailableInARS))]
        [XmlIncludeAttribute(typeof(sig.RoutePriority))]
        [XmlIncludeAttribute(typeof(sig.RouteSetupTime))]
        [XmlIncludeAttribute(typeof(sig.RouteSpeedRestriction))]
        [XmlIncludeAttribute(typeof(sig.RouteTowardsTunnel))]
        [XmlIncludeAttribute(typeof(sig.RouteTractionType))]
        [XmlIncludeAttribute(typeof(sig.RouteWithReducedBrakingDistance))]
        [XmlIncludeAttribute(typeof(prorail.RouteSettingProperties))]     
        public abstract partial class RouteProperty: sig.BaseObject
        {
            [XmlElementAttribute("appliesToRoute", Order=1)]
            public tElementWithIDref appliesToRoute;
                
            [XmlElementAttribute("causesSpeedRestriction", Order=2)]
            public List<tElementWithIDref> causesSpeedRestriction { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The typical delay between the moment the operator calls this route and the moment the entry signal opens. 
This  parameter includes the response-time of many subsystems as well as point throwing time (the position of which is often unknown beforehand). This parameter is by nature stochastic.
This parameter is useful for simulation purposes and system performance analysis.
de-DE: Fahrstra&#223;enbildezeit
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteSetupTime: sig.RouteProperty
        {
            [XmlElementAttribute("hasSetupTime", Order=1)]
            public rtmCommon.Duration hasSetupTime {get; set;} = new rtmCommon.Duration();
                
             
        }  
    
        /** 
        Speed restriction resulting from external constraints that cannot be deduced from the elements situated along or associated with this route. For instance noise reduction or simplification of speed profiles.
Not to be used for speed restriction due to reduced braking distance. Use the class RouteWithReducedBrakingDistance instead. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteSpeedRestriction: sig.RouteProperty
        {
            [XmlElementAttribute("hasSpeedRestriction", Order=1)]
            public rtmCommon.Speed hasSpeedRestriction {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        This route leads towards a tunnel.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteTowardsTunnel: sig.RouteProperty
        {
             
        }  
    
        /** 
        The route is suitable for the given type of traction. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteTractionType: sig.RouteProperty
        {
            [XmlElementAttribute("isSuitableForTractionType", Order=1)]
            public RouteTractionTypes isSuitableForTractionType {get; set;} = new RouteTractionTypes();
                
             
        }  
    
        /** 
        The distance to the closed signal of this route is lower than usual, resulting in a shorter braking distance. This in turn can be signalled to the driver with a specific sequence of aspects (UK, NL, FR solution, pre-annonce) or an extra light (DE solution, Zusatzlicht).  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class RouteWithReducedBrakingDistance: sig.RouteProperty
        {
             
        }  
    
        /** 
        A shunting route can normally be activated even if one or more sections are not proven vacant. This class selects which sections must be proven vacant.
If no sections are needed vacant no ShuntingRouteSectionProving instance is created. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class ShuntingRouteSectionProving: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToShuntingRoute", Order=1)]
            public tElementWithIDref appliesToShuntingRoute;
                
            [XmlElementAttribute("needsVacantSection", Order=2)]
            public List<tElementWithIDref> needsVacantSection { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The overlap can only be activated when the block accepts the direction in which the route and thus the overlap are set. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DirectionAuthorityDependentOverlap: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToOverlap", Order=1)]
            public tElementWithIDref appliesToOverlap {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        An overlap can cause a speed restriction in the approach route. 
This class lists the overlaps for which the speed isn't upgraded when the exit signal opens.
For an overlap not in the list, the IL lifts the speed restriction when the exit signal opens. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NotUpgradeableSpeedRestriction: sig.BaseObject
        {
            [XmlElementAttribute("appliesToOverlap", Order=1)]
            public tElementWithIDref appliesToOverlap {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Unlocks the elements in the overlap.
The IL may release the overlap in the following situations:
<ul>
 <li>When the approaching train <i>has plausibly stopped</i> before the exit signal. In this case, the overlap release is delayed by a given duration: the timer is triggered when the train occupies or vacates a given section.</li>
 <li>When the approaching train <i>positively confirms to have stopped</i> (e.g. by means of an ETCS position report). In this case, the release is immediate or with a short delay.</li>
</ul> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class OverlapRelease
        {
            [XmlElementAttribute("hasOverlapReleaseDelay", Order=1)]
            public rtmCommon.Duration hasOverlapReleaseDelay {get; set;} = new rtmCommon.Duration();
                
            [XmlElementAttribute("isTriggeredBy", Order=2)]
            public tElementWithIDref isTriggeredBy {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("overlapReleaseCondition", Order=3)]
            public OverlapReleaseConditionTypes overlapReleaseCondition {get; set;} = new OverlapReleaseConditionTypes();
                
             
        }  
    
        /** 
        The safety distance must be specialised into either an overlap or a dangerpoint. It carries common attributes and relations.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.DistanceToDangerpoint))]
        [XmlIncludeAttribute(typeof(sig.Overlap))]     
        public abstract partial class SafetyDistance: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("endsAtLocation", Order=1)]
            public List<tElementWithIDref> endsAtLocation { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasDesignSlope", Order=2)]
            public rtmCommon.Gradient hasDesignSlope {get; set;} = new rtmCommon.Gradient();
                
            [XmlElementAttribute("hasMinimalLength", Order=3)]
            public rtmCommon.Length hasMinimalLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasTpDangerpoint", Order=4)]
            public tElementWithIDref hasTpDangerpoint;
                
            [XmlElementAttribute("isLocatedAt", Order=5)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("needsVacantSection", Order=6)]
            public List<tElementWithIDref> needsVacantSection { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        The dangerpoint defines the position beyond the exit signal up to where a train is likely to be safe.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class DistanceToDangerpoint: sig.SafetyDistance
        {
             
        }  
    
        /** 
        Overlap
de-DE: Durchrutschweg (D-Weg)
nl-NL: doorschietlengte 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Overlap: sig.SafetyDistance
        {
            [XmlElementAttribute("overlapRelease", Order=1)]
            public List<OverlapRelease> overlapRelease { get; set; } = new List<OverlapRelease>(); 
                
            [XmlElementAttribute("requiresCrossingElementLockedInPosition", Order=2)]
            public List<tElementWithIDref> requiresCrossingElementLockedInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresDerailerLockedInPosition", Order=3)]
            public List<tElementWithIDref> requiresDerailerLockedInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresFlankProtection", Order=4)]
            public List<tElementWithIDref> requiresFlankProtection { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresMovableElementLocked", Order=5)]
            public List<tElementWithIDref> requiresMovableElementLocked { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("requiresPointElementLockedInPosition", Order=6)]
            public List<tElementWithIDref> requiresPointElementLockedInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("speedRestrictionInApproach", Order=7)]
            public rtmCommon.Speed speedRestrictionInApproach {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("speedThroughOverlap", Order=8)]
            public rtmCommon.Speed speedThroughOverlap {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        An overlap section may, even though locked, be swung away from a conflicting route to provide a full-length overlap (source: INESS)
The swinging overlap typically contains a facing point (de-DE: Ruderweiche). This implies that 
<ol>
 <li>there are two possible overlaps associated with the closed exit signal and</li>
 <li>the signaller can swing the overlap between left and right (normal and reverse).</li>
</ol>
The swinging overlap must point to two limiting train detectors.
National rules and regulations govern when and how the facing point(s) can be thrown.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SwingingOverlap: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToOverlap", Order=1)]
            public tElementWithIDref appliesToOverlap {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Category for trains carrying freight or goods. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class FreightTrain: sig.TrainCategory
        {
             
        }  
    
        /** 
        Category for KVB speed-controlled trains.
This allows imposing speed limits per category. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class KvbTrain: sig.TrainCategory
        {
            [XmlElementAttribute("C", Order=1)]
            public Int32 C {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Category for trains carrying passengers. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class PassengerTrain: sig.TrainCategory
        {
             
        }  
    
        /** 
        A speed profile represents the maximum speed along a defined and delimited path through the railway network. 
The origin of the profile is situated at the signal plus a positive or negative offset.  
The profile has one or more of sections, each of given length and with given maximum speed. 
This approach is equivalent to the ETCS SSP. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TrainCategorySpeedProfile))]     
        public  partial class SpeedProfile: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("hasSpeedSegment", Order=1)]
            public List<tElementWithIDref> hasSpeedSegment { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A segment of a speed profile for which a constant speed applies.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TemporarySpeedRestriction))]
        [XmlIncludeAttribute(typeof(sig.TrainCategorySpeedRestriction))]     
        public  partial class SpeedSegment: sig.Segment
        {
            [XmlElementAttribute("hasMaximumSpeed", Order=1)]
            public rtmCommon.Speed hasMaximumSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("reasonForSpeed", Order=2)]
            public String reasonForSpeed= "";
                
             
        }  
    
        /** 
        A time-limited, i.e. temporary speed restriction.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TemporarySpeedRestriction: sig.SpeedSegment
        {
             
        }  
    
        /** 
        Category for trains equipped with a tilting mechanism. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TiltingTrain: sig.TrainCategory
        {
             
        }  
    
        /** 
        Category for trains equipped with Train Protection and Warning System. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TpwsTrain: sig.TrainCategory
        {
            [XmlElementAttribute("type", Order=1)]
            public String type= "";
                
             
        }  
    
        /** 
        Train category, such as freight, tilting, passenger, high speed. Can be expanded in national domains because ETCS category may not suffice. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.FreightTrain))]
        [XmlIncludeAttribute(typeof(sig.KvbTrain))]
        [XmlIncludeAttribute(typeof(sig.PassengerTrain))]
        [XmlIncludeAttribute(typeof(sig.TiltingTrain))]
        [XmlIncludeAttribute(typeof(sig.TpwsTrain))]     
        public abstract partial class TrainCategory: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        Speed profile that applies to a given train category. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrainCategorySpeedProfile: sig.SpeedProfile
        {
            [XmlElementAttribute("appliesToCategory", Order=1)]
            public List<tElementWithIDref> appliesToCategory { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A speed restriction that applies to a given train category. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrainCategorySpeedRestriction: sig.SpeedSegment
        {
            [XmlElementAttribute("appliesToTrainCategory", Order=1)]
            public List<tElementWithIDref> appliesToTrainCategory { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Area without train protection system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class AreaWithoutTps: sig.TpArea
        {
             
        }  
    
        /** 
        TPS Device using balise technology, e.g. euro balise, ATB NG or metro balises.
A balise is energised by a passing train antenna and returns a series of bits to the antenna. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsBalise))]
        [XmlIncludeAttribute(typeof(sncf.KvbBalise))]
        [XmlIncludeAttribute(typeof(trv.AtcBalise))]     
        public  partial class Balise: sig.TpsSpotDevice
        {
            [XmlElementAttribute("isSwitchable", Order=1)]
            public Boolean isSwitchable {get; set;} = new Boolean();
                
            [XmlElementAttribute("mountingInstructions", Order=2)]
            public String mountingInstructions= "";
                
             
        }  
    
        /** 
        A group of train protection balises. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroup))]
        [XmlIncludeAttribute(typeof(db.BaliseGroup))]     
        public  partial class BaliseGroup: sig.TpsDataTransmissionSystem
        {
            [XmlElementAttribute("hasPurpose", Order=1)]
            public BaliseGroupPurpose hasPurpose {get; set;} = new BaliseGroupPurpose();
                
             
        }  
    
        /** 
        Describes why the balise is there.
The balise group protects or announces the level crossing, big metal mass or signal that the train approaches.
de-DE: Bezugspunkt 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BaliseGroupPurpose
        {
            [XmlElementAttribute("direct", Order=1)]
            public Boolean direct {get; set;} = new Boolean();
                
            [XmlElementAttribute("hasDistance", Order=2)]
            public rtmCommon.Length hasDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("refersToBigMetalMassArea", Order=3)]
            public tElementWithIDref refersToBigMetalMassArea {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToLx", Order=4)]
            public tElementWithIDref refersToLx {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("refersToSignal", Order=5)]
            public tElementWithIDref refersToSignal {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Area with massive metal structures that are liable to adversely influence the TP systems. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class BigMetalMassArea: sig.TrackConditionArea
        {
             
        }  
    
        /** 
        Marks a <i>spot location</i> from where a quality like a speed, gradient or ATP control changes.  A<i> physical track side signal</i> may be present at this location. This signal need not be positioned exactly where the quality changes. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.SpeedChangeMarker))]
        [XmlIncludeAttribute(typeof(sig.TpMarker))]     
        public abstract partial class ChangeMarker: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesFrom", Order=1)]
            public tElementWithIDref appliesFrom {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesOverDistance", Order=2)]
            public rtmCommon.Length appliesOverDistance {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasTracksideSignal", Order=3)]
            public List<tElementWithIDref> hasTracksideSignal { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        A detonator creates an explosion to warn the driver about imminent danger ahead. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class Detonator: sig.TpsSpotDevice
        {
            [XmlElementAttribute("isActivatedByTreadle", Order=1)]
            public tElementWithIDref isActivatedByTreadle {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("type", Order=2)]
            public String type= "";
                
             
        }  
    
        /** 
        An area where traction current is limited. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class LimitedCurrentArea: sig.TrackConditionArea
        {
            [XmlElementAttribute("appliesToTrainCategory", Order=1)]
            public List<tElementWithIDref> appliesToTrainCategory { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("maxTractionCurrent", Order=2)]
            public Int32 maxTractionCurrent {get; set;} = new Int32();
                
             
        }  
    
        /** 
        Area where eddy current braking is prohibited. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NoEddyCurrentBrakeArea: sig.TrackConditionArea
        {
            [XmlElementAttribute("isOfProhibitionType", Order=1)]
            public EddyCurrentProhibitionTypes isOfProhibitionType {get; set;} = new EddyCurrentProhibitionTypes();
                
             
        }  
    
        /** 
        Area where stopping isn't allowed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NonStoppingArea: sig.TrackConditionArea
        {
            [XmlElementAttribute("description", Order=1)]
            public String description= "";
                
             
        }  
    
        /** 
        Area where regenerative braking isn't allowed. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NoRegenerativeBrakeArea: sig.TrackConditionArea
        {
             
        }  
    
        /** 
        National Train Control system as defined by ERA 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class NTC
        {
            [XmlElementAttribute("additionalInfo", Order=1)]
            public String additionalInfo= "";
                
            [XmlElementAttribute("nid_ntc", Order=2)]
            public Int32 nid_ntc {get; set;} = new Int32();
                
             
        }  
    
        /** 
        For speed checking configurations with a speed checking section (also known as Overspeed sensor, OSS) 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.PzbSpeedCheckingSystemProperties))]     
        public  partial class SpeedCheckingSystemProperties
        {
            [XmlElementAttribute("hasSpeedCheckingSectionLength", Order=1)]
            public rtmCommon.Length hasSpeedCheckingSectionLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasSpeedProperties", Order=2)]
            public List<SpeedProperties> hasSpeedProperties { get; set; } = new List<SpeedProperties>(); 
                
             
        }  
    
        /** 
        Properties of a speed checking system are design speed and, optionally, train category.
The results from the design process are stored for validation purposes.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class SpeedProperties
        {
            [XmlElementAttribute("appliesToTrainCategoryForAttainableSpeed", Order=1)]
            public tElementWithIDref appliesToTrainCategoryForAttainableSpeed;
                
            [XmlElementAttribute("appliesToTrainCategoryForDesignSpeed", Order=2)]
            public tElementWithIDref appliesToTrainCategoryForDesignSpeed;
                
            [XmlElementAttribute("hasAttainableSpeed", Order=3)]
            public rtmCommon.Speed hasAttainableSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("hasDesignSpeed", Order=4)]
            public rtmCommon.Speed hasDesignSpeed {get; set;} = new rtmCommon.Speed();
                
             
        }  
    
        /** 
        Area equipped with a train protection system for tilting trains. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TiltingArea: sig.TpArea
        {
             
        }  
    
        /** 
        Area equipped with a Train Protection (TP) System.
If different directional TP systems are used in an area (border area), directional area locations must be created. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsArea))]
        [XmlIncludeAttribute(typeof(sig.AreaWithoutTps))]
        [XmlIncludeAttribute(typeof(sig.TiltingArea))]
        [XmlIncludeAttribute(typeof(db.ZbsArea))]     
        public  partial class TpArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("nid_ntc", Order=2)]
            public Int32 nid_ntc {get; set;} = new Int32();
                
             
        }  
    
        /** 
        A mark from where Train Protection applies a (different) restriction. 
Use the inherited Description to annotate the ATP area demarcation (entry or exit point).
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsMarker))]
        [XmlIncludeAttribute(typeof(sig.TpTransitionMarker))]     
        public abstract partial class TpMarker: sig.ChangeMarker
        {
            [XmlElementAttribute("fromNtc", Order=1)]
            public NTC fromNtc {get; set;} = new NTC();
                
            [XmlElementAttribute("transitFromEtcsLevel", Order=2)]
            public EtcsLevelTypes transitFromEtcsLevel {get; set;} = new EtcsLevelTypes();
                
             
        }  
    
        /** 
        System for transmitting train protection data. Also known as <i>Information Point.</i> 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BaliseGroup))]
        [XmlIncludeAttribute(typeof(prorail.AtbVvInstallation))]     
        public  partial class TpsDataTransmissionSystem: sig.VirtualTrackAsset
        {
            [XmlElementAttribute("hasControllerHousedIn", Order=1)]
            public tElementWithIDref hasControllerHousedIn {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Property set that applies to the TPS data transmission system. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.EtcsBaliseGroupProperties))]
        [XmlIncludeAttribute(typeof(nr.AwsSystemProperties))]
        [XmlIncludeAttribute(typeof(nr.TpwsSystemProperties))]
        [XmlIncludeAttribute(typeof(sncf.CrocodileSystemProperties))]
        [XmlIncludeAttribute(typeof(sncf.KvbSystemProperties))]     
        public  partial class TpsDataTransmissionSystemProperties: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTpsDataTxSystem", Order=1)]
            public tElementWithIDref appliesToTpsDataTxSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasExtensionDirection", Order=2)]
            public ExtensionDirectionTypes hasExtensionDirection {get; set;} = new ExtensionDirectionTypes();
                
            [XmlElementAttribute("hasExtensionLength", Order=3)]
            public rtmCommon.Length hasExtensionLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasPowerSupplyType", Order=4)]
            public TpsPowerSupplyTypes hasPowerSupplyType {get; set;} = new TpsPowerSupplyTypes();
                
            [XmlElementAttribute("hasSpeedCheckingProperties", Order=5)]
            public SpeedCheckingSystemProperties hasSpeedCheckingProperties {get; set;} = new SpeedCheckingSystemProperties();
                
            [XmlElementAttribute("hasSuppressionDirection", Order=6)]
            public SuppressedDirectionTypes hasSuppressionDirection {get; set;} = new SuppressedDirectionTypes();
                
            [XmlElementAttribute("isSuppressedWhenPointElementInPosition", Order=7)]
            public List<tElementWithIDref> isSuppressedWhenPointElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("isSwitchable", Order=8)]
            public Boolean isSwitchable {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Properties of a TPS device. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(db.PzbDeviceProperties))]     
        public  partial class TpsDeviceProperties: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTpsDevice", Order=1)]
            public tElementWithIDref appliesToTpsDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasLength", Order=2)]
            public rtmCommon.Length hasLength {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasPowerSupplyType", Order=3)]
            public TpsPowerSupplyTypes hasPowerSupplyType {get; set;} = new TpsPowerSupplyTypes();
                
             
        }  
    
        /** 
        A loop transmitting train protection information. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(prorail.AtbLoop))]     
        public  partial class TpsLinearDevice: sig.TpsDevice
        {
            [XmlElementAttribute("isLineLocatedAt", Order=1)]
            public tElementWithIDref isLineLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        The distance to a protected location that the TPS needs to halt a train. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TpsProtectionDistance: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToSignal", Order=1)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("value", Order=2)]
            public rtmCommon.Length value {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Informs at what distance the TP device or system is placed on approach to the signal. 
The signal could be a speed restriction board (NR approach). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.KvbRelation))]     
        public  partial class TpsRelation: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToBufferStop", Order=1)]
            public tElementWithIDref appliesToBufferStop {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToRelatedSignal", Order=2)]
            public List<tElementWithIDref> appliesToRelatedSignal { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("appliesToSignal", Order=3)]
            public tElementWithIDref appliesToSignal {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTpsDataTxSystem", Order=4)]
            public tElementWithIDref appliesToTpsDataTxSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTpsDevice", Order=5)]
            public tElementWithIDref appliesToTpsDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDistanceFromTpsToSignal", Order=6)]
            public rtmCommon.Length hasDistanceFromTpsToSignal {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        A TPS device of limited length. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.Balise))]
        [XmlIncludeAttribute(typeof(sig.Detonator))]
        [XmlIncludeAttribute(typeof(db.PzbDevice))]
        [XmlIncludeAttribute(typeof(nr.ApcMagnet))]
        [XmlIncludeAttribute(typeof(nr.AtpBeacon))]
        [XmlIncludeAttribute(typeof(nr.AwsMagnet))]
        [XmlIncludeAttribute(typeof(nr.TpwsDevice))]
        [XmlIncludeAttribute(typeof(nr.TrainStop))]
        [XmlIncludeAttribute(typeof(nr.TripcockTester))]
        [XmlIncludeAttribute(typeof(prorail.AtbngBeacon))]
        [XmlIncludeAttribute(typeof(prorail.AtbvvBeacon))]
        [XmlIncludeAttribute(typeof(sncf.Crocodile))]     
        public  partial class TpsSpotDevice: sig.TpsDevice
        {
             
        }  
    
        /** 
        A spot on the track where a train enters the control area of a another TP system.
de-DE: Bereichsgrenze.
nl-NL: puntafbakening van het beinvloedingsgebied. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TpTransitionMarker: sig.TpMarker
        {
             
        }  
    
        /** 
        An area where a particular track condition applies. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.BigMetalMassArea))]
        [XmlIncludeAttribute(typeof(sig.LimitedCurrentArea))]
        [XmlIncludeAttribute(typeof(sig.NoEddyCurrentBrakeArea))]
        [XmlIncludeAttribute(typeof(sig.NonStoppingArea))]
        [XmlIncludeAttribute(typeof(sig.NoRegenerativeBrakeArea))]     
        public abstract partial class TrackConditionArea: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("isLocatedAt", Order=1)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        TP devices can be train-selective. The TPS transmits information to the train such that only  "suitable" trains are allowed through. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
             
        public  partial class TrainSelectionProperties
        {
            [XmlElementAttribute("appliesToTpsDevice", Order=1)]
            public tElementWithIDref appliesToTpsDevice {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("selectionDescription", Order=2)]
            public String selectionDescription= "";
                
             
        }  
    
        /** 
        Device that transmits train protection information to a passing train.
This class can be instantiated if the device is not (yet) planned and located in detail. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/Signalling")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/Signalling",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sig.TpsLinearDevice))]
        [XmlIncludeAttribute(typeof(sig.TpsSpotDevice))]     
        public  partial class TpsDevice: sig.PhysicalTrackAsset
        {
            [XmlElementAttribute("implementsTpsDataTxSystem", Order=1)]
            public tElementWithIDref implementsTpsDataTxSystem {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("isLocatedAt", Order=2)]
            public tElementWithIDref isLocatedAt {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("positionInSystem", Order=3)]
            public Int32 positionInSystem {get; set;} = new Int32();
                
             
        }  
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum BlockCircuitryTypes : int {
        /*  */_3wire,/* nl-NL: 4-draads APB */_4wire,/*  */_6wire,/*  */_8wire,/*  */_9wire,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum BlockSettingTypes : int {
        /* The block element automatically sets the block when the next train needs to be sent and the block is normalised. */automatic,/* When the block normalises, the block element that received the train automatically reverts the setting to the sending block element. 

SNCF: there's a normal, preferred direction setting. If a train in the opposite direction has cleared the block, the setting automatically reverts to the preferred direction. fr-FR: installation permanente de contresens. (IPCS) */automaticReversal,/* The system requests the claim whilst the block is still occupied. As soon as the block is normalised the block element gets the block. E.g. preselection of setting. */storesRequest,/* The block element permanently claims the block. This disallows bidirectional traffic. */permanent,/* The signaller at one block element must explicitly set the block. */manual
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LineBlockWorkingTypes : int {
        /* Dual track, each track is equipped for bidirectional traffic.
<ul>
 <li>de-DE: zweigleisig, Gleiswechselbetrieb (GWB)</li>
 <li>fr-FR: voie banalis&#233;e</li>
 <li>it-IT: linea banalizato</li>
</ul> */dualTrackBidirectional,/* Single-track operation equipped for bidirectional operation. */singleTrackBidirectional,/* Simplified procedural movement authority without technical block protection.
de-DE: Zugleitbetrieb */proceduralWorking,/* Single-track operation equipped for one-directional operation.
May be used in rare cases for describing a run-round loop at the end of a line.
de-DE: eingleisig */singleTrack,/* Dual-track operation.
Each track is used in one direction only.
de-DE: zweigleisig */dualTrack,/* Dead-end track that is claimed by a single train and then remains claimed until it returns.
de-DE: Stichstreckenblock */deadEnd,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum AccessabilityTypes : int {
        /* Access is restricted to IM staff only, i.e. those holding a key to open the box that houses the key release instrument. */imOnly,/* Access is not restricted. All railway staff (operators, drivers) can have access. */notRestricted,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LevelCrossingActivationTypes : int {
        /*  */locallyMonitored,/*  */locallyMonitoredOptimisedActivation,/*  */mainSignalProtected,/*  */selfSupervised
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LocalOperatingZoneLimitTypes : int {
        /* Interlocking area 
de-DE: STW-Bereich  */interlockingOperatedArea,/* Another local operating zone (that can be taken/given locally)
de-DE: NB-Zone */localOperatingZone,/* the adjacent area is permanently under local operation, i.e. it has no interlocking.
de-DE: Ortsstellbereich */permanentLocallyOperatedArea,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LocalOperatingZoneRelationTypes : int {
        /* Zone A is superordinate to B (which implies that B is subordinate to A).
 */zoneAIsSuperordinateOfB,/* Zones A and B overlap. */zonesOverlap,/* Zone A is subordinate to B (which implies that B is superordinate to A). */zoneAIsSubordinateOfB,/* Zones A and B can merge. */zonesMergeable,/* Other relation between zones A and B.
de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LocalOperationDeviceTypes : int {
        /* A vertical panel.
de-DE: Tafel */panel,/* An inclined panel.
de-DE: Pult
en-UK: part of the UI where the interactive UI elements are. 
 */console,/* A vertical column with integrated control elements.
de-DE: S&#228;ule */column,/* A small panel, can be portable.
de-DE: Tablett */tablet,/* A set of levers, typically used to throw switch blades and (dis-)engage point locks.
en-GB: ground frame */leverFrame,/* de-DE: sonstige */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum UiElementFunctionTypes : int {
        /* Request local control. When the signalman grants local control and safety conditions are met, the interlocking hands over local control of the local operating zone.  */request,/* Hand back local control to interlocking.
Once pressed, the signalman and interlocking can take back control of the local area.
de-DE: Fertigmeldetaste. */finished,/* Request local control over (group of) point(s). 
Another button or switch is foreseen for throwing the point(s).
de-DE: Weichengruppentaste, notwendig um Weiche um zu stellen innerhalb NB welche sonnst von Stw bedient wird. */localPointOperation
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PowerSupplyTypes : int {
        /* To be used if the controller is not available or cannot be specified.
 */otherController,/* Battery, not to be confused with UPS. */battery,/* uninteruptable power supply. The UPS is connected to the main grid and continues to work for some time when the mains fail. */ups,/* level crossing installations supplying power (DB) */levelCrossing,/* overhead line or third rail, normally used for traction, is used for supplying power to the controller. */tractionSupply,/* a power grid dedicated to railway signalling */railwayPowerSupply,/* national grid */nationalPowerSupply,/* permanent power generator. */generator,/* socket to which an external power supply, typically a portable generator, can connect. */generatorConnection,/* other technologies like solar, fuel cell, geothermal, pneumatic, hydraulic */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PlatformAccessTypes : int {
        /*  */staircase,/* Access via the station hall. */stationBuilding,/*  */lift,/* Inclined pathway. */ramp,/* a walkway crossing at the level of the rails, for accessing a platform situated between two tracks. 
DE: Resi, Reisendensicherungsanlage (von Bahnpersonal gesperrt und in Stellwerkslogik eingespeist).
UK: barrow crossing (not in use anymore) */railCrossingWalkway,/*  */escalator,/* A walkway at rail level for accessing a platform, not crossing any tracks. */walkway,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ControlModes : int {
        /* The element is operated on site by means of a nearby control panel or lever (en-UK: ground frame). */local,/* An interlocking normally controls the element, even when the element can be taken over for local working e.g. shunting. */remote,/* Used for a crossing without switchable diamond. */notMovable,/* No longer in service, partly removed (e.g. in France, the drive is removed), yet some iron is left. */decommissioned,/* some other control mode. */other,/* The control mode is unknown. */undetermined
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum CrossingTypes : int {
        /* A crossing without slip junctions. */simple,/* A single slip junction. */singleSlip,/* A double slip junction. */doubleSlip,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum DiamondComponentSide : int {
        /* One half of the (movable) diamond in a crossing. */componentA,/* One half of the (movable) diamond in a crossing. */componentB
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum MechanismTypes : int {
        /* Actuated electrically */electric,/* Power is transmitted via wires or bars over larger distances. */mechanical,/* Power provided by hydraulics. */hydraulic,/* Power provided by pneumatics. */pneumatic,/* Local manual operation by hand-pulled levers. Forces can be transmitted by rods but over a short distance. When forces are transmitted over longer wires and rods, powering is considered mechanical.
 */handOperated,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum MovableElementOperatingModes : int {
        /* This is the default, i.e. not fixed in a given position. */notFixed,/* Actuation is prevented by 
<ul>
 <li>a plug that prevents the interlocking from moving the element (de-DE: Betriebsartenstecker)</li>
 <li>unplugging power</li>
 <li>removing the drive.</li>
</ul> */fixedElectrically,/* The element is kept in place mechanically. The fixation is described by the clampType attribute.
 */fixedMechanically,/* The point is fixed, both electrically and mechanically. 
The mechanical fixation is described by the clampType attribute. */fixedMechanicallyAndElectrically
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum NormalisationTypes : int {
        /* The interlocking throws the point to the normal position automatically. */automatic,/* The signalman receives a notification that the point has been cleared. After manual acknowledgment the interlocking throws the point to the normal position.
 */manual,/* A spring or hydro-pneumatic mechanism restores the point to normal position after trailing.
<ul>
 <li>en-GB: spring point</li>
 <li>de-DE: R&#252;ckfallweiche </li>
</ul> */spring
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PointIndicatorTypes : int {
        /*  */backlit,/*  */reflective
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PointTypes : int {
        /* A simple point.
de-DE: EW (einfache Weiche) */simple,/* A simple point with contrary flexure geometry.
de-DE: Aussenbogenweiche */contraryFlexure,/* A simple point with similar flexure geometry.
de-DE: Innenbogenweiche */similarFlexure,/* A simple point with clothoid geometry.
de-DE: Klotho&#239;denweiche */clothoid,/* Point that can cause a derailing when in protecting position. This point has no nose. */trap,/* a three-centered curved point
de-DE: Korbbogenweiche */threeCentered,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum SignalFrameTypes : int {
        /* main frame of the signal; a signal can have several main frames
SNCF: chassis-lampe, RFI: vela, DB: Schirm, PR: lamphuis, NR: signal housing. */main,/* simple plate that displays the label of a signal. The text value can be taken from the associated designation.  Alternatively, the name can be given as text information that is part of the aspect. */namePlate,/* a (passive, metal) plate showing a <i>fixed </i>aspect, For instance a painted or lit letter P, W or S, speed limit numeral or a written message like "call signalman" (refer to aspect for the meaning). 
An (ETCS) stop marker board is a sign. */sign,/* a wooden or concrete structure for marking fouling or clearance points (FR: garage franc, NL: grensteken) */slab,/* used e.g. by DB for marking fouling points (DB Grenzzeichen). */ceramicBody,/* switchable frame designed to show supplementary aspect information, e.g. <i>speed</i>, <i>direction </i>information, tunnel approach, or the french oeuilleton (degraded situation).  */indicator,/* a frame showing shunting aspects only. */shunting,/* pattern painted on the signal pole that sends a message to the driver (Zebra pattern in Italy). */paintedPost,/* a repeater signal is usually smaller. Refer to the aspect for the meaning of a repeater signal. The repeater signal is not considered a subordinated signal.  */repeater,/* This frame is designed to display a restricted movement authority, e.g. in degraded situations when the normal aspect cannot be displayed.
RFI: two white or blue flashing lights.
SNCF: oeuilleton maps to indicator because it belongs to the main frame. */auxiliary,/* This frame is designed to display a restricted movement authority that applies when the normal signal aspect cannot be displayed. RFI: two flashing white or blue lamps. See <i>Aspect </i>for the exact <i>meaning</i> of this aspect. */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum AspectDeactivationTypes : int {
        /* The deactivation of this aspect is triggered by a technical condition (e.g. occupation of a section).
The trigger is the same for all technically triggered aspects of the same signal. */technicallyTriggered,/* The deactivation of this aspect is triggered by a timer.
The trigger is the same for all technically triggered aspects of the same signal.
 */timeTriggered,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum AutomaticTypes : int {
        /* de-DE: Signalselbststellbetrieb  */autoworking,/* Controlled by automatic route setting system 
de-DE: Zuglenkung). */subjectToARS,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum IlluminationTypes : int {
        /* Aka flood lit. */frontLit,/* Aka internally lit */backLit,/*  */reflectorised
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LuminosityTypes : int {
        /* Light intensity is permanently high. */permanentlyHigh,/* Light intensity is permanently low. */permanentlyLow,/* Light intensity can be switched. High during day and low during the night. */switchable
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum NonStopMovementAllowedTypes : int {
        /* The train is to stop, only after which the signal is opened for a follow-on route.
 */disallowed,/* A route beyond the signal may be called together with the previous route so that the train can proceed without stopping. */allowed,/* The train is allowed to proceed with a shunting route.

Ist betrieblich die Weiterfahrt einer Zugfahrt als Rangierfahrt zu gestatten  */nextIsShunting
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum RouteCategoryTypes : int {
        /*  */Main,/*  */Shunting,/*  */OnSight
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum MathematicalOperators : int {
        /*  */and,/*  */or,/* E.g. NOT (W23A, left) */not,/*  */before,/*  */after,/* logically identical to AND */until
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum MovableElementPassableTypes : int {
        /*  */passable,/*  */nonPassable
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LxStateTypes : int {
        /* Barrier position is unknown.  */unknown,/* Barriers are confirmed open to road traffic. */open,/* Barriers are confirmed closed to road traffic. */closed,/* Barriers have been ordered to open but haven't reported open yet.  */opening,/* Barriers have been ordered to close but haven't been confirmed closed yet.  */closing,/* The level crossing activation process has been triggered. */activated,/* The level crossing deactivation process has been triggered. */deactivated,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ProvingTypes : int {
        /* The proving is continuous (typical situation).
For expressions like "the derailer is continously proven in position nonDerailing". */continuously,/* The condition is proven only during the activation.
For expressions like "the interlocking opens signal S when point X is proven in position left but doesn't close the signal when the point is no longer proven"
en-UK: when cleared. */oneOff,/* Personnel must observe and acknowledge the state of the asset (because the system cannot technically acquire information from the asset)
E.g. the driver reports that a point is in a given position, upon which the system issues a movemement authority.
May be used for Track Ahead Free (TAF) where the driver acknowledges that a section ahead is vacant. */staffAcknowledged,/* The condition is never proven, there is no need to detect the state of the asset. 
This allows stating expressions like "point X <b><i>should </i></b>be in position right" (A route requests the point position but if the point cannot take the requested position, then the route can be locked anyway).
nl-NL: verzoekwissel.  */none
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum DerailingPositionTypes : int {
        /* The derailer is engaged and will derail a passing train.  */derailing,/* The derailer is not engaged and will not derail a passing train. */notDerailing
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum SectionVacancyTypes : int {
        /*  */occupied,/*  */vacant
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum FixingTypes : int {
        /* Substructure foundation. */foundation,/* Ground or pile. A pile is a very lightweight mounting structure without any foundation. Commonly used for clearance point markers.
 */groundOrPile,/*  */sleeper,/* Rail mounting is often used for temporary signs. */rail,/*  */bufferStop,/*  */wall,/* A post is a permanent structure with a solid foundation. */post,/*  */shortPost,/* A pole is a lightweight mounting structure with a simple or even without a foundation. Alternative, more common choice, is the post. Simple passive signs could be mounted on poles. */pole,/* DB: Signalbruecke
SNCF: portique
RFI: portale */gantry,/* DB: Signalausleger
SNCF: potence
RFI: sospensione */cantilever,/* A cantilever covering two lines. */cantileverTwoLines,/* A cage protects the signal and track maintenance workers from the overhead line.
Alternative choice is a mesh. */cage,/* A mesh protects the signal and track workers from the overhead line. Alternative choice is a cage which is an almost closed mesh. */mesh,/* Fixed to a platform. The platform itself is modelled by means of <a href="$element://{C4DE174C-A184-4231-B5B7-7972B57E8A9C}"><font color="#0000ff"><u>a different class</u></font></a>. */platform,/* A custom made construction in case one cannot use one of the standard fixing types. */specialConstruction,/* The frame or signal is attached to a roof, e.g. a platform roof. Alternative choices are wall (e.g. for tunnel) or bridge. */roof,/*  */bridge,/* en-UK: dropper
de-DE: Signalkorb 
fr-FR: nacelle */suspensionStructure,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum BufferStopTypes : int {
        /* Firmly fixated to the earth */fixated,/* The impact of a train is dissipated by friction, e.g. the train pushes the buffer stop some way along the track. */friction,/* The impact energy of the train is dissipated by a hydraulic piston. */hydraulic,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ConductorVoltageTypes : int {
        /* 1200 Volt Direct Current */DC1200V,/* 750 VDC third rail */DC750V,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum DerailmentContainmentLocationTypes : int {
        /* Containment to the left. */left,/* Containment to the right. */right,/* Containment between the rails (derailment plinth) */centre,/* Containment to either side of the track. */both
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum OverheadLineGapTypes : int {
        /* Separates two AC electrification sections with different phases. */phaseLock,/* Separates two electrified sections with different voltages. */voltageLock
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum TractionVoltageTypes : int {
        /* 25000 V Alternating Current 50 Hertz */AC25kV_50Hz,/*  */DC1500V,/* 15000 Volt AC 17,7 Hz */AC15kV_16_7Hz,/*  */DC2400V,/*  */DC3000V,/* 750V DC overhead catenary line */DC750V,/* choose other if there is a specialisation in the national domain  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum VehicleStopTypes : int {
        /* For traversal., turntable, crossed sleepers.
de-DE: Schiebeb&#252;hne */other,/*  */ferryTerminal,/* Ramp at the end of track for loading cars. */headRamp,/* A wedge fixed to the rails at the end of the track that keeps cars from rolling away. */scotchBlock
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ProjectPhaseTypes : int {
        /*  */toBuild,/*  */asBuilt
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ResetStrategyTypes : int {
        /* FC-C, Force section status to clear, conditional */fc_c,/* FC-P, Force section status to clear, preparatory */fc_p,/* FC-P-A, Force section status to clear, preparatory, with acknowledgement */fc_p_a,/* FC-U, Force section status to clear, unconditional */fc_u
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum TcBondTypes : int {
        /* de-DE: Kurzschlussverbinder */shortCircuit,/* de-DE: S_Verbinder */bondSForm,/* de-DE: Endverbinder */termination,/* de-DE: Endverbinder modifiziert */terminationBondModified,/* de-DE: Ueberlagerungsverbinder */overlapping,/* de-DE: Potentialausgleichsverbinder */potentialEqualisation,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum TcFeederReceiverTypes : int {
        /* UK: letter R
FR: letters Re(cepteur) */receiver,/* UK: letter F(eed)
 */transmitter,/* audio frequency receiver
UK: letters RX
FR: Re(cepteur) */receiverWithTuner,/* audio frequency transmitter 
FR: Em(etteur)
UK: TX */transmitterWithTuner,/* A track side receiver attached to a loop in the track.
FR: reception sur boucle */receiverWithLoop
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LeftRight : int {
        /*  */left,/*  */right
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LeftRightCentreTypes : int {
        /*  */left,/*  */right,/* position of the  */centre
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LineSideDetectorTypes : int {
        /* Detects an overheating bearing in a passing axle box. */hotAxleBox,/* Detects blocked brakes. */fixedBrakes,/* Detects avalanches and/or rock-fall. */avalanche,/* Detects flooded tracks. */flooding,/* Seismometer detecting earthquakes */earthQuake,/* Detects fire and/or smoke. */fireAndSmoke,/* Detects high winds from the side. */lateralWind,/* Warns about the presence of dangerous compounds near a chemical industry site. */chemical,/* Detects vehicle fallen on the track from a bridge or embankment. */fallenVehicle,/* Detects non-round wheels */flatWheel,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum MaterialTypes : int {
        /* wood */timber,/* beton */concrete,/* steel sleepers are incompatible with track circuits */steel,/* plastic
DE: Kunststoff
NL: kunststof
FR: mati&#232;re plastique  */synthetic,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum OperatorPosition : int {
        /*  */left,/*  */right,/*  */far,/*  */near
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum StrandTypes : int {
        /*  */pair,/*  */quad,/*  */single
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EtcsBaselines : int {
        /* Baseline 2, also known as SRS 2.3.0d 
 */B2,/* Baseline 3, which includes Limited Supervision */B3,/*  */B4
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EtcsBaselineVersions : int {
        /*  */MR1,/*  */MR2,/*  */MR3,/*  */R1,/*  */R2,/*  */R3
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EtcsBlockageExitTypes : int {
        /*  */yes,/*  */no,/*  */regular
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EtcsLevelTypes : int {
        /* ETCS Level 0 
E.g. shunting area on HSL Zuid (NL) */level0,/*  */level1,/* ETCS Level 1 Limited Supervision.
de-DE: ESG - ETCS Signalgef&#252;hrt.
 */level1Ls,/* Level 2 without lateral light signalling.
This includes areas that have light signals at the level transitions and/or some yard signals. */level2WithoutLightSignals,/*  */level2WithLightSignals,/*  */level3,/*  */level3Hybrid,/* This area has a national train control system. */levelNtc
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EtcsSystemVersions : int {
        /* 1.0 */_10,/* 1.1 */_11,/* 1.2 */_12,/* 2.0 */_20,/* 2.1 */_21
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LeuModuleClassificationTypes : int {
        /* Parallel use with legacy systems like PZB. The PZB contacts feed into the LEU which converts it into balise telegrams.
Can be used to replace or overlay the PZB. This LEU module has a reduced function set. */parallel,/* Full standard LEU functionality, including current sensing. 
de-DE: voll */standard,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LeuRelativePositionTypes : int {
        /* The cabinet is placed at or attached to the signal post. */at,/* The cabinet is behind the signal, viewed from the signal's application direction. */behind,/* The cabinet is in front of the signal, viewed from the signal's application direction. */inFront
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum LinkReactionTypes : int {
        /*  */trainTrip,/* Link reaction types as per SRS. */serviceBrake,/*  */noReaction,/* Only report the missed balise. This doesn't exclude that other reactions also report the balise.
de-DE: Meldereaktion */report
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum NominalVoltageTypes : int {
        /*  */AC110,/*  */AC230,/*  */AC400,/*  */DC110,/*  */DC136,/*  */DC24,/*  */DC36,/*  */DC48,/*  */DC60,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum Orientation : int {
        /*  */normal,/*  */reverse,/*  */none
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PlanningPhase : int {
        /*  */asBuilt,/*  */planned,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum SignalFallbackTypes : int {
        /* The signal aspect is a fall-back aspect.
de-DE: Rueckfall  */fallback,/* The aspect is only shown as fall-back, i.e. not in normal operation. */fallbackOnly,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum SpecialConditionTypes : int {
        /* Default telegram is sent when the switchable balise is disconnected. */defaultTelegram,/* For fixed data balises.
de-DE: Festdatenbalise */fixedTelegram,/* Failure telegram sent by the LEU. */failureTelegram,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ZbsLinkingTypes : int {
        /* Normal linking 
de-DE: Grundverkettung */normal,/* Auxiliary linking if normal linking is insufficient.
de-DE: Hilfsverkettung */auxiliary
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PowerSourceTypes : int {
        /*  */fuelCell,/*  */generator,/*  */solar,/*  */traction,/*  */nationalGrid,/* E.g. a voltage for switching gear */railwayGrid,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum PowerSupplyModuleType : int {
        /*  */autonomous,/*  */autonomousSmall,/*  */gridConnected,/* de-DE: PoP-V  */pointOfPower,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum CheckCodeTypes : int {
        /* None */optionA,/* CRC32 with polynomial 0x EE5B42FD */optionB,/* CRC32 with polynomial 0x 1EDC6F41 */optionC,/* CRC16 with polynomial 0x 1021 */optionD,/* CRC16 with polynomial 0x 8005 */optionE
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EulynxSciTypes : int {
        /* Interface to light signal */ls,/* Interface to external level crossing system */lx,/* Interface to subsystem level crossing */lc,/* Interface to point. */p,/* Interface to train detection system. */tds,/* Interface to (binary) input/output */io,/* Interface to Radio Block Centre. */rbc,/* Interface to adjacent interlocking system */ils,/* Interface to Command &amp; Control system. */cc,/* Interface to trackworker safety system */tss
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum AlarmTypes : int {
        /*  */claxon,/*  */siren,/*  */yodalarm,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum RouteConflictTypes : int {
        /* The requested route always conflicts with the referred route(s).
de-DE: Gegenfahrtausschluss besteht */permanent,/* Conflict only exists when the berthing track is vacant, the shunting unit hasn't yet reached the berthing track.
de-DE:  Inselgleis_frei: Gegenfahrtausschluss besteht, wenn die Gegenrangierfahrt das Inselgleis noch nicht belegt hat */berthingTrackVacant,/* The routes never conflict.
de-DE: Gegenfahrtausschluss besteht nicht. */never
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum TargetTrackConditionTypes : int {
        /* Target track of the shunting route must be vacant.
de-DE: Zielgleis Rangierstrasse muss frei sein. */targetTrackVacant,/* Target track of the shunting route must be occupied.
de-DE: Zielgleis Rangierstrasse muss besetzt sein. */targetTrackOccupied,/*  */other
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum RouteTractionTypes : int {
        /* Suitable for electric traction. */fullyElectrified,/* The route (or parts of it) is not electrified. This route is permissible for non-electric vehicles only.
<ul>
 <li>de-DE: F-Bedienung</li>
</ul>
<ul>
 <li>nl-NL: Dieseltractie</li>
</ul>
<ul>
 <li>fr-FR: Thermique</li>
</ul>
Note: this is a static property and does not take into account whether traction power can be switched off. */notFullyElectrified
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum OverlapReleaseConditionTypes : int {
        /* Overlap release timer starts when train occupies the TVP section, normally the berthing track.
de-DE: Zielgleis
 */startTimerUponOccupation,/* Overlap release timer starts when train clears the TVP section. 
Typically used in reversing scenarios. */startTimerAfterVacating,/* Trackside releases the overlap only after train is proven in standstill by ETCS system or by a manual command.
de-DE: Aufl&#246;sung nach Stillstand des Zuges, z.B. ETCS */trainInitiatedTrigger
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum EddyCurrentProhibitionTypes : int {
        /* The brake may only be used for emergency braking. */emergencyOnly,/* The brake may never be used. */fullProhibition
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum ExtensionDirectionTypes : int {
        /* Same direction as linear element. */nominal,/* Opposite direction to linear element. */opposite,/* Spot without length (e.g. single balise). */none,/* The extension direction is (yet) unknown. */unknown
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum SuppressedDirectionTypes : int {
        /* Suppression takes place in the same direction as the application direction of the device spot location. */sameDirection,/* Suppression takes place in the opposite direction as the application direction of the device spot location. */oppositeDirection,/* A special suppression is selected for normal direction (NR). */special
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/Signalling")]
    public enum TpsPowerSupplyTypes : int {
        /* IL supplies power. */interlocking,/* battery only. */battery,/* solar (always have batteries included). */solar,/*  */other
    }
    
} 
            