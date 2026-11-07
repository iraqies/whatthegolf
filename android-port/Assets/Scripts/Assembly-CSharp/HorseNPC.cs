using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000794")]
public class HorseNPC : MonoBehaviour
{
	[Token(Token = "0x40027FF")]
	[FieldOffset(Offset = "0x18")]
	public HorseLaps Waypoints;

	[Token(Token = "0x4002800")]
	[FieldOffset(Offset = "0x20")]
	private NavMeshAgent agent;

	[Token(Token = "0x4002801")]
	[FieldOffset(Offset = "0x28")]
	private int currentWaypoint;

	[Token(Token = "0x4002802")]
	[FieldOffset(Offset = "0x2C")]
	private bool hasPath;

	[Token(Token = "0x4002803")]
	[FieldOffset(Offset = "0x2D")]
	private bool hasStarted;

	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x14D56D0", Offset = "0x14D56D0", VA = "0x14D56D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x14D5794", Offset = "0x14D5794", VA = "0x14D5794")]
	private void Start()
	{
	}

	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x14D5858", Offset = "0x14D5858", VA = "0x14D5858")]
	private void Ball_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x14D5B10", Offset = "0x14D5B10", VA = "0x14D5B10")]
	private void Update()
	{
	}

	[Token(Token = "0x60022C3")]
	[Address(RVA = "0x14D5888", Offset = "0x14D5888", VA = "0x14D5888")]
	private void SetNewDestination()
	{
	}

	[Token(Token = "0x60022C4")]
	[Address(RVA = "0x14D5B98", Offset = "0x14D5B98", VA = "0x14D5B98")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60022C5")]
	[Address(RVA = "0x14D5CC0", Offset = "0x14D5CC0", VA = "0x14D5CC0")]
	public HorseNPC()
	{
	}
}
