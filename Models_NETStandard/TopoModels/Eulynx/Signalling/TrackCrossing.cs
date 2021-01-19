using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.sig
{
    public partial class TrackCrossing
    {
        public TrackCrossing()
        {

        }
        public TrackCrossing(tElementWithIDref[] isLocatedAt, string streetName, string type, string id)
        {
            this.isLocatedAt = isLocatedAt;
            this.streetName = streetName;
            this.type = type;
            this.id = id;
        }
    }
}
