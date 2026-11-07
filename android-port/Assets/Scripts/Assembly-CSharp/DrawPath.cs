using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA6")]
public class DrawPath : MonoBehaviour
{
	[Token(Token = "0x4004101")]
	[FieldOffset(Offset = "0x18")]
	public Color color;

	[Token(Token = "0x4004102")]
	[FieldOffset(Offset = "0x28")]
	public float minPosChangeBeforeDraw;

	[Token(Token = "0x4004103")]
	[FieldOffset(Offset = "0x2C")]
	public float segmentDuration;

	[Token(Token = "0x4004104")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 lastPos;

	[Token(Token = "0x6003843")]
	[Address(RVA = "0x1435E34", Offset = "0x1435E34", VA = "0x1435E34")]
	private void Start()
	{
	}

	[Token(Token = "0x6003844")]
	[Address(RVA = "0x1435E70", Offset = "0x1435E70", VA = "0x1435E70")]
	private void Update()
	{
	}

	[Token(Token = "0x6003845")]
	[Address(RVA = "0x1435FB4", Offset = "0x1435FB4", VA = "0x1435FB4")]
	public DrawPath()
	{
	}
}
