using System;
using System.Collections.Generic;
using System.Net;
using ThirdParty.Json.LitJson;

namespace Amazon.Util
{
	public class AWSPublicIpAddressRanges
	{
		public const string AmazonServiceKey = "AMAZON";

		public const string EC2ServiceKey = "EC2";

		public const string CloudFrontServiceKey = "CLOUDFRONT";

		public const string Route53ServiceKey = "ROUTE53";

		public const string Route53HealthChecksServiceKey = "ROUTE53_HEALTHCHECKS";

		public const string GlobalRegionIdentifier = "GLOBAL";

		private const string createDateKey = "createDate";

		private const string ipv4PrefixesKey = "prefixes";

		private const string ipv4PrefixKey = "ip_prefix";

		private const string ipv6PrefixesKey = "ipv6_prefixes";

		private const string ipv6PrefixKey = "ipv6_prefix";

		private const string regionKey = "region";

		private const string serviceKey = "service";

		private const string networkBorderGroupKey = "network_border_group";

		private const string createDateFormatString = "yyyy-MM-dd-HH-mm-ss";

		private static readonly Uri IpAddressRangeEndpoint;

		public IEnumerable<string> ServiceKeys => null;

		public DateTime CreateDate { get; private set; }

		public IEnumerable<AWSPublicIpAddressRange> AllAddressRanges { get; private set; }

		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByServiceKey(string serviceKey)
		{
			return null;
		}

		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByRegion(string regionIdentifier)
		{
			return null;
		}

		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByNetworkBorderGroup(string networkBorderGroup)
		{
			return null;
		}

		public static AWSPublicIpAddressRanges Load()
		{
			return null;
		}

		public static AWSPublicIpAddressRanges Load(IWebProxy proxy)
		{
			return null;
		}

		private static AWSPublicIpAddressRanges Parse(string fileContent)
		{
			return null;
		}

		private static IEnumerable<AWSPublicIpAddressRange> ParseRange(JsonData ranges, AWSPublicIpAddressRange.AddressFormat addressFormat)
		{
			return null;
		}

		private AWSPublicIpAddressRanges()
		{
		}
	}
}
