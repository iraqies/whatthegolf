using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2E")]
public class ScaleObjectWithWorldPos : MonoBehaviour
{
	[Token(Token = "0x400431B")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 WorldAxisToUse;

	[Token(Token = "0x400431C")]
	[FieldOffset(Offset = "0x24")]
	public float ScaleMod;

	[Token(Token = "0x400431D")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 MinScale;

	[Token(Token = "0x400431E")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 startPos;

	[Token(Token = "0x400431F")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 startScale;

	[Token(Token = "0x6003A32")]
	[Address(RVA = "0x167A35C", Offset = "0x167A35C", VA = "0x167A35C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A33")]
	[Address(RVA = "0x167A3B8", Offset = "0x167A3B8", VA = "0x167A3B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A34")]
	[Address(RVA = "0x167A548", Offset = "0x167A548", VA = "0x167A548")]
	public ScaleObjectWithWorldPos()
	{
	}
}
