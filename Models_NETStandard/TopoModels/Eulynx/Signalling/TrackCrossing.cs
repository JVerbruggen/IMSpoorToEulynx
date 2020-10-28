using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
{
    public partial class TrackCrossing
    {
        public TrackCrossing()
        {

        }
        public TrackCrossing(tElementWithIDref[] isLocatedAt, string streetName, string type, string uuid)
        {
            this.isLocatedAt = isLocatedAt;
            this.streetName = streetName;
            this.type = type;
            this.uuid = uuid;
        }
    }
}
