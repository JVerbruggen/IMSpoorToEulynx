using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Mapping.Assets.LevelCrossing;
using Services.Mapping.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public class LevelCrossingSystemManager : ItemManager<LevelCrossingSystem>
    {
        public LevelCrossingSystem[] GetLevelCrossingSystems(LevelCrossing[] levelCrossings)
        {
            IList<LevelCrossingSystem> levelCrossingSystems = new List<LevelCrossingSystem>();

            foreach (LevelCrossing levelCrossing in levelCrossings)
            {
                LevelCrossingSystem levelCrossingSystem = GetLevelCrossingSystem(levelCrossing);
                levelCrossingSystems.Add(levelCrossingSystem);
            }

            return levelCrossingSystems.ToArray();
        }

        public LevelCrossingSystem GetLevelCrossingSystem(LevelCrossing levelCrossing)
        {
            IMapping<LevelCrossing, LevelCrossingSystem> mapping = InstanceManager.GetMappingSelector<LevelCrossing, LevelCrossingSystem>().Select(levelCrossing);

            LevelCrossingSystem levelCrossingSystem = mapping.Map(levelCrossing);

            return levelCrossingSystem;
        }
    }
}
