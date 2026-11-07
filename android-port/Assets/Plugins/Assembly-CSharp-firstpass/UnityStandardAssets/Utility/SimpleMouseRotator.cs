using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000059")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x13FADB0", Offset = "0x13FADB0", VA = "0x13FADB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x13FADEC", Offset = "0x13FADEC", VA = "0x13FADEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x13FB0E0", Offset = "0x13FB0E0", VA = "0x13FB0E0")]
		public SimpleMouseRotator()
		{
		}
	}
}
