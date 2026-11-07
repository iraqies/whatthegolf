using Il2CppDummyDll;
using Triband.Splines;
using UnityEngine;

[Token(Token = "0x2000DFA")]
public class ToyRoad : MonoBehaviour
{
	[Token(Token = "0x4004C19")]
	[FieldOffset(Offset = "0x18")]
	public Spline splineToFollow;

	[Token(Token = "0x4004C1A")]
	[FieldOffset(Offset = "0x20")]
	private MeshFilter meshFilter;

	[Token(Token = "0x60041CE")]
	[Address(RVA = "0x1720B60", Offset = "0x1720B60", VA = "0x1720B60")]
	private void Start()
	{
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0x1720C10", Offset = "0x1720C10", VA = "0x1720C10")]
	public ToyRoad()
	{
	}
}
