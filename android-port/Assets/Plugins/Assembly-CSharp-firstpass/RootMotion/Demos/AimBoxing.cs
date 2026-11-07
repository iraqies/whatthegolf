using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E2")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x12EA510", Offset = "0x12EA510", VA = "0x12EA510")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x12EA594", Offset = "0x12EA594", VA = "0x12EA594")]
		public AimBoxing()
		{
		}
	}
}
