using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ED4")]
public class ChangeHorseOutfitRandom : MonoBehaviour
{
	[Token(Token = "0x4005017")]
	[FieldOffset(Offset = "0x18")]
	public Outfit[] outfits;

	[Token(Token = "0x4005018")]
	[FieldOffset(Offset = "0x20")]
	public Transform particles;

	[Token(Token = "0x4005019")]
	[FieldOffset(Offset = "0x28")]
	public Renderer horseRenderer;

	[Token(Token = "0x400501A")]
	[FieldOffset(Offset = "0x30")]
	private int currentIndex;

	[Token(Token = "0x400501B")]
	[FieldOffset(Offset = "0x38")]
	private GameObject newOutfit;

	[Token(Token = "0x400501C")]
	[FieldOffset(Offset = "0x40")]
	private Material[] defaultHorseMaterials;

	[Token(Token = "0x600452D")]
	[Address(RVA = "0x1896F04", Offset = "0x1896F04", VA = "0x1896F04")]
	private void Start()
	{
	}

	[Token(Token = "0x600452E")]
	[Address(RVA = "0x1896F38", Offset = "0x1896F38", VA = "0x1896F38")]
	public void ChangeOutfit()
	{
	}

	[Token(Token = "0x600452F")]
	[Address(RVA = "0x1897520", Offset = "0x1897520", VA = "0x1897520")]
	public ChangeHorseOutfitRandom()
	{
	}
}
