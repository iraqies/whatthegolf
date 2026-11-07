using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C1E")]
public class RagdollReset : MonoBehaviour
{
	[Token(Token = "0x40042DA")]
	[FieldOffset(Offset = "0x18")]
	public bool TwoD;

	[Token(Token = "0x40042DB")]
	[FieldOffset(Offset = "0x19")]
	public bool ManualReset;

	[Token(Token = "0x40042DC")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Rigidbody2D, ResetInfo2D> savedResetInfo2D;

	[Token(Token = "0x40042DD")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<Rigidbody, ResetInfo> savedResetInfo;

	[Token(Token = "0x40042DE")]
	[FieldOffset(Offset = "0x30")]
	public bool resetOnFirstFixed;

	[Token(Token = "0x60039FB")]
	[Address(RVA = "0x163CC8C", Offset = "0x163CC8C", VA = "0x163CC8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039FC")]
	[Address(RVA = "0x163D3A0", Offset = "0x163D3A0", VA = "0x163D3A0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60039FD")]
	[Address(RVA = "0x163CFE4", Offset = "0x163CFE4", VA = "0x163CFE4")]
	public void SaveResetInfo()
	{
	}

	[Token(Token = "0x60039FE")]
	[Address(RVA = "0x163D3B8", Offset = "0x163D3B8", VA = "0x163D3B8")]
	public void ResetRagdoll()
	{
	}

	[Token(Token = "0x60039FF")]
	[Address(RVA = "0x163D76C", Offset = "0x163D76C", VA = "0x163D76C")]
	public RagdollReset()
	{
	}
}
