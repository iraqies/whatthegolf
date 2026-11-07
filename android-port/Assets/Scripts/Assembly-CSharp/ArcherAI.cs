using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherAI : MonoBehaviour
{
	[SerializeField]
	private ArrowShooter arrowShooter;

	[SerializeField]
	private float waitBeforeShooting;

	[SerializeField]
	private float waitAfterShooting;

	[SerializeField]
	private float minShootBoost;

	[SerializeField]
	private float maxShootBoost;

	[SerializeField]
	private float minShootAngle;

	[SerializeField]
	private float maxShootAngle;

	[SerializeField]
	private float aimAnimSmoothTime;

	private float currSpeed;

	[SerializeField]
	private int simulationSteps;

	[SerializeField]
	private float simulationDeltaTime;

	private Collider[] aimingTestResults;

	private string goalTagName;

	[SerializeField]
	private List<float> fallbackShootAngles;

	[SerializeField]
	private List<float> fallbackShootBoosts;

	[SerializeField]
	private float sphereCastRadius;

	private List<int> shotIndeces;

	private float currentAngle;

	private int shotCount;

	private IEnumerator Start()
	{
		return null;
	}

	private bool TestTrajectory(Vector3 boost, Color goodColor, float debugLifetime = 0f)
	{
		return false;
	}

	private bool DrawTrajectoryGizmos(Vector3 boost)
	{
		return false;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
