using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000005")]
	public class DecalAnimation : MonoBehaviour
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		public int Columns;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x1C")]
		public int Rows;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public float FPS;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x24")]
		public bool CorrectTime;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		public TweenType Type;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		public string[] InputTextureNames;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x38")]
		private int frames;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x3C")]
		private int frameNumber;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x40")]
		private int direction;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x44")]
		private float duration;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		private float frameTime;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x4C")]
		private float rowFrac;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x50")]
		private float colFrac;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 size;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x60")]
		private Renderer decalRenderer;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2C59B2C", Offset = "0x2C59B2C", VA = "0x2C59B2C", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2C59B30", Offset = "0x2C59B30", VA = "0x2C59B30")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2C59D70", Offset = "0x2C59D70", VA = "0x2C59D70", Slot = "5")]
		protected virtual void RenderFrame()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2C59F74", Offset = "0x2C59F74", VA = "0x2C59F74")]
		public bool IsFinished()
		{
			return default;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2C59F98", Offset = "0x2C59F98", VA = "0x2C59F98")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2C59FA0", Offset = "0x2C59FA0", VA = "0x2C59FA0")]
		protected void SwitchDirection()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2C59CC0", Offset = "0x2C59CC0", VA = "0x2C59CC0")]
		protected void SetTexturesScale(Vector2 size)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2C59EC4", Offset = "0x2C59EC4", VA = "0x2C59EC4")]
		protected void SetTexturesOffsets(Vector2 offset)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2C59FB0", Offset = "0x2C59FB0", VA = "0x2C59FB0")]
		public DecalAnimation()
		{
		}
	}
}
