using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000208")]
[Attribute(Name = "RequireComponent", RVA = "0x3E3E8", Offset = "0x3E3E8")]
public class TransformLineRenderer : MonoBehaviour
{
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x18")]
	private LineRenderer lr;

	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> nodes;

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x172ADDC", Offset = "0x172ADDC", VA = "0x172ADDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x172AE5C", Offset = "0x172AE5C", VA = "0x172AE5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000917")]
	[Address(RVA = "0x172AF10", Offset = "0x172AF10", VA = "0x172AF10")]
	public TransformLineRenderer()
	{
	}
}
