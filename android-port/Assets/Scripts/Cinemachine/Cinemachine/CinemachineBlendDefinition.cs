using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[Token(Token = "0x200005C")]
	public struct CinemachineBlendDefinition
	{
		[Token(Token = "0x200005D")]
		public enum Style
		{
			[Token(Token = "0x4000230")]
			Cut = 0,
			[Token(Token = "0x4000231")]
			EaseInOut = 1,
			[Token(Token = "0x4000232")]
			EaseIn = 2,
			[Token(Token = "0x4000233")]
			EaseOut = 3,
			[Token(Token = "0x4000234")]
			HardIn = 4,
			[Token(Token = "0x4000235")]
			HardOut = 5,
			[Token(Token = "0x4000236")]
			Linear = 6,
			[Token(Token = "0x4000237")]
			Custom = 7
		}

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x0")]
		public Style m_Style;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x4")]
		public float m_Time;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x8")]
		public AnimationCurve m_CustomCurve;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x0")]
		private static AnimationCurve[] sStandardCurves;

		[Token(Token = "0x17000089")]
		public AnimationCurve BlendCurve
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x18E1F18", Offset = "0x18E1F18", VA = "0x18E1F18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x18E1A0C", Offset = "0x18E1A0C", VA = "0x18E1A0C")]
		public CinemachineBlendDefinition(Style style, float time)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x18E1A1C", Offset = "0x18E1A1C", VA = "0x18E1A1C")]
		private void CreateStandardCurves()
		{
		}
	}
}
