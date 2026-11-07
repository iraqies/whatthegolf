using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200016B")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36008", Offset = "0x36008")]
		public int iterations;

		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36020", Offset = "0x36020")]
		public float twistWeight;

		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x138849C", Offset = "0x138849C", VA = "0x138849C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1388820", Offset = "0x1388820", VA = "0x1388820")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1388904", Offset = "0x1388904", VA = "0x1388904")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1388914", Offset = "0x1388914", VA = "0x1388914")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1388980", Offset = "0x1388980", VA = "0x1388980")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x13889FC", Offset = "0x13889FC", VA = "0x13889FC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1388FFC", Offset = "0x1388FFC", VA = "0x1388FFC")]
		private bool UseFABRIK()
		{
			return default;
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1389034", Offset = "0x1389034", VA = "0x1389034")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x13892B0", Offset = "0x13892B0", VA = "0x13892B0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x13895AC", Offset = "0x13895AC", VA = "0x13895AC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x13896F0", Offset = "0x13896F0", VA = "0x13896F0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x13897F8", Offset = "0x13897F8", VA = "0x13897F8")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
}
