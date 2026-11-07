using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200007C")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x34930", Offset = "0x34930")]
		public float RunningStrideLengthen;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1381FB4", Offset = "0x1381FB4", VA = "0x1381FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1382010", Offset = "0x1382010", VA = "0x1382010")]
		private void Update()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1382210", Offset = "0x1382210", VA = "0x1382210")]
		public HeadBob()
		{
		}
	}
}
