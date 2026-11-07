using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000176")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x360E8", Offset = "0x360E8")]
		public float rootPin;

		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x138E7B0", Offset = "0x138E7B0", VA = "0x138E7B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x138EE34", Offset = "0x138EE34", VA = "0x138EE34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x138EECC", Offset = "0x138EECC", VA = "0x138EECC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x138EF70", Offset = "0x138EF70", VA = "0x138EF70", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x138F068", Offset = "0x138F068", VA = "0x138F068")]
		private bool IsRoot(int index)
		{
			return default;
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x138F118", Offset = "0x138F118", VA = "0x138F118", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x138F568", Offset = "0x138F568", VA = "0x138F568", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x138F75C", Offset = "0x138F75C", VA = "0x138F75C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x138F620", Offset = "0x138F620", VA = "0x138F620")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x138F318", Offset = "0x138F318", VA = "0x138F318")]
		private Vector3 GetCentroid()
		{
			return default;
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x138F7F4", Offset = "0x138F7F4", VA = "0x138F7F4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
}
