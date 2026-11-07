using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000180")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000181")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40009C9")]
			[FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700016B")]
			public Vector3 forward
			{
				[Token(Token = "0x6000B13")]
				[Address(RVA = "0x133FED8", Offset = "0x133FED8", VA = "0x133FED8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x133FBE8", Offset = "0x133FBE8", VA = "0x133FBE8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x133FC48", Offset = "0x133FC48", VA = "0x133FC48")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x133FCB4", Offset = "0x133FCB4", VA = "0x133FCB4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x133FDB4", Offset = "0x133FDB4", VA = "0x133FDB4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x361B8", Offset = "0x361B8")]
		public float bodyWeight;

		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x361D0", Offset = "0x361D0")]
		public float headWeight;

		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x361E8", Offset = "0x361E8")]
		public float eyesWeight;

		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36200", Offset = "0x36200")]
		public float clampWeight;

		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36218", Offset = "0x36218")]
		public float clampWeightHead;

		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36230", Offset = "0x36230")]
		public float clampWeightEyes;

		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36248", Offset = "0x36248")]
		public int clampSmoothing;

		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x17000165")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x1396B54", Offset = "0x1396B54", VA = "0x1396B54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000166")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x1396D3C", Offset = "0x1396D3C", VA = "0x1396D3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000167")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x1396C40", Offset = "0x1396C40", VA = "0x1396C40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000168")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x1396D60", Offset = "0x1396D60", VA = "0x1396D60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000169")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1396C50", Offset = "0x1396C50", VA = "0x1396C50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700016A")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x1396DE0", Offset = "0x1396DE0", VA = "0x1396DE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x13965C8", Offset = "0x13965C8", VA = "0x13965C8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x13966B8", Offset = "0x13966B8", VA = "0x13966B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x13967F4", Offset = "0x13967F4", VA = "0x13967F4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x139693C", Offset = "0x139693C", VA = "0x139693C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x1396E04", Offset = "0x1396E04", VA = "0x1396E04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x139705C", Offset = "0x139705C", VA = "0x139705C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x1397200", Offset = "0x1397200", VA = "0x1397200")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default;
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x1397434", Offset = "0x1397434", VA = "0x1397434", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x1397708", Offset = "0x1397708", VA = "0x1397708", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x13977E0", Offset = "0x13977E0", VA = "0x13977E0")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x1397978", Offset = "0x1397978", VA = "0x1397978")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x1397C00", Offset = "0x1397C00", VA = "0x1397C00")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x1397FB0", Offset = "0x1397FB0", VA = "0x1397FB0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x13972B4", Offset = "0x13972B4", VA = "0x13972B4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x1398224", Offset = "0x1398224", VA = "0x1398224")]
		public IKSolverLookAt()
		{
		}
	}
}
