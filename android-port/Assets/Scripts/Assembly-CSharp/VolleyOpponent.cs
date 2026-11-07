using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000729")]
public class VolleyOpponent : MonoBehaviour
{
	[Token(Token = "0x40025CB")]
	[FieldOffset(Offset = "0x18")]
	public VolleyGame VolleyGame;

	[Token(Token = "0x40025CC")]
	[FieldOffset(Offset = "0x20")]
	public float ShootForce;

	[Token(Token = "0x40025CD")]
	[FieldOffset(Offset = "0x24")]
	public float MoveForce;

	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x28")]
	public float ReactionTime;

	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody2D Rigidbody;

	[Token(Token = "0x40025D0")]
	[FieldOffset(Offset = "0x38")]
	private float reactionTimer;

	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x40")]
	private Transform currentTarget;

	[Token(Token = "0x40025D2")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 startPos;

	[Token(Token = "0x6002112")]
	[Address(RVA = "0x174B8F8", Offset = "0x174B8F8", VA = "0x174B8F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002113")]
	[Address(RVA = "0x174B930", Offset = "0x174B930", VA = "0x174B930")]
	private void Update()
	{
	}

	[Token(Token = "0x6002114")]
	[Address(RVA = "0x174BAE0", Offset = "0x174BAE0", VA = "0x174BAE0")]
	public VolleyOpponent()
	{
	}
}
