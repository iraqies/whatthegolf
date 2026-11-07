using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001A6")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RangeAttribute", RVA = "0x3684C", Offset = "0x3684C")]
		public float weight;

		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36864", Offset = "0x36864")]
		public float localRotationWeight;

		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x3687C", Offset = "0x3687C")]
		public float localPositionWeight;

		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000C6E")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x13C0D4C", Offset = "0x13C0D4C", VA = "0x13C0D4C")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000C70")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000C71")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000C72")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x13C0D58", Offset = "0x13C0D58", VA = "0x13C0D58", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x13C0DAC", Offset = "0x13C0DAC", VA = "0x13C0DAC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x13C0DE4", Offset = "0x13C0DE4", VA = "0x13C0DE4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x13C0E00", Offset = "0x13C0E00", VA = "0x13C0E00")]
		protected Poser()
		{
		}
	}
}
