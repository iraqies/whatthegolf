using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000169")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public enum BoneMapType
		{
			[Token(Token = "0x400091D")]
			Parent = 0,
			[Token(Token = "0x400091E")]
			Bone1 = 1,
			[Token(Token = "0x400091F")]
			Bone2 = 2,
			[Token(Token = "0x4000920")]
			Bone3 = 3
		}

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35FD8", Offset = "0x35FD8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35FF0", Offset = "0x35FF0")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1387C78", Offset = "0x1387C78", VA = "0x1387C78", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1387CF8", Offset = "0x1387CF8", VA = "0x1387CF8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1387DE4", Offset = "0x1387DE4", VA = "0x1387DE4")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1387EA8", Offset = "0x1387EA8", VA = "0x1387EA8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1387EB4", Offset = "0x1387EB4", VA = "0x1387EB4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1387F78", Offset = "0x1387F78", VA = "0x1387F78")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x138804C", Offset = "0x138804C", VA = "0x138804C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x13882B8", Offset = "0x13882B8", VA = "0x13882B8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x138832C", Offset = "0x138832C", VA = "0x138832C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
}
