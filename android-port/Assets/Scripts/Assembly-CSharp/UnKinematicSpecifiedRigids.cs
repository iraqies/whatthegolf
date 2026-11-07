using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEC")]
public class UnKinematicSpecifiedRigids : MonoBehaviour
{
	[Token(Token = "0x4004BDA")]
	[FieldOffset(Offset = "0x18")]
	public bool setAllKinematicAtStart;

	[Token(Token = "0x4004BDB")]
	[FieldOffset(Offset = "0x1C")]
	public float massCoefficient;

	[Token(Token = "0x4004BDC")]
	[FieldOffset(Offset = "0x20")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x6004191")]
	[Address(RVA = "0x173A734", Offset = "0x173A734", VA = "0x173A734")]
	private void Start()
	{
	}

	[Token(Token = "0x6004192")]
	[Address(RVA = "0x173A838", Offset = "0x173A838", VA = "0x173A838")]
	public void MakeUnkinematic()
	{
	}

	[Token(Token = "0x6004193")]
	[Address(RVA = "0x173A8D8", Offset = "0x173A8D8", VA = "0x173A8D8")]
	public UnKinematicSpecifiedRigids()
	{
	}
}
