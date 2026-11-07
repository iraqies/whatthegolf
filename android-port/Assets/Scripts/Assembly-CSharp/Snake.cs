using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200084C")]
public class Snake : MonoBehaviour
{
	[Token(Token = "0x4002CF7")]
	[FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x4002CF8")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] segments;

	[Token(Token = "0x4002CF9")]
	[FieldOffset(Offset = "0x28")]
	private List<Vector3> breadcrumbs;

	[Token(Token = "0x4002CFA")]
	[FieldOffset(Offset = "0x30")]
	public float segmentSpacing;

	[Token(Token = "0x6002649")]
	[Address(RVA = "0x16B7FF4", Offset = "0x16B7FF4", VA = "0x16B7FF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0x16B82CC", Offset = "0x16B82CC", VA = "0x16B82CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0x16B886C", Offset = "0x16B886C", VA = "0x16B886C")]
	public Snake()
	{
	}
}
