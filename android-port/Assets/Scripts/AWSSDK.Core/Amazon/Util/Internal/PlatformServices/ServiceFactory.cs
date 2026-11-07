using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x2000092")]
	public class ServiceFactory
	{
		[Token(Token = "0x2000093")]
		private enum InstantiationModel
		{
			[Token(Token = "0x400029A")]
			Singleton = 0,
			[Token(Token = "0x400029B")]
			InstancePerCall = 1
		}

		[Token(Token = "0x4000292")]
		internal const string NotImplementedErrorMessage = "This functionality is not implemented in the portable version of this assembly. You should reference the AWSSDK.Core NuGet package from your main application project in order to reference the platform-specific implementation.";

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object _lock;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x8")]
		private static bool _factoryInitialized;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x10")]
		private static IDictionary<Type, Type> _mappings;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<Type, InstantiationModel> _instantationMappings;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x18")]
		private IDictionary<Type, object> _singletonServices;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x18")]
		public static ServiceFactory Instance;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1271388", Offset = "0x1271388", VA = "0x1271388")]
		private ServiceFactory()
		{
		}

		[Token(Token = "0x6000561")]
		public static void RegisterService<T>(Type serviceType)
		{
		}

		[Token(Token = "0x6000562")]
		public T GetService<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000563")]
		private static Type GetServiceType<T>()
		{
			return null;
		}
	}
}
