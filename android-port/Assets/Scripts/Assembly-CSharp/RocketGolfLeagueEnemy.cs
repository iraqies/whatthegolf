using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000812")]
public class RocketGolfLeagueEnemy : MonoBehaviour
{
	[Token(Token = "0x4002B6F")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x4002B70")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4002B71")]
	[FieldOffset(Offset = "0x24")]
	public ForceMode ForceMode;

	[Token(Token = "0x4002B72")]
	[FieldOffset(Offset = "0x28")]
	public float MaxRotation;

	[Token(Token = "0x4002B73")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x6002518")]
	[Address(RVA = "0x1659870", Offset = "0x1659870", VA = "0x1659870")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002519")]
	[Address(RVA = "0x16598CC", Offset = "0x16598CC", VA = "0x16598CC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600251A")]
	[Address(RVA = "0x1659A60", Offset = "0x1659A60", VA = "0x1659A60")]
	public RocketGolfLeagueEnemy()
	{
	}
}
