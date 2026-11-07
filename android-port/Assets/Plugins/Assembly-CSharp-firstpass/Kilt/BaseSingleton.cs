using Il2CppDummyDll;
using UnityEngine;

namespace Kilt
{
	[Token(Token = "0x2000081")]
	public abstract class BaseSingleton : MonoBehaviour
	{
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_enableSingletonCreation;

		[Token(Token = "0x17000042")]
		public static bool EnableSingletonCreation
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x12FB30C", Offset = "0x12FB30C", VA = "0x12FB30C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x12FB3B0", Offset = "0x12FB3B0", VA = "0x12FB3B0")]
			private set
			{
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x12FB448", Offset = "0x12FB448", VA = "0x12FB448")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x37DF0", Offset = "0x37DF0")]
		private static void EnableInstanceCreation()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x12FB50C", Offset = "0x12FB50C", VA = "0x12FB50C")]
		protected BaseSingleton()
		{
		}
	}
}
