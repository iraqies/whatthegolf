using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000940")]
[Attribute(Name = "RequireComponent", RVA = "0x420F8", Offset = "0x420F8")]
public class GoToRandomNavMeshPosition : MonoBehaviour
{
	[Token(Token = "0x4003293")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 WaitTimeRange;

	[Token(Token = "0x4003294")]
	[FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4003295")]
	[FieldOffset(Offset = "0x28")]
	private NavMeshAgent agent;

	[Token(Token = "0x4003296")]
	[FieldOffset(Offset = "0x30")]
	private float waitTimer;

	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x148E8BC", Offset = "0x148E8BC", VA = "0x148E8BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002AFA")]
	[Address(RVA = "0x148EAD4", Offset = "0x148EAD4", VA = "0x148EAD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002AFB")]
	[Address(RVA = "0x148E9BC", Offset = "0x148E9BC", VA = "0x148E9BC")]
	private bool RandomPoint(Vector3 center, float range, out Vector3 result)
	{
		return default;
	}

	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x148EBF0", Offset = "0x148EBF0", VA = "0x148EBF0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x148ED04", Offset = "0x148ED04", VA = "0x148ED04")]
	public GoToRandomNavMeshPosition()
	{
	}
}
