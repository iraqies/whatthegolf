using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000208")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000209")]
		public class EffectorLink
		{
			[Token(Token = "0x4000DAC")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000DAD")]
			[FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000DAE")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0x1350DF8", Offset = "0x1350DF8", VA = "0x1350DF8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x13BCD60", Offset = "0x13BCD60", VA = "0x13BCD60", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x13BCF30", Offset = "0x13BCF30", VA = "0x13BCF30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x13BD0EC", Offset = "0x13BD0EC", VA = "0x13BD0EC")]
		public OffsetEffector()
		{
		}
	}
}
