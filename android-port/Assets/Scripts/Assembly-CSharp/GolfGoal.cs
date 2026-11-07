using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20004A8")]
public class GolfGoal : MonoBehaviour
{
	[Token(Token = "0x20004A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FD74", Offset = "0x3FD74")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0x10")]
		public string message;

		[Token(Token = "0x6001581")]
		[Address(RVA = "0x17B57B8", Offset = "0x17B57B8", VA = "0x17B57B8")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6001582")]
		[Address(RVA = "0x17B57C0", Offset = "0x17B57C0", VA = "0x17B57C0")]
		internal void _003CCompleteTrailerMode_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FD84", Offset = "0x3FD84")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001884")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001885")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__23_0;

		[Token(Token = "0x6001584")]
		[Address(RVA = "0x17B57AC", Offset = "0x17B57AC", VA = "0x17B57AC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001585")]
		[Address(RVA = "0x17B57B4", Offset = "0x17B57B4", VA = "0x17B57B4")]
		internal void _003CCompleteTrailerMode_003Eb__23_0(float t)
		{
		}
	}

	[Token(Token = "0x400187A")]
	[FieldOffset(Offset = "0x18")]
	public float winDelay;

	[Token(Token = "0x400187B")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D74C", Offset = "0x4D74C")]
	private Action<string> m_OnGoal;

	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x28")]
	public string CustomWinTextID;

	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D75C", Offset = "0x4D75C")]
	private Action<int, string> m_OnGoalProgress;

	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnGoalEvent;

	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x40")]
	private bool hasCheated;

	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D76C", Offset = "0x4D76C")]
	private bool TrailerDelayMode__BackingField;

	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x42")]
	private bool trailerCompleteDetected;

	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x43")]
	private bool completed;

	[Token(Token = "0x1700025C")]
	public bool TrailerDelayMode
	{
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x14A085C", Offset = "0x14A085C", VA = "0x14A085C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623AC", Offset = "0x623AC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x14A0864", Offset = "0x14A0864", VA = "0x14A0864")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623BC", Offset = "0x623BC")]
		set
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public event Action<string> OnGoal
	{
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x14A05CC", Offset = "0x14A05CC", VA = "0x14A05CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6236C", Offset = "0x6236C")]
		add
		{
		}
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x14A0670", Offset = "0x14A0670", VA = "0x14A0670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6237C", Offset = "0x6237C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public event Action<int, string> OnGoalProgress
	{
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x14A0714", Offset = "0x14A0714", VA = "0x14A0714")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6238C", Offset = "0x6238C")]
		add
		{
		}
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x14A07B8", Offset = "0x14A07B8", VA = "0x14A07B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6239C", Offset = "0x6239C")]
		remove
		{
		}
	}

	[Token(Token = "0x6001577")]
	[Address(RVA = "0x14A086C", Offset = "0x14A086C", VA = "0x14A086C", Slot = "4")]
	public virtual void Complete()
	{
	}

	[Token(Token = "0x6001578")]
	[Address(RVA = "0x14A08A4", Offset = "0x14A08A4", VA = "0x14A08A4", Slot = "5")]
	public virtual void Complete(float delay)
	{
	}

	[Token(Token = "0x6001579")]
	[Address(RVA = "0x14A08EC", Offset = "0x14A08EC", VA = "0x14A08EC", Slot = "6")]
	protected virtual string GetWinString()
	{
		return null;
	}

	[Token(Token = "0x600157A")]
	[Address(RVA = "0x149E35C", Offset = "0x149E35C", VA = "0x149E35C")]
	public void GoalProgress(int playerIndex)
	{
	}

	[Token(Token = "0x600157B")]
	[Address(RVA = "0x14A094C", Offset = "0x14A094C", VA = "0x14A094C", Slot = "7")]
	public virtual void Complete(string message)
	{
	}

	[Token(Token = "0x600157C")]
	[Address(RVA = "0x14A0A60", Offset = "0x14A0A60", VA = "0x14A0A60", Slot = "8")]
	public virtual void Complete(string message, float delay)
	{
	}

	[Token(Token = "0x600157D")]
	[Address(RVA = "0x14A0954", Offset = "0x14A0954", VA = "0x14A0954")]
	private void DoComplete(string message, float? delay)
	{
	}

	[Token(Token = "0x600157E")]
	[Address(RVA = "0x14A0AE8", Offset = "0x14A0AE8", VA = "0x14A0AE8")]
	private void CompleteTrailerMode(string message)
	{
	}

	[Token(Token = "0x600157F")]
	[Address(RVA = "0x14A0D4C", Offset = "0x14A0D4C", VA = "0x14A0D4C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0x14A0D54", Offset = "0x14A0D54", VA = "0x14A0D54")]
	public GolfGoal()
	{
	}
}
