using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000147")]
public class SetMaterialColorToPlayerColor : MonoBehaviour
{
	[Token(Token = "0x2000148")]
	public enum ModifyMethods
	{
		[Token(Token = "0x40005C1")]
		Materials = 0,
		[Token(Token = "0x40005C2")]
		SpriteColors = 1,
		[Token(Token = "0x40005C3")]
		ParticleSystem = 2
	}

	[Token(Token = "0x2000149")]
	public enum ColorType
	{
		[Token(Token = "0x40005C5")]
		BaseColor = 0,
		[Token(Token = "0x40005C6")]
		ArrowColor = 1,
		[Token(Token = "0x40005C7")]
		ArrowColorMin = 2,
		[Token(Token = "0x40005C8")]
		StrokeCounterColor = 3,
		[Token(Token = "0x40005C9")]
		IntroBackgroundColor = 4,
		[Token(Token = "0x40005CA")]
		Custom = 5
	}

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem particleSystem;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Renderer renderer;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ModifyMethods ModifyMethod;

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<int> materialsIndices;

	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ColorType colorType;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Color customColor;

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x168E144", Offset = "0x168E144", VA = "0x168E144")]
	public void UpdateMaterials(PlayerColors.AvatarData avatar)
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x168E53C", Offset = "0x168E53C", VA = "0x168E53C")]
	public ModifyMethods GetModifyMethod()
	{
		return default;
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x168E544", Offset = "0x168E544", VA = "0x168E544")]
	public Renderer GetRenderer()
	{
		return null;
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x168E54C", Offset = "0x168E54C", VA = "0x168E54C")]
	public ColorType GetColorType()
	{
		return default;
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x168E554", Offset = "0x168E554", VA = "0x168E554")]
	public void SetRenderer(Renderer r)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x168E55C", Offset = "0x168E55C", VA = "0x168E55C")]
	public List<int> GetIndices()
	{
		return null;
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x168E564", Offset = "0x168E564", VA = "0x168E564")]
	public void CreateList()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x168E5DC", Offset = "0x168E5DC", VA = "0x168E5DC")]
	public SetMaterialColorToPlayerColor()
	{
	}
}
