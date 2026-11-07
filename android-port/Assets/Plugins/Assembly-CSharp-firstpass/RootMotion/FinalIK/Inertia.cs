using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001C7")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C8")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001C9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C11")]
				[FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C12")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x6000D37")]
				[Address(RVA = "0x135AEB8", Offset = "0x135AEB8", VA = "0x135AEB8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000C06")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000C07")]
			[FieldOffset(Offset = "0x18")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000C08")]
			[FieldOffset(Offset = "0x20")]
			public float speed;

			[Token(Token = "0x4000C09")]
			[FieldOffset(Offset = "0x24")]
			public float acceleration;

			[Token(Token = "0x4000C0A")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36A70", Offset = "0x36A70")]
			public float matchVelocity;

			[Token(Token = "0x4000C0B")]
			[FieldOffset(Offset = "0x2C")]
			public float gravity;

			[Token(Token = "0x4000C0C")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000C0D")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000C0E")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000C0F")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000C10")]
			[FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x134AB34", Offset = "0x134AB34", VA = "0x134AB34")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x134ABFC", Offset = "0x134ABFC", VA = "0x134ABFC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x134AECC", Offset = "0x134AECC", VA = "0x134AECC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x30")]
		public Body[] bodies;

		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x38")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x139D4C4", Offset = "0x139D4C4", VA = "0x139D4C4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x139D548", Offset = "0x139D548", VA = "0x139D548", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x139D608", Offset = "0x139D608", VA = "0x139D608")]
		public Inertia()
		{
		}
	}
}
