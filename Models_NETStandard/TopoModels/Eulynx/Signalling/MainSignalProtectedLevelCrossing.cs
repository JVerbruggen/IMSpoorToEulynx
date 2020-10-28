using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
{
    public partial class MainSignalProtectedLevelCrossing
    {
        public MainSignalProtectedLevelCrossing()
        {

        }

        public MainSignalProtectedLevelCrossing(tElementWithIDref protectsTrackCrossing, string uuid, bool dependsOnRoadTrafficLights)
        {
            this.protectsTrackCrossing = protectsTrackCrossing;
            this.uuid = uuid;
            this.dependsOnRoadTrafficLights = dependsOnRoadTrafficLights;
        }
    }
}
