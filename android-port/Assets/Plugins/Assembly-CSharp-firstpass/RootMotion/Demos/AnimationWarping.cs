using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001ED")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001EE")]
		public struct Warp
		{
			[Token(Token = "0x4000D09")]
			[FieldOffset(Offset = "0x0")]
			public int animationLayer;

			[Token(Token = "0x4000D0A")]
			[FieldOffset(Offset = "0x8")]
			public string animationState;

			[Token(Token = "0x4000D0B")]
			[FieldOffset(Offset = "0x10")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000D0C")]
			[FieldOffset(Offset = "0x18")]
			public Transform warpFrom;

			[Token(Token = "0x4000D0D")]
			[FieldOffset(Offset = "0x20")]
			public Transform warpTo;

			[Token(Token = "0x4000D0E")]
			[FieldOffset(Offset = "0x28")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20001EF")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000D10")]
			PositionOffset = 0,
			[Token(Token = "0x4000D11")]
			Position = 1
		}

		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x38")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x40")]
		public Warp[] warps;

		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x12EE4AC", Offset = "0x12EE4AC", VA = "0x12EE4AC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x12EE4D8", Offset = "0x12EE4D8", VA = "0x12EE4D8")]
		public float GetWarpWeight(int warpIndex)
		{
			return default;
		}

		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x12EE71C", Offset = "0x12EE71C", VA = "0x12EE71C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x12EE9E0", Offset = "0x12EE9E0", VA = "0x12EE9E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x12EEA7C", Offset = "0x12EEA7C", VA = "0x12EEA7C")]
		public AnimationWarping()
		{
		}
	}
}
