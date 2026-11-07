using System.Threading;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E5")]
	public interface IRequestContext
	{
		[Token(Token = "0x17000218")]
		AmazonWebServiceRequest OriginalRequest
		{
			[Token(Token = "0x60007F6")]
			get;
		}

		[Token(Token = "0x17000219")]
		string RequestName
		{
			[Token(Token = "0x60007F7")]
			get;
		}

		[Token(Token = "0x1700021A")]
		IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller
		{
			[Token(Token = "0x60007F8")]
			get;
		}

		[Token(Token = "0x1700021B")]
		ResponseUnmarshaller Unmarshaller
		{
			[Token(Token = "0x60007F9")]
			get;
		}

		[Token(Token = "0x1700021C")]
		InvokeOptionsBase Options
		{
			[Token(Token = "0x60007FA")]
			get;
		}

		[Token(Token = "0x1700021D")]
		RequestMetrics Metrics
		{
			[Token(Token = "0x60007FB")]
			get;
		}

		[Token(Token = "0x1700021E")]
		AbstractAWSSigner Signer
		{
			[Token(Token = "0x60007FC")]
			get;
		}

		[Token(Token = "0x1700021F")]
		IClientConfig ClientConfig
		{
			[Token(Token = "0x60007FD")]
			get;
		}

		[Token(Token = "0x17000220")]
		ImmutableCredentials ImmutableCredentials
		{
			[Token(Token = "0x60007FE")]
			get;
			[Token(Token = "0x60007FF")]
			set;
		}

		[Token(Token = "0x17000221")]
		IRequest Request
		{
			[Token(Token = "0x6000800")]
			get;
			[Token(Token = "0x6000801")]
			set;
		}

		[Token(Token = "0x17000222")]
		bool IsSigned
		{
			[Token(Token = "0x6000802")]
			get;
			[Token(Token = "0x6000803")]
			set;
		}

		[Token(Token = "0x17000223")]
		bool IsAsync
		{
			[Token(Token = "0x6000804")]
			get;
		}

		[Token(Token = "0x17000224")]
		int Retries
		{
			[Token(Token = "0x6000805")]
			get;
			[Token(Token = "0x6000806")]
			set;
		}

		[Token(Token = "0x17000225")]
		CapacityManager.CapacityType LastCapacityType
		{
			[Token(Token = "0x6000807")]
			get;
			[Token(Token = "0x6000808")]
			set;
		}

		[Token(Token = "0x17000226")]
		int EndpointDiscoveryRetries
		{
			[Token(Token = "0x6000809")]
			get;
			[Token(Token = "0x600080A")]
			set;
		}

		[Token(Token = "0x17000227")]
		CancellationToken CancellationToken
		{
			[Token(Token = "0x600080B")]
			get;
		}

		[Token(Token = "0x17000228")]
		MonitoringAPICallAttempt CSMCallAttempt
		{
			[Token(Token = "0x600080C")]
			get;
			[Token(Token = "0x600080D")]
			set;
		}

		[Token(Token = "0x17000229")]
		MonitoringAPICallEvent CSMCallEvent
		{
			[Token(Token = "0x600080E")]
			get;
			[Token(Token = "0x600080F")]
			set;
		}

		[Token(Token = "0x1700022A")]
		IServiceMetadata ServiceMetaData
		{
			[Token(Token = "0x6000810")]
			get;
		}

		[Token(Token = "0x1700022B")]
		bool CSMEnabled
		{
			[Token(Token = "0x6000811")]
			get;
		}

		[Token(Token = "0x1700022C")]
		bool IsLastExceptionRetryable
		{
			[Token(Token = "0x6000812")]
			get;
			[Token(Token = "0x6000813")]
			set;
		}
	}
}
