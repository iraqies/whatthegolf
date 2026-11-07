using System;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util
{
	[Obsolete]
	public class SAMLEndpointSettings : ProfileSettingsBase
	{
		public static readonly string DefaultAuthenticationType;

		private string _authenticationType;

		public Uri Endpoint { get; private set; }

		public string AuthenticationType => null;

		public static bool CanCreateFrom(string endpointName)
		{
			return false;
		}

		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return false;
		}

		public static SAMLEndpointSettings LoadFrom(string endpointName)
		{
			return null;
		}

		public static SAMLEndpointSettings LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		public static void Validate(string endpointName)
		{
		}

		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		public override string Persist()
		{
			return null;
		}

		public static string Persist(string settingsName, Uri endpoint, string authenticationType)
		{
			return null;
		}

		private SAMLEndpointSettings(string settingsName, Uri endpoint, string authenticationType)
		{
		}

		private static SettingsCollection.ObjectSettings LoadSettings(string endpointName)
		{
			return null;
		}
	}
}
