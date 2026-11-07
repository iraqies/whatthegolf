using System;
using Il2CppDummyDll;
using RootMotion.Dynamics;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000227")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000228")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000229")]
			public class Anim
			{
				[Token(Token = "0x4000E44")]
				[FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x4000E45")]
				[FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x4000E46")]
				[FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x4000E47")]
				[FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x6000EA5")]
				[Address(RVA = "0x135A744", Offset = "0x135A744", VA = "0x135A744")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x4000E3D")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000E3E")]
			[FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x4000E3F")]
			[FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x4000E40")]
			[FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x4000E41")]
			[FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x4000E42")]
			[FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x4000E43")]
			[FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000EA4")]
			[Address(RVA = "0x133916C", Offset = "0x133916C", VA = "0x133916C")]
			public Action()
			{
			}
		}

		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x1F8")]
		public Action[] actions;

		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0x200")]
		public int currentActionIndex;

		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x204")]
		public float lastActionTime;

		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x208")]
		private float lastActionMoveMag;

		[Token(Token = "0x170001C9")]
		public Action currentAction
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x135BBFC", Offset = "0x135BBFC", VA = "0x135BBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x135D2E8", Offset = "0x135D2E8", VA = "0x135D2E8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x135D36C", Offset = "0x135D36C", VA = "0x135D36C", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x135D5F0", Offset = "0x135D5F0", VA = "0x135D5F0")]
		private bool StartAction(Action action)
		{
			return default;
		}

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x135D824", Offset = "0x135D824", VA = "0x135D824")]
		public CharacterMeleeDemo()
		{
		}
	}
}
