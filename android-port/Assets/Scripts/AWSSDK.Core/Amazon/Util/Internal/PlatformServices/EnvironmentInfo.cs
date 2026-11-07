namespace Amazon.Util.Internal.PlatformServices
{
	public class EnvironmentInfo : IEnvironmentInfo
	{
		public string Platform { get; private set; }

		public string Model { get; private set; }

		public string Make { get; private set; }

		public string PlatformVersion { get; private set; }

		public string Locale { get; private set; }

		public string PclPlatform { get; private set; }

		public string PlatformUserAgent { get; private set; }

		public string FrameworkUserAgent { get; private set; }
	}
}
