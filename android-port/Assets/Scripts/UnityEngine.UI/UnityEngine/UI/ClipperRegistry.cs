using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	[Token(Token = "0x200000A")]
	public class ClipperRegistry
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		private static ClipperRegistry s_Instance;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		private readonly IndexedSet<IClipper> m_Clippers;

		[Token(Token = "0x17000012")]
		public static ClipperRegistry instance
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2BFB5D0", Offset = "0x2BFB5D0", VA = "0x2BFB5D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2BFC5FC", Offset = "0x2BFC5FC", VA = "0x2BFC5FC")]
		protected ClipperRegistry()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2BFB6B0", Offset = "0x2BFB6B0", VA = "0x2BFB6B0")]
		public void Cull()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2BFC67C", Offset = "0x2BFC67C", VA = "0x2BFC67C")]
		public static void Register(IClipper c)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2BFC6F0", Offset = "0x2BFC6F0", VA = "0x2BFC6F0")]
		public static void Unregister(IClipper c)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2BFC750", Offset = "0x2BFC750", VA = "0x2BFC750")]
		public static void Disable(IClipper c)
		{
		}
	}
}
