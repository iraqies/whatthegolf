using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086D")]
public class AdjustMaterialTiling : MonoBehaviour
{
	[Token(Token = "0x4002E25")]
	[FieldOffset(Offset = "0x18")]
	public Material MaterialToTile;

	[Token(Token = "0x4002E26")]
	[FieldOffset(Offset = "0x20")]
	public Transform From;

	[Token(Token = "0x4002E27")]
	[FieldOffset(Offset = "0x28")]
	public Transform To;

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x1408EF8", Offset = "0x1408EF8", VA = "0x1408EF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x1408F8C", Offset = "0x1408F8C", VA = "0x1408F8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x1408FC0", Offset = "0x1408FC0", VA = "0x1408FC0")]
	public AdjustMaterialTiling()
	{
	}
}
