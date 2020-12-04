using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Factory.Assets;
using Services.Factory.Manager;
using Services.Managers.Assets;
using Services.Mapping.Assets.LevelCrossing;
using Services.Mapping.Assets.Signal;
using Services.Mapping.Base;

namespace FormsApp
{
    public class Dependencies
    {
        public static void RegisterFactories()
        {
            InstanceManager.RegisterFactory(new TrackAssetManagerFactory());
            InstanceManager.RegisterFactory(new SignalFactory());
        }

        public static void RegisterDependencies()
        {
            // Add abstract singletons here with implementing type
            // Registering here will override a factory with the same type

            //InstanceManager.Singleton<TrackAssetManager>(new TrackAssetManagerLimited());

        }

        public static void RegisterMappingSelectors()
        {
            InstanceManager.RegisterMappingSelectorB(new LevelCrossingMapping());
            InstanceManager.RegisterMappingSelectorB(new SignalMapping());
        }
    }
}
