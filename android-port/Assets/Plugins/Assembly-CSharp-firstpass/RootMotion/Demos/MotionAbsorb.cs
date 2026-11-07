using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000204")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000205")]
		public enum Mode
		{
			[Token(Token = "0x4000D9C")]
			Position = 0,
			[Token(Token = "0x4000D9D")]
			PositionOffset = 1
		}

		[Serializable]
		[Token(Token = "0x2000206")]
		public class Absorber
		{
			[Token(Token = "0x4000D9E")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000D9F")]
			[FieldOffset(Offset = "0x14")]
			public float weight;

			[Token(Token = "0x4000DA0")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000DA1")]
			[FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000DA2")]
			[FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x134FAC8", Offset = "0x134FAC8", VA = "0x134FAC8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x134FB94", Offset = "0x134FB94", VA = "0x134FB94")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x134FBB8", Offset = "0x134FBB8", VA = "0x134FBB8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x134FC60", Offset = "0x134FC60", VA = "0x134FC60")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000E24")]
			[Address(RVA = "0x134FCD4", Offset = "0x134FCD4", VA = "0x134FCD4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x2C")]
		public Mode mode;

		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x30")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x40")]
		public float falloffSpeed;

		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x13B4B94", Offset = "0x13B4B94", VA = "0x13B4B94", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x13B4C78", Offset = "0x13B4C78", VA = "0x13B4C78")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x13B4D08", Offset = "0x13B4D08", VA = "0x13B4D08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x13B4E1C", Offset = "0x13B4E1C", VA = "0x13B4E1C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x13B4EA8", Offset = "0x13B4EA8", VA = "0x13B4EA8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x13B4FD0", Offset = "0x13B4FD0", VA = "0x13B4FD0")]
		public MotionAbsorb()
		{
		}
	}
}
