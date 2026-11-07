using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000050")]
	[Attribute(Name = "RequireComponent", RVA = "0x1F6664", Offset = "0x1F6664")]
	public class RawImage : MaskableGraphic
	{
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F7DF8", Offset = "0x1F7DF8")]
		[SerializeField]
		private Texture m_Texture;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Rect m_UVRect;

		[Token(Token = "0x170000DF")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2C2E4B0", Offset = "0x2C2E4B0", VA = "0x2C2E4B0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public Texture texture
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2C2E640", Offset = "0x2C2E640", VA = "0x2C2E640")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x2C2E648", Offset = "0x2C2E648", VA = "0x2C2E648")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public Rect uvRect
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x2C2E708", Offset = "0x2C2E708", VA = "0x2C2E708")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x2C2E714", Offset = "0x2C2E714", VA = "0x2C2E714")]
			set
			{
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2C2E458", Offset = "0x2C2E458", VA = "0x2C2E458")]
		protected RawImage()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2C2E7A0", Offset = "0x2C2E7A0", VA = "0x2C2E7A0", Slot = "44")]
		public override void SetNativeSize()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2C2E914", Offset = "0x2C2E914", VA = "0x2C2E914", Slot = "43")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2C2ED58", Offset = "0x2C2ED58", VA = "0x2C2ED58", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
