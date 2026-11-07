using UnityEngine;

namespace Audio
{
	public class SFXOnFacingCollision : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rigidbody;

		[SerializeField]
		private float sleepThreshold;

		[SerializeField]
		private Vector3 localFacingDirection;

		[SerializeField]
		private Vector3 checkForWorldDirection;

		[SerializeField]
		private float directionThreshold;

		[SerializeField]
		private float checkTime;

		[SerializeField]
		private ClipSettingsCollection sfx;

		private float _timer;

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
