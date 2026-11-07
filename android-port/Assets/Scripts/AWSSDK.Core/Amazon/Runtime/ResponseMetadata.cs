using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x2000104")]
	public class ResponseMetadata
	{
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x10")]
		private string requestIdField;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x18")]
		private IDictionary<string, string> _metadata;

		[Token(Token = "0x1700025E")]
		public string RequestId
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x125F8DC", Offset = "0x125F8DC", VA = "0x125F8DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x125F8E4", Offset = "0x125F8E4", VA = "0x125F8E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700025F")]
		public IDictionary<string, string> Metadata
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x125F8EC", Offset = "0x125F8EC", VA = "0x125F8EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x125F968", Offset = "0x125F968", VA = "0x125F968")]
		public ResponseMetadata()
		{
		}
	}
}
