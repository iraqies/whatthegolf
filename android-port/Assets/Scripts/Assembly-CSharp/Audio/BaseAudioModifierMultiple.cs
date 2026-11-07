using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001387")]
	public abstract class BaseAudioModifierMultiple : MonoBehaviour
	{
		[Token(Token = "0x40068D4")]
		[FieldOffset(Offset = "0x18")]
		public List<AudioValueMapper> modifiers;

		[Token(Token = "0x40068D5")]
		[FieldOffset(Offset = "0x20")]
		public bool smooth;

		[Token(Token = "0x40068D6")]
		[FieldOffset(Offset = "0x24")]
		public float smoothTime;

		[Token(Token = "0x40068D7")]
		[FieldOffset(Offset = "0x28")]
		private float chainOutput;

		[Token(Token = "0x40068D8")]
		[FieldOffset(Offset = "0x2C")]
		private float smooth_velocity;

		[Token(Token = "0x40068D9")]
		[FieldOffset(Offset = "0x30")]
		public float output;

		[Token(Token = "0x40068DA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A5B0", Offset = "0x5A5B0")]
		private float Gain__BackingField;

		[Token(Token = "0x17000A4E")]
		public float Gain
		{
			[Token(Token = "0x6005B31")]
			[Address(RVA = "0x151B2D0", Offset = "0x151B2D0", VA = "0x151B2D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x725A8", Offset = "0x725A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005B32")]
			[Address(RVA = "0x151B2D8", Offset = "0x151B2D8", VA = "0x151B2D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x725B8", Offset = "0x725B8")]
			set
			{
			}
		}

		[Token(Token = "0x6005B33")]
		[Address(RVA = "0x151B2E0", Offset = "0x151B2E0", VA = "0x151B2E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B34")]
		[Address(RVA = "0x151B578", Offset = "0x151B578", VA = "0x151B578", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6005B35")]
		[Address(RVA = "0x151B44C", Offset = "0x151B44C", VA = "0x151B44C")]
		public void SetOutput()
		{
		}

		[Token(Token = "0x6005B36")]
		[Address(RVA = "0x151B57C", Offset = "0x151B57C", VA = "0x151B57C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B37")]
		[Address(RVA = "0x151B5D4", Offset = "0x151B5D4", VA = "0x151B5D4", Slot = "5")]
		protected virtual void UpdateModifier()
		{
		}

		[Token(Token = "0x6005B38")]
		[Address(RVA = "0x151B5D8", Offset = "0x151B5D8", VA = "0x151B5D8")]
		protected BaseAudioModifierMultiple()
		{
		}
	}
}
