using UnityEngine;

namespace Buoyancy
{
	public class RaiseBuoyancyTrigger : MonoBehaviour
	{
		[SerializeField]
		private float minPositionY;

		[SerializeField]
		private float maxPositionY;

		[SerializeField]
		private float maxAccumulatedMass;

		[SerializeField]
		private float smoothTime;

		private float targetSurfacePositionY;

		private float currentRaiseVelocityY;

		private BuoyancyTrigger water;

		private Transform _transform;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void SetNewSurfacePosition()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
