using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000459")]
public abstract class AutoFailBase : MonoBehaviour
{
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x18")]
	public float failStateTime;

	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x1C")]
	public bool CheckAutoFail;

	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x20")]
	public Action OnFail;

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x28")]
	public float m_Timer;

	[Token(Token = "0x600145F")]
	[Address(RVA = "0x15149EC", Offset = "0x15149EC", VA = "0x15149EC", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6001460")]
	[Address(RVA = "0x15149F0", Offset = "0x15149F0", VA = "0x15149F0")]
	public void DecrementFailTimer()
	{
	}

	[Token(Token = "0x6001461")]
	[Address(RVA = "0x1514A60", Offset = "0x1514A60", VA = "0x1514A60")]
	public void ResetFailTimer()
	{
	}

	[Token(Token = "0x6001462")]
	[Address(RVA = "0x1514A4C", Offset = "0x1514A4C", VA = "0x1514A4C")]
	public void DoFail()
	{
	}

	[Token(Token = "0x6001463")]
	[Address(RVA = "0x1514A6C", Offset = "0x1514A6C", VA = "0x1514A6C")]
	protected AutoFailBase()
	{
	}
}
