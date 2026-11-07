using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183994", Offset = "0x183994")]
	public interface ITraceWriter
	{
		[Token(Token = "0x17000085")]
		TraceLevel LevelFilter
		{
			[Token(Token = "0x60003D7")]
			get;
		}

		[Token(Token = "0x60003D8")]
		void Trace(TraceLevel level, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CBBC", Offset = "0x18CBBC")] Exception ex);
	}
}
