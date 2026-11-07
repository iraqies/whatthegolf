using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBD")]
public class BlockShotIfAboveVelocity : MonoBehaviour
{
	[Token(Token = "0x400415F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float sqrMagnitudeThreshold;

	[Token(Token = "0x4004160")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x4004161")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4004162")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool AddToControllerBlockingFunctions;

	[Token(Token = "0x4004163")]
	[FieldOffset(Offset = "0x38")]
	private GolfBallController controller;

	[Token(Token = "0x4004164")]
	[FieldOffset(Offset = "0x40")]
	private float sqrVelocity;

	[Token(Token = "0x600388E")]
	[Address(RVA = "0x1612FC8", Offset = "0x1612FC8", VA = "0x1612FC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600388F")]
	[Address(RVA = "0x16131A4", Offset = "0x16131A4", VA = "0x16131A4")]
	public bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6003890")]
	[Address(RVA = "0x16132D4", Offset = "0x16132D4", VA = "0x16132D4")]
	public BlockShotIfAboveVelocity()
	{
	}
}
