using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A33")]
public class PlayAgainDialog : MonoBehaviour
{
	[Token(Token = "0x4003857")]
	[FieldOffset(Offset = "0x18")]
	public Action<bool> lastCallback;

	[Token(Token = "0x600308F")]
	[Address(RVA = "0x15E8A20", Offset = "0x15E8A20", VA = "0x15E8A20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003090")]
	[Address(RVA = "0x15E8A48", Offset = "0x15E8A48", VA = "0x15E8A48")]
	public void BeginPlayagainMenu(Action<bool> callback)
	{
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x15E8A88", Offset = "0x15E8A88", VA = "0x15E8A88")]
	private void SetResult(bool result)
	{
	}

	[Token(Token = "0x6003092")]
	[Address(RVA = "0x15E8B0C", Offset = "0x15E8B0C", VA = "0x15E8B0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x15E8BEC", Offset = "0x15E8BEC", VA = "0x15E8BEC")]
	public PlayAgainDialog()
	{
	}
}
