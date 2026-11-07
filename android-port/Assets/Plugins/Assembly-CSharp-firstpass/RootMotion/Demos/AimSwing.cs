using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E3")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x12EB4A8", Offset = "0x12EB4A8", VA = "0x12EB4A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x12EB520", Offset = "0x12EB520", VA = "0x12EB520")]
		public AimSwing()
		{
		}
	}
}
