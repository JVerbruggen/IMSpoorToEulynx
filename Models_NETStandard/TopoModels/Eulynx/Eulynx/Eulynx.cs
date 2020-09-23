using Models.DependencyInjection.Manager;
using Models.TopoModels.DependencyInjection;
using Models.TopoModels.IMSpoor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Eulynx : ITranslatableSingle<Eulynx, IMSpoor.IMSpoor>
    {
        public Eulynx TranslateSingle(IMSpoor.IMSpoor imSpoor)
        {
            InstanceManager.AddInstanceSupplier(new InstanceSupplier<IMSpoor.IMSpoor>(imSpoor));

            object item = imSpoor.Item;
            String version = imSpoor.imxVersion;

            if (item == null) return null;

            Version v = new Version().TranslateSingle(imSpoor);
            this.isReleaseVersion = v;
            tSituation situation;

            if (item is tSituation)
            {
                situation = (tSituation)item;
            }
            else
            {
                Project project = (Project)item;
                situation = project.InitialSituation;
            }

            InstanceManager.AddInstanceSupplier(new InstanceSupplier<tSituation>(situation));

            RtmEntities rtmEntities = new RtmEntities().TranslateSingle(situation);
            //SignallingEntities signallingEntities = SignallingEntities.GetSignallingEntities(imSpoor);

            this.ownsRtmEntities = rtmEntities;
            //this.ownsSignallingEntities = signallingEntities;

            return this;
        }
    }
}
