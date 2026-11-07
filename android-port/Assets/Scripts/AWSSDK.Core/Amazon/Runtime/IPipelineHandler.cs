using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F4")]
	public interface IPipelineHandler
	{
		[Token(Token = "0x1700023C")]
		ILogger Logger
		{
			[Token(Token = "0x6000857")]
			get;
			[Token(Token = "0x6000858")]
			set;
		}

		[Token(Token = "0x1700023D")]
		IPipelineHandler InnerHandler
		{
			[Token(Token = "0x6000859")]
			get;
			[Token(Token = "0x600085A")]
			set;
		}

		[Token(Token = "0x1700023E")]
		IPipelineHandler OuterHandler
		{
			[Token(Token = "0x600085B")]
			get;
			[Token(Token = "0x600085C")]
			set;
		}

		[Token(Token = "0x600085D")]
		void InvokeSync(IExecutionContext executionContext);

		[Token(Token = "0x600085E")]
		Task<T> InvokeAsync<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new();
	}
}
