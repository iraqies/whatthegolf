using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x200007A")]
	public class RootConfig
	{
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26578", Offset = "0x26578")]
		private CSMConfig CSMConfig__BackingField;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26588", Offset = "0x26588")]
		private LoggingConfig Logging__BackingField;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26598", Offset = "0x26598")]
		private ProxyConfig Proxy__BackingField;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265A8", Offset = "0x265A8")]
		private string EndpointDefinition__BackingField;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265B8", Offset = "0x265B8")]
		private string Region__BackingField;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265C8", Offset = "0x265C8")]
		private string ProfileName__BackingField;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265D8", Offset = "0x265D8")]
		private string ProfilesLocation__BackingField;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265E8", Offset = "0x265E8")]
		private bool UseSdkCache__BackingField;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x265F8", Offset = "0x265F8")]
		private bool CorrectForClockSkew__BackingField;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x4A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26608", Offset = "0x26608")]
		private bool UseAlternateUserAgentHeader__BackingField;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26618", Offset = "0x26618")]
		private string ApplicationName__BackingField;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26628", Offset = "0x26628")]
		private bool? CSMEnabled__BackingField;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26638", Offset = "0x26638")]
		private string CSMClientId__BackingField;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26648", Offset = "0x26648")]
		private int? CSMPort__BackingField;

		[Token(Token = "0x400026F")]
		private const string _rootAwsSectionName = "aws";

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26658", Offset = "0x26658")]
		private IDictionary<string, XElement> ServiceSections__BackingField;

		[Token(Token = "0x17000103")]
		public CSMConfig CSMConfig
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1263E5C", Offset = "0x1263E5C", VA = "0x1263E5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x286DC", Offset = "0x286DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1263E64", Offset = "0x1263E64", VA = "0x1263E64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x286EC", Offset = "0x286EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public LoggingConfig Logging
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1263E6C", Offset = "0x1263E6C", VA = "0x1263E6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x286FC", Offset = "0x286FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1263E74", Offset = "0x1263E74", VA = "0x1263E74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2870C", Offset = "0x2870C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public ProxyConfig Proxy
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1263E7C", Offset = "0x1263E7C", VA = "0x1263E7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2871C", Offset = "0x2871C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1263E84", Offset = "0x1263E84", VA = "0x1263E84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2872C", Offset = "0x2872C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public string EndpointDefinition
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1263E8C", Offset = "0x1263E8C", VA = "0x1263E8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2873C", Offset = "0x2873C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1263E94", Offset = "0x1263E94", VA = "0x1263E94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2874C", Offset = "0x2874C")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public string Region
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1263E9C", Offset = "0x1263E9C", VA = "0x1263E9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2875C", Offset = "0x2875C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1263EA4", Offset = "0x1263EA4", VA = "0x1263EA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2876C", Offset = "0x2876C")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public string ProfileName
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1263EAC", Offset = "0x1263EAC", VA = "0x1263EAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2877C", Offset = "0x2877C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1263EB4", Offset = "0x1263EB4", VA = "0x1263EB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2878C", Offset = "0x2878C")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public string ProfilesLocation
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1263EBC", Offset = "0x1263EBC", VA = "0x1263EBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2879C", Offset = "0x2879C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1263EC4", Offset = "0x1263EC4", VA = "0x1263EC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287AC", Offset = "0x287AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public RegionEndpoint RegionEndpoint
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1263ECC", Offset = "0x1263ECC", VA = "0x1263ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1263F5C", Offset = "0x1263F5C", VA = "0x1263F5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public bool UseSdkCache
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1263F74", Offset = "0x1263F74", VA = "0x1263F74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287BC", Offset = "0x287BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1263F7C", Offset = "0x1263F7C", VA = "0x1263F7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287CC", Offset = "0x287CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public bool CorrectForClockSkew
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1263F84", Offset = "0x1263F84", VA = "0x1263F84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287DC", Offset = "0x287DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1263F8C", Offset = "0x1263F8C", VA = "0x1263F8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287EC", Offset = "0x287EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public bool UseAlternateUserAgentHeader
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1263F94", Offset = "0x1263F94", VA = "0x1263F94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x287FC", Offset = "0x287FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1263F9C", Offset = "0x1263F9C", VA = "0x1263F9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2880C", Offset = "0x2880C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public string ApplicationName
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1263FA4", Offset = "0x1263FA4", VA = "0x1263FA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2881C", Offset = "0x2881C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1263FAC", Offset = "0x1263FAC", VA = "0x1263FAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2882C", Offset = "0x2882C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public bool? CSMEnabled
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1263FB4", Offset = "0x1263FB4", VA = "0x1263FB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2883C", Offset = "0x2883C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1263FBC", Offset = "0x1263FBC", VA = "0x1263FBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2884C", Offset = "0x2884C")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public string CSMClientId
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1263FC4", Offset = "0x1263FC4", VA = "0x1263FC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2885C", Offset = "0x2885C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1263FCC", Offset = "0x1263FCC", VA = "0x1263FCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2886C", Offset = "0x2886C")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public int? CSMPort
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1263FD4", Offset = "0x1263FD4", VA = "0x1263FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2887C", Offset = "0x2887C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1263FDC", Offset = "0x1263FDC", VA = "0x1263FDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2888C", Offset = "0x2888C")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		private IDictionary<string, XElement> ServiceSections
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x126413C", Offset = "0x126413C", VA = "0x126413C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2889C", Offset = "0x2889C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1264144", Offset = "0x1264144", VA = "0x1264144")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x288AC", Offset = "0x288AC")]
			set
			{
			}
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1263FE4", Offset = "0x1263FE4", VA = "0x1263FE4")]
		public RootConfig()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x126410C", Offset = "0x126410C", VA = "0x126410C")]
		private static string Choose(string a, string b)
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x126414C", Offset = "0x126414C", VA = "0x126414C")]
		public XElement GetServiceSection(string service)
		{
			return null;
		}
	}
}
