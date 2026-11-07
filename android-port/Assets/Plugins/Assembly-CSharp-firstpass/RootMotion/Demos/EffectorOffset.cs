using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C7C", Offset = "0x36C7C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000D2C")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x1367FD8", Offset = "0x1367FD8", VA = "0x1367FD8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x1368464", Offset = "0x1368464", VA = "0x1368464")]
		public EffectorOffset()
		{
		}
	}
}
