using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Assets;
using Services.Managers.Location;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Assets.Signal
{
    public class SignalMappingControlled : IMapping<Models.TopoModels.IMSpoor.V1_2_3.Signal, Models.TopoModels.EULYNX.sig.Signal>
    {
        public Models.TopoModels.EULYNX.sig.Signal Map(Models.TopoModels.IMSpoor.V1_2_3.Signal input)
        {
            return null;
        }
    }
}
