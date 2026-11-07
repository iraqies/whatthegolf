using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001B6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001B7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001B8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BC6")]
				[FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BC7")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x6000CEA")]
				[Address(RVA = "0x135A73C", Offset = "0x135A73C", VA = "0x135A73C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000BBD")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000BBE")]
			[FieldOffset(Offset = "0x18")]
			public Transform relativeTo;

			[Token(Token = "0x4000BBF")]
			[FieldOffset(Offset = "0x20")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000BC0")]
			[FieldOffset(Offset = "0x28")]
			public float verticalWeight;

			[Token(Token = "0x4000BC1")]
			[FieldOffset(Offset = "0x2C")]
			public float horizontalWeight;

			[Token(Token = "0x4000BC2")]
			[FieldOffset(Offset = "0x30")]
			public float speed;

			[Token(Token = "0x4000BC3")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000BC4")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000BC5")]
			[FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x1330870", Offset = "0x1330870", VA = "0x1330870")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x1330BA4", Offset = "0x1330BA4", VA = "0x1330BA4")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x30")]
		public Body[] bodies;

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x12EBA54", Offset = "0x12EBA54", VA = "0x12EBA54", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x12EBB9C", Offset = "0x12EBB9C", VA = "0x12EBB9C")]
		public Amplifier()
		{
		}
	}
}
