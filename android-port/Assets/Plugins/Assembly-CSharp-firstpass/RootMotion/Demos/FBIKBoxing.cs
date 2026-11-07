using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FBIKBoxing : MonoBehaviour
	{
		public Transform target;

		public Transform pin;

		public FullBodyBipedIK ik;

		public AimIK aim;

		public float weight;

		public FullBodyBipedEffector effector;

		public AnimationCurve aimWeight;

		private Animator animator;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
