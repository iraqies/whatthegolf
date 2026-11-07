using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PendulumExample : MonoBehaviour
	{
		public float weight;

		public float hangingDistanceMlp;

		public Vector3 rootTargetPosition;

		public Quaternion rootTargetRotation;

		public Transform target;

		public Transform leftHandTarget;

		public Transform rightHandTarget;

		public Transform leftFootTarget;

		public Transform rightFootTarget;

		public Transform pelvisTarget;

		public Transform bodyTarget;

		public Transform headTarget;

		public Vector3 pelvisDownAxis;

		private FullBodyBipedIK ik;

		private Quaternion rootRelativeToPelvis;

		private Vector3 pelvisToRoot;

		private float lastWeight;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
