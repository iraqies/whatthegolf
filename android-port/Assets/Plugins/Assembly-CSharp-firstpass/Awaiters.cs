using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000007")]
public static class Awaiters
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WaitForUpdate _waitForUpdate;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x8")]
	private static readonly WaitForFixedUpdate _waitForFixedUpdate;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x10")]
	private static readonly WaitForEndOfFrame _waitForEndOfFrame;

	[Token(Token = "0x17000003")]
	public static WaitForUpdate NextFrame
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12F4AA8", Offset = "0x12F4AA8", VA = "0x12F4AA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x12F4B0C", Offset = "0x12F4B0C", VA = "0x12F4B0C")]
		get
		{
			return null;
		}
	}
}
