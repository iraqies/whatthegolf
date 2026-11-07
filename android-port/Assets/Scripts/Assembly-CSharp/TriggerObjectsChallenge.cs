using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x200042A")]
public class TriggerObjectsChallenge : Challenge
{
	[Serializable]
	[Token(Token = "0x200042B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA0C", Offset = "0x3FA0C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__14_0;

		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__14_1;

		[Token(Token = "0x6001396")]
		[Address(RVA = "0x186D53C", Offset = "0x186D53C", VA = "0x186D53C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001397")]
		[Address(RVA = "0x186D544", Offset = "0x186D544", VA = "0x186D544")]
		internal void _003COnTrigger_003Eb__14_0(float v)
		{
		}

		[Token(Token = "0x6001398")]
		[Address(RVA = "0x186D548", Offset = "0x186D548", VA = "0x186D548")]
		internal void _003COnTrigger_003Eb__14_1(float v)
		{
		}
	}

	[Token(Token = "0x40016C5")]
	[FieldOffset(Offset = "0xA1")]
	public bool LookForTriggersInChildren;

	[Token(Token = "0x40016C6")]
	[FieldOffset(Offset = "0xA8")]
	public List<ChallengeTriggerBase> triggers;

	[Token(Token = "0x40016C7")]
	[FieldOffset(Offset = "0xB0")]
	public bool WinOnLastTrigger;

	[Token(Token = "0x40016C8")]
	[FieldOffset(Offset = "0xB1")]
	public bool DestroyObjectOnHit;

	[Token(Token = "0x40016C9")]
	[FieldOffset(Offset = "0xB8")]
	public Action<int> onChallengeTrigger;

	[Token(Token = "0x40016CA")]
	[FieldOffset(Offset = "0xC0")]
	public ClipSettingsCollection SFX_OnTrigger;

	[Token(Token = "0x40016CB")]
	[FieldOffset(Offset = "0xC8")]
	public ClipSettingsCollection SFX_OnWin;

	[Token(Token = "0x40016CC")]
	[FieldOffset(Offset = "0xD0")]
	public bool CompleteAfterDelay;

	[Token(Token = "0x40016CD")]
	[FieldOffset(Offset = "0xD4")]
	public float delay;

	[Token(Token = "0x40016CE")]
	[FieldOffset(Offset = "0xD8")]
	public int customTriggerAmount;

	[Token(Token = "0x40016CF")]
	[FieldOffset(Offset = "0xDC")]
	public bool hideStrokeCounter;

	[Token(Token = "0x40016D0")]
	[FieldOffset(Offset = "0xE0")]
	private int triggerCount;

	[Token(Token = "0x40016D1")]
	[FieldOffset(Offset = "0xE8")]
	private GolfBallController controller;

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x172E94C", Offset = "0x172E94C", VA = "0x172E94C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001392")]
	[Address(RVA = "0x172EB98", Offset = "0x172EB98", VA = "0x172EB98")]
	private void OnTrigger(ChallengeTriggerBase trigger)
	{
	}

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x172F098", Offset = "0x172F098", VA = "0x172F098", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0x172F128", Offset = "0x172F128", VA = "0x172F128")]
	public TriggerObjectsChallenge()
	{
	}
}
