using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x200009A")]
	public abstract class AmazonServiceClient : IDisposable
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x259EC", Offset = "0x259EC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, string>, bool> _003C_003E9__62_0;

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1286EDC", Offset = "0x1286EDC", VA = "0x1286EDC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1286EE4", Offset = "0x1286EE4", VA = "0x1286EE4")]
			internal bool _003CComposeUrl_003Eb__62_0(KeyValuePair<string, string> v)
			{
				return default;
			}
		}

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x18")]
		private Logger _logger;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26728", Offset = "0x26728")]
		private EndpointDiscoveryResolverBase EndpointDiscoveryResolver__BackingField;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26738", Offset = "0x26738")]
		private RuntimePipeline RuntimePipeline__BackingField;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26748", Offset = "0x26748")]
		private AWSCredentials Credentials__BackingField;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26758", Offset = "0x26758")]
		private IClientConfig Config__BackingField;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26768", Offset = "0x26768")]
		private readonly IServiceMetadata ServiceMetadata__BackingField;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x48")]
		private PreRequestEventHandler mBeforeMarshallingEvent;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x50")]
		private RequestEventHandler mBeforeRequestEvent;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x58")]
		private ResponseEventHandler mAfterResponseEvent;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x60")]
		private ExceptionEventHandler mExceptionEvent;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26778", Offset = "0x26778")]
		private AbstractAWSSigner Signer__BackingField;

		[Token(Token = "0x1700015F")]
		protected EndpointDiscoveryResolverBase EndpointDiscoveryResolver
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x11C99C0", Offset = "0x11C99C0", VA = "0x11C99C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28ACC", Offset = "0x28ACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x11C99C8", Offset = "0x11C99C8", VA = "0x11C99C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28ADC", Offset = "0x28ADC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000160")]
		protected RuntimePipeline RuntimePipeline
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x11C99D0", Offset = "0x11C99D0", VA = "0x11C99D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28AEC", Offset = "0x28AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x11C99D8", Offset = "0x11C99D8", VA = "0x11C99D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28AFC", Offset = "0x28AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		protected internal AWSCredentials Credentials
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x11C99E0", Offset = "0x11C99E0", VA = "0x11C99E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B0C", Offset = "0x28B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x11C99E8", Offset = "0x11C99E8", VA = "0x11C99E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B1C", Offset = "0x28B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public IClientConfig Config
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x11C99F0", Offset = "0x11C99F0", VA = "0x11C99F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B2C", Offset = "0x28B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x11C99F8", Offset = "0x11C99F8", VA = "0x11C99F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B3C", Offset = "0x28B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000163")]
		protected virtual IServiceMetadata ServiceMetadata
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x11C9A00", Offset = "0x11C9A00", VA = "0x11C9A00", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B4C", Offset = "0x28B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		protected virtual bool SupportResponseLogging
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x11C9A08", Offset = "0x11C9A08", VA = "0x11C9A08", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000165")]
		protected AbstractAWSSigner Signer
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x11CAEA4", Offset = "0x11CAEA4", VA = "0x11CAEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B5C", Offset = "0x28B5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x11CAEAC", Offset = "0x11CAEAC", VA = "0x11CAEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28B6C", Offset = "0x28B6C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000004")]
		internal event PreRequestEventHandler BeforeMarshallingEvent
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x11C9A10", Offset = "0x11C9A10", VA = "0x11C9A10")]
			add
			{
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x11C9B38", Offset = "0x11C9B38", VA = "0x11C9B38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event RequestEventHandler BeforeRequestEvent
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x11C9C60", Offset = "0x11C9C60", VA = "0x11C9C60")]
			add
			{
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x11C9D88", Offset = "0x11C9D88", VA = "0x11C9D88")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event ResponseEventHandler AfterResponseEvent
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x11C9EB0", Offset = "0x11C9EB0", VA = "0x11C9EB0")]
			add
			{
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x11C9FD8", Offset = "0x11C9FD8", VA = "0x11C9FD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event ExceptionEventHandler ExceptionEvent
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x11CA100", Offset = "0x11CA100", VA = "0x11CA100")]
			add
			{
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x11CA228", Offset = "0x11CA228", VA = "0x11CA228")]
			remove
			{
			}
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11CA350", Offset = "0x11CA350", VA = "0x11CA350")]
		protected AmazonServiceClient(AWSCredentials credentials, ClientConfig config)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11CAEB4", Offset = "0x11CAEB4", VA = "0x11CAEB4")]
		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11CAF4C", Offset = "0x11CAF4C", VA = "0x11CAF4C")]
		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11CB02C", Offset = "0x11CB02C", VA = "0x11CB02C", Slot = "7")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x60005A2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x28B7C", Offset = "0x28B7C")]
		protected TResponse Invoke<TRequest, TResponse>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller) where TRequest : AmazonWebServiceRequest where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		protected TResponse Invoke<TResponse>(AmazonWebServiceRequest request, InvokeOptionsBase options) where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x28BB4", Offset = "0x28BB4")]
		protected Task<TResponse> InvokeAsync<TRequest, TResponse>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller, CancellationToken cancellationToken) where TRequest : AmazonWebServiceRequest where TResponse : AmazonWebServiceResponse, new()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		protected Task<TResponse> InvokeAsync<TResponse>(AmazonWebServiceRequest request, InvokeOptionsBase options, CancellationToken cancellationToken) where TResponse : AmazonWebServiceResponse, new()
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11CB030", Offset = "0x11CB030", VA = "0x11CB030", Slot = "8")]
		protected virtual IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11CB038", Offset = "0x11CB038", VA = "0x11CB038")]
		protected void ProcessPreRequestHandlers(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11CB1B0", Offset = "0x11CB1B0", VA = "0x11CB1B0")]
		protected void ProcessRequestHandlers(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11CB450", Offset = "0x11CB450", VA = "0x11CB450")]
		protected void ProcessResponseHandlers(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11CB7AC", Offset = "0x11CB7AC", VA = "0x11CB7AC", Slot = "9")]
		protected virtual void ProcessExceptionHandlers(IExecutionContext executionContext, Exception exception)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11CB934", Offset = "0x11CB934", VA = "0x11CB934", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11CB9B4", Offset = "0x11CB9B4", VA = "0x11CB9B4", Slot = "10")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11CB9FC", Offset = "0x11CB9FC", VA = "0x11CB9FC")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x60005AE")]
		protected abstract AbstractAWSSigner CreateSigner();

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11CBA78", Offset = "0x11CBA78", VA = "0x11CBA78", Slot = "12")]
		protected virtual void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x11CA514", Offset = "0x11CA514", VA = "0x11CA514")]
		private void BuildRuntimePipeline()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x11CBA7C", Offset = "0x11CBA7C", VA = "0x11CBA7C")]
		public static Uri ComposeUrl(IRequest iRequest)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x11CC92C", Offset = "0x11CC92C", VA = "0x11CC92C")]
		private static void DontUnescapePathDotsAndSlashes(Uri uri)
		{
		}

		[Token(Token = "0x60005B3")]
		internal C CloneConfig<C>() where C : ClientConfig, new()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x11CC930", Offset = "0x11CC930", VA = "0x11CC930")]
		internal void CloneConfig(ClientConfig newConfig)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x11CCD70", Offset = "0x11CCD70", VA = "0x11CCD70")]
		private static void SetupCSMHandler(IRequestContext requestContext)
		{
		}
	}
}
