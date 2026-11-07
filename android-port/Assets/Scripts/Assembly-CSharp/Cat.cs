using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF8")]
public class Cat : MonoBehaviour
{
	[Token(Token = "0x4003D13")]
	[FieldOffset(Offset = "0x18")]
	public string CatId;

	[Token(Token = "0x4003D14")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Collectable collectable;

	[Token(Token = "0x4003D15")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TipObject tipObject;

	[Token(Token = "0x600344E")]
	[Address(RVA = "0x188E014", Offset = "0x188E014", VA = "0x188E014")]
	public Cat()
	{
	}
}
