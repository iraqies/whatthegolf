namespace Amazon.Util
{
	public class CSMConfig
	{
		internal const string DEFAULT_HOST = "127.0.0.1";

		internal const int DEFAULT_PORT = 31000;

		public string CSMHost { get; set; }

		public int CSMPort { get; set; }

		public string CSMClientId { get; set; }

		public bool? CSMEnabled { get; set; }
	}
}
