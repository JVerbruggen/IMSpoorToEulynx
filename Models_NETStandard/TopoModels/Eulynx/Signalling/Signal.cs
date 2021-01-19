using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.sig
{
    public partial class Signal
    {
        public Signal()
        {

        }

        public Signal(string id, rtmCommon.tElementWithIDref hasLocation, rtmCommon.tElementWithIDref[] hasSignalFrame, FixingTypes isDesignedForFixingType, rtmCommon.tElementWithIDref[] refersToOverlapsForDisplay, rtmCommon.tElementWithIDref refersToRsmSignal, rtmCommon.tElementWithIDref[] refersToSafetyDistance, rtmCommon.tElementWithIDref showsDefaultActiveAspectSet)
        {
            this.id = id;
            this.hasLocation = hasLocation;
            this.hasSignalFrame = hasSignalFrame;
            this.isDesignedForFixingType = isDesignedForFixingType;
            this.refersToOverlapsForDisplay = refersToOverlapsForDisplay;
            this.refersToRsmSignal = refersToRsmSignal;
            this.refersToSafetyDistance = refersToSafetyDistance;
            this.showsDefaultActiveAspectSet = showsDefaultActiveAspectSet;
        }

        public Signal(tElementWithIDref hasLocation, tElementWithIDref[] hasSignalFrame, FixingTypes isDesignedForFixingType, tElementWithIDref[] refersToOverlapsForDisplay, tElementWithIDref refersToRsmSignal, tElementWithIDref[] refersToSafetyDistance, tElementWithIDref showsDefaultActiveAspectSet)
        {
            this.hasLocation = hasLocation;
            this.hasSignalFrame = hasSignalFrame;
            this.isDesignedForFixingType = isDesignedForFixingType;
            this.refersToOverlapsForDisplay = refersToOverlapsForDisplay;
            this.refersToRsmSignal = refersToRsmSignal;
            this.refersToSafetyDistance = refersToSafetyDistance;
            this.showsDefaultActiveAspectSet = showsDefaultActiveAspectSet;
        }

        public override BaseLocation GetLocation(IEnumerable<BaseLocation> allLocations)
        {
            tElementWithIDref location = this.hasLocation;
            BaseLocation bl = BaseLocation.Find(allLocations, location);
            return bl;
        }
    }
}
