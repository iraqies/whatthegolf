using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200110B")]
	public class CBOrthographicStatic : CameraBehaviorOrthographic
	{
		[Token(Token = "0x4005A31")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform trans;

		[Token(Token = "0x4005A32")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 desktopRotationOffset;

		[Token(Token = "0x4005A33")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public bool autoAdjustOrthographicSize;

		[Token(Token = "0x4005A34")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion baseRotation;

		[Token(Token = "0x4005A35")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected float orthographicSizeLongDevice;

		[Token(Token = "0x4005A36")]
		[FieldOffset(Offset = "0x6C")]
		public bool AdjustForLongPhones;

		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0x17E0D60", Offset = "0x17E0D60", VA = "0x17E0D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x17E0D9C", Offset = "0x17E0D9C", VA = "0x17E0D9C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x17E1234", Offset = "0x17E1234", VA = "0x17E1234", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x17E12D8", Offset = "0x17E12D8", VA = "0x17E12D8", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x17E137C", Offset = "0x17E137C", VA = "0x17E137C")]
		public CBOrthographicStatic()
		{
		}
	}
}
