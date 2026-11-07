using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000708")]
public class GolfCheckpoint : MonoBehaviour
{
	[Token(Token = "0x40024FE")]
	[FieldOffset(Offset = "0x18")]
	public Transform NewStartPosition;

	[Token(Token = "0x6002076")]
	[Address(RVA = "0x149DBFC", Offset = "0x149DBFC", VA = "0x149DBFC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002077")]
	[Address(RVA = "0x149DD44", Offset = "0x149DD44", VA = "0x149DD44")]
	public GolfCheckpoint()
	{
	}
}
