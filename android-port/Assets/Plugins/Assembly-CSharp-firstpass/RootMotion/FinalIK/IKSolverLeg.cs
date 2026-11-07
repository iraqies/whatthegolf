using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200017C")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36170", Offset = "0x36170")]
		public float IKRotationWeight;

		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x13945D8", Offset = "0x13945D8", VA = "0x13945D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x13949A8", Offset = "0x13949A8", VA = "0x13949A8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1394B00", Offset = "0x1394B00", VA = "0x1394B00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1394CC0", Offset = "0x1394CC0", VA = "0x1394CC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1394D1C", Offset = "0x1394D1C", VA = "0x1394D1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1394D90", Offset = "0x1394D90", VA = "0x1394D90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x13950E0", Offset = "0x13950E0", VA = "0x13950E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x139510C", Offset = "0x139510C", VA = "0x139510C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1394DF4", Offset = "0x1394DF4", VA = "0x1394DF4")]
		private void Read()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x139519C", Offset = "0x139519C", VA = "0x139519C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1395318", Offset = "0x1395318", VA = "0x1395318")]
		public IKSolverLeg()
		{
		}
	}
}
