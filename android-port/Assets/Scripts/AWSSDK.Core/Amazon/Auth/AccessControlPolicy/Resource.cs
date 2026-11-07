using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000267")]
	public class Resource
	{
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x10")]
		private string resource;

		[Token(Token = "0x1700046B")]
		public string Id
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x125F020", Offset = "0x125F020", VA = "0x125F020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x125EFF4", Offset = "0x125EFF4", VA = "0x125EFF4")]
		public Resource(string resource)
		{
		}
	}
}
