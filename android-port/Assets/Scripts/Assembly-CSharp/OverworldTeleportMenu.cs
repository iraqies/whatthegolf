using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A72")]
public class OverworldTeleportMenu : MonoBehaviour
{
	[Token(Token = "0x2000A73")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D40", Offset = "0x42D40")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x10")]
		public OverworldTeleportMenu _003C_003E4__this;

		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0x18")]
		public HubSection hubSection;

		[Token(Token = "0x40039E0")]
		[FieldOffset(Offset = "0x20")]
		public Func<HubSection, bool> _003C_003E9__1;

		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x181E198", Offset = "0x181E198", VA = "0x181E198")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x181E1A0", Offset = "0x181E1A0", VA = "0x181E1A0")]
		internal bool _003CPopulateMainCampaignSections_003Eb__1(HubSection x)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D50", Offset = "0x42D50")]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		[Token(Token = "0x40039E1")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x40039E2")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x181E21C", Offset = "0x181E21C", VA = "0x181E21C")]
		public _003C_003Ec__DisplayClass8_1()
		{
		}
	}

	[Token(Token = "0x2000A75")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D60", Offset = "0x42D60")]
	private sealed class _003C_003Ec__DisplayClass8_2
	{
		[Token(Token = "0x40039E3")]
		[FieldOffset(Offset = "0x10")]
		public OverworldLevelSection levelSection;

		[Token(Token = "0x40039E4")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x181E224", Offset = "0x181E224", VA = "0x181E224")]
		public _003C_003Ec__DisplayClass8_2()
		{
		}

		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x181E22C", Offset = "0x181E22C", VA = "0x181E22C")]
		internal void _003CPopulateMainCampaignSections_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000A76")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D70", Offset = "0x42D70")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x40039E5")]
		[FieldOffset(Offset = "0x10")]
		public OverworldTeleportMenu _003C_003E4__this;

		[Token(Token = "0x40039E6")]
		[FieldOffset(Offset = "0x18")]
		public HubSection hubSection;

		[Token(Token = "0x40039E7")]
		[FieldOffset(Offset = "0x20")]
		public Func<HubSection, bool> _003C_003E9__1;

		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x181E0C8", Offset = "0x181E0C8", VA = "0x181E0C8")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x181E0D0", Offset = "0x181E0D0", VA = "0x181E0D0")]
		internal bool _003CRefreshButtons_003Eb__1(HubSection x)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A77")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D80", Offset = "0x42D80")]
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		[Token(Token = "0x40039E8")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x40039E9")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x181E14C", Offset = "0x181E14C", VA = "0x181E14C")]
		public _003C_003Ec__DisplayClass10_1()
		{
		}
	}

	[Token(Token = "0x2000A78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D90", Offset = "0x42D90")]
	private sealed class _003C_003Ec__DisplayClass10_2
	{
		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0x10")]
		public OverworldLevelSection levelSection;

		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x181E154", Offset = "0x181E154", VA = "0x181E154")]
		public _003C_003Ec__DisplayClass10_2()
		{
		}

		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x181E15C", Offset = "0x181E15C", VA = "0x181E15C")]
		internal void _003CRefreshButtons_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40039D9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform _mainPanel;

	[Token(Token = "0x40039DA")]
	[FieldOffset(Offset = "0x20")]
	private List<AdventureButton> _teleportButtons;

	[Token(Token = "0x40039DB")]
	[FieldOffset(Offset = "0x28")]
	private bool _initialized;

	[Token(Token = "0x40039DC")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine closeCR;

	[Token(Token = "0x40039DD")]
	[FieldOffset(Offset = "0x38")]
	private int activeTeleportButton;

	[Token(Token = "0x17000525")]
	private OverworldLevelData _campaignData
	{
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x15CCB7C", Offset = "0x15CCB7C", VA = "0x15CCB7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60031D3")]
	[Address(RVA = "0x15CCB9C", Offset = "0x15CCB9C", VA = "0x15CCB9C")]
	private void InitializeIfNot()
	{
	}

	[Token(Token = "0x60031D4")]
	[Address(RVA = "0x15CCBCC", Offset = "0x15CCBCC", VA = "0x15CCBCC")]
	private void PopulateMainCampaignSections()
	{
	}

	[Token(Token = "0x60031D5")]
	[Address(RVA = "0x15CD150", Offset = "0x15CD150", VA = "0x15CD150")]
	private void Teleport(OverworldLevelSection section, int index)
	{
	}

	[Token(Token = "0x60031D6")]
	[Address(RVA = "0x15CD3DC", Offset = "0x15CD3DC", VA = "0x15CD3DC")]
	private void RefreshButtons()
	{
	}

	[Token(Token = "0x60031D7")]
	[Address(RVA = "0x15CD8D8", Offset = "0x15CD8D8", VA = "0x15CD8D8")]
	public void Show()
	{
	}

	[Token(Token = "0x60031D8")]
	[Address(RVA = "0x15CD930", Offset = "0x15CD930", VA = "0x15CD930")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x15CD984", Offset = "0x15CD984", VA = "0x15CD984")]
	public OverworldTeleportMenu()
	{
	}
}
