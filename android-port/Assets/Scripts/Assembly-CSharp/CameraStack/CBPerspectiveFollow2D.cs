using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200110F")]
	public class CBPerspectiveFollow2D : CameraBehaviorPerspective
	{
		[Token(Token = "0x4005A5A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 rotation;

		[Token(Token = "0x4005A5B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4005A5C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float sideTrackPadding;

		[Token(Token = "0x4005A5D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float upperTrackPadding;

		[Token(Token = "0x4005A5E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float lowerTrackPadding;

		[Token(Token = "0x4005A5F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool lockVerticalAxis;

		[Token(Token = "0x4005A60")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x6004CAF")]
		[Address(RVA = "0x17E2C00", Offset = "0x17E2C00", VA = "0x17E2C00", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x17E2CAC", Offset = "0x17E2CAC", VA = "0x17E2CAC", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x17E2D48", Offset = "0x17E2D48", VA = "0x17E2D48", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x17E2D58", Offset = "0x17E2D58", VA = "0x17E2D58", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0x17E2F44", Offset = "0x17E2F44", VA = "0x17E2F44")]
		public CBPerspectiveFollow2D()
		{
		}
	}
}
