using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000222")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x132AD70", Offset = "0x132AD70", VA = "0x132AD70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x132B208", Offset = "0x132B208", VA = "0x132B208")]
		public VRIKPlatformController()
		{
		}
	}
}
