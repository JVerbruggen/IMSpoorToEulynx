 
using System; 
using System.Collections.Generic; 
using System.Text; using System.IO; 
using System.Xml.Serialization; 
using System.Linq;
     
using Models.TopoModels.EULYNX.rtmCommon;
     
using Models.TopoModels.EULYNX.dp;
     
using Models.TopoModels.EULYNX.sig;
     
using sncf = Models.TopoModels.EULYNX.sncf;

namespace Models.TopoModels.EULYNX.sncf {
    
        /** 
        Signal fictif. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class FictitiousSignal: sig.FictitiousSignal
        {
            [XmlElementAttribute("hasFunction", Order=1)]
            public FictitiousSignalFunctionTypes hasFunction {get; set;} = new FictitiousSignalFunctionTypes();
                
             
        }  
    
        public partial class SignallingEntities
        {
            internal string AddObject(Object myObject, string id = null)
            {
                switch (myObject)
                {
                
                    case sncf.OpposingRouteLocking myOpposingRouteLocking:
                        if (!ownsOpposingRoute.Contains(myOpposingRouteLocking)) ownsOpposingRoute.Append(myObject);
                        break;
                
                    case sncf.Transit myTransit:
                        if (!ownsTransit.Contains(myTransit)) ownsTransit.Append(myObject);
                        break;
                
                }
                return id;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class SignallingEntities: dp.SignallingEntities
        {
            [XmlElementAttribute("ownsOpposingRoute", Order=1)]
            public List<OpposingRouteLocking> ownsOpposingRoute { get; set; } = new List<OpposingRouteLocking>(); 
                
            [XmlElementAttribute("ownsTransit", Order=2)]
            public List<Transit> ownsTransit { get; set; } = new List<Transit>(); 
                
             
        }  
    
        /** 
        Opposing route locking for routes in areas with points.
fr-FR: Enclenchement de parcours banalis&#233; (dans les zones &#233;quip&#233;es d'appareils de voie).
Les conditions d'&#233;tablissement de l'itin&#233;raire ne requi&#232;rent que la v&#233;rification du transit de sens contraire en aval du signal origine de l'itin&#233;raire (e.g. pour v&#233;rifier qu'aucun intin&#233;raire de sens contraire form&#233; a pour destination un signal en amont du signal origine).  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class BidirectionalRouteLocking: sncf.OpposingRouteLocking
        {
            [XmlElementAttribute("checksTransit", Order=1)]
            public tElementWithIDref checksTransit {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        fr-FR: Enclenchement de sens entre postes.
Checks to prevent simultaneous opening of opposing signals that are controlled by different interlocking systems. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class DirectionLocking: sncf.TrackLocking
        {
            [XmlElementAttribute("hasInterval", Order=1)]
            public Interval hasInterval {get; set;} = new Interval();
                
             
        }  
    
        /** 
        Track between two signals equipped with an interlocked direction.
fr-FR: Intervalle. Portion de voie entre 2 signaux munie d'un enclenchement de sens. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class Interval
        {
            [XmlElementAttribute("hasTvpSections", Order=1)]
            public List<tElementWithIDref> hasTvpSections { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("limitedBySignals", Order=2)]
            public List<tElementWithIDref> limitedBySignals { get; set; } = new List<tElementWithIDref>(); 
                
             
        }  
    
        /** 
        Used in case of IPCS or ITCS installations.

fr-FR: Installations Permanentes ou Temporaires de Contresens.
IPCS est un enclenchement de sens modifi&#233;.
Par d&#233;faut, l'intervalle est orient&#233; dans le sens normal (les signaux de contre-sens sont &#233;teints, sauf celui de sortie de l'intervalle et son signal d'annonce, les crocodiles des signaux de sens contraire sont non aliment&#233;s, les annonces de PN ne fonctionnent que dans le sens normal, etc.).
Pour prendre le sens normal, IPCS fonctionne quasiment comme l'enclenchement de sens sauf que l'occupation de l'intervalle n'est pas v&#233;rifi&#233;e.
Pour prendre le contre-sens, IPCS fonctionne comme l'enclenchement de sens (donc l'occupation de l'intervalle est v&#233;rifi&#233;e), mais cette prise de sens &#224; des cons&#233;quences sur la signalisation de l'intervalle. A la prise du contre-sens, l'intervalle s'oriente en contre-sens (les signaux de contre-sens s'allument, les crocodiles de sens normal sont non aliment&#233;s, les crocodiles de contre-sens sont aliment&#233;s, les annonces de PN ne fonctionnent que dans le contre-sens, etc.).
D&#232;s que l'intervalle n'est plus occup&#233; et qu'il n'y a plus d'itin&#233;raire vers l'intervalle en contre-sens, l'intervalle se r&#233;oriente en sens normal.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class IpcsLocking: sncf.TrackLocking
        {
            [XmlElementAttribute("checksState", Order=1)]
            public List<tElementWithIDref> checksState { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("conflictsWithMovableElementInPosition", Order=2)]
            public List<tElementWithIDref> conflictsWithMovableElementInPosition { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("conflictsWithRoute", Order=3)]
            public List<tElementWithIDref> conflictsWithRoute { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasInterval", Order=4)]
            public Interval hasInterval {get; set;} = new Interval();
                
             
        }  
    
        /** 
        Defines the configuration parameters needed to implement the exclusion of face-to-face movement.
The system proves that sections in between opposing signals are not claimed for movement in the opposite direction. A signal that provides entry to a route can only be opened when no opposing route is set.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.BidirectionalRouteLocking))]
        [XmlIncludeAttribute(typeof(sncf.TrackLocking))]     
        public abstract partial class OpposingRouteLocking: sig.ConfiguredBaseObject
        {
             
        }  
    
        /** 
        The SNCF route body is used for opposing route checks. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class RouteBody: sig.RouteBody
        {
            [XmlElementAttribute("activatesTransit", Order=1)]
            public List<tElementWithIDref> activatesTransit { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("checksOpposingRouteLocking", Order=2)]
            public List<tElementWithIDref> checksOpposingRouteLocking { get; set; } = new List<tElementWithIDref>(); 
                
            [XmlElementAttribute("hasDirection", Order=3)]
            public SncfDirectionTypes hasDirection {get; set;} = new SncfDirectionTypes();
                
             
        }  
    
        /** 
        Used case of single track, i.e. the opposing routes are part of one yard controlled by a single interlocking.

fr-FR: Voie Unique (VU)
Une voie unique dans le poste est une portion de voie d&#233;limit&#233;e par deux signaux de sens contraire dos &#224; dos. Est v&#233;rifi&#233; que le transit de sens contraire de la zone de la VU est lib&#233;r&#233;. Si c'est le cas, le sens de la VU est pris et l'itin&#233;raire s'&#233;tablit.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class SingleTrackLocking: sncf.TrackLocking
        {
            [XmlElementAttribute("hasInterval", Order=1)]
            public Interval hasInterval {get; set;} = new Interval();
                
             
        }  
    
        /** 
        fr-FR: Enclenchement d'affrontement. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class StandoffLocking: sncf.TrackLocking
        {
            [XmlElementAttribute("manualReleasePossible", Order=1)]
            public Boolean manualReleasePossible {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        Allows shunting movement on track situated between the opposing signals.

fr-FR: enclenchement de voie de stationnement (St).
Typiquement utilis&#233; pour une voie &#224; quai. Le transit qui donne acc&#232;s &#224; la voie de stationnement en sens contraire est v&#233;rifi&#233;. Permet de manœuvrer (e.g. pour coupler deux rames ou atteler une locomotive). 

Comme une VU, sauf que l'on peut y manœuvrer (pour coupler deux rames ou pour atteler une locomotive). Au lieu de v&#233;rifier le transit de sens contraire de la VU, est v&#233;rifi&#233; le transit qui donne acc&#232;s &#224; la voie de stationnement en sens contraire.  
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class StationTrackLocking: sncf.TrackLocking
        {
            [XmlElementAttribute("hasInterval", Order=1)]
            public Interval hasInterval {get; set;} = new Interval();
                
             
        }  
    
        /** 
        Opposing route locking for line without points.
fr-FR: Enclenchement portant sur des portions de voie lin&#233;aire, g&#233;n&#233;ralement sans aiguilles. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.DirectionLocking))]
        [XmlIncludeAttribute(typeof(sncf.IpcsLocking))]
        [XmlIncludeAttribute(typeof(sncf.SingleTrackLocking))]
        [XmlIncludeAttribute(typeof(sncf.StandoffLocking))]
        [XmlIncludeAttribute(typeof(sncf.StationTrackLocking))]     
        public abstract partial class TrackLocking: sncf.OpposingRouteLocking
        {
            [XmlElementAttribute("betweenInterlockings", Order=1)]
            public Boolean betweenInterlockings {get; set;} = new Boolean();
                
            [XmlElementAttribute("checksTransitForEvenDirection", Order=2)]
            public TransitAndMovableElementPosition checksTransitForEvenDirection {get; set;} = new TransitAndMovableElementPosition();
                
            [XmlElementAttribute("checksTransitForOddDirection", Order=3)]
            public TransitAndMovableElementPosition checksTransitForOddDirection {get; set;} = new TransitAndMovableElementPosition();
                
             
        }  
    
        /** 
        A transit is a TVP section plus a direction.
fr-FR: Un transit correspond &#224; une section TVP &#224; laquelle on affecte un sens. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class Transit: sig.ConfiguredBaseObject
        {
            [XmlElementAttribute("appliesToTvpSection", Order=1)]
            public tElementWithIDref appliesToTvpSection {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDirection", Order=2)]
            public SncfDirectionTypes hasDirection {get; set;} = new SncfDirectionTypes();
                
             
        }  
    
        /** 
        Tuple of a transit plus point and position.
fr-FR: paire transit et position de l' aiguille. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class TransitAndMovableElementPosition
        {
            [XmlElementAttribute("checksIfMovableElementIsInPosition", Order=1)]
            public sig.MovableElementAndPosition checksIfMovableElementIsInPosition {get; set;} = new sig.MovableElementAndPosition();
                
            [XmlElementAttribute("checksTransit", Order=2)]
            public tElementWithIDref checksTransit {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        Train Protection Device used in France, Belgium and Luxemburg. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class Crocodile: sig.TpsSpotDevice
        {
            [XmlElementAttribute("isSuppressedByTreadle", Order=1)]
            public tElementWithIDref isSuppressedByTreadle {get; set;} = new tElementWithIDref();
                
             
        }  
    
        /** 
        System behavioural properties of the crocodile installation. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class CrocodileSystemProperties: sig.TpsDataTransmissionSystemProperties
        {
            [XmlElementAttribute("hasCrocodileFunction", Order=1)]
            public CrocodileFunctionTypes hasCrocodileFunction {get; set;} = new CrocodileFunctionTypes();
                
            [XmlElementAttribute("isDesignedForReaction", Order=2)]
            public CrocodileReactionType isDesignedForReaction {get; set;} = new CrocodileReactionType();
                
            [XmlElementAttribute("trailable", Order=3)]
            public Boolean trailable {get; set;} = new Boolean();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbAnalogBalise: sncf.KvbBalise
        {
            [XmlElementAttribute("hasFunction", Order=1)]
            public KvbAnalogBaliseFunctionTypes hasFunction {get; set;} = new KvbAnalogBaliseFunctionTypes();
                
             
        }  
    
        /** 
        A balise used for Controle de Vitesse par Balise (KVB). 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.KvbAnalogBalise))]
        [XmlIncludeAttribute(typeof(sncf.KvbDigitalBalise))]     
        public  partial class KvbBalise: sig.Balise
        {
            [XmlElementAttribute("positionInGroup", Order=1)]
            public String positionInGroup= "";
                
             
        }  
    
        /** 
        Information from the CSSP family not linked to speed control. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbCsspInformationField: sncf.KvbInformationField
        {
            [XmlElementAttribute("hasKvbCsspInformationType", Order=1)]
            public KvbCsspInformationTypes hasKvbCsspInformationType {get; set;} = new KvbCsspInformationTypes();
                
            [XmlElementAttribute("value", Order=2)]
            public Int32 value {get; set;} = new Int32();
                
             
        }  
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbDigitalBalise: sncf.KvbBalise
        {
             
        }  
    
        /** 
        Individual information fields for a KVB Train Protection System. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.KvbCsspInformationField))]
        [XmlIncludeAttribute(typeof(sncf.KvbSpeedControlInformationField))]     
        public  partial class KvbInformationField: sig.BaseObject
        {
            [XmlElementAttribute("designation", Order=1)]
            public String designation= "";
                
            [XmlElementAttribute("normalDirection", Order=2)]
            public Boolean normalDirection {get; set;} = new Boolean();
                
            [XmlElementAttribute("remarks", Order=3)]
            public String remarks= "";
                
             
        }  
    
        /** 
        Informs at what distance the KVB balises are placed on approach to the signal.
fr-FR: Renseigne &#224; quelle distance les balises KVB sont plac&#233;es &#224; l'approche du signal.
 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
        
        [XmlIncludeAttribute(typeof(sncf.KvbTpsToTargetRelation))]     
        public  partial class KvbRelation: sig.TpsRelation
        {
            [XmlElementAttribute("appliesToFacingPoint", Order=1)]
            public tElementWithIDref appliesToFacingPoint {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToFoulingPoint", Order=2)]
            public tElementWithIDref appliesToFoulingPoint {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToLocationOfInterest", Order=3)]
            public tElementWithIDref appliesToLocationOfInterest {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("appliesToTurnoutBranch", Order=4)]
            public tElementWithIDref appliesToTurnoutBranch {get; set;} = new tElementWithIDref();
                
            [XmlElementAttribute("hasDistanceFromTpsToFoulingPoint", Order=5)]
            public rtmCommon.Length hasDistanceFromTpsToFoulingPoint {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        Information linked to speed control. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbSpeedControlInformationField: sncf.KvbInformationField
        {
            [XmlElementAttribute("hasKvbSpeedControlInformationType", Order=1)]
            public KvbSpeedControlInformationTypes hasKvbSpeedControlInformationType {get; set;} = new KvbSpeedControlInformationTypes();
                
            [XmlElementAttribute("hasSpeedDesignProperties", Order=2)]
            public List<KvbSpeedDesignProperties> hasSpeedDesignProperties { get; set; } = new List<KvbSpeedDesignProperties>(); 
                
            [XmlElementAttribute("hasTarget", Order=3)]
            public List<KvbTpsToTargetRelation> hasTarget { get; set; } = new List<KvbTpsToTargetRelation>(); 
                
             
        }  
    
        /** 
        See SNCF document DES258/IG33258 for details about the properties in this class. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbSpeedDesignProperties
        {
            [XmlElementAttribute("isDesignedForSpeed", Order=1)]
            public rtmCommon.Speed isDesignedForSpeed {get; set;} = new rtmCommon.Speed();
                
            [XmlElementAttribute("isDesignedForTrainCategory", Order=2)]
            public sig.KvbTrain isDesignedForTrainCategory {get; set;} = new sig.KvbTrain();
                
            [XmlElementAttribute("trainCategoryHasLowerSpeed", Order=3)]
            public Boolean trainCategoryHasLowerSpeed {get; set;} = new Boolean();
                
            [XmlElementAttribute("trainCategoryNotAllowed", Order=4)]
            public Boolean trainCategoryNotAllowed {get; set;} = new Boolean();
                
             
        }  
    
        /** 
        KVB system properties.
The inherited speed design properties are not used for KVB.

FR: champs d'informations 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbSystemProperties: sig.TpsDataTransmissionSystemProperties
        {
            [XmlElementAttribute("hasInformationField", Order=1)]
            public List<KvbInformationField> hasInformationField { get; set; } = new List<KvbInformationField>(); 
                
             
        }  
    
        /** 
        Gives the distance from a target where speed must be reduced or equal to zero.
fr-FR: Renseigne la distance &#224; une cible o&#249; la vitesse doit &#234;tre r&#233;duite ou &#233;gale &#224; z&#233;ro. 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class KvbTpsToTargetRelation: sncf.KvbRelation
        {
            [XmlElementAttribute("hasDesignSlope", Order=1)]
            public rtmCommon.Gradient hasDesignSlope {get; set;} = new rtmCommon.Gradient();
                
            [XmlElementAttribute("hasDistanceFromSignalToTarget", Order=2)]
            public rtmCommon.Length hasDistanceFromSignalToTarget {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasDistanceFromTargetToFoulingPoint", Order=3)]
            public rtmCommon.Length hasDistanceFromTargetToFoulingPoint {get; set;} = new rtmCommon.Length();
                
            [XmlElementAttribute("hasDistanceTpsToTarget", Order=4)]
            public rtmCommon.Length hasDistanceTpsToTarget {get; set;} = new rtmCommon.Length();
                
             
        }  
    
        /** 
        SNCF device 
        */
    
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")] [Serializable]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [XmlTypeAttribute(Namespace="http://dataprep.eulynx.eu/schema/SNCF")]
        [XmlRootAttribute("LevelCrossingSystem", Namespace="http://dataprep.eulynx.eu/schema/SNCF",IsNullable=false)] 
             
