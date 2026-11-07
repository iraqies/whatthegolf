using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000813")]
public class RoguelikeEnemy : MonoBehaviour
{
	[Token(Token = "0x4002B74")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x4002B75")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController PlayerShooter;

	[Token(Token = "0x4002B76")]
	[FieldOffset(Offset = "0x28")]
	public float AlertDistance;

	[Token(Token = "0x4002B77")]
	[FieldOffset(Offset = "0x2C")]
	public float StopDistance;

	[Token(Token = "0x4002B78")]
	[FieldOffset(Offset = "0x30")]
	public float StepSize;

	[Token(Token = "0x4002B79")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem DeathSystem;

	[Token(Token = "0x4002B7A")]
	[FieldOffset(Offset = "0x40")]
	private NavMeshAgent agent;

	[Token(Token = "0x4002B7B")]
	[FieldOffset(Offset = "0x48")]
	private bool doMove;

	[Token(Token = "0x4002B7C")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 lastPosition;

	[Token(Token = "0x4002B7D")]
	[FieldOffset(Offset = "0x58")]
	private RoguelikeShooter player;

	[Token(Token = "0x600251B")]
	[Address(RVA = "0x165B7B0", Offset = "0x165B7B0", VA = "0x165B7B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600251C")]
	[Address(RVA = "0x165B8EC", Offset = "0x165B8EC", VA = "0x165B8EC")]
	private void PlayerShooter_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600251D")]
	[Address(RVA = "0x165B930", Offset = "0x165B930", VA = "0x165B930")]
	private void Update()
	{
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0x165BD5C", Offset = "0x165BD5C", VA = "0x165BD5C")]
	public void Die()
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x165BE5C", Offset = "0x165BE5C", VA = "0x165BE5C")]
	public RoguelikeEnemy()
	{
	}
}
