using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000179")]
	public class ResponseContext : IResponseContext
	{
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x273B8", Offset = "0x273B8")]
		private AmazonWebServiceResponse Response__BackingField;

		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x273C8", Offset = "0x273C8")]
		private IWebResponseData HttpResponse__BackingField;

		[Token(Token = "0x17000332")]
		public AmazonWebServiceResponse Response
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x125F3B0", Offset = "0x125F3B0", VA = "0x125F3B0", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A614", Offset = "0x2A614")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x125F3B8", Offset = "0x125F3B8", VA = "0x125F3B8", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A624", Offset = "0x2A624")]
			set
			{
			}
		}

		[Token(Token = "0x17000333")]
		public IWebResponseData HttpResponse
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x125F3C0", Offset = "0x125F3C0", VA = "0x125F3C0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A634", Offset = "0x2A634")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x125F3C8", Offset = "0x125F3C8", VA = "0x125F3C8", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A644", Offset = "0x2A644")]
			set
			{
			}
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x125F3D0", Offset = "0x125F3D0", VA = "0x125F3D0")]
		public ResponseContext()
		{
		}
	}
}
