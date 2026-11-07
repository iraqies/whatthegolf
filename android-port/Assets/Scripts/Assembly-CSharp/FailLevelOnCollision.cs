using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D5")]
public class FailLevelOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask FailLayerMask;

	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x1C")]
	public float Delay;

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x145B208", Offset = "0x145B208", VA = "0x145B208")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x145B34C", Offset = "0x145B34C", VA = "0x145B34C")]
	public FailLevelOnCollision()
	{
	}
}
