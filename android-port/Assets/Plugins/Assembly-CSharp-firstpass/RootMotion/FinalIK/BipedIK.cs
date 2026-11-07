using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200013C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x130123C", Offset = "0x130123C", VA = "0x130123C")]
		[Attribute(Name = "ContextMenu", RVA = "0x38ED4", Offset = "0x38ED4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1301284", Offset = "0x1301284", VA = "0x1301284")]
		[Attribute(Name = "ContextMenu", RVA = "0x38F0C", Offset = "0x38F0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x13012CC", Offset = "0x13012CC", VA = "0x13012CC")]
		[Attribute(Name = "ContextMenu", RVA = "0x38F44", Offset = "0x38F44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x1301314", Offset = "0x1301314", VA = "0x1301314")]
		[Attribute(Name = "ContextMenu", RVA = "0x38F7C", Offset = "0x38F7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x130135C", Offset = "0x130135C", VA = "0x130135C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x130140C", Offset = "0x130140C", VA = "0x130140C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default;
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x130142C", Offset = "0x130142C", VA = "0x130142C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x130145C", Offset = "0x130145C", VA = "0x130145C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x130148C", Offset = "0x130148C", VA = "0x130148C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x13014CC", Offset = "0x13014CC", VA = "0x13014CC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1301510", Offset = "0x1301510", VA = "0x1301510")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1301534", Offset = "0x1301534", VA = "0x1301534")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default;
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1301558", Offset = "0x1301558", VA = "0x1301558")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1301580", Offset = "0x1301580", VA = "0x1301580")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x13015AC", Offset = "0x13015AC", VA = "0x13015AC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x13015D8", Offset = "0x13015D8", VA = "0x13015D8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x130137C", Offset = "0x130137C", VA = "0x130137C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1301600", Offset = "0x1301600", VA = "0x1301600")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x130160C", Offset = "0x130160C", VA = "0x130160C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1301618", Offset = "0x1301618", VA = "0x1301618")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x13018B8", Offset = "0x13018B8", VA = "0x13018B8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1301960", Offset = "0x1301960", VA = "0x1301960", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1301D50", Offset = "0x1301D50", VA = "0x1301D50", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1301EDC", Offset = "0x1301EDC", VA = "0x1301EDC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1301F10", Offset = "0x1301F10", VA = "0x1301F10")]
		public BipedIK()
		{
		}
	}
}
