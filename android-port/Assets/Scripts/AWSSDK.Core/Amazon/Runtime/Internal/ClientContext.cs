using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000148")]
	public class ClientContext
	{
		[Token(Token = "0x400050C")]
		private const string CLIENT_KEY = "client";

		[Token(Token = "0x400050D")]
		private const string CLIENT_ID_KEY = "client_id";

		[Token(Token = "0x400050E")]
		private const string CLIENT_APP_TITLE_KEY = "app_title";

		[Token(Token = "0x400050F")]
		private const string CLIENT_APP_VERSION_NAME_KEY = "app_version_name";

		[Token(Token = "0x4000510")]
		private const string CLIENT_APP_VERSION_CODE_KEY = "app_version_code";

		[Token(Token = "0x4000511")]
		private const string CLIENT_APP_PACKAGE_NAME_KEY = "app_package_name";

		[Token(Token = "0x4000512")]
		private const string CUSTOM_KEY = "custom";

		[Token(Token = "0x4000513")]
		private const string ENV_KEY = "env";

		[Token(Token = "0x4000514")]
		private const string ENV_PLATFORM_KEY = "platform";

		[Token(Token = "0x4000515")]
		private const string ENV_MODEL_KEY = "model";

		[Token(Token = "0x4000516")]
		private const string ENV_MAKE_KEY = "make";

		[Token(Token = "0x4000517")]
		private const string ENV_PLATFORM_VERSION_KEY = "platform_version";

		[Token(Token = "0x4000518")]
		private const string ENV_LOCALE_KEY = "locale";

		[Token(Token = "0x4000519")]
		private const string SERVICES_KEY = "services";

		[Token(Token = "0x400051A")]
		private const string SERVICE_MOBILE_ANALYTICS_KEY = "mobile_analytics";

		[Token(Token = "0x400051B")]
		private const string SERVICE_MOBILE_ANALYTICS_APP_ID_KEY = "app_id";

		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, string> _client;

		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x18")]
		private IDictionary<string, string> _custom;

		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x20")]
		private IDictionary<string, string> _env;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x28")]
		private IDictionary<string, IDictionary> _services;

		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x30")]
		private IDictionary _clientContext;

		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000522")]
		private const string APP_ID_KEY = "APP_ID_KEY";

		[Token(Token = "0x4000523")]
		private const string CLIENT_ID_CACHE_FILENAME = "client-ID-cache";

		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27098", Offset = "0x27098")]
		private string AppID__BackingField;

		[Token(Token = "0x170002AA")]
		public string AppID
		{
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x11E109C", Offset = "0x11E109C", VA = "0x11E109C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29F34", Offset = "0x29F34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x11E10A4", Offset = "0x11E10A4", VA = "0x11E10A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29F44", Offset = "0x29F44")]
			set
			{
			}
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x11E10AC", Offset = "0x11E10AC", VA = "0x11E10AC")]
		public void AddCustomAttributes(string key, string value)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x11E12B4", Offset = "0x11E12B4", VA = "0x11E12B4")]
		public string ToJsonString()
		{
			return null;
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x11E18F4", Offset = "0x11E18F4", VA = "0x11E18F4")]
		public ClientContext()
		{
		}
	}
}
