using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200042E")]
public class QuestState : MonoBehaviour
{
	[Token(Token = "0x200042F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA2C", Offset = "0x3FA2C")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x10")]
		public QuestState _003C_003E4__this;

		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x18")]
		public GolfBallController controller;

		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x182F71C", Offset = "0x182F71C", VA = "0x182F71C")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}
	}

	[Token(Token = "0x2000430")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FA3C", Offset = "0x3FA3C")]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x10")]
		public ChallengeTriggerBase trigger;

		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem ps;

		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x182F724", Offset = "0x182F724", VA = "0x182F724")]
		public _003C_003Ec__DisplayClass16_1()
		{
		}

		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x182F72C", Offset = "0x182F72C", VA = "0x182F72C")]
		internal void _003CInit_003Eb__0(ChallengeTriggerBase t)
		{
		}
	}

	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x18")]
	public string DescriptionLocalizationID;

	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x20")]
	public bool triggerAll;

	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x24")]
	public int customTriggerCount;

	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x28")]
	public float particleSizeFactor;

	[Token(Token = "0x40016E3")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnCompleteEvent;

	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D64C", Offset = "0x4D64C")]
	private int triggerCount__BackingField;

	[Token(Token = "0x40016E5")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D65C", Offset = "0x4D65C")]
	private ChallengeTriggerBase[] triggers__BackingField;

	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<ChallengeTriggerBase, ParticleSystem> TriggerParticles;

	[Token(Token = "0x17000230")]
	public int triggerCount
	{
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x1632CE4", Offset = "0x1632CE4", VA = "0x1632CE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F0C", Offset = "0x61F0C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x1632CEC", Offset = "0x1632CEC", VA = "0x1632CEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F1C", Offset = "0x61F1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000231")]
	public ChallengeTriggerBase[] triggers
	{
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x1632CF4", Offset = "0x1632CF4", VA = "0x1632CF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F2C", Offset = "0x61F2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x1632CFC", Offset = "0x1632CFC", VA = "0x1632CFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61F3C", Offset = "0x61F3C")]
		set
		{
		}
	}

	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x1632D04", Offset = "0x1632D04", VA = "0x1632D04")]
	public int GetMaxTriggerCount()
	{
		return default;
	}

	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x1632D30", Offset = "0x1632D30", VA = "0x1632D30")]
	public bool HasCompletedState()
	{
		return default;
	}

	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x1632D68", Offset = "0x1632D68", VA = "0x1632D68")]
	public void Init(GolfBallController controller, ParticleSystem HintParticleSystem)
	{
	}

	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x16330C8", Offset = "0x16330C8", VA = "0x16330C8")]
	public void OnStart()
	{
	}

	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x163319C", Offset = "0x163319C", VA = "0x163319C")]
	public void OnComplete()
	{
	}

	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x163336C", Offset = "0x163336C", VA = "0x163336C")]
	public QuestState()
	{
	}
}
