using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class SimpleAimingSystem : MonoBehaviour
	{
		public AimPoser aimPoser;

		public AimIK aim;

		public LookAtIK lookAt;

		public Animator animator;

		public float crossfadeTime;

		public float minAimDistance;

		private AimPoser.Pose aimPose;

		private AimPoser.Pose lastPose;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void Pose()
		{
		}

		private void LimitAimTarget()
		{
		}

		private void DirectCrossFade(string state, float target)
		{
		}
	}
}
