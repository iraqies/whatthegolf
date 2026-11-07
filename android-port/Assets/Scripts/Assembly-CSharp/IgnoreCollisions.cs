using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0C")]
public class IgnoreCollisions : MonoBehaviour
{
	[Token(Token = "0x4003DBE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject rootA;

	[Token(Token = "0x4003DBF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rootB;

	[Token(Token = "0x60034C4")]
	[Address(RVA = "0x14E57DC", Offset = "0x14E57DC", VA = "0x14E57DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x14E58F8", Offset = "0x14E58F8", VA = "0x14E58F8")]
	public IgnoreCollisions()
	{
	}
}
