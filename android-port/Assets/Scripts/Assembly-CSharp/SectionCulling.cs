using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A3E")]
public class SectionCulling : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A3F")]
	public class SectionInfo
	{
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x10")]
		public HubSection section;

		[Token(Token = "0x4003898")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody2D[] rigids;

		[Token(Token = "0x4003899")]
		[FieldOffset(Offset = "0x20")]
		public CullWhenHidden[] cullers;

		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer[] sprites;

		[Token(Token = "0x400389B")]
		[FieldOffset(Offset = "0x30")]
		public MonoBehaviour[] rotators;

		[Token(Token = "0x400389C")]
		[FieldOffset(Offset = "0x38")]
		public bool isActive;

		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x18409BC", Offset = "0x18409BC", VA = "0x18409BC")]
		public SectionInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42B90", Offset = "0x42B90")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Rigidbody2D, bool> _003C_003E9__15_0;

		[Token(Token = "0x60030D8")]
		[Address(RVA = "0x184091C", Offset = "0x184091C", VA = "0x184091C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x1840924", Offset = "0x1840924", VA = "0x1840924")]
		internal bool _003CCache_003Eb__15_0(Rigidbody2D r)
		{
			return default;
		}
	}

	[Token(Token = "0x400388E")]
	[FieldOffset(Offset = "0x1C")]
	public float SizeMod;

	[Token(Token = "0x400388F")]
	[FieldOffset(Offset = "0x20")]
	public bool isOnlyDisablingSimulationOnRigids;

	[Token(Token = "0x4003890")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<SectionInfo> sections;

	[Token(Token = "0x4003891")]
	[FieldOffset(Offset = "0x30")]
	private Bounds playerBounds;

	[Token(Token = "0x4003892")]
	[FieldOffset(Offset = "0x48")]
	private Transform trans;

	[Token(Token = "0x4003893")]
	[FieldOffset(Offset = "0x50")]
	private bool cullingEnabled;

	[Token(Token = "0x4003894")]
	[FieldOffset(Offset = "0x54")]
	public int total;

	[Token(Token = "0x4003895")]
	[FieldOffset(Offset = "0x58")]
	public int simulated;

	[Token(Token = "0x4003896")]
	[FieldOffset(Offset = "0x5C")]
	public int activeCullers;

	[Token(Token = "0x1700050B")]
	public bool CullingEnabled
	{
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x1681340", Offset = "0x1681340", VA = "0x1681340")]
		get
		{
			return default;
		}
		[Token(Token = "0x60030CD")]
		[Address(RVA = "0x1681348", Offset = "0x1681348", VA = "0x1681348")]
		set
		{
		}
	}

	[Token(Token = "0x60030CE")]
	[Address(RVA = "0x168157C", Offset = "0x168157C", VA = "0x168157C", Slot = "4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x695EC", Offset = "0x695EC")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x60030CF")]
	[Address(RVA = "0x1681954", Offset = "0x1681954", VA = "0x1681954")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60030D0")]
	[Address(RVA = "0x16815A4", Offset = "0x16815A4", VA = "0x16815A4")]
	public void Cache()
	{
	}

	[Token(Token = "0x60030D1")]
	[Address(RVA = "0x1681E54", Offset = "0x1681E54", VA = "0x1681E54")]
	public void ReturnToOverworld()
	{
	}

	[Token(Token = "0x60030D2")]
	[Address(RVA = "0x168202C", Offset = "0x168202C", VA = "0x168202C")]
	public void UpdateCulling()
	{
	}

	[Token(Token = "0x60030D3")]
	[Address(RVA = "0x1682658", Offset = "0x1682658", VA = "0x1682658")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60030D4")]
	[Address(RVA = "0x1681358", Offset = "0x1681358", VA = "0x1681358")]
	public void DisableCulling()
	{
	}

	[Token(Token = "0x60030D5")]
	[Address(RVA = "0x16828E8", Offset = "0x16828E8", VA = "0x16828E8")]
	public SectionCulling()
	{
	}
}
