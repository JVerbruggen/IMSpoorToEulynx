    using Models.Base;
using Services.DependencyInjection.Abstract;
using Services.Factory.Base;
using Services.Mapping.Assets.LevelCrossing;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DependencyInjection
{
    public static class InstanceManager
    {
        private static IList<IAbstractInstanceSupplier> instanceSuppliers = new List<IAbstractInstanceSupplier>();
        private static IList<IFactory<IManageable>> factories = new List<IFactory<IManageable>>();
        private static IList<IMappingSelector> mappingSelectors = new List<IMappingSelector>();

        /// <summary>
        /// Get factory that supplies given type
        /// </summary>
        /// <typeparam name="T">Type that factory must supply</typeparam>
        /// <returns>Found factory</returns>
        public static IFactory<T> GetFactory<T>() where T : IManageable
        {
            if (factories.Count == 0) return null;

            var factoriesWType = factories.Where(factory => factory.CompareTo(typeof(T)));
            if (factoriesWType.Count() == 0) return null;

            IFactory<T> foundFactory = factoriesWType.Cast<IFactory<T>>()?.First();
            return foundFactory;
        }

        /// <summary>
        /// Register multiple factories
        /// </summary>
        /// <param name="factories">Factories to register</param>
        public static void RegisterFactories(IEnumerable<IFactory<IManageable>> factories)
        {
            foreach(var factory in factories)
            {
                bool registered = RegisterFactory(factory);
            }
        }

        /// <summary>
        /// Register a factory
        /// </summary>
        /// <typeparam name="T">Type the factory is supplying</typeparam>
        /// <param name="factory">The factory to register</param>
        /// <returns>True if registered, False if already existed</returns>
        public static bool RegisterFactory<T>(IFactory<T> factory) 
            where T : IManageable
        {
            IFactory<T> alreadyExistingFactory = GetFactory<T>();
            if(alreadyExistingFactory == null)
            {
                factories.Add((IFactory<IManageable>)factory);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Registers a mapping selector
        /// </summary>
        /// <typeparam name="T">Mapping input type</typeparam>
        /// <typeparam name="U">Mapping output type</typeparam>
        /// <param name="mappingSelector">The mapping selector to register</param>
        /// <returns>True if registered, False if already existed</returns>
        public static bool RegisterMappingSelector<T, U>(IMappingSelector<T, U> mappingSelector)
            where T : IMappable
            where U : IMappable
        {
            IMappingSelector<T, U> alreadyExistingMappingSelector = GetMappingSelector<T, U>();
            if (alreadyExistingMappingSelector == null)
            {
                mappingSelectors.Add(mappingSelector);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get a mapping selector that was previously registered
        /// </summary>
        /// <typeparam name="T">Input type of mapping</typeparam>
        /// <typeparam name="U">Output type of mapping</typeparam>
        /// <returns>Found MappingSelector<T,U>, null if not found</returns>
        public static IMappingSelector<T, U> GetMappingSelector<T, U>()
           where T : IMappable
           where U : IMappable
        {
            if (mappingSelectors.Count == 0) return null;

            var mappingSelectorsWType = mappingSelectors.Where(ms => ms.CompareTo(typeof(T)));
            if (mappingSelectorsWType.Count() == 0) return null;

            IMappingSelector<T, U> foundMappingSelector = mappingSelectorsWType.Cast<IMappingSelector<T, U>>()?.First();
            return foundMappingSelector;
        }

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// </summary>
        /// <returns>Found InstanceSupplier<T>, null if not found</returns>
        private static InstanceSupplier<T> GetInstanceSupplier<T>() where T : IManageable
        {
            InstanceSupplier<T> found = null;
            foreach(IAbstractInstanceSupplier instanceSupplier in instanceSuppliers)
            {
                if (instanceSupplier.GetType() == typeof(InstanceSupplier<T>))
                {
                    found = (InstanceSupplier<T>)instanceSupplier;
                    break;
                }
            }

            return found;
        }

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// If not found, make a new InstanceSupplier with given instance
        /// </summary>
        /// <param name="t">Instance to supply if no InstanceSupplier was found</param>
        /// <returns>Found or new InstanceSupplier object</returns>
        public static InstanceSupplier<T> Singleton<T>(T t) where T : IManageable
        {
            InstanceSupplier<T> instanceSupplier = GetInstanceSupplier<T>();
            if(instanceSupplier == null)
            {
                instanceSupplier = new InstanceSupplier<T>(t);
                AddInstanceSupplier(instanceSupplier);
            }
            return instanceSupplier;
        }

        /// <summary>
        /// Get an InstanceSupplier<T> object that was previously registered
        /// If not found, make a new InstanceSupplier with instance made by System.Activator class
        /// </summary>
        /// <returns>Found or new InstanceSupplier object</returns>
        public static InstanceSupplier<T> Singleton<T>() where T : IManageable
        {
            InstanceSupplier<T> instanceSupplier = GetInstanceSupplier<T>();
            if (instanceSupplier != null) return instanceSupplier;

            IFactory<T> factory = GetFactory<T>();
            if(factory != null)
            {
                instanceSupplier = new InstanceSupplier<T>(factory.CreateDefault());
                AddInstanceSupplier(instanceSupplier);
                return instanceSupplier;
            }

            Type t = typeof(T);
            if (t.GetConstructor(Type.EmptyTypes) == null || t.IsAbstract)
            {
                throw new Exception("Singleton of abstract object has not been instantiated");
            }

            return Singleton((T)Activator.CreateInstance(typeof(T)));
        }

        /// <summary>
        /// Add an InstanceSupplier to the registry
        /// </summary>
        /// <param name="instanceSupplier">InstanceSupplier to add</param>
        public static void AddInstanceSupplier<T>(IInstanceSupplier<T> instanceSupplier) where T : IManageable
        {
            instanceSuppliers.Add(instanceSupplier);
        }   
    }
}
