using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.DependencyInjection;
using Services.Factory.Assets;
using Services.Factory.Manager;
using Services.Managers.Assets;

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
    }
}
