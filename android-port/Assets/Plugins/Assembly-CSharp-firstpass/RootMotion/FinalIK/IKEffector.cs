using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000165")]
	public class IKEffector
	{
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35F68", Offset = "0x35F68")]
		public float positionWeight;

		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35F80", Offset = "0x35F80")]
		public float rotationWeight;

		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35F98", Offset = "0x35F98")]
		private bool isEndEffector__BackingField;

		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35FA8", Offset = "0x35FA8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40008E4")]
		[FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000143")]
		public bool isEndEffector
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x1386184", Offset = "0x1386184", VA = "0x1386184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A03C", Offset = "0x3A03C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x138618C", Offset = "0x138618C", VA = "0x138618C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A04C", Offset = "0x3A04C")]
			private set
			{
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x138611C", Offset = "0x138611C", VA = "0x138611C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1386194", Offset = "0x1386194", VA = "0x1386194")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x13862B0", Offset = "0x13862B0", VA = "0x13862B0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x13865F0", Offset = "0x13865F0", VA = "0x13865F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1386890", Offset = "0x1386890", VA = "0x1386890")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x138695C", Offset = "0x138695C", VA = "0x138695C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1386A14", Offset = "0x1386A14", VA = "0x1386A14")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1386F3C", Offset = "0x1386F3C", VA = "0x1386F3C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1386F68", Offset = "0x1386F68", VA = "0x1386F68")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x13870C8", Offset = "0x13870C8", VA = "0x13870C8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1387350", Offset = "0x1387350", VA = "0x1387350")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default;
		}
	}
}
