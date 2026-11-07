using System.Collections;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public class ClientContext
	{
		private const string CLIENT_KEY = "client";

		private const string CLIENT_ID_KEY = "client_id";

		private const string CLIENT_APP_TITLE_KEY = "app_title";

		private const string CLIENT_APP_VERSION_NAME_KEY = "app_version_name";

		private const string CLIENT_APP_VERSION_CODE_KEY = "app_version_code";

		private const string CLIENT_APP_PACKAGE_NAME_KEY = "app_package_name";

		private const string CUSTOM_KEY = "custom";

		private const string ENV_KEY = "env";

		private const string ENV_PLATFORM_KEY = "platform";

		private const string ENV_MODEL_KEY = "model";

		private const string ENV_MAKE_KEY = "make";

		private const string ENV_PLATFORM_VERSION_KEY = "platform_version";

		private const string ENV_LOCALE_KEY = "locale";

		private const string SERVICES_KEY = "services";

		private const string SERVICE_MOBILE_ANALYTICS_KEY = "mobile_analytics";

		private const string SERVICE_MOBILE_ANALYTICS_APP_ID_KEY = "app_id";

		private IDictionary<string, string> _client;

		private IDictionary<string, string> _custom;

		private IDictionary<string, string> _env;

		private IDictionary<string, IDictionary> _services;

		private IDictionary _clientContext;

		private static object _lock;

		private const string APP_ID_KEY = "APP_ID_KEY";

		private const string CLIENT_ID_CACHE_FILENAME = "client-ID-cache";

		public string AppID { get; set; }

		public void AddCustomAttributes(string key, string value)
		{
		}

		public string ToJsonString()
		{
			return null;
		}
	}
}
