using UnityEngine;

namespace Buoyancy
{
	public class RaiseBuoyancyTrigger : MonoBehaviour
	{
		[SerializeField]
		private float minPositionY = -5f;

		[SerializeField]
		private float maxPositionY;

		[SerializeField]
		private float maxAccumulatedMass = 100f;

		[SerializeField]
		private float smoothTime = 1f;

		private float targetSurfacePositionY;

		private float currentRaiseVelocityY;

		private BuoyancyTrigger water;

		private Transform _transform;

		private void Awake()
		{
			water = GetComponent<BuoyancyTrigger>();
			if (water != null)
			{
				water.OnEnterWater += delegate
				{
					SetNewSurfacePosition();
				};
				water.OnExitWater += delegate
				{
					SetNewSurfacePosition();
				};
				_transform = water.transform;
				SetNewSurfacePosition();
			}
		}

		private void FixedUpdate()
		{
			if (water == null || Mathf.Approximately(water.SurfacePositionY, targetSurfacePositionY))
				return;

			water.SurfacePositionY = Mathf.SmoothDamp(water.SurfacePositionY, targetSurfacePositionY, ref currentRaiseVelocityY, smoothTime);
			if (_transform != null)
			{
				Vector3 pos = _transform.position;
				pos.y = water.SurfacePositionY;
				_transform.position = pos;
			}
		}

		private void SetNewSurfacePosition()
		{
			if (water != null && maxAccumulatedMass > 0f)
			{
				targetSurfacePositionY = Mathf.Lerp(minPositionY, maxPositionY, water.AccumulatedMass / maxAccumulatedMass);
			}
		}

		private void OnDrawGizmosSelected()
		{
			Vector3 pos = base.transform.position;
			Vector3 minPos = new Vector3(pos.x, minPositionY, pos.z);
			Vector3 maxPos = new Vector3(pos.x, maxPositionY, pos.z);
			Gizmos.DrawLine(minPos, maxPos);
			Gizmos.DrawCube(minPos, Vector3.one * 0.2f);
			Gizmos.DrawCube(maxPos, Vector3.one * 0.2f);
		}
	}
}
