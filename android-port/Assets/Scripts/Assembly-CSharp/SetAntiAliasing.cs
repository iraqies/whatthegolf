using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C3B")]
public class SetAntiAliasing : MonoBehaviour
{
	[Token(Token = "0x400434B")]
	[FieldOffset(Offset = "0x18")]
	public int newAntiAliasingValue;

	[Token(Token = "0x400434C")]
	[FieldOffset(Offset = "0x1C")]
	private int previousAA;

	[Token(Token = "0x6003A54")]
	[Address(RVA = "0x168B9A8", Offset = "0x168B9A8", VA = "0x168B9A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A55")]
	[Address(RVA = "0x168B9D8", Offset = "0x168B9D8", VA = "0x168B9D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003A56")]
	[Address(RVA = "0x168B9E4", Offset = "0x168B9E4", VA = "0x168B9E4")]
	public SetAntiAliasing()
	{
	}
}
