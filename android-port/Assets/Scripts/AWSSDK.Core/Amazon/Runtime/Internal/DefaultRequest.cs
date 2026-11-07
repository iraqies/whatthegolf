using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200014D")]
	public class DefaultRequest : IRequest
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C78", Offset = "0x25C78")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400054B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400054C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Stream, bool> _003C_003E9__68_0;

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x128A6C0", Offset = "0x128A6C0", VA = "0x128A6C0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x128A6C8", Offset = "0x128A6C8", VA = "0x128A6C8")]
			internal bool _003CComputeContentStreamHash_003Eb__68_0(Stream s)
			{
				return default;
			}
		}

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x10")]
		private readonly ParameterCollection parametersCollection;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDictionary<string, string> parametersFacade;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDictionary<string, string> headers;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x28")]
		private readonly IDictionary<string, string> subResources;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x30")]
		private readonly IDictionary<string, string> pathResources;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x38")]
		private Uri endpoint;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x40")]
		private string resourcePath;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x48")]
		private string serviceName;

		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x50")]
		private readonly AmazonWebServiceRequest originalRequest;

		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x58")]
		private byte[] content;

		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x60")]
		private Stream contentStream;

		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x68")]
		private string contentStreamHash;

		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x70")]
		private string httpMethod;

		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x78")]
		private bool useQueryString;

		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x80")]
		private string requestName;

		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x88")]
		private string canonicalResource;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x90")]
		private RegionEndpoint alternateRegion;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x98")]
		private long originalStreamLength;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0xA0")]
		private int marshallerVersion;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27128", Offset = "0x27128")]
		private bool SetContentFromParameters__BackingField;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27138", Offset = "0x27138")]
		private string HostPrefix__BackingField;

		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27148", Offset = "0x27148")]
		private bool Suppress404Exceptions__BackingField;

		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27158", Offset = "0x27158")]
		private AWS4SigningResult AWS4SignerResult__BackingField;

		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27168", Offset = "0x27168")]
		private bool UseChunkEncoding__BackingField;

		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27178", Offset = "0x27178")]
		private string CanonicalResourcePrefix__BackingField;

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27188", Offset = "0x27188")]
		private bool UseSigV4__BackingField;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27198", Offset = "0x27198")]
		private string AuthenticationRegion__BackingField;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x271A8", Offset = "0x271A8")]
		private string DeterminedSigningRegion__BackingField;

		[Token(Token = "0x170002B5")]
		public string RequestName
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x11EF2D4", Offset = "0x11EF2D4", VA = "0x11EF2D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B6")]
		public string HttpMethod
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x11EF2DC", Offset = "0x11EF2DC", VA = "0x11EF2DC", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x11EF2E4", Offset = "0x11EF2E4", VA = "0x11EF2E4", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public bool UseQueryString
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x11EF2EC", Offset = "0x11EF2EC", VA = "0x11EF2EC", Slot = "6")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x11EF35C", Offset = "0x11EF35C", VA = "0x11EF35C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public AmazonWebServiceRequest OriginalRequest
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x11EF364", Offset = "0x11EF364", VA = "0x11EF364", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B9")]
		public IDictionary<string, string> Headers
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x11EF36C", Offset = "0x11EF36C", VA = "0x11EF36C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002BA")]
		public IDictionary<string, string> Parameters
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x11EF374", Offset = "0x11EF374", VA = "0x11EF374", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002BB")]
		public ParameterCollection ParameterCollection
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x11EF37C", Offset = "0x11EF37C", VA = "0x11EF37C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002BC")]
		public IDictionary<string, string> SubResources
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x11EF384", Offset = "0x11EF384", VA = "0x11EF384", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002BD")]
		public Uri Endpoint
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x11EF528", Offset = "0x11EF528", VA = "0x11EF528", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x11EF530", Offset = "0x11EF530", VA = "0x11EF530", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public string ResourcePath
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x11EF538", Offset = "0x11EF538", VA = "0x11EF538", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x11EF540", Offset = "0x11EF540", VA = "0x11EF540", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x170002BF")]
		public IDictionary<string, string> PathResources
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x11EF548", Offset = "0x11EF548", VA = "0x11EF548", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C0")]
		public int MarshallerVersion
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x11EF620", Offset = "0x11EF620", VA = "0x11EF620", Slot = "21")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x11EF628", Offset = "0x11EF628", VA = "0x11EF628", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x170002C1")]
		public string CanonicalResource
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x11EF630", Offset = "0x11EF630", VA = "0x11EF630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x11EF638", Offset = "0x11EF638", VA = "0x11EF638")]
			set
			{
			}
		}

		[Token(Token = "0x170002C2")]
		public byte[] Content
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x11EF640", Offset = "0x11EF640", VA = "0x11EF640", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x11EF648", Offset = "0x11EF648", VA = "0x11EF648", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x170002C3")]
		public bool SetContentFromParameters
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x11EF650", Offset = "0x11EF650", VA = "0x11EF650", Slot = "26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A054", Offset = "0x2A054")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x11EF658", Offset = "0x11EF658", VA = "0x11EF658", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A064", Offset = "0x2A064")]
			set
			{
			}
		}

		[Token(Token = "0x170002C4")]
		public Stream ContentStream
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x11EF660", Offset = "0x11EF660", VA = "0x11EF660", Slot = "28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x11EF668", Offset = "0x11EF668", VA = "0x11EF668", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x170002C5")]
		public long OriginalStreamPosition
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x11EF6D0", Offset = "0x11EF6D0", VA = "0x11EF6D0", Slot = "30")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x11EF6D8", Offset = "0x11EF6D8", VA = "0x11EF6D8", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x170002C6")]
		public string ServiceName
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x11EF994", Offset = "0x11EF994", VA = "0x11EF994", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C7")]
		public RegionEndpoint AlternateEndpoint
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x11EF99C", Offset = "0x11EF99C", VA = "0x11EF99C", Slot = "35")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x11EF9A4", Offset = "0x11EF9A4", VA = "0x11EF9A4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170002C8")]
		public string HostPrefix
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x11EF9AC", Offset = "0x11EF9AC", VA = "0x11EF9AC", Slot = "37")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A074", Offset = "0x2A074")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x11EF9B4", Offset = "0x11EF9B4", VA = "0x11EF9B4", Slot = "38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A084", Offset = "0x2A084")]
			set
			{
			}
		}

		[Token(Token = "0x170002C9")]
		public bool Suppress404Exceptions
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x11EF9BC", Offset = "0x11EF9BC", VA = "0x11EF9BC", Slot = "39")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A094", Offset = "0x2A094")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x11EF9C4", Offset = "0x11EF9C4", VA = "0x11EF9C4", Slot = "40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0A4", Offset = "0x2A0A4")]
			set
			{
			}
		}

		[Token(Token = "0x170002CA")]
		public AWS4SigningResult AWS4SignerResult
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x11EF9CC", Offset = "0x11EF9CC", VA = "0x11EF9CC", Slot = "41")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0B4", Offset = "0x2A0B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x11EF9D4", Offset = "0x11EF9D4", VA = "0x11EF9D4", Slot = "42")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0C4", Offset = "0x2A0C4")]
			set
			{
			}
		}

		[Token(Token = "0x170002CB")]
		public bool UseChunkEncoding
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x11EF9DC", Offset = "0x11EF9DC", VA = "0x11EF9DC", Slot = "43")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0D4", Offset = "0x2A0D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x11EF9E4", Offset = "0x11EF9E4", VA = "0x11EF9E4", Slot = "44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0E4", Offset = "0x2A0E4")]
			set
			{
			}
		}

		[Token(Token = "0x170002CC")]
		public string CanonicalResourcePrefix
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x11EF9EC", Offset = "0x11EF9EC", VA = "0x11EF9EC", Slot = "45")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0F4", Offset = "0x2A0F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x11EF9F4", Offset = "0x11EF9F4", VA = "0x11EF9F4", Slot = "46")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A104", Offset = "0x2A104")]
			set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		public bool UseSigV4
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x11EF9FC", Offset = "0x11EF9FC", VA = "0x11EF9FC", Slot = "47")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A114", Offset = "0x2A114")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x11EFA04", Offset = "0x11EFA04", VA = "0x11EFA04", Slot = "48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A124", Offset = "0x2A124")]
			set
			{
			}
		}

		[Token(Token = "0x170002CE")]
		public string AuthenticationRegion
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x11EFA0C", Offset = "0x11EFA0C", VA = "0x11EFA0C", Slot = "49")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A134", Offset = "0x2A134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x11EFA14", Offset = "0x11EFA14", VA = "0x11EFA14", Slot = "50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A144", Offset = "0x2A144")]
			set
			{
			}
		}

		[Token(Token = "0x170002CF")]
		public string DeterminedSigningRegion
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x11EFA1C", Offset = "0x11EFA1C", VA = "0x11EFA1C", Slot = "51")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A154", Offset = "0x2A154")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x11EFA24", Offset = "0x11EFA24", VA = "0x11EFA24", Slot = "52")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A164", Offset = "0x2A164")]
			set
			{
			}
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x11EEF30", Offset = "0x11EEF30", VA = "0x11EEF30")]
		public DefaultRequest(AmazonWebServiceRequest request, string serviceName)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x11EF38C", Offset = "0x11EF38C", VA = "0x11EF38C", Slot = "11")]
		public void AddSubResource(string subResource)
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x11EF458", Offset = "0x11EF458", VA = "0x11EF458", Slot = "12")]
		public void AddSubResource(string subResource, string value)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x11EF550", Offset = "0x11EF550", VA = "0x11EF550", Slot = "20")]
		public void AddPathResource(string key, string value)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x11EF6E0", Offset = "0x11EF6E0", VA = "0x11EF6E0", Slot = "32")]
		public string ComputeContentStreamHash()
		{
			return null;
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x11EFA2C", Offset = "0x11EFA2C", VA = "0x11EFA2C", Slot = "53")]
		public bool IsRequestStreamRewindable()
		{
			return default;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x11EFA68", Offset = "0x11EFA68", VA = "0x11EFA68", Slot = "54")]
		public bool MayContainRequestBody()
		{
			return default;
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x11EFB24", Offset = "0x11EFB24", VA = "0x11EFB24", Slot = "55")]
		public bool HasRequestBody()
		{
			return default;
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x11EFC18", Offset = "0x11EFC18", VA = "0x11EFC18", Slot = "25")]
		public string GetHeaderValue(string headerName)
		{
			return null;
		}
	}
}
