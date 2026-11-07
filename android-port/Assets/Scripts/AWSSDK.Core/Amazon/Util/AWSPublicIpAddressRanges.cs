using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Util
{
	[Token(Token = "0x2000046")]
	public class AWSPublicIpAddressRanges
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25714", Offset = "0x25714")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x4000168")]
			[FieldOffset(Offset = "0x10")]
			public string serviceKey;

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1285320", Offset = "0x1285320", VA = "0x1285320")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1285328", Offset = "0x1285328", VA = "0x1285328")]
			internal bool _003CAddressRangesByServiceKey_003Eb__0(AWSPublicIpAddressRange ar)
			{
				return default;
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25724", Offset = "0x25724")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x4000169")]
			[FieldOffset(Offset = "0x10")]
			public string regionIdentifier;

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1285358", Offset = "0x1285358", VA = "0x1285358")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1285360", Offset = "0x1285360", VA = "0x1285360")]
			internal bool _003CAddressRangesByRegion_003Eb__0(AWSPublicIpAddressRange ar)
			{
				return default;
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25734", Offset = "0x25734")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x400016A")]
			[FieldOffset(Offset = "0x10")]
			public string networkBorderGroup;

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1285390", Offset = "0x1285390", VA = "0x1285390")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1285398", Offset = "0x1285398", VA = "0x1285398")]
			internal bool _003CAddressRangesByNetworkBorderGroup_003Eb__0(AWSPublicIpAddressRange ar)
			{
				return default;
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25744", Offset = "0x25744")]
		private sealed class _003C_003Ec__DisplayClass31_0
		{
			[Token(Token = "0x400016B")]
			[FieldOffset(Offset = "0x10")]
			public AWSPublicIpAddressRange.AddressFormat addressFormat;

			[Token(Token = "0x400016C")]
			[FieldOffset(Offset = "0x18")]
			public string prefixKey;

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x12853C8", Offset = "0x12853C8", VA = "0x12853C8")]
			public _003C_003Ec__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x12853D0", Offset = "0x12853D0", VA = "0x12853D0")]
			internal AWSPublicIpAddressRange _003CParseRange_003Eb__0(JsonData range)
			{
				return null;
			}
		}

		[Token(Token = "0x4000156")]
		public const string AmazonServiceKey = "AMAZON";

		[Token(Token = "0x4000157")]
		public const string EC2ServiceKey = "EC2";

		[Token(Token = "0x4000158")]
		public const string CloudFrontServiceKey = "CLOUDFRONT";

		[Token(Token = "0x4000159")]
		public const string Route53ServiceKey = "ROUTE53";

		[Token(Token = "0x400015A")]
		public const string Route53HealthChecksServiceKey = "ROUTE53_HEALTHCHECKS";

		[Token(Token = "0x400015B")]
		public const string GlobalRegionIdentifier = "GLOBAL";

		[Token(Token = "0x400015C")]
		private const string createDateKey = "createDate";

		[Token(Token = "0x400015D")]
		private const string ipv4PrefixesKey = "prefixes";

		[Token(Token = "0x400015E")]
		private const string ipv4PrefixKey = "ip_prefix";

		[Token(Token = "0x400015F")]
		private const string ipv6PrefixesKey = "ipv6_prefixes";

		[Token(Token = "0x4000160")]
		private const string ipv6PrefixKey = "ipv6_prefix";

		[Token(Token = "0x4000161")]
		private const string regionKey = "region";

		[Token(Token = "0x4000162")]
		private const string serviceKey = "service";

		[Token(Token = "0x4000163")]
		private const string networkBorderGroupKey = "network_border_group";

		[Token(Token = "0x4000164")]
		private const string createDateFormatString = "yyyy-MM-dd-HH-mm-ss";

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x262F8", Offset = "0x262F8")]
		private DateTime CreateDate__BackingField;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26308", Offset = "0x26308")]
		private IEnumerable<AWSPublicIpAddressRange> AllAddressRanges__BackingField;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Uri IpAddressRangeEndpoint;

		[Token(Token = "0x1700009F")]
		public IEnumerable<string> ServiceKeys
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x11C1904", Offset = "0x11C1904", VA = "0x11C1904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public DateTime CreateDate
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x11C1CE0", Offset = "0x11C1CE0", VA = "0x11C1CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28190", Offset = "0x28190")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x11C1CE8", Offset = "0x11C1CE8", VA = "0x11C1CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x281A0", Offset = "0x281A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public IEnumerable<AWSPublicIpAddressRange> AllAddressRanges
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x11C1CF0", Offset = "0x11C1CF0", VA = "0x11C1CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x281B0", Offset = "0x281B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x11C1CF8", Offset = "0x11C1CF8", VA = "0x11C1CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x281C0", Offset = "0x281C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11C1D00", Offset = "0x11C1D00", VA = "0x11C1D00")]
		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByServiceKey(string serviceKey)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11C1E60", Offset = "0x11C1E60", VA = "0x11C1E60")]
		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByRegion(string regionIdentifier)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11C1FC0", Offset = "0x11C1FC0", VA = "0x11C1FC0")]
		public IEnumerable<AWSPublicIpAddressRange> AddressRangesByNetworkBorderGroup(string networkBorderGroup)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11C2120", Offset = "0x11C2120", VA = "0x11C2120")]
		public static AWSPublicIpAddressRanges Load()
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x11C217C", Offset = "0x11C217C", VA = "0x11C217C")]
		public static AWSPublicIpAddressRanges Load(IWebProxy proxy)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11C250C", Offset = "0x11C250C", VA = "0x11C250C")]
		private static AWSPublicIpAddressRanges Parse(string fileContent)
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11C2B40", Offset = "0x11C2B40", VA = "0x11C2B40")]
		private static IEnumerable<AWSPublicIpAddressRange> ParseRange(JsonData ranges, AWSPublicIpAddressRange.AddressFormat addressFormat)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11C2B38", Offset = "0x11C2B38", VA = "0x11C2B38")]
		private AWSPublicIpAddressRanges()
		{
		}
	}
}
