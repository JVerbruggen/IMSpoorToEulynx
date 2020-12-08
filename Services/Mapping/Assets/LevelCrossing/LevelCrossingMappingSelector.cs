using Models.Base;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Assets.LevelCrossing
{
    public class LevelCrossingMappingSelector : MappingSelector<Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing, LevelCrossingSystem>
    {
        public override IMapping<Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing, LevelCrossingSystem> Select(Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing input)
        {
            IMapping<Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing, LevelCrossingSystem> mapping;
            if (input.levelCrossingType == tLevelCrossingTypeEnum.HBKI)
            {
                mapping = new LevelCrossingMappingHBKI();
            }
            else if (input.levelCrossingType == tLevelCrossingTypeEnum.ADOB)
            {
                mapping = new LevelCrossingMappingADOB();
            }
            else
            {
                mapping = new LevelCrossingMappingDefault();
            }
            return mapping;
        }
    }
}
