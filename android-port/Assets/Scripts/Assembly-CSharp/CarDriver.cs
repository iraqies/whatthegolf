using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20007EC")]
public class CarDriver : MonoBehaviour
{
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0x18")]
	public NavMeshAgent navAgent;

	[Token(Token = "0x4002A71")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] targets;

	[Token(Token = "0x4002A72")]
	[FieldOffset(Offset = "0x28")]
	public float checkpointDist;

	[Token(Token = "0x4002A73")]
	[FieldOffset(Offset = "0x2C")]
	private int currentTarget;

	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0x30")]
	public float stunForce;

	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0x34")]
	public float stunDuration;

	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0x38")]
	public float stunSpinVel;

	[Token(Token = "0x4002A77")]
	[FieldOffset(Offset = "0x3C")]
	private bool stunned;

	[Token(Token = "0x4002A78")]
	[FieldOffset(Offset = "0x40")]
	private float stunStart;

	[Token(Token = "0x4002A79")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigid;

	[Token(Token = "0x4002A7A")]
	[FieldOffset(Offset = "0x50")]
	public string[] stunTags;

	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject[] disableWhenStunned;

	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0x60")]
	public bool wait;

	[Token(Token = "0x4002A7D")]
	[FieldOffset(Offset = "0x68")]
	public RaceManager race;

	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0x70")]
	public Color gizmosColor;

	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0x80")]
	public float stunJumpVel;

	[Token(Token = "0x6002462")]
	[Address(RVA = "0x1888E18", Offset = "0x1888E18", VA = "0x1888E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002463")]
	[Address(RVA = "0x1888F18", Offset = "0x1888F18", VA = "0x1888F18")]
	private void Update()
	{
	}

	[Token(Token = "0x6002464")]
	[Address(RVA = "0x18892F0", Offset = "0x18892F0", VA = "0x18892F0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002465")]
	[Address(RVA = "0x1889540", Offset = "0x1889540", VA = "0x1889540")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002466")]
	[Address(RVA = "0x18896EC", Offset = "0x18896EC", VA = "0x18896EC")]
	public CarDriver()
	{
	}
}
