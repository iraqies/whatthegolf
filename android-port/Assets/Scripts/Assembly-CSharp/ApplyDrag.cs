using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BB6")]
public class ApplyDrag : MonoBehaviour
{
	[Token(Token = "0x400413B")]
	[FieldOffset(Offset = "0x18")]
	public float drag;

	[Token(Token = "0x400413C")]
	[FieldOffset(Offset = "0x1C")]
	public float angularDrag;

	[Token(Token = "0x6003875")]
	[Address(RVA = "0x141C77C", Offset = "0x141C77C", VA = "0x141C77C")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6003876")]
	[Address(RVA = "0x141CA18", Offset = "0x141CA18", VA = "0x141CA18")]
	public ApplyDrag()
	{
	}
}
