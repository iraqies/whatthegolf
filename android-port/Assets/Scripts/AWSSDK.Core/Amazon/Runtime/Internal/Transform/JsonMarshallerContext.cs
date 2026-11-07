using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000215")]
	public class JsonMarshallerContext : MarshallerContext
	{
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27BA8", Offset = "0x27BA8")]
		private JsonWriter Writer__BackingField;

		[Token(Token = "0x17000405")]
		public JsonWriter Writer
		{
			[Token(Token = "0x6001012")]
			[Address(RVA = "0x122F7F8", Offset = "0x122F7F8", VA = "0x122F7F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD30", Offset = "0x2BD30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x122F800", Offset = "0x122F800", VA = "0x122F800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BD40", Offset = "0x2BD40")]
			private set
			{
			}
		}

		[Token(Token = "0x6001014")]
		[Address(RVA = "0x122F808", Offset = "0x122F808", VA = "0x122F808")]
		public JsonMarshallerContext(IRequest request, JsonWriter writer)
		{
		}
	}
}
