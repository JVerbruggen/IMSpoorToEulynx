using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Eulynx
    {

        public static explicit operator Eulynx(IMSpoor.IMSpoor imSpoor)
        {
            object item = imSpoor.Item;
            String version = imSpoor.imxVersion;
            
            Eulynx eulynx = new Eulynx();
            Version v = Version.GetVersion(version);
            RtmEntities rtmEntities = RtmEntities.GetRtmEntities();
            SignallingEntities signallingEntities = SignallingEntities.GetSignallingEntities();

            eulynx.isReleaseVersion = v;
            eulynx.ownsRtmEntities = rtmEntities;
            eulynx.ownsSignallingEntities = signallingEntities;

            return eulynx;
        }

    }
}
