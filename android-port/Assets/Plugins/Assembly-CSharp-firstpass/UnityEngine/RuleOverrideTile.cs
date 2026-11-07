using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	[Serializable]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x3360C", Offset = "0x3360C")]
	public class RuleOverrideTile : RuleTile
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class TileSpritePair
		{
			[Token(Token = "0x4000380")]
			[FieldOffset(Offset = "0x10")]
			public Sprite m_OriginalSprite;

			[Token(Token = "0x4000381")]
			[FieldOffset(Offset = "0x18")]
			public Sprite m_OverrideSprite;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1356244", Offset = "0x1356244", VA = "0x1356244")]
			public TileSpritePair()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class OverrideTilingRule
		{
			[Token(Token = "0x4000382")]
			[FieldOffset(Offset = "0x10")]
			public bool m_Enabled;

			[Token(Token = "0x4000383")]
			[FieldOffset(Offset = "0x18")]
			public TilingRule m_TilingRule;

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x13560C4", Offset = "0x13560C4", VA = "0x13560C4")]
			public OverrideTilingRule()
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33644", Offset = "0x33644")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x10")]
			public Sprite originalSprite;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x135602C", Offset = "0x135602C", VA = "0x135602C")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1356034", Offset = "0x1356034", VA = "0x1356034")]
			internal bool _003Cset_Item_003Eb__0(TileSpritePair spritePair)
			{
				return default;
			}
		}

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x38")]
		public RuleTile m_Tile;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x40")]
		public bool m_Advanced;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x48")]
		public List<TileSpritePair> m_Sprites;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x50")]
		public List<OverrideTilingRule> m_OverrideTilingRules;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x58")]
		public OverrideTilingRule m_OverrideDefault;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170000C5")]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x13F5CC8", Offset = "0x13F5CC8", VA = "0x13F5CC8")]
		public Sprite get_Item(Sprite originalSprite)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x13F5E9C", Offset = "0x13F5E9C", VA = "0x13F5E9C")]
		public void set_Item(Sprite originalSprite, Sprite value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170000C6")]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x13F61E0", Offset = "0x13F61E0", VA = "0x13F61E0")]
		public TilingRule get_Item(TilingRule originalRule)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x13F633C", Offset = "0x13F633C", VA = "0x13F633C")]
		public void set_Item(TilingRule originalRule, TilingRule value)
		{
		}

		[Token(Token = "0x170000C7")]
		public TilingRule m_OriginalDefault
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x13F6690", Offset = "0x13F6690", VA = "0x13F6690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x13F6840", Offset = "0x13F6840", VA = "0x13F6840", Slot = "7")]
		public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			return default;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x13F6D6C", Offset = "0x13F6D6C", VA = "0x13F6D6C")]
		public void ApplyOverrides(IList<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x13F6FA8", Offset = "0x13F6FA8", VA = "0x13F6FA8")]
		public void GetOverrides(List<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x13F74C4", Offset = "0x13F74C4", VA = "0x13F74C4")]
		public void ApplyOverrides(IList<KeyValuePair<TilingRule, TilingRule>> overrides)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x13F7700", Offset = "0x13F7700", VA = "0x13F7700")]
		public void GetOverrides(List<KeyValuePair<TilingRule, TilingRule>> overrides)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x13F6898", Offset = "0x13F6898", VA = "0x13F6898")]
		public void Override()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x13F661C", Offset = "0x13F661C", VA = "0x13F661C")]
		public TilingRule CloneTilingRule(TilingRule from)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x13F79A0", Offset = "0x13F79A0", VA = "0x13F79A0")]
		public void CopyTilingRule(TilingRule from, TilingRule to, bool copyRule)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x13F7A50", Offset = "0x13F7A50", VA = "0x13F7A50")]
		public RuleOverrideTile()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x13F7C14", Offset = "0x13F7C14", VA = "0x13F7C14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38164", Offset = "0x38164")]
		private TilingRule _003COverride_003Eb__20_0(TilingRule rule)
		{
			return null;
		}
	}
}
