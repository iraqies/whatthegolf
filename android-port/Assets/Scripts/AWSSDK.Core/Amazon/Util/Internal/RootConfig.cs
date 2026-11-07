using System.Collections.Generic;
using System.Xml.Linq;

namespace Amazon.Util.Internal
{
	public class RootConfig
	{
		private const string _rootAwsSectionName = "aws";

		public CSMConfig CSMConfig { get; set; }

		public LoggingConfig Logging { get; private set; }

		public ProxyConfig Proxy { get; private set; }

		public string EndpointDefinition { get; set; }

		public string Region { get; set; }

		public string ProfileName { get; set; }

		public string ProfilesLocation { get; set; }

		public RegionEndpoint RegionEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseSdkCache { get; set; }

		public bool CorrectForClockSkew { get; set; }

		public bool UseAlternateUserAgentHeader { get; set; }

		public string ApplicationName { get; set; }

		public bool? CSMEnabled { get; set; }

		public string CSMClientId { get; set; }

		public int? CSMPort { get; set; }

		private IDictionary<string, XElement> ServiceSections { get; set; }

		private static string Choose(string a, string b)
		{
			return null;
		}

		public XElement GetServiceSection(string service)
		{
			return null;
		}
	}
}
