using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000FF")]
	public interface IMetricsFormatter
	{
		[Token(Token = "0x60008B1")]
		string FormatMetrics(IRequestMetrics metrics);
	}
}
