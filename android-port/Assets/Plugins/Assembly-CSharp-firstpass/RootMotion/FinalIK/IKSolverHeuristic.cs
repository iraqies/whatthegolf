using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200017B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700015F")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1393A84", Offset = "0x1393A84", VA = "0x1393A84", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000160")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1393A8C", Offset = "0x1393A8C", VA = "0x1393A8C", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000161")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x1393A94", Offset = "0x1393A94", VA = "0x1393A94", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000162")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x1393F30", Offset = "0x1393F30", VA = "0x1393F30", Slot = "15")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000163")]
		protected float positionOffset
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x1393FF8", Offset = "0x1393FF8", VA = "0x1393FF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1393340", Offset = "0x1393340", VA = "0x1393340")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default;
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x13934DC", Offset = "0x13934DC", VA = "0x13934DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1393548", Offset = "0x1393548", VA = "0x1393548", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x13935CC", Offset = "0x13935CC", VA = "0x13935CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x139397C", Offset = "0x139397C", VA = "0x139397C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x1393984", Offset = "0x1393984", VA = "0x1393984", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1393A9C", Offset = "0x1393A9C", VA = "0x1393A9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1393AA0", Offset = "0x1393AA0", VA = "0x1393AA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x1393AA4", Offset = "0x1393AA4", VA = "0x1393AA4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x139404C", Offset = "0x139404C", VA = "0x139404C")]
		protected Vector3 GetSingularityOffset()
		{
			return default;
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1394368", Offset = "0x1394368", VA = "0x1394368")]
		private bool SingularityDetected()
		{
			return default;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x1394564", Offset = "0x1394564", VA = "0x1394564")]
		public IKSolverHeuristic()
		{
		}
	}
}
