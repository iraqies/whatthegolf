using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000177")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36100", Offset = "0x36100")]
		public int iterations;

		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x138F870", Offset = "0x138F870", VA = "0x138F870")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x138F970", Offset = "0x138F970", VA = "0x138F970")]
		public int GetChainIndex(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x13860C0", Offset = "0x13860C0", VA = "0x13860C0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1385758", Offset = "0x1385758", VA = "0x1385758")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x138FA94", Offset = "0x138FA94", VA = "0x138FA94", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x138FC2C", Offset = "0x138FC2C", VA = "0x138FC2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x138FDA0", Offset = "0x138FDA0", VA = "0x138FDA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x138FFA4", Offset = "0x138FFA4", VA = "0x138FFA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x13900C8", Offset = "0x13900C8", VA = "0x13900C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x13901BC", Offset = "0x13901BC", VA = "0x13901BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1390328", Offset = "0x1390328", VA = "0x1390328", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1390488", Offset = "0x1390488", VA = "0x1390488", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x13906D0", Offset = "0x13906D0", VA = "0x13906D0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x13909D8", Offset = "0x13909D8", VA = "0x13909D8", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1390A1C", Offset = "0x1390A1C", VA = "0x1390A1C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1390B14", Offset = "0x1390B14", VA = "0x1390B14")]
		public IKSolverFullBody()
		{
		}
	}
}
