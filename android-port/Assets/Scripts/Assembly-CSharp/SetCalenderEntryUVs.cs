using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000047")]
public class SetCalenderEntryUVs : MonoBehaviour
{
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform ParentRect;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform Rect;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x28")]
	public Material Mat;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x30")]
	public SVGImage Image;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 offset;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x40")]
	private Material instancedMaterial;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x168BCFC", Offset = "0x168BCFC", VA = "0x168BCFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x168BDAC", Offset = "0x168BDAC", VA = "0x168BDAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x168C0C0", Offset = "0x168C0C0", VA = "0x168C0C0")]
	public void SetOverlayColor(Color col)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x168C1B4", Offset = "0x168C1B4", VA = "0x168C1B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x168C26C", Offset = "0x168C26C", VA = "0x168C26C")]
	public SetCalenderEntryUVs()
	{
	}
}
