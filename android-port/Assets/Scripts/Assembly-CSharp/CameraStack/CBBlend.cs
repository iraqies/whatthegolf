using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x20010FF")]
	public class CBBlend : CameraBehaviorPerspective
	{
		[Token(Token = "0x400599A")]
		[FieldOffset(Offset = "0x40")]
		public CameraBehaviorPerspective cameraA;

		[Token(Token = "0x400599B")]
		[FieldOffset(Offset = "0x48")]
		public CameraBehaviorPerspective cameraB;

		[Token(Token = "0x400599C")]
		[FieldOffset(Offset = "0x50")]
		public float AtoBBlend;

		[Token(Token = "0x400599D")]
		[FieldOffset(Offset = "0x54")]
		private float width;

		[Token(Token = "0x400599E")]
		[FieldOffset(Offset = "0x58")]
		private float height;

		[Token(Token = "0x17000809")]
		public override float FOV
		{
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0x17DA684", Offset = "0x17DA684", VA = "0x17DA684", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x17DA220", Offset = "0x17DA220", VA = "0x17DA220", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x17DA334", Offset = "0x17DA334", VA = "0x17DA334")]
		public void UpdateCameras()
		{
		}

		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x17DA524", Offset = "0x17DA524", VA = "0x17DA524", Slot = "9")]
		public override void OutOfBounds()
		{
		}

		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x17DA56C", Offset = "0x17DA56C", VA = "0x17DA56C", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x17DA378", Offset = "0x17DA378", VA = "0x17DA378")]
		private void UpdateWidthAndHeight()
		{
		}

		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x17DA6E8", Offset = "0x17DA6E8", VA = "0x17DA6E8", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x17DA864", Offset = "0x17DA864", VA = "0x17DA864")]
		public CBBlend()
		{
		}
	}
}
