using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200017A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36118", Offset = "0x36118")]
		public float spineStiffness;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36130", Offset = "0x36130")]
		public float pullBodyVertical;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36148", Offset = "0x36148")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36160", Offset = "0x36160")]
		private Vector3 pullBodyOffset__BackingField;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700014E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x1390C38", Offset = "0x1390C38", VA = "0x1390C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x1390DD0", Offset = "0x1390DD0", VA = "0x1390DD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x1390E08", Offset = "0x1390E08", VA = "0x1390E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1390E40", Offset = "0x1390E40", VA = "0x1390E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1390E78", Offset = "0x1390E78", VA = "0x1390E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x1383A88", Offset = "0x1383A88", VA = "0x1383A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x1383A50", Offset = "0x1383A50", VA = "0x1383A50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1390EB0", Offset = "0x1390EB0", VA = "0x1390EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x1390EE8", Offset = "0x1390EE8", VA = "0x1390EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x1390F20", Offset = "0x1390F20", VA = "0x1390F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x1390F58", Offset = "0x1390F58", VA = "0x1390F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x1390F90", Offset = "0x1390F90", VA = "0x1390F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1390FC4", Offset = "0x1390FC4", VA = "0x1390FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1390FFC", Offset = "0x1390FFC", VA = "0x1390FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x1391034", Offset = "0x1391034", VA = "0x1391034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x139106C", Offset = "0x139106C", VA = "0x139106C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1392A94", Offset = "0x1392A94", VA = "0x1392A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A07C", Offset = "0x3A07C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1392AA0", Offset = "0x1392AA0", VA = "0x1392AA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A08C", Offset = "0x3A08C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x13910A0", Offset = "0x13910A0", VA = "0x13910A0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x139116C", Offset = "0x139116C", VA = "0x139116C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x1390C6C", Offset = "0x1390C6C", VA = "0x1390C6C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1391250", Offset = "0x1391250", VA = "0x1391250")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x139131C", Offset = "0x139131C", VA = "0x139131C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x13913E4", Offset = "0x13913E4", VA = "0x13913E4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x13914B8", Offset = "0x13914B8", VA = "0x13914B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x139166C", Offset = "0x139166C", VA = "0x139166C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x139265C", Offset = "0x139265C", VA = "0x139265C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x139290C", Offset = "0x139290C", VA = "0x139290C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x13929D0", Offset = "0x13929D0", VA = "0x13929D0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x1392AAC", Offset = "0x1392AAC", VA = "0x1392AAC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1392B88", Offset = "0x1392B88", VA = "0x1392B88", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1392C60", Offset = "0x1392C60", VA = "0x1392C60")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1392D98", Offset = "0x1392D98", VA = "0x1392D98")]
		private Vector3 GetBodyOffset()
		{
			return default;
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1392F24", Offset = "0x1392F24", VA = "0x1392F24")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default;
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1393058", Offset = "0x1393058", VA = "0x1393058", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x13932B0", Offset = "0x13932B0", VA = "0x13932B0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1393334", Offset = "0x1393334", VA = "0x1393334")]
		public IKSolverFullBodyBiped()
		{
		}
	}
}
