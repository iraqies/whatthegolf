using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000A0")]
	public class AmazonWebServiceResponse
	{
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x10")]
		private ResponseMetadata responseMetadataField;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		private long contentLength;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x20")]
		private HttpStatusCode httpStatusCode;

		[Token(Token = "0x17000174")]
		public ResponseMetadata ResponseMetadata
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x11CDAF0", Offset = "0x11CDAF0", VA = "0x11CDAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x11CDAF8", Offset = "0x11CDAF8", VA = "0x11CDAF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public long ContentLength
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x11CDB00", Offset = "0x11CDB00", VA = "0x11CDB00")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x11CDB08", Offset = "0x11CDB08", VA = "0x11CDB08")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public HttpStatusCode HttpStatusCode
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x11CDB10", Offset = "0x11CDB10", VA = "0x11CDB10")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x11CDB18", Offset = "0x11CDB18", VA = "0x11CDB18")]
			set
			{
			}
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x11CDB20", Offset = "0x11CDB20", VA = "0x11CDB20")]
		public AmazonWebServiceResponse()
		{
		}
	}
}
