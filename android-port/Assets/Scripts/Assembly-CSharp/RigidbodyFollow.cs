using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000815")]
public class RigidbodyFollow : MonoBehaviour
{
	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002B83")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x1657AF4", Offset = "0x1657AF4", VA = "0x1657AF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0x1657B44", Offset = "0x1657B44", VA = "0x1657B44")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0x1657B84", Offset = "0x1657B84", VA = "0x1657B84")]
	public RigidbodyFollow()
	{
	}
}
