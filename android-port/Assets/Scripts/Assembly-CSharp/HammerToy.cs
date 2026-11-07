using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF4")]
public class HammerToy : MonoBehaviour
{
	[Token(Token = "0x4004BFE")]
	[FieldOffset(Offset = "0x18")]
	public Collider flatTrigger;

	[Token(Token = "0x4004BFF")]
	[FieldOffset(Offset = "0x20")]
	public FlatToyBehaviour flatControllerPrefab;

	[Token(Token = "0x4004C00")]
	[FieldOffset(Offset = "0x28")]
	public FlatToyBehaviour flatPropPrefab;

	[Token(Token = "0x4004C01")]
	[FieldOffset(Offset = "0x30")]
	private bool canFlatten;

	[Token(Token = "0x4004C02")]
	[FieldOffset(Offset = "0x38")]
	private FlatToyBehaviour instantiatedFlatToy;

	[Token(Token = "0x60041B5")]
	[Address(RVA = "0x14C215C", Offset = "0x14C215C", VA = "0x14C215C")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60041B6")]
	[Address(RVA = "0x14C22F0", Offset = "0x14C22F0", VA = "0x14C22F0")]
	private void InstantiateFlatController(GameObject GOtoReplace, bool isController)
	{
	}

	[Token(Token = "0x60041B7")]
	[Address(RVA = "0x14C25D0", Offset = "0x14C25D0", VA = "0x14C25D0")]
	public void FlattenFromAnimation()
	{
	}

	[Token(Token = "0x60041B8")]
	[Address(RVA = "0x14C25FC", Offset = "0x14C25FC", VA = "0x14C25FC")]
	public HammerToy()
	{
	}
}
