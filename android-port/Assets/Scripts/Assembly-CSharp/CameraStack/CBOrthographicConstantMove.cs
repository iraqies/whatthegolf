using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001108")]
	public class CBOrthographicConstantMove : CameraBehaviorOrthographic
	{
		[Token(Token = "0x4005A0B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform trans;

		[Token(Token = "0x4005A0C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 desktopRotationOffset;

		[Token(Token = "0x4005A0D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public bool autoAdjustOrthographicSize;

		[Token(Token = "0x4005A0E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public Vector3 moveSpeed;

		[Token(Token = "0x4005A0F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float rampUpTime;

		[Token(Token = "0x4005A10")]
		[FieldOffset(Offset = "0x68")]
		private float rampUpTimer;

		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x17DF53C", Offset = "0x17DF53C", VA = "0x17DF53C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x17DF9E0", Offset = "0x17DF9E0", VA = "0x17DF9E0", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x17DFB24", Offset = "0x17DFB24", VA = "0x17DFB24", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x17DFBC8", Offset = "0x17DFBC8", VA = "0x17DFBC8")]
		public CBOrthographicConstantMove()
		{
		}
	}
}
