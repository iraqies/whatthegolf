using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000108")]
public class PlayerBeachBall : MonoBehaviour
{
	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x18")]
	public BeachBallWithAvatarController Player;

	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigid;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x28")]
	private float nextPushTime;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x2C")]
	public bool debugThings;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x30")]
	public float pushMultiplier;

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x15F70C8", Offset = "0x15F70C8", VA = "0x15F70C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x15F7124", Offset = "0x15F7124", VA = "0x15F7124")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x15F7640", Offset = "0x15F7640", VA = "0x15F7640")]
	public void Push(Vector3 dir)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x15F7724", Offset = "0x15F7724", VA = "0x15F7724")]
	public PlayerBeachBall()
	{
	}
}
