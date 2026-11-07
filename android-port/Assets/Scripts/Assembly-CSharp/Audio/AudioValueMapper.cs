using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x2001389")]
	public class AudioValueMapper
	{
		[Token(Token = "0x200138A")]
		public enum ValueOperation
		{
			[Token(Token = "0x40068E5")]
			Add = 0,
			[Token(Token = "0x40068E6")]
			Multiply = 1,
			[Token(Token = "0x40068E7")]
			Divide = 2
		}

		[Token(Token = "0x40068DC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BaseAudioValue audioValue;

		[Token(Token = "0x40068DD")]
		[FieldOffset(Offset = "0x18")]
		public float inputValue;

		[Token(Token = "0x40068DE")]
		[FieldOffset(Offset = "0x20")]
		public MinMax In;

		[Token(Token = "0x40068DF")]
		[FieldOffset(Offset = "0x28")]
		public MinMax Out;

		[Token(Token = "0x40068E0")]
		[FieldOffset(Offset = "0x30")]
		public bool outputZeroBelowMin;

		[Token(Token = "0x40068E1")]
		[FieldOffset(Offset = "0x34")]
		public float value;

		[Token(Token = "0x40068E2")]
		[FieldOffset(Offset = "0x38")]
		public ValueOperation valueOperation;

		[Token(Token = "0x40068E3")]
		[FieldOffset(Offset = "0x40")]
		public Action OnChange;

		[Token(Token = "0x6005B3B")]
		[Address(RVA = "0x15100E4", Offset = "0x15100E4", VA = "0x15100E4")]
		public void Init()
		{
		}

		[Token(Token = "0x6005B3C")]
		[Address(RVA = "0x15102A8", Offset = "0x15102A8", VA = "0x15102A8")]
		private void SetValue(float _input)
		{
		}

		[Token(Token = "0x6005B3D")]
		[Address(RVA = "0x1510348", Offset = "0x1510348", VA = "0x1510348")]
		public AudioValueMapper()
		{
		}
	}
}
