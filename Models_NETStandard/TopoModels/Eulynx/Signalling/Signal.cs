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

        public Signal(string id, rtmCommon.tElementWithIDref hasLocation, List<tElementWithIDref> hasSignalFrame, FixingTypes isDesignedForFixingType, List<tElementWithIDref> refersToOverlapsForDisplay, rtmCommon.tElementWithIDref refersToRsmSignal, List<tElementWithIDref> refersToSafetyDistance, rtmCommon.tElementWithIDref showsDefaultActiveAspectSet)
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

        public Signal(tElementWithIDref hasLocation, List<tElementWithIDref> hasSignalFrame, FixingTypes isDesignedForFixingType, List<tElementWithIDref> refersToOverlapsForDisplay, tElementWithIDref refersToRsmSignal, List<tElementWithIDref> refersToSafetyDistance, tElementWithIDref showsDefaultActiveAspectSet)
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
