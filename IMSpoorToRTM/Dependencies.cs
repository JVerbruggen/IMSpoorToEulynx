using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.DependencyInjection;
using Services.Factory.Assets;
using Services.Factory.Manager;
using Services.Managers.Assets;

namespace FormsApp
{
    public class Dependencies
    {
        /// <summary>
        /// Registers factories for InstanceManager Singleton to use
        /// </summary>
        public static void RegisterFactories()
        {
            InstanceManager.RegisterFactory(new TrackAssetManagerFactory());
            InstanceManager.RegisterFactory(new SignalFactory());
        }

        /// <summary>
        /// Registers all dependencies for InstanceManager Singleton
        /// </summary>
        public static void RegisterDependencies()
        {
            // Add abstract singletons here with implementing type
            // Registering here will override a factory with the same type

            // InstanceManager.Singleton<TrackAssetManager>(new TrackAssetManagerLimited());

        }
    }
}
