using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DCE")]
public class RandomGoopOnTrees : MonoBehaviour
{
	[Token(Token = "0x4004B47")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> goop;

	[Token(Token = "0x4004B48")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject tape;

	[Token(Token = "0x4004B49")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _randomYRotation;

	[Token(Token = "0x6004115")]
	[Address(RVA = "0x163FD0C", Offset = "0x163FD0C", VA = "0x163FD0C")]
	public void Randomize()
	{
	}

	[Token(Token = "0x6004116")]
	[Address(RVA = "0x1640034", Offset = "0x1640034", VA = "0x1640034")]
	public RandomGoopOnTrees()
	{
	}
}
