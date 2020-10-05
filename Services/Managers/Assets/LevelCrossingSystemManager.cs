using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
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
            LevelCrossingSystem levelCrossingSystem = null;
            if(levelCrossing.levelCrossingType == tLevelCrossingTypeEnum.HBKI)
            {
                levelCrossingSystem = new LocallyMonitoredLevelCrossing();
                throw new NotImplementedException();
            }
            else if(levelCrossing.levelCrossingType == tLevelCrossingTypeEnum.ADOB)
            {
                levelCrossingSystem = new SelfSupervisedLevelCrossing();
                throw new NotImplementedException();
            }
            else
            {
                levelCrossingSystem = GetMainSignalProtectedLevelCrossing(levelCrossing);
            }

            return levelCrossingSystem;
        }

        public MainSignalProtectedLevelCrossing GetMainSignalProtectedLevelCrossing(LevelCrossing levelCrossing)
        {
            TrackCrossing trackCrossing = new TrackCrossing(levelCrossing);
            InstanceManager.Singleton<TrackCrossingManager>().GetInstance().Register(trackCrossing);

            tElementWithIDref protectsTrackCrossing = new tElementWithIDref(trackCrossing.uuid);
            bool dependsOnRoadTrafficLights = levelCrossing.isConnectedToTrafficControlInstallation == tTrueFalseEnum.True;
            string uuid = levelCrossing.puic;

            MainSignalProtectedLevelCrossing mainSignalProtectedLevelCrossing = new MainSignalProtectedLevelCrossing(protectsTrackCrossing, uuid, dependsOnRoadTrafficLights);

            return mainSignalProtectedLevelCrossing;
        }
    }
}
