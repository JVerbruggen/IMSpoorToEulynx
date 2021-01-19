using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.sig
{
    public partial class MainSignalProtectedLevelCrossing
    {
        public MainSignalProtectedLevelCrossing()
        {

        }

        public MainSignalProtectedLevelCrossing(tElementWithIDref protectsTrackCrossing, string id, bool dependsOnRoadTrafficLights)
        {
            this.protectsTrackCrossing = protectsTrackCrossing;
            this.id = id;
            this.dependsOnRoadTrafficLights = dependsOnRoadTrafficLights;
        }
    }
}
