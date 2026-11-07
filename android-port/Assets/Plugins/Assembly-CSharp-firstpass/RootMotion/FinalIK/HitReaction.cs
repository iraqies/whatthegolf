using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001BB")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001BC")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000BD1")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000BD2")]
			[FieldOffset(Offset = "0x18")]
			public Collider collider;

			[Token(Token = "0x4000BD3")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000BD4")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x369B0", Offset = "0x369B0")]
			private float crossFader__BackingField;

			[Token(Token = "0x4000BD5")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x369C0", Offset = "0x369C0")]
			private float timer__BackingField;

			[Token(Token = "0x4000BD6")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x369D0", Offset = "0x369D0")]
			private Vector3 force__BackingField;

			[Token(Token = "0x4000BD7")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x369E0", Offset = "0x369E0")]
			private Vector3 point__BackingField;

			[Token(Token = "0x4000BD8")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000BD9")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000BDA")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170001A3")]
			public bool inProgress
			{
				[Token(Token = "0x6000CF5")]
				[Address(RVA = "0x133C7E8", Offset = "0x133C7E8", VA = "0x133C7E8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170001A4")]
			protected float crossFader
			{
				[Token(Token = "0x6000CF6")]
				[Address(RVA = "0x133C7FC", Offset = "0x133C7FC", VA = "0x133C7FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADBC", Offset = "0x3ADBC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0x133C804", Offset = "0x133C804", VA = "0x133C804")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADCC", Offset = "0x3ADCC")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A5")]
			protected float timer
			{
				[Token(Token = "0x6000CF8")]
				[Address(RVA = "0x133C80C", Offset = "0x133C80C", VA = "0x133C80C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADDC", Offset = "0x3ADDC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000CF9")]
				[Address(RVA = "0x133C814", Offset = "0x133C814", VA = "0x133C814")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADEC", Offset = "0x3ADEC")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A6")]
			protected Vector3 force
			{
				[Token(Token = "0x6000CFA")]
				[Address(RVA = "0x133C81C", Offset = "0x133C81C", VA = "0x133C81C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ADFC", Offset = "0x3ADFC")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000CFB")]
				[Address(RVA = "0x133C828", Offset = "0x133C828", VA = "0x133C828")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE0C", Offset = "0x3AE0C")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A7")]
			protected Vector3 point
			{
				[Token(Token = "0x6000CFC")]
				[Address(RVA = "0x133C834", Offset = "0x133C834", VA = "0x133C834")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE1C", Offset = "0x3AE1C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000CFD")]
				[Address(RVA = "0x133C840", Offset = "0x133C840", VA = "0x133C840")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AE2C", Offset = "0x3AE2C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x133C84C", Offset = "0x133C84C", VA = "0x133C84C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x133C98C", Offset = "0x133C98C", VA = "0x133C98C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D00")]
			protected abstract float GetLength();

			[Token(Token = "0x6000D01")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000D02")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x133CA5C", Offset = "0x133CA5C", VA = "0x133CA5C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BD")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001BE")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BDE")]
				[FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BDF")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x4000BE0")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BE1")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D08")]
				[Address(RVA = "0x135A8B4", Offset = "0x135A8B4", VA = "0x135A8B4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D09")]
				[Address(RVA = "0x135A97C", Offset = "0x135A97C", VA = "0x135A97C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D0A")]
				[Address(RVA = "0x135A990", Offset = "0x135A990", VA = "0x135A990")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000BDB")]
			[FieldOffset(Offset = "0x50")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000BDC")]
			[FieldOffset(Offset = "0x58")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000BDD")]
			[FieldOffset(Offset = "0x60")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x133CD9C", Offset = "0x133CD9C", VA = "0x133CD9C", Slot = "4")]
			protected override float GetLength()
			{
				return default;
			}

			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x133CECC", Offset = "0x133CECC", VA = "0x133CECC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x133CF40", Offset = "0x133CF40", VA = "0x133CF40", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x133D0C8", Offset = "0x133D0C8", VA = "0x133D0C8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001C0")]
			public class BoneLink
			{
				[Token(Token = "0x4000BE5")]
				[FieldOffset(Offset = "0x10")]
				public Transform bone;

				[Token(Token = "0x4000BE6")]
				[FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x369F0", Offset = "0x369F0")]
				public float weight;

				[Token(Token = "0x4000BE7")]
				[FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000BE8")]
				[FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000D0F")]
				[Address(RVA = "0x135A74C", Offset = "0x135A74C", VA = "0x135A74C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D10")]
				[Address(RVA = "0x135A864", Offset = "0x135A864", VA = "0x135A864")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D11")]
				[Address(RVA = "0x135A870", Offset = "0x135A870", VA = "0x135A870")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000BE2")]
			[FieldOffset(Offset = "0x50")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000BE3")]
			[FieldOffset(Offset = "0x58")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000BE4")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x133CA70", Offset = "0x133CA70", VA = "0x133CA70", Slot = "4")]
			protected override float GetLength()
			{
				return default;
			}

			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x133CB10", Offset = "0x133CB10", VA = "0x133CB10", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x133CB84", Offset = "0x133CB84", VA = "0x133CB84", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x133CD88", Offset = "0x133CD88", VA = "0x133CD88")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x30")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x38")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170001A2")]
		public bool inProgress
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x1382AB0", Offset = "0x1382AB0", VA = "0x1382AB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x1382B84", Offset = "0x1382B84", VA = "0x1382B84", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x1382C60", Offset = "0x1382C60", VA = "0x1382C60")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x1382EE4", Offset = "0x1382EE4", VA = "0x1382EE4")]
		public HitReaction()
		{
		}
	}
}
