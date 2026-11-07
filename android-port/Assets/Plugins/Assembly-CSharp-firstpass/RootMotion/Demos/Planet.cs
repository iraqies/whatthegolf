using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200023B")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x13BFFD8", Offset = "0x13BFFD8", VA = "0x13BFFD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x13C00DC", Offset = "0x13C00DC", VA = "0x13C00DC")]
		public Planet()
		{
		}
	}
}
