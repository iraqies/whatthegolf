using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000173")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x360D0", Offset = "0x360D0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x138AE14", Offset = "0x138AE14", VA = "0x138AE14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x138B1E0", Offset = "0x138B1E0", VA = "0x138B1E0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x138B338", Offset = "0x138B338", VA = "0x138B338", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x138B4F8", Offset = "0x138B4F8", VA = "0x138B4F8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x138B554", Offset = "0x138B554", VA = "0x138B554", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x138B5C8", Offset = "0x138B5C8", VA = "0x138B5C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x138B918", Offset = "0x138B918", VA = "0x138B918", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x138B944", Offset = "0x138B944", VA = "0x138B944")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x138B62C", Offset = "0x138B62C", VA = "0x138B62C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x138B9B0", Offset = "0x138B9B0", VA = "0x138B9B0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x138BB2C", Offset = "0x138BB2C", VA = "0x138BB2C")]
		public IKSolverArm()
		{
		}
	}
}
