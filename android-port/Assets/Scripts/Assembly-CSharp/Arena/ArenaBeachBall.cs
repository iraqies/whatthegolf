using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001212")]
	public class ArenaBeachBall : MonoBehaviour
	{
		[Token(Token = "0x4006196")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioEventAsset popSfx;

		[Token(Token = "0x6005322")]
		[Address(RVA = "0x142035C", Offset = "0x142035C", VA = "0x142035C")]
		public void Pop()
		{
		}

		[Token(Token = "0x6005323")]
		[Address(RVA = "0x1420554", Offset = "0x1420554", VA = "0x1420554")]
		public ArenaBeachBall()
		{
		}
	}
}
