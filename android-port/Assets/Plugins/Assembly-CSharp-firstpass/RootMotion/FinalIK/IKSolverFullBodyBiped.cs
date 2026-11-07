using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		public Transform rootNode;

		public float spineStiffness;

		public float pullBodyVertical;

		public float pullBodyHorizontal;

		private Vector3 offset;

		public IKEffector bodyEffector => null;

		public IKEffector leftShoulderEffector => null;

		public IKEffector rightShoulderEffector => null;

		public IKEffector leftThighEffector => null;

		public IKEffector rightThighEffector => null;

		public IKEffector leftHandEffector => null;

		public IKEffector rightHandEffector => null;

		public IKEffector leftFootEffector => null;

		public IKEffector rightFootEffector => null;

		public FBIKChain leftArmChain => null;

		public FBIKChain rightArmChain => null;

		public IKMappingLimb leftArmMapping => null;

		public IKMappingLimb rightArmMapping => null;

		public IKMappingLimb leftLegMapping => null;

		public IKMappingLimb rightLegMapping => null;

		public IKMappingBone headMapping => null;

		public Vector3 pullBodyOffset { get; private set; }

		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		public override bool IsValid(ref string message)
		{
			return false;
		}

		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
		}

		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		private static bool Contains(Transform[] array, Transform transform)
		{
			return false;
		}

		protected override void ReadPose()
		{
		}

		private void PullBody()
		{
		}

		private Vector3 GetBodyOffset()
		{
			return default;
		}

		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default;
		}

		protected override void ApplyBendConstraints()
		{
		}

		protected override void WritePose()
		{
		}
	}
}
