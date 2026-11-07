using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x20000DA")]
	public class BakerMuscle
	{
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x12F68EC", Offset = "0x12F68EC", VA = "0x12F68EC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x12F69A0", Offset = "0x12F69A0", VA = "0x12F69A0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x12F74DC", Offset = "0x12F74DC", VA = "0x12F74DC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x12F7590", Offset = "0x12F7590", VA = "0x12F7590")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x12F7478", Offset = "0x12F7478", VA = "0x12F7478")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x12F76B0", Offset = "0x12F76B0", VA = "0x12F76B0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x12F76F8", Offset = "0x12F76F8", VA = "0x12F76F8")]
		public void SetLoopFrame(float time)
		{
		}
	}
}