        public  partial class LockoutDevice: sig.LockoutDevice
        {
             
        }  
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum FictitiousSignalFunctionTypes : int {
        /* Signal fictif &#224; la limite de poste. Permet de scinder un parcours allant d'un poste vers un autre en deux itin&#233;raires compl&#232;tement distincts, limitant ainsi au maximum les d&#233;pendances entre les deux postes. */interlockingBorder
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum SncfDirectionTypes : int {
        /* fr-FR: impair */odd,/* fr-FR: pair */even
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum CrocodileFunctionTypes : int {
        /* fr-FR: Controle de vitesse DAAT-Avanc&#233; */speedChecking,/* fr-FR: Reconnaissance de cat&#233;gorie de trains (de banlieue parisienne) */trainCategoryDetection,/* Equipement compl&#233;mentaire d'un signal */signal
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum CrocodileReactionType : int {
        /* fr-FR: Avertissement de survitesse
DC current  */warning,/* fr-FR: Frein d'urgence
AC current */emergencyBrake,/* fr-FR: Avertissement et frein d'urgence. */WarningAndEb
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum KvbAnalogBaliseFunctionTypes : int {
        /* Signal. */s,/* Distance. */d,/* Profil (d&#233;clivit&#233;). */p,/* Distance et profil. */dp,/* Limitation de vitesse &#171; cat&#233;gorie g&#233;n&#233;rale &#187;. */g,/* Limitation de vitesse &#171; cat&#233;gories sp&#233;ciales &#187;. */s1,/* Limitation de vitesse &#171; cat&#233;gories sp&#233;ciales &#187;. */s2,/* Limitation de vitesse &#171; cat&#233;gories sp&#233;ciales &#187;. */s3,/* Limitation temporaire de vitesse. */ltv,/* Marqueur. */m,/* Informations diverses. */f,/* Informations pour Cartes de Sortie S&#233;rie Parall&#232;le. */cssp
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum KvbCsspInformationTypes : int {
        /* Canal radio num&#233;ro ... */cr,/* Syst&#232;me radio num&#233;ro ... */sr,/* Entr&#233;e tunnel. */etu,/* Sortie tunnel. */stu,/* Quai de type haut. */qte,/* Quai de type interm&#233;diaire. */qtc,/* Quai de type mi-haut niveau 1. */qtb1,/* Quai de type mi-haut niveau 3.
 */qtb3,/* Quai de type bas. */qta,/* Quai &#224; desservir &#224; gauche. */qag,/* Quai &#224; desservir &#224; droite. */qad,/* Quai &#224; desservir &#224; gauche et &#224; droite. */qgd,/* Quai haut &#224; gauche. */qhg,/* Quai haut &#224; droite. */qhd,/* Verrouillage WC. */vwc,/* Lib&#233;ration WC. */lwc,/* Banlieue Grande Ligne. */bgl,/* Quai bas &#224; gauche. */qbg,/* Quai bas &#224; droite. */qbd,/* Quai haut &#224; droite et &#224; gauche. */qhdg,/* Quai bas &#224; droite et &#224; gauche. */qbdg
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum KvbSpeedControlInformationTypes : int {
        /* Champ cod&#233; AE pour raison technique. */ae,/* Annulation d’un TIVD en talon d’appareil. */aativd,/* Annulation de la vitesse de rappel. */avra,/* D&#233;but de vitesse limit&#233;e. */dvl,/* Fin de vitesse limit&#233;e. */fvl,/* Fin de zone &#233;quip&#233;e. */fz,/* D&#233;but de zone en construction. */dzc,/* Fin de zone en construction. */fzc,/* D&#233;but de zone sans alerte. */dzsa,/* Fin de zone sans alerte. */fzsa,/* D&#233;but de zone hors visualisation. */dzhv,/* Fin de zone hors visualisation. */fzhv,/* D&#233;but de zone de transmission continue en construction. */dtcc,/* Fin de zone de transmission continue en construction. */ftcc,/* Initialisation de la transmission continue. */itc,/* Initialisation de la localisation. */iloc,/* Tableau P fixe. */pfix,/* Tableau P mobile. */vpmob,/* Proximit&#233; de heurtoir. */proxh,/* Rafra&#238;chissement d’espace pour canton court. */rafcc,/* Rafra&#238;chissement d’espace pour canton long. */rafcl,/* Signal. */s,/* Traitement de proximit&#233;. */sp,/* R&#233;ouverture signal. */sreo,/* Franchissement de signal. */sf,/* R&#233;veil de train. */srev,/* Surveillance. */sur,/* TIVD fixe. */tivd,/* Ex&#233;cution d’une limitation de vitesse fixe (par plaque Z ou R, de type "LMTR" par pancarte km ou facilement rep&#233;rable ou pour une entr&#233;e syst&#232;me).  */tive,/* TIVE de heurtoir. */tive5,/* Annulation d’un tableau P mobile au TIV.D pr&#233;annonc&#233;. */tpaa,/* Ex&#233;cution d’un tableau P fixe au TIV.D pr&#233;annonc&#233;. */tpex,/* Annulation d’un TIV.D fixe ou mobile. */vaa,/* Vitesse d’annonce (R ou (R) ou TIV.D mobile). */van,/* Vitesse de rappel (RR ou (RR) ou TIV.R). */vra,/* R&#233;ouverture vitesse. */vreo,/* D&#233;but de zone &#224; grande vitesse */dgv,/* Fin de zone &#224; grande vitesse */fgv
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dataprep.eulynx.eu/schema/SNCF")]
    public enum LockoutDeviceTypes : int {
        
    }
    
} 
            