using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000FB")]
	public class HeadersRequestEventArgs : RequestEventArgs
	{
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26CE8", Offset = "0x26CE8")]
		private IDictionary<string, string> Headers__BackingField;

		[Token(Token = "0x1700024F")]
		public IDictionary<string, string> Headers
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x120E568", Offset = "0x120E568", VA = "0x120E568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x296FC", Offset = "0x296FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x120E570", Offset = "0x120E570", VA = "0x120E570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2970C", Offset = "0x2970C")]
			protected set
			{
			}
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x120E560", Offset = "0x120E560", VA = "0x120E560")]
		protected HeadersRequestEventArgs()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x120E578", Offset = "0x120E578", VA = "0x120E578")]
		internal static HeadersRequestEventArgs Create(IDictionary<string, string> headers)
		{
			return null;
		}
	}
}
