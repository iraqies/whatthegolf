using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000221")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x132AB5C", Offset = "0x132AB5C", VA = "0x132AB5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x132ABB8", Offset = "0x132ABB8", VA = "0x132ABB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x132AD3C", Offset = "0x132AD3C", VA = "0x132AD3C")]
		public VRIKPlatform()
		{
		}
	}
}
