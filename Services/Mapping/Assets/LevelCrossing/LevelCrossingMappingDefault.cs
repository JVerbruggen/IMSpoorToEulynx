using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Assets;
using Services.Managers.Location;
using Services.Mapping.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Assets.LevelCrossing
{
    public class LevelCrossingMappingDefault : IMapping<Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing, LevelCrossingSystem>
    {
        public LevelCrossingSystem Map(Models.TopoModels.IMSpoor.V1_2_3.LevelCrossing input)
        {
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();

            string streetName = input.locationIndication;
            string type = input.levelCrossingType.ToString();
            tElementWithIDref[] isLocatedAt = tElementWithIDref.GetTElementsWithIDref(spotLocationManager.GetGeoLocationRef(input.Location));
            string uuid = UUIDService.NewFakeUUID(isLocatedAt + streetName + type);
            TrackCrossing trackCrossing = new TrackCrossing(isLocatedAt, streetName, type, uuid);

            InstanceManager.Singleton<TrackCrossingManager>().GetInstance().Register(trackCrossing);

            tElementWithIDref protectsTrackCrossing = new tElementWithIDref(trackCrossing.uuid);
            bool dependsOnRoadTrafficLights = input.isConnectedToTrafficControlInstallation == tTrueFalseEnum.True;
            string levelCrossingUUID = input.puic;

            MainSignalProtectedLevelCrossing result = new MainSignalProtectedLevelCrossing(protectsTrackCrossing, levelCrossingUUID, dependsOnRoadTrafficLights);

            return result;
        }
    }
}
