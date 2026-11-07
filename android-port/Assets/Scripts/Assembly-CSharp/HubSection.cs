using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x20009BF")]
public class HubSection : GolfBehaviour
{
	[Token(Token = "0x20009C0")]
	public enum SectionPlatformEnum
	{
		[Token(Token = "0x400357B")]
		All = 0,
		[Token(Token = "0x400357C")]
		Mobile = 1,
		[Token(Token = "0x400357D")]
		Standalone = 2,
		[Token(Token = "0x400357E")]
		None = 3
	}

	[Token(Token = "0x400356A")]
	[FieldOffset(Offset = "0x0")]
	public static Tilemap LAST_SELECTED_TILEMAP_FOR_EDITOR;

	[Token(Token = "0x400356B")]
	[FieldOffset(Offset = "0x1C")]
	public SectionPlatformEnum SectionPlatform;

	[Token(Token = "0x400356C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Container;

	[Token(Token = "0x400356D")]
	[FieldOffset(Offset = "0x28")]
	public Tilemap SectionTilemap;

	[Token(Token = "0x400356E")]
	[FieldOffset(Offset = "0x30")]
	public List<Tilemap> DecorationsMaps;

	[Token(Token = "0x400356F")]
	[FieldOffset(Offset = "0x38")]
	public bool shouldRotateTilesForMobile;

	[Token(Token = "0x4003570")]
	[FieldOffset(Offset = "0x39")]
	public bool dontChangeAnimatorCullingMode;

	[Token(Token = "0x4003571")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SortGroupManager sortManager;

	[Token(Token = "0x4003572")]
	[FieldOffset(Offset = "0x48")]
	public bool useLineRendersForBounds;

	[Token(Token = "0x4003573")]
	[FieldOffset(Offset = "0x4C")]
	public Bounds cachedBounds;

	[Token(Token = "0x4003574")]
	[FieldOffset(Offset = "0x64")]
	public bool isUsingSectionBoundsInstead;

	[Token(Token = "0x4003575")]
	[FieldOffset(Offset = "0x68")]
	public List<Bounds> cullingBounds;

	[Token(Token = "0x4003576")]
	[FieldOffset(Offset = "0x70")]
	public bool hasBeenCached;

	[Token(Token = "0x4003577")]
	[FieldOffset(Offset = "0x71")]
	public bool isActiveInCulling;

	[Token(Token = "0x4003578")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TilemapRenderer tileRenderer;

	[Token(Token = "0x4003579")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FE9C", Offset = "0x4FE9C")]
	private Action<bool> m_OnSectionCullingUpdate;

	[Token(Token = "0x1400004A")]
	public event Action<bool> OnSectionCullingUpdate
	{
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x14DF734", Offset = "0x14DF734", VA = "0x14DF734")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686E8", Offset = "0x686E8")]
		add
		{
		}
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x14DF7D8", Offset = "0x14DF7D8", VA = "0x14DF7D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686F8", Offset = "0x686F8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x14DE728", Offset = "0x14DE728", VA = "0x14DE728")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x686D4", Offset = "0x686D4")]
	private static void Init()
	{
	}

	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x14DE774", Offset = "0x14DE774", VA = "0x14DE774")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x14DE89C", Offset = "0x14DE89C", VA = "0x14DE89C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x14DED50", Offset = "0x14DED50", VA = "0x14DED50")]
	public bool PreBuildScript(bool isRotated)
	{
		return default;
	}

	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x14DEF10", Offset = "0x14DEF10", VA = "0x14DEF10")]
	public void UpdateWhenCulledIn()
	{
	}

	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x14DEF2C", Offset = "0x14DEF2C", VA = "0x14DEF2C")]
	public Bounds GetBounds(bool redraw = true)
	{
		return default;
	}

	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x14DF22C", Offset = "0x14DF22C", VA = "0x14DF22C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x14DF47C", Offset = "0x14DF47C", VA = "0x14DF47C")]
	public void Show()
	{
	}

	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x14DF49C", Offset = "0x14DF49C", VA = "0x14DF49C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x14DF574", Offset = "0x14DF574", VA = "0x14DF574")]
	public bool Intersects(Bounds playerBounds)
	{
		return default;
	}

	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x14DF5C4", Offset = "0x14DF5C4", VA = "0x14DF5C4")]
	public bool IntersectsCullingBounds(Bounds playerBounds)
	{
		return default;
	}

	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x14DF500", Offset = "0x14DF500", VA = "0x14DF500")]
	public void SetActiveCulling(bool isActive)
	{
	}

	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x14DF87C", Offset = "0x14DF87C", VA = "0x14DF87C")]
	public HubSection()
	{
	}
}
