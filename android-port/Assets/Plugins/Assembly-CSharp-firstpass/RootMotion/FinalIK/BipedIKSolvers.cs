using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200013D")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000122")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1301774", Offset = "0x1301774", VA = "0x1301774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1301C30", Offset = "0x1301C30", VA = "0x1301C30")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x130206C", Offset = "0x130206C", VA = "0x130206C")]
		public BipedIKSolvers()
		{
		}
	}
}
