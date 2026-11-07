using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B6")]
[ExecuteAlways]
public class ReplaceAllChildrenWithNewGameObject : MonoBehaviour
{
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObjectToReplaceWith;

	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x20")]
	public bool Replace;

	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x21")]
	public bool DestroyNew;

	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x22")]
	public bool DestroyOld;

	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 ScaleMod;

	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 PositionOffset;

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> NewObjects;

	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x1649320", Offset = "0x1649320", VA = "0x1649320")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x1649C68", Offset = "0x1649C68", VA = "0x1649C68")]
	public ReplaceAllChildrenWithNewGameObject()
	{
	}
}
