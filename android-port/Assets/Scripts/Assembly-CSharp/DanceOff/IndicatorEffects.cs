using UnityEngine;

namespace DanceOff
{
	public class IndicatorEffects : MonoBehaviour
	{
		[SerializeField]
		private Transform cameraTransform;

		[SerializeField]
		private AnimationCurve punchOutCurve;

		[SerializeField]
		private AnimationCurve rotationCurve;

		[SerializeField]
		private float rotationSpeed;

		[SerializeField]
		private float initialVel;

		[SerializeField]
		private float drag;

		[SerializeField]
		private float gravity;

		[SerializeField]
		private Vector3 leftPunchOutDir;

		[SerializeField]
		private Vector3 rightPunchOutDir;

		private float duration;

		private float radius;

		private void Awake()
		{
		}

		public void IndicatorHit(DanceMoveIndicator indicator, Vector2 dir, bool wasCorrect)
		{
		}

		public void IndicatorMiss(DanceMoveIndicator indicator)
		{
		}
	}
}
