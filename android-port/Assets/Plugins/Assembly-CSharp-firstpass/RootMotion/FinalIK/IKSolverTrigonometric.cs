using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000182")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000183")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40009D3")]
			[FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40009D4")]
			[FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x133FF14", Offset = "0x133FF14", VA = "0x133FF14")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x1340010", Offset = "0x1340010", VA = "0x1340010")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default;
			}

			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x1340040", Offset = "0x1340040", VA = "0x1340040")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default;
			}

			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x134007C", Offset = "0x134007C", VA = "0x134007C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36260", Offset = "0x36260")]
		public float IKRotationWeight;

		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x1398418", Offset = "0x1398418", VA = "0x1398418")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x1398560", Offset = "0x1398560", VA = "0x1398560")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x13986AC", Offset = "0x13986AC", VA = "0x13986AC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x13986B8", Offset = "0x13986B8", VA = "0x13986B8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x13986E8", Offset = "0x13986E8", VA = "0x13986E8")]
		public Quaternion GetIKRotation()
		{
			return default;
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x13986F4", Offset = "0x13986F4", VA = "0x13986F4")]
		public float GetIKRotationWeight()
		{
			return default;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x13986FC", Offset = "0x13986FC", VA = "0x13986FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x13987FC", Offset = "0x13987FC", VA = "0x13987FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x139892C", Offset = "0x139892C", VA = "0x139892C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x1398978", Offset = "0x1398978", VA = "0x1398978", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x13989DC", Offset = "0x13989DC", VA = "0x13989DC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x1398DC4", Offset = "0x1398DC4", VA = "0x1398DC4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default;
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x1398E1C", Offset = "0x1398E1C", VA = "0x1398E1C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x1398F80", Offset = "0x1398F80", VA = "0x1398F80")]
		private bool IsDirectHierarchy()
		{
			return default;
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x1398EF4", Offset = "0x1398EF4", VA = "0x1398EF4")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x1399090", Offset = "0x1399090", VA = "0x1399090", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1399840", Offset = "0x1399840", VA = "0x1399840", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1399844", Offset = "0x1399844", VA = "0x1399844", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1399848", Offset = "0x1399848", VA = "0x1399848", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x139966C", Offset = "0x139966C", VA = "0x139966C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default;
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x139645C", Offset = "0x139645C", VA = "0x139645C")]
		public IKSolverTrigonometric()
		{
		}
	}
}
