using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200016B")]
	public interface IRuntimePipelineCustomizer
	{
		[Token(Token = "0x17000316")]
		string UniqueName
		{
			[Token(Token = "0x6000B95")]
			get;
		}

		[Token(Token = "0x6000B96")]
		void Customize(Type type, RuntimePipeline pipeline);
	}
}
