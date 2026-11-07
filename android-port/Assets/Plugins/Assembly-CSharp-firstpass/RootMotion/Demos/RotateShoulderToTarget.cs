using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000247")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x13F3500", Offset = "0x13F3500", VA = "0x13F3500")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x13F3598", Offset = "0x13F3598", VA = "0x13F3598")]
		public RotateShoulderToTarget()
		{
		}
	}
}
