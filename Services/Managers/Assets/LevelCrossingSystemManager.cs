using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
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
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();

            string streetName = levelCrossing.locationIndication;
            string type = levelCrossing.levelCrossingType.ToString();
            tElementWithIDref[] isLocatedAt = tElementWithIDref.GetTElementsWithIDref(spotLocationManager.GetGeoLocationRef(levelCrossing.Location));
            string uuid = UUIDService.NewFakeUUID(isLocatedAt + streetName + type);
            TrackCrossing trackCrossing = new TrackCrossing(isLocatedAt, streetName, type, uuid);

            InstanceManager.Singleton<TrackCrossingManager>().GetInstance().Register(trackCrossing);

            tElementWithIDref protectsTrackCrossing = new tElementWithIDref(trackCrossing.uuid);
            bool dependsOnRoadTrafficLights = levelCrossing.isConnectedToTrafficControlInstallation == tTrueFalseEnum.True;
            string levelCrossingUUID = levelCrossing.puic;

            MainSignalProtectedLevelCrossing mainSignalProtectedLevelCrossing = new MainSignalProtectedLevelCrossing(protectsTrackCrossing, levelCrossingUUID, dependsOnRoadTrafficLights);

            return mainSignalProtectedLevelCrossing;
        }
    }
}
