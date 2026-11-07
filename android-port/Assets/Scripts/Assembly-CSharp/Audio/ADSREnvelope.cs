using System;
using Il2CppDummyDll;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x20013A9")]
	public class ADSREnvelope
	{
		[Token(Token = "0x20013AA")]
		public enum State
		{
			[Token(Token = "0x40069E2")]
			Idle = 0,
			[Token(Token = "0x40069E3")]
			Attack = 1,
			[Token(Token = "0x40069E4")]
			Decay = 2,
			[Token(Token = "0x40069E5")]
			Sustain = 3,
			[Token(Token = "0x40069E6")]
			Release = 4
		}

		[Token(Token = "0x40069D4")]
		[FieldOffset(Offset = "0x10")]
		public float attackTime;

		[Token(Token = "0x40069D5")]
		[FieldOffset(Offset = "0x14")]
		public float decayTime;

		[Token(Token = "0x40069D6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A944", Offset = "0x5A944")]
		public float sustainLevel;

		[Token(Token = "0x40069D7")]
		[FieldOffset(Offset = "0x1C")]
		public float sustainTime;

		[Token(Token = "0x40069D8")]
		[FieldOffset(Offset = "0x20")]
		public float releaseTime;

		[Token(Token = "0x40069D9")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A95C", Offset = "0x5A95C")]
		private State EnvelopeState__BackingField;

		[Token(Token = "0x40069DA")]
		[FieldOffset(Offset = "0x28")]
		private float _attackIncrement;

		[Token(Token = "0x40069DB")]
		[FieldOffset(Offset = "0x2C")]
		private float _decayIncrement;

		[Token(Token = "0x40069DC")]
		[FieldOffset(Offset = "0x30")]
		private uint _decaySamples;

		[Token(Token = "0x40069DD")]
		[FieldOffset(Offset = "0x34")]
		private uint _sustainSamples;

		[Token(Token = "0x40069DE")]
		[FieldOffset(Offset = "0x38")]
		private float _releaseIncrement;

		[Token(Token = "0x40069DF")]
		[FieldOffset(Offset = "0x3C")]
		private float _outputLevel;

		[Token(Token = "0x40069E0")]
		[FieldOffset(Offset = "0x40")]
		private int _samplesUntillTrigger;

		[Token(Token = "0x17000A5A")]
		public State EnvelopeState
		{
			[Token(Token = "0x6005BCF")]
			[Address(RVA = "0x14039EC", Offset = "0x14039EC", VA = "0x14039EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726E8", Offset = "0x726E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005BD0")]
			[Address(RVA = "0x14039F4", Offset = "0x14039F4", VA = "0x14039F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726F8", Offset = "0x726F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A5B")]
		public float Duration
		{
			[Token(Token = "0x6005BD1")]
			[Address(RVA = "0x14039FC", Offset = "0x14039FC", VA = "0x14039FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x1403A14", Offset = "0x1403A14", VA = "0x1403A14")]
		public ADSREnvelope(float attackTime, float decayTime, float sustainLevel, float sustainTime, float releaseTime)
		{
		}

		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x1403A98", Offset = "0x1403A98", VA = "0x1403A98")]
		public void SetSustainTime(float sustainTime)
		{
		}

		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x1403AA0", Offset = "0x1403AA0", VA = "0x1403AA0")]
		public void Trigger(int sampleRate, bool resetVolume = true)
		{
		}

		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x1403B98", Offset = "0x1403B98", VA = "0x1403B98")]
		public float GetLevel()
		{
			return default;
		}

		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x1403BA0", Offset = "0x1403BA0", VA = "0x1403BA0")]
		public void SetLevel(bool held = false)
		{
		}
	}
}
