using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D1")]
	public class AudioValueModulation : BaseAudioValue
	{
		[Token(Token = "0x4006A81")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve Curve;

		[Token(Token = "0x4006A82")]
		[FieldOffset(Offset = "0x40")]
		public float phaseDuration;

		[Token(Token = "0x4006A83")]
		[FieldOffset(Offset = "0x44")]
		public bool maxToMin;

		[Token(Token = "0x4006A84")]
		[FieldOffset(Offset = "0x45")]
		public bool canSelfTrigger;

		[Token(Token = "0x4006A85")]
		[FieldOffset(Offset = "0x48")]
		public float cooldownMin;

		[Token(Token = "0x4006A86")]
		[FieldOffset(Offset = "0x4C")]
		public float cooldownMax;

		[Token(Token = "0x4006A87")]
		[FieldOffset(Offset = "0x50")]
		public Action OnModulationComplete;

		[Token(Token = "0x4006A88")]
		[FieldOffset(Offset = "0x58")]
		private bool m_modulating;

		[Token(Token = "0x4006A89")]
		[FieldOffset(Offset = "0x5C")]
		private float m_nextModulation;

		[Token(Token = "0x17000A73")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C6C")]
			[Address(RVA = "0x15103DC", Offset = "0x15103DC", VA = "0x15103DC", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x15103E4", Offset = "0x15103E4", VA = "0x15103E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x15105A8", Offset = "0x15105A8", VA = "0x15105A8", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x15105EC", Offset = "0x15105EC", VA = "0x15105EC")]
		public void TriggerModulation()
		{
		}

		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x1510430", Offset = "0x1510430", VA = "0x1510430")]
		private void StartModulation()
		{
		}

		[Token(Token = "0x6005C71")]
		[Address(RVA = "0x15105F0", Offset = "0x15105F0", VA = "0x15105F0")]
		public AudioValueModulation()
		{
		}

		[Token(Token = "0x6005C72")]
		[Address(RVA = "0x1510608", Offset = "0x1510608", VA = "0x1510608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72820", Offset = "0x72820")]
		private void _003CStartModulation_003Eb__14_0(float t)
		{
		}

		[Token(Token = "0x6005C73")]
		[Address(RVA = "0x1510648", Offset = "0x1510648", VA = "0x1510648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72830", Offset = "0x72830")]
		private void _003CStartModulation_003Eb__14_1()
		{
		}
	}
}
