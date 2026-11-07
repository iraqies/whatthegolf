using Core;
using UnityEngine;

public class LaserSight : MonoBehaviour
{
	public LayerMask HitLayers;

	public float Distance;

	public float RaycastRadius;

	private LineRenderer line;

	private GolfBallController owner;

	private void Awake()
	{
	}

	public void SetOwner(GolfBallController controller)
	{
	}

	private void BallOnOnAimUpdate(Vector3 boost, bool b)
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
