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
		private float rotationSpeed = 180f;

		[SerializeField]
		private float initialVel = 5f;

		[SerializeField]
		private float drag = 1f;

		[SerializeField]
		private float gravity = 9.8f;

		[SerializeField]
		private Vector3 leftPunchOutDir = Vector3.left;

		[SerializeField]
		private Vector3 rightPunchOutDir = Vector3.right;

		private float duration = 0.5f;

		private float radius = 1f;

		private void Awake()
		{
		}

		public void IndicatorHit(DanceMoveIndicator indicator, Vector2 dir, bool wasCorrect)
		{
			if (indicator != null)
			{
				Object.Destroy(indicator.gameObject);
			}
		}

		public void IndicatorMiss(DanceMoveIndicator indicator)
		{
			if (indicator != null)
			{
				Object.Destroy(indicator.gameObject);
			}
		}
	}
}
