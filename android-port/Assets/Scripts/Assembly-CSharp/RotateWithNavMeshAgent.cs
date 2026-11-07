using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x20007C3")]
public class RotateWithNavMeshAgent : MonoBehaviour
{
	[Token(Token = "0x400291F")]
	[FieldOffset(Offset = "0x18")]
	public NavMeshAgent Agent;

	[Token(Token = "0x4002920")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x600238F")]
	[Address(RVA = "0x16603F8", Offset = "0x16603F8", VA = "0x16603F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0x16604D8", Offset = "0x16604D8", VA = "0x16604D8")]
	public RotateWithNavMeshAgent()
	{
	}
}
