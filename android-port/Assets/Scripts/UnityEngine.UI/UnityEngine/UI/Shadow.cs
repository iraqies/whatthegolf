using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200007A")]
	public class Shadow : BaseMeshEffect
	{
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_EffectColor;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_EffectDistance;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_UseGraphicAlpha;

		[Token(Token = "0x4000249")]
		private const float kMaxEffectDistance = 600f;

		[Token(Token = "0x17000151")]
		public Color effectColor
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2C39C78", Offset = "0x2C39C78", VA = "0x2C39C78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2C39C84", Offset = "0x2C39C84", VA = "0x2C39C84")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public Vector2 effectDistance
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x2C39D70", Offset = "0x2C39D70", VA = "0x2C39D70")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x2C39D78", Offset = "0x2C39D78", VA = "0x2C39D78")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public bool useGraphicAlpha
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x2C39E9C", Offset = "0x2C39E9C", VA = "0x2C39E9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x2C39EA4", Offset = "0x2C39EA4", VA = "0x2C39EA4")]
			set
			{
			}
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2C39C0C", Offset = "0x2C39C0C", VA = "0x2C39C0C")]
		protected Shadow()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2C39F68", Offset = "0x2C39F68", VA = "0x2C39F68")]
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2C3A240", Offset = "0x2C3A240", VA = "0x2C3A240")]
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2C3A248", Offset = "0x2C3A248", VA = "0x2C3A248", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
