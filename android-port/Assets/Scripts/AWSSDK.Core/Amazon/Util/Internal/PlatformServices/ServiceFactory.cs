using System;
using System.Collections.Generic;

namespace Amazon.Util.Internal.PlatformServices
{
	public class ServiceFactory
	{
		private enum InstantiationModel
		{
			Singleton = 0,
			InstancePerCall = 1
		}

		internal const string NotImplementedErrorMessage = "This functionality is not implemented in the portable version of this assembly. You should reference the AWSSDK.Core NuGet package from your main application project in order to reference the platform-specific implementation.";

		private static readonly object _lock;

		private static bool _factoryInitialized;

		private static IDictionary<Type, Type> _mappings;

		private IDictionary<Type, InstantiationModel> _instantationMappings;

		private IDictionary<Type, object> _singletonServices;

		public static ServiceFactory Instance;

		private ServiceFactory()
		{
		}

		public static void RegisterService<T>(Type serviceType)
		{
		}

		public T GetService<T>()
		{
			return default;
		}

		private static Type GetServiceType<T>()
		{
			return null;
		}
	}
}
