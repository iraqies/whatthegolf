using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F6")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001F7")]
		public class Limb
		{
			[Token(Token = "0x4000D46")]
			[FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000D47")]
			[FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000D48")]
			[FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x133A048", Offset = "0x133A048", VA = "0x133A048")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x133A0CC", Offset = "0x133A0CC", VA = "0x133A0CC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x136C65C", Offset = "0x136C65C", VA = "0x136C65C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x136C7B4", Offset = "0x136C7B4", VA = "0x136C7B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x136C868", Offset = "0x136C868", VA = "0x136C868")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x136C86C", Offset = "0x136C86C", VA = "0x136C86C")]
		public FBBIKSettings()
		{
		}
	}
}
