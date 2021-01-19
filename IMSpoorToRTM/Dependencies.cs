using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Factory.Assets;
using Services.Factory.Manager;
using Services.Managers.Positioning;
using Services.Managers.Topology;
using Services.Mapping.Assets.LevelCrossing;
using Services.Mapping.Assets.Signal;
using Services.Mapping.Topology;

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

            // InstanceManager.Singleton<TrackAssetManager>(new TrackAssetManagerLimited());
        }

        public static void RegisterMappingSelectors()
        {
            var associatedPositioningSystemManager = InstanceManager.Singleton<AssociatedPositioningSystemManager>().GetInstance();
            var positionedRelationManager = InstanceManager.Singleton<PositionedRelationManager>().GetInstance();

            InstanceManager.RegisterMappingSelector(new PositioningNetElementMappingSelector(associatedPositioningSystemManager));
            InstanceManager.RegisterMappingSelector(new PositionedRelationMappingSelector(positionedRelationManager));

            InstanceManager.RegisterMappingSelector(new LevelCrossingMappingSelector());
            InstanceManager.RegisterMappingSelector(new SignalMappingSelector());
        }
    }
}
