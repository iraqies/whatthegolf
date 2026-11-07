using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000105")]
public class CrapContainer : MonoBehaviour
{
	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Root;

	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody BaseRigid;

	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x28")]
	public Transform BaseToRotate;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x18BD15C", Offset = "0x18BD15C", VA = "0x18BD15C")]
	public CrapContainer()
	{
	}
}
