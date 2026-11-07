using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000ED2")]
public class BounceRagdoll : MonoBehaviour
{
	[Token(Token = "0x400500E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float bouncePower;

	[Token(Token = "0x400500F")]
	[FieldOffset(Offset = "0x20")]
	private Transform lastObject;

	[Token(Token = "0x4005010")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent onRagdollHit;

	[Token(Token = "0x600452A")]
	[Address(RVA = "0x1701E70", Offset = "0x1701E70", VA = "0x1701E70")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600452B")]
	[Address(RVA = "0x1702054", Offset = "0x1702054", VA = "0x1702054")]
	public BounceRagdoll()
	{
	}
}
