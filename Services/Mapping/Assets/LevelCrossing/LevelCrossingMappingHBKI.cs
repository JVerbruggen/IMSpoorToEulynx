using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Assets.LevelCrossing
{
    public class LevelCrossingMappingHBKI : IMapping<Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing, LevelCrossingSystem>
    {
        public LevelCrossingSystem Map(Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing input)
        {
            var result = new LocallyMonitoredLevelCrossing();

            return result;
        }
    }
}
