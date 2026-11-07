using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D3")]
public class DominoCameraTarget : MonoBehaviour
{
	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x18")]
	public Transform targetPosition;

	[Token(Token = "0x40023B9")]
	[FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x14310C0", Offset = "0x14310C0", VA = "0x14310C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x143118C", Offset = "0x143118C", VA = "0x143118C")]
	public DominoCameraTarget()
	{
	}
}
