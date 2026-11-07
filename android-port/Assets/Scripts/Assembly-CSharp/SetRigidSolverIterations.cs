using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B2C")]
[Attribute(Name = "RequireComponent", RVA = "0x436B8", Offset = "0x436B8")]
public class SetRigidSolverIterations : MonoBehaviour
{
	[Token(Token = "0x4003E61")]
	[FieldOffset(Offset = "0x18")]
	public bool setOnAwake;

	[Token(Token = "0x4003E62")]
	[FieldOffset(Offset = "0x1C")]
	public int solverIterationCount;

	[Token(Token = "0x6003536")]
	[Address(RVA = "0x168F7F0", Offset = "0x168F7F0", VA = "0x168F7F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003537")]
	[Address(RVA = "0x168F8BC", Offset = "0x168F8BC", VA = "0x168F8BC")]
	public SetRigidSolverIterations()
	{
	}
}
