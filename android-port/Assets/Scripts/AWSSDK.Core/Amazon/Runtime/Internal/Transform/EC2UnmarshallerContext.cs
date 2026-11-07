using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000238")]
	public class EC2UnmarshallerContext : XmlUnmarshallerContext
	{
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27C38", Offset = "0x27C38")]
		private string RequestId__BackingField;

		[Token(Token = "0x1700043B")]
		public string RequestId
		{
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x11F874C", Offset = "0x11F874C", VA = "0x11F874C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE60", Offset = "0x2BE60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x11F8754", Offset = "0x11F8754", VA = "0x11F8754")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BE70", Offset = "0x2BE70")]
			private set
			{
			}
		}

		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x11F8678", Offset = "0x11F8678", VA = "0x11F8678")]
		public EC2UnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x11F875C", Offset = "0x11F875C", VA = "0x11F875C", Slot = "7")]
		public override bool Read()
		{
			return default;
		}
	}
}
