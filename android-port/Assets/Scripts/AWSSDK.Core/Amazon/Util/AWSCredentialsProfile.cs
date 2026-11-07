using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;

namespace Amazon.Util
{
	[Obsolete]
	public class AWSCredentialsProfile : ProfileSettingsBase
	{
		public BasicAWSCredentials Credentials { get; private set; }

		public static bool CanCreateFrom(string profileName)
		{
			return false;
		}

		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return false;
		}

		public static AWSCredentialsProfile LoadFrom(string profileName)
		{
			return null;
		}

		public static AWSCredentialsProfile LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		public static void Validate(string profileName)
		{
		}

		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		public override string Persist()
		{
			return null;
		}

		public static string Persist(string profileName, string accessKeyId, string secretKey)
		{
			return null;
		}

		private AWSCredentialsProfile(string profileName, string accessKeyId, string secretKey)
		{
		}
	}
}
