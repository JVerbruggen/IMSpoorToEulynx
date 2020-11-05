using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
{
    public partial class Signal
    {
        public Signal()
        {

        }

        public Signal(string uuid, LocalDatum hasLocalDatum, tElementWithIDref hasLocation, tElementWithIDref[] hasSignalFrame, FixingTypes isOfFixingType, tElementWithIDref[] refersToOverlapsForDisplay, tElementWithIDref refersToRtmSignal, tElementWithIDref[] refersToSafetyDistance, tElementWithIDref showsDefaultMessage)
        {
            this.uuid = uuid;
            this.hasLocalDatum = hasLocalDatum;
            this.hasLocation = hasLocation;
            this.hasSignalFrame = hasSignalFrame;
            this.isOfFixingType = isOfFixingType;
            this.refersToOverlapsForDisplay = refersToOverlapsForDisplay;
            this.refersToRtmSignal = refersToRtmSignal;
            this.refersToSafetyDistance = refersToSafetyDistance;
            this.showsDefaultMessage = showsDefaultMessage;
        }

        public override BaseLocation GetLocation(IEnumerable<BaseLocation> allLocations)
        {
            tElementWithIDref location = this.hasLocation;
            BaseLocation bl = BaseLocation.Find(allLocations, location);
            return bl;
        }
    }
}
