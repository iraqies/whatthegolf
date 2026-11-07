using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000161")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public class ChildConstraint
		{
			[Token(Token = "0x40008B8")]
			[FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40008B9")]
			[FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40008BA")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40008BB")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40008BC")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35F20", Offset = "0x35F20")]
			private float nominalDistance__BackingField;

			[Token(Token = "0x40008BD")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35F30", Offset = "0x35F30")]
			private bool isRigid__BackingField;

			[Token(Token = "0x40008BE")]
			[FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40008BF")]
			[FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40008C0")]
			[FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40008C1")]
			[FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000140")]
			public float nominalDistance
			{
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0x133A0DC", Offset = "0x133A0DC", VA = "0x133A0DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x39FDC", Offset = "0x39FDC")]
				get
				{
					return default;
				}
				[Token(Token = "0x60009E4")]
				[Address(RVA = "0x133A0E4", Offset = "0x133A0E4", VA = "0x133A0E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x39FEC", Offset = "0x39FEC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000141")]
			public bool isRigid
			{
				[Token(Token = "0x60009E5")]
				[Address(RVA = "0x133A0EC", Offset = "0x133A0EC", VA = "0x133A0EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x39FFC", Offset = "0x39FFC")]
				get
				{
					return default;
				}
				[Token(Token = "0x60009E6")]
				[Address(RVA = "0x133A0F4", Offset = "0x133A0F4", VA = "0x133A0F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A00C", Offset = "0x3A00C")]
				private set
				{
				}
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x133A0FC", Offset = "0x133A0FC", VA = "0x133A0FC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x133A148", Offset = "0x133A148", VA = "0x133A148")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x133A1A4", Offset = "0x133A1A4", VA = "0x133A1A4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x133A354", Offset = "0x133A354", VA = "0x133A354")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public enum Smoothing
		{
			[Token(Token = "0x40008C3")]
			None = 0,
			[Token(Token = "0x40008C4")]
			Exponential = 1,
			[Token(Token = "0x40008C5")]
			Cubic = 2
		}

		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35E88", Offset = "0x35E88")]
		public float pin;

		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35EA0", Offset = "0x35EA0")]
		public float pull;

		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35EB8", Offset = "0x35EB8")]
		public float push;

		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35ED0", Offset = "0x35ED0")]
		public float pushParent;

		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35EE8", Offset = "0x35EE8")]
		public float reach;

		[Token(Token = "0x40008A6")]
		[FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40008A7")]
		[FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40008A8")]
		[FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40008B7")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x136CBE8", Offset = "0x136CBE8", VA = "0x136CBE8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x136CCE8", Offset = "0x136CCE8", VA = "0x136CCE8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x136CE0C", Offset = "0x136CE0C", VA = "0x136CE0C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default;
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x136CEE8", Offset = "0x136CEE8", VA = "0x136CEE8")]
		public bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x136D00C", Offset = "0x136D00C", VA = "0x136D00C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x136D65C", Offset = "0x136D65C", VA = "0x136D65C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x136D19C", Offset = "0x136D19C", VA = "0x136D19C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x136DA54", Offset = "0x136DA54", VA = "0x136DA54")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x136DCC0", Offset = "0x136DCC0", VA = "0x136DCC0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default;
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x136DF1C", Offset = "0x136DF1C", VA = "0x136DF1C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x136E2B4", Offset = "0x136E2B4", VA = "0x136E2B4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x136E844", Offset = "0x136E844", VA = "0x136E844")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x136EACC", Offset = "0x136EACC", VA = "0x136EACC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x136E7D0", Offset = "0x136E7D0", VA = "0x136E7D0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x136E154", Offset = "0x136E154", VA = "0x136E154")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default;
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x136E754", Offset = "0x136E754", VA = "0x136E754")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x136EBF8", Offset = "0x136EBF8", VA = "0x136EBF8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x136E61C", Offset = "0x136E61C", VA = "0x136E61C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x136E950", Offset = "0x136E950", VA = "0x136E950")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
}
