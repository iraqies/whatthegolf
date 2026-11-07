using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000166")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000167")]
		public class BoneMap
		{
			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000144")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x133E0C0", Offset = "0x133E0C0", VA = "0x133E0C0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000145")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x133E19C", Offset = "0x133E19C", VA = "0x133E19C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000146")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000A1D")]
				[Address(RVA = "0x133E540", Offset = "0x133E540", VA = "0x133E540")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x133E094", Offset = "0x133E094", VA = "0x133E094")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x133E0FC", Offset = "0x133E0FC", VA = "0x133E0FC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x133E14C", Offset = "0x133E14C", VA = "0x133E14C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x133E1AC", Offset = "0x133E1AC", VA = "0x133E1AC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x133E234", Offset = "0x133E234", VA = "0x133E234")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x133E23C", Offset = "0x133E23C", VA = "0x133E23C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x133E314", Offset = "0x133E314", VA = "0x133E314")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x133E38C", Offset = "0x133E38C", VA = "0x133E38C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x133E424", Offset = "0x133E424", VA = "0x133E424")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x133E68C", Offset = "0x133E68C", VA = "0x133E68C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x133E6C4", Offset = "0x133E6C4", VA = "0x133E6C4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x133E6FC", Offset = "0x133E6FC", VA = "0x133E6FC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x133E724", Offset = "0x133E724", VA = "0x133E724")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x133E818", Offset = "0x133E818", VA = "0x133E818")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default;
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x133E9A4", Offset = "0x133E9A4", VA = "0x133E9A4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x133EA58", Offset = "0x133EA58", VA = "0x133EA58")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x133EAC8", Offset = "0x133EAC8", VA = "0x133EAC8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x133EC04", Offset = "0x133EC04", VA = "0x133EC04")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x133ED40", Offset = "0x133ED40", VA = "0x133ED40")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x133EDC0", Offset = "0x133EDC0", VA = "0x133EDC0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x133E894", Offset = "0x133E894", VA = "0x133E894")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default;
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x133EEF8", Offset = "0x133EEF8", VA = "0x133EEF8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x138787C", Offset = "0x138787C", VA = "0x138787C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1387884", Offset = "0x1387884", VA = "0x1387884", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1387888", Offset = "0x1387888", VA = "0x1387888")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x13879C8", Offset = "0x13879C8", VA = "0x13879C8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1387A3C", Offset = "0x1387A3C", VA = "0x1387A3C")]
		public IKMapping()
		{
		}
	}
}
