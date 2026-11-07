using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class MechSpiderLeg : MonoBehaviour
	{
		public MechSpider mechSpider;

		public MechSpiderLeg unSync;

		public Vector3 offset;

		public float minDelay;

		public float maxOffset;

		public float stepSpeed;

		public float footHeight;

		public float velocityPrediction;

		public float raycastFocus;

		public AnimationCurve yOffset;

		public Transform foot;

		public Vector3 footUpAxis;

		public float footRotationSpeed;

		public ParticleSystem sand;

		private IK ik;

		private float stepProgress;

		private float lastStepTime;

		private Vector3 defaultPosition;

		private RaycastHit hit;

		private Quaternion lastFootLocalRotation;

		private Vector3 smoothHitNormal;

		private Vector3 lastStepPosition;

		public bool isStepping => false;

		public Vector3 position
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void AfterIK()
		{
		}

		private void Start()
		{
		}

		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			stepFound = default;
			return default;
		}

		private void UpdatePosition(float distance)
		{
		}

		private void Update()
		{
		}

		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}
	}
}
