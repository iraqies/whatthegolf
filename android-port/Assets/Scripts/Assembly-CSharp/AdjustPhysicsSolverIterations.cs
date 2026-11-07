using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF4")]
public class AdjustPhysicsSolverIterations : MonoBehaviour
{
	[Token(Token = "0x4003D02")]
	[FieldOffset(Offset = "0x18")]
	public int DefaultSolverVelocityIterations;

	[Token(Token = "0x4003D03")]
	[FieldOffset(Offset = "0x1C")]
	public int DefaultSolverIterations;

	[Token(Token = "0x4003D04")]
	[FieldOffset(Offset = "0x20")]
	private int originalSolverVelocityIterations;

	[Token(Token = "0x4003D05")]
	[FieldOffset(Offset = "0x24")]
	private int originalSolverIterations;

	[Token(Token = "0x600343F")]
	[Address(RVA = "0x1408FC8", Offset = "0x1408FC8", VA = "0x1408FC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0x1409010", Offset = "0x1409010", VA = "0x1409010")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003441")]
	[Address(RVA = "0x1409040", Offset = "0x1409040", VA = "0x1409040")]
	public AdjustPhysicsSolverIterations()
	{
	}
}
