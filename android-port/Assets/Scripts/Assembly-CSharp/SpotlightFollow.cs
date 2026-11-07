using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000321")]
public class SpotlightFollow : MonoBehaviour
{
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x18")]
	public Transform targetTransform;

	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x20")]
	public bool followOnY;

	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 offset;

	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x30")]
	public float followSpeed;

	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 posWithoutY;

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x16D8DCC", Offset = "0x16D8DCC", VA = "0x16D8DCC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x16D8F94", Offset = "0x16D8F94", VA = "0x16D8F94")]
	public SpotlightFollow()
	{
	}
}
