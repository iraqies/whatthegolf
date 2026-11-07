using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000350")]
[ExecuteAlways]
public class PlaceObjecsOnSphere : MonoBehaviour
{
	[Token(Token = "0x400124C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject planet;

	[Token(Token = "0x400124D")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x400124E")]
	[FieldOffset(Offset = "0x28")]
	public List<int> upModifier;

	[Token(Token = "0x400124F")]
	[FieldOffset(Offset = "0x30")]
	public int numToSpawn;

	[Token(Token = "0x4001250")]
	[FieldOffset(Offset = "0x34")]
	public bool Place;

	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x15E3B80", Offset = "0x15E3B80", VA = "0x15E3B80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x15E3BB0", Offset = "0x15E3BB0", VA = "0x15E3BB0")]
	public void Run()
	{
	}

	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x15E3FB8", Offset = "0x15E3FB8", VA = "0x15E3FB8")]
	public PlaceObjecsOnSphere()
	{
	}
}
