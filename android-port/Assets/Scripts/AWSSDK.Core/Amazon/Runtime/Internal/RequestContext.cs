using System.Threading;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000177")]
	public class RequestContext : IRequestContext
	{
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x10")]
		private IServiceMetadata _serviceMetadata;

		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x18")]
		private AbstractAWSSigner clientSigner;

		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27278", Offset = "0x27278")]
		private IRequest Request__BackingField;

		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27288", Offset = "0x27288")]
		private RequestMetrics Metrics__BackingField;

		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27298", Offset = "0x27298")]
		private IClientConfig ClientConfig__BackingField;

		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272A8", Offset = "0x272A8")]
		private int Retries__BackingField;

		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272B8", Offset = "0x272B8")]
		private CapacityManager.CapacityType LastCapacityType__BackingField;

		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272C8", Offset = "0x272C8")]
		private int EndpointDiscoveryRetries__BackingField;

		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272D8", Offset = "0x272D8")]
		private bool IsSigned__BackingField;

		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x45")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272E8", Offset = "0x272E8")]
		private bool IsAsync__BackingField;

		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x272F8", Offset = "0x272F8")]
		private AmazonWebServiceRequest OriginalRequest__BackingField;

		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27308", Offset = "0x27308")]
		private IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller__BackingField;

		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27318", Offset = "0x27318")]
		private ResponseUnmarshaller Unmarshaller__BackingField;

		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27328", Offset = "0x27328")]
		private InvokeOptionsBase Options__BackingField;

		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27338", Offset = "0x27338")]
		private ImmutableCredentials ImmutableCredentials__BackingField;

		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27348", Offset = "0x27348")]
		private CancellationToken CancellationToken__BackingField;

		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27358", Offset = "0x27358")]
		private MonitoringAPICallAttempt CSMCallAttempt__BackingField;

		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27368", Offset = "0x27368")]
		private MonitoringAPICallEvent CSMCallEvent__BackingField;

		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27378", Offset = "0x27378")]
		private bool CSMEnabled__BackingField;

		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x89")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27388", Offset = "0x27388")]
		private bool IsLastExceptionRetryable__BackingField;

		[Token(Token = "0x1700031B")]
		public IRequest Request
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x125C8F4", Offset = "0x125C8F4", VA = "0x125C8F4", Slot = "14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A394", Offset = "0x2A394")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x125C8FC", Offset = "0x125C8FC", VA = "0x125C8FC", Slot = "15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A4", Offset = "0x2A3A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700031C")]
		public RequestMetrics Metrics
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x125C904", Offset = "0x125C904", VA = "0x125C904", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B4", Offset = "0x2A3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x125C90C", Offset = "0x125C90C", VA = "0x125C90C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3C4", Offset = "0x2A3C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700031D")]
		public IClientConfig ClientConfig
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x125C914", Offset = "0x125C914", VA = "0x125C914", Slot = "11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3D4", Offset = "0x2A3D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x125C91C", Offset = "0x125C91C", VA = "0x125C91C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3E4", Offset = "0x2A3E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700031E")]
		public int Retries
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x125C924", Offset = "0x125C924", VA = "0x125C924", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3F4", Offset = "0x2A3F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x125C92C", Offset = "0x125C92C", VA = "0x125C92C", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A404", Offset = "0x2A404")]
			set
			{
			}
		}

		[Token(Token = "0x1700031F")]
		public CapacityManager.CapacityType LastCapacityType
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x125C934", Offset = "0x125C934", VA = "0x125C934", Slot = "21")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A414", Offset = "0x2A414")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x125C93C", Offset = "0x125C93C", VA = "0x125C93C", Slot = "22")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A424", Offset = "0x2A424")]
			set
			{
			}
		}

		[Token(Token = "0x17000320")]
		public int EndpointDiscoveryRetries
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x125C944", Offset = "0x125C944", VA = "0x125C944", Slot = "23")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A434", Offset = "0x2A434")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x125C94C", Offset = "0x125C94C", VA = "0x125C94C", Slot = "24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A444", Offset = "0x2A444")]
			set
			{
			}
		}

		[Token(Token = "0x17000321")]
		public bool IsSigned
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x125C954", Offset = "0x125C954", VA = "0x125C954", Slot = "16")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A454", Offset = "0x2A454")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x125C95C", Offset = "0x125C95C", VA = "0x125C95C", Slot = "17")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A464", Offset = "0x2A464")]
			set
			{
			}
		}

		[Token(Token = "0x17000322")]
		public bool IsAsync
		{
			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x125C964", Offset = "0x125C964", VA = "0x125C964", Slot = "18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A474", Offset = "0x2A474")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0x125C96C", Offset = "0x125C96C", VA = "0x125C96C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A484", Offset = "0x2A484")]
			set
			{
			}
		}

		[Token(Token = "0x17000323")]
		public AmazonWebServiceRequest OriginalRequest
		{
			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x125C974", Offset = "0x125C974", VA = "0x125C974", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A494", Offset = "0x2A494")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x125C97C", Offset = "0x125C97C", VA = "0x125C97C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4A4", Offset = "0x2A4A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000324")]
		public IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller
		{
			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x125C984", Offset = "0x125C984", VA = "0x125C984", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4B4", Offset = "0x2A4B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x125C98C", Offset = "0x125C98C", VA = "0x125C98C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4C4", Offset = "0x2A4C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000325")]
		public ResponseUnmarshaller Unmarshaller
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x125C994", Offset = "0x125C994", VA = "0x125C994", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4D4", Offset = "0x2A4D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x125C99C", Offset = "0x125C99C", VA = "0x125C99C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4E4", Offset = "0x2A4E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000326")]
		public InvokeOptionsBase Options
		{
			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x125C9A4", Offset = "0x125C9A4", VA = "0x125C9A4", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4F4", Offset = "0x2A4F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x125C9AC", Offset = "0x125C9AC", VA = "0x125C9AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A504", Offset = "0x2A504")]
			set
			{
			}
		}

		[Token(Token = "0x17000327")]
		public ImmutableCredentials ImmutableCredentials
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x125C9B4", Offset = "0x125C9B4", VA = "0x125C9B4", Slot = "12")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A514", Offset = "0x2A514")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x125C9BC", Offset = "0x125C9BC", VA = "0x125C9BC", Slot = "13")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A524", Offset = "0x2A524")]
			set
			{
			}
		}

		[Token(Token = "0x17000328")]
		public AbstractAWSSigner Signer
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x125C9C4", Offset = "0x125C9C4", VA = "0x125C9C4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000329")]
		public CancellationToken CancellationToken
		{
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x125C9F8", Offset = "0x125C9F8", VA = "0x125C9F8", Slot = "25")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A534", Offset = "0x2A534")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x125CA00", Offset = "0x125CA00", VA = "0x125CA00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A544", Offset = "0x2A544")]
			set
			{
			}
		}

		[Token(Token = "0x1700032A")]
		public string RequestName
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x125CA08", Offset = "0x125CA08", VA = "0x125CA08", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032B")]
		public MonitoringAPICallAttempt CSMCallAttempt
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x125CA38", Offset = "0x125CA38", VA = "0x125CA38", Slot = "26")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A554", Offset = "0x2A554")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x125CA40", Offset = "0x125CA40", VA = "0x125CA40", Slot = "27")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A564", Offset = "0x2A564")]
			set
			{
			}
		}

		[Token(Token = "0x1700032C")]
		public MonitoringAPICallEvent CSMCallEvent
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x125CA48", Offset = "0x125CA48", VA = "0x125CA48", Slot = "28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A574", Offset = "0x2A574")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x125CA50", Offset = "0x125CA50", VA = "0x125CA50", Slot = "29")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A584", Offset = "0x2A584")]
			set
			{
			}
		}

		[Token(Token = "0x1700032D")]
		public IServiceMetadata ServiceMetaData
		{
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x125CA58", Offset = "0x125CA58", VA = "0x125CA58", Slot = "30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x125CA60", Offset = "0x125CA60", VA = "0x125CA60")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700032E")]
		public bool CSMEnabled
		{
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x125CBD8", Offset = "0x125CBD8", VA = "0x125CBD8", Slot = "31")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A594", Offset = "0x2A594")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x125CBE0", Offset = "0x125CBE0", VA = "0x125CBE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5A4", Offset = "0x2A5A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700032F")]
		public bool IsLastExceptionRetryable
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x125CBE8", Offset = "0x125CBE8", VA = "0x125CBE8", Slot = "32")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5B4", Offset = "0x2A5B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x125CBF0", Offset = "0x125CBF0", VA = "0x125CBF0", Slot = "33")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5C4", Offset = "0x2A5C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x125C620", Offset = "0x125C620", VA = "0x125C620")]
		public RequestContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}
	}
}
