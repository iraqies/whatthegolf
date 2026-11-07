using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FE")]
public class FishHook : MonoBehaviour
{
	[Token(Token = "0x40024AF")]
	[FieldOffset(Offset = "0x18")]
	private Transform hookedFish;

	[Token(Token = "0x40024B0")]
	[FieldOffset(Offset = "0x20")]
	private Collider collider;

	[Token(Token = "0x40024B1")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody floater;

	[Token(Token = "0x40024B2")]
	[FieldOffset(Offset = "0x30")]
	private bool hooked;

	[Token(Token = "0x6002044")]
	[Address(RVA = "0x14677DC", Offset = "0x14677DC", VA = "0x14677DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0x1467860", Offset = "0x1467860", VA = "0x1467860")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x146790C", Offset = "0x146790C", VA = "0x146790C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x1467964", Offset = "0x1467964", VA = "0x1467964")]
	public void ReleaseHook()
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x1467988", Offset = "0x1467988", VA = "0x1467988")]
	public FishHook()
	{
	}
}
