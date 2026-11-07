using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000728")]
public class VolleyGame : MonoBehaviour
{
	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0x18")]
	public Transform PlayerBallStartPosition;

	[Token(Token = "0x40025C0")]
	[FieldOffset(Offset = "0x20")]
	public Transform EnemyBallStartPosition;

	[Token(Token = "0x40025C1")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D VolleyBall;

	[Token(Token = "0x40025C2")]
	[FieldOffset(Offset = "0x30")]
	public int AllowedGroundHits;

	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x34")]
	public int PlayerScore;

	[Token(Token = "0x40025C4")]
	[FieldOffset(Offset = "0x38")]
	public int EnemyScore;

	[Token(Token = "0x40025C5")]
	[FieldOffset(Offset = "0x3C")]
	public int ScoreGoal;

	[Token(Token = "0x40025C6")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> PlayerPoints;

	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> EnemyPoints;

	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x50")]
	public int Side;

	[Token(Token = "0x40025C9")]
	[FieldOffset(Offset = "0x58")]
	public Collider2D Divider;

	[Token(Token = "0x40025CA")]
	[FieldOffset(Offset = "0x60")]
	private int groundHits;

	[Token(Token = "0x600210C")]
	[Address(RVA = "0x174B3C4", Offset = "0x174B3C4", VA = "0x174B3C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600210D")]
	[Address(RVA = "0x174B468", Offset = "0x174B468", VA = "0x174B468")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x600210E")]
	[Address(RVA = "0x174B518", Offset = "0x174B518", VA = "0x174B518")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x600210F")]
	[Address(RVA = "0x174B5CC", Offset = "0x174B5CC", VA = "0x174B5CC")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002110")]
	[Address(RVA = "0x174B850", Offset = "0x174B850", VA = "0x174B850")]
	private void ResetBall(Vector3 resetPos)
	{
	}

	[Token(Token = "0x6002111")]
	[Address(RVA = "0x174B8E0", Offset = "0x174B8E0", VA = "0x174B8E0")]
	public VolleyGame()
	{
	}
}
