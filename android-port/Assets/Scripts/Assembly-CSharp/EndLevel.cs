using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076B")]
public class EndLevel : MonoBehaviour
{
	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0x18")]
	public Transform startPos;

	[Token(Token = "0x400274C")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> numbers;

	[Token(Token = "0x600222B")]
	[Address(RVA = "0x1443AB8", Offset = "0x1443AB8", VA = "0x1443AB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600222C")]
	[Address(RVA = "0x1443C24", Offset = "0x1443C24", VA = "0x1443C24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600222D")]
	[Address(RVA = "0x1444124", Offset = "0x1444124", VA = "0x1444124")]
	public EndLevel()
	{
	}
}
