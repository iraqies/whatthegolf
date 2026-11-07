using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200131F")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x4006694")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000A18")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x6005947")]
			[Address(RVA = "0x18BA494", Offset = "0x18BA494", VA = "0x18BA494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005948")]
		[Address(RVA = "0x18BA5F0", Offset = "0x18BA5F0", VA = "0x18BA5F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005949")]
		[Address(RVA = "0x18BA680", Offset = "0x18BA680", VA = "0x18BA680")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x600594A")]
		[Address(RVA = "0x18BA6B0", Offset = "0x18BA6B0", VA = "0x18BA6B0")]
		public CoroutineManager()
		{
		}
	}
}
