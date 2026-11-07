using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200020E")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x13D8CEC", Offset = "0x13D8CEC", VA = "0x13D8CEC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x13D8DD4", Offset = "0x13D8DD4", VA = "0x13D8DD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x13D8F04", Offset = "0x13D8F04", VA = "0x13D8F04")]
		public RagdollUtilityDemo()
		{
		}
	}
}
