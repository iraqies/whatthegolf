using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class BipedReferences
	{
		[Token(Token = "0x20000E6")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400050C")]
			[FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400050D")]
			[FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1338B48", Offset = "0x1338B48", VA = "0x1338B48")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x170000D3")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1309544", Offset = "0x1309544", VA = "0x1309544", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1309990", Offset = "0x1309990", VA = "0x1309990")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x130A008", Offset = "0x130A008", VA = "0x130A008")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1309BF0", Offset = "0x1309BF0", VA = "0x1309BF0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1301B40", Offset = "0x1301B40", VA = "0x1301B40")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x130A860", Offset = "0x130A860", VA = "0x130A860")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x130ADCC", Offset = "0x130ADCC", VA = "0x130ADCC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x130ABC4", Offset = "0x130ABC4", VA = "0x130ABC4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x130AA38", Offset = "0x130AA38", VA = "0x130AA38")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x130A900", Offset = "0x130A900", VA = "0x130A900")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x130ACCC", Offset = "0x130ACCC", VA = "0x130ACCC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x130AEC0", Offset = "0x130AEC0", VA = "0x130AEC0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x130B9E4", Offset = "0x130B9E4", VA = "0x130B9E4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x130B418", Offset = "0x130B418", VA = "0x130B418")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x130BC88", Offset = "0x130BC88", VA = "0x130BC88")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x130B7D8", Offset = "0x130B7D8", VA = "0x130B7D8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x130BC90", Offset = "0x130BC90", VA = "0x130BC90")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x130BC98", Offset = "0x130BC98", VA = "0x130BC98")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x130BE54", Offset = "0x130BE54", VA = "0x130BE54")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default;
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x130C010", Offset = "0x130C010", VA = "0x130C010")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1301FF8", Offset = "0x1301FF8", VA = "0x1301FF8")]
		public BipedReferences()
		{
		}
	}
}
