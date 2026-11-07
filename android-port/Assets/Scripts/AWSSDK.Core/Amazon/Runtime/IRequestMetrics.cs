using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000FD")]
	public interface IRequestMetrics
	{
		[Token(Token = "0x17000250")]
		Dictionary<Metric, List<object>> Properties
		{
			[Token(Token = "0x60008A9")]
			get;
		}

		[Token(Token = "0x17000251")]
		Dictionary<Metric, List<IMetricsTiming>> Timings
		{
			[Token(Token = "0x60008AA")]
			get;
		}

		[Token(Token = "0x17000252")]
		Dictionary<Metric, long> Counters
		{
			[Token(Token = "0x60008AB")]
			get;
		}

		[Token(Token = "0x17000253")]
		bool IsEnabled
		{
			[Token(Token = "0x60008AC")]
			get;
		}

		[Token(Token = "0x60008AD")]
		string ToJSON();
	}
}
