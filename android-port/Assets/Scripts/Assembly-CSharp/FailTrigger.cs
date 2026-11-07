using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BE8")]
public class FailTrigger : MonoBehaviour
{
	[Token(Token = "0x40041F9")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask FailLayerMask;

	[Token(Token = "0x40041FA")]
	[FieldOffset(Offset = "0x1C")]
	public float Delay;

	[Token(Token = "0x6003916")]
	[Address(RVA = "0x145BAA8", Offset = "0x145BAA8", VA = "0x145BAA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003917")]
	[Address(RVA = "0x145BC44", Offset = "0x145BC44", VA = "0x145BC44")]
	public FailTrigger()
	{
	}
}
