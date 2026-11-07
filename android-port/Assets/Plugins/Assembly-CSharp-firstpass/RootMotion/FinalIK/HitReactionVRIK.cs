using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001C1")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20001C2")]
		public abstract class Offset
		{
			[Token(Token = "0x4000BEC")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000BED")]
			[FieldOffset(Offset = "0x18")]
			public Collider collider;

			[Token(Token = "0x4000BEE")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000BEF")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36A18", Offset = "0x36A18")]
			private float crossFader__BackingField;

			[Token(Token = "0x4000BF0")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36A28", Offset = "0x36A28")]
			private float timer__BackingField;

			[Token(Token = "0x4000BF1")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36A38", Offset = "0x36A38")]
			private Vector3 force__BackingField;

			[Token(Token = "0x4000BF2")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36A48", Offset = "0x36A48")]
			private Vector3 point__BackingField;

			[Token(Token = "0x4000BF3")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000BF4")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000BF5")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170001A8")]
			protected float crossFader
			{
				[Token(Token = "0x6000D15")]
				[Address(RVA = "0x133D0DC", Offset = "0x133D0DC", VA = "0x133D0DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE3C", Offset = "0x3AE3C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000D16")]
				[Address(RVA = "0x133D0E4", Offset = "0x133D0E4", VA = "0x133D0E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE4C", Offset = "0x3AE4C")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A9")]
			protected float timer
			{
				[Token(Token = "0x6000D17")]
				[Address(RVA = "0x133D0EC", Offset = "0x133D0EC", VA = "0x133D0EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE5C", Offset = "0x3AE5C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000D18")]
				[Address(RVA = "0x133D0F4", Offset = "0x133D0F4", VA = "0x133D0F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE6C", Offset = "0x3AE6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AA")]
			protected Vector3 force
			{
				[Token(Token = "0x6000D19")]
				[Address(RVA = "0x133D0FC", Offset = "0x133D0FC", VA = "0x133D0FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE7C", Offset = "0x3AE7C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000D1A")]
				[Address(RVA = "0x133D108", Offset = "0x133D108", VA = "0x133D108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE8C", Offset = "0x3AE8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AB")]
			protected Vector3 point
			{
				[Token(Token = "0x6000D1B")]
				[Address(RVA = "0x133D114", Offset = "0x133D114", VA = "0x133D114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE9C", Offset = "0x3AE9C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000D1C")]
				[Address(RVA = "0x133D120", Offset = "0x133D120", VA = "0x133D120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AEAC", Offset = "0x3AEAC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x133D12C", Offset = "0x133D12C", VA = "0x133D12C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x133D280", Offset = "0x133D280", VA = "0x133D280")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D1F")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000D20")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000D21")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x133D364", Offset = "0x133D364", VA = "0x133D364")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C3")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001C4")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000BF9")]
				[FieldOffset(Offset = "0x10")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000BFA")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x4000BFB")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BFC")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D27")]
				[Address(RVA = "0x135A998", Offset = "0x135A998", VA = "0x135A998")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D28")]
				[Address(RVA = "0x135AA3C", Offset = "0x135AA3C", VA = "0x135AA3C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D29")]
				[Address(RVA = "0x135AA50", Offset = "0x135AA50", VA = "0x135AA50")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000BF6")]
			[FieldOffset(Offset = "0x50")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000BF7")]
			[FieldOffset(Offset = "0x54")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000BF8")]
			[FieldOffset(Offset = "0x58")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x133D378", Offset = "0x133D378", VA = "0x133D378", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default;
			}

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x133D514", Offset = "0x133D514", VA = "0x133D514", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x133D588", Offset = "0x133D588", VA = "0x133D588", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x133D748", Offset = "0x133D748", VA = "0x133D748")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C5")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001C6")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000C00")]
				[FieldOffset(Offset = "0x10")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000C01")]
				[FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36A58", Offset = "0x36A58")]
				public float weight;

				[Token(Token = "0x4000C02")]
				[FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000C03")]
				[FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000D2E")]
				[Address(RVA = "0x135AA58", Offset = "0x135AA58", VA = "0x135AA58")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D2F")]
				[Address(RVA = "0x135AB34", Offset = "0x135AB34", VA = "0x135AB34")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D30")]
				[Address(RVA = "0x135AB40", Offset = "0x135AB40", VA = "0x135AB40")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000BFD")]
			[FieldOffset(Offset = "0x50")]
			public int curveIndex;

			[Token(Token = "0x4000BFE")]
			[FieldOffset(Offset = "0x58")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000BFF")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x133D764", Offset = "0x133D764", VA = "0x133D764", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default;
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x133D84C", Offset = "0x133D84C", VA = "0x133D84C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x133D8C0", Offset = "0x133D8C0", VA = "0x133D8C0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x133DB84", Offset = "0x133DB84", VA = "0x133DB84")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x38")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x40")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x1383230", Offset = "0x1383230", VA = "0x1383230", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x1383304", Offset = "0x1383304", VA = "0x1383304")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x1383590", Offset = "0x1383590", VA = "0x1383590")]
		public HitReactionVRIK()
		{
		}
	}
}
