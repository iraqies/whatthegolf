using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x200012E")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x200012F")]
		public enum Mode
		{
			[Token(Token = "0x4000752")]
			Float = 0,
			[Token(Token = "0x4000753")]
			Curve = 1
		}

		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x132D5AC", Offset = "0x132D5AC", VA = "0x132D5AC")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x132D624", Offset = "0x132D624", VA = "0x132D624")]
		public float GetValue(float param)
		{
			return default;
		}
	}
}
