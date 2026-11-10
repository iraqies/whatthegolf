using Core;
using UnityEngine;

public class LaserSight : MonoBehaviour
{
	public LayerMask HitLayers;

	public float Distance = 100f;

	public float RaycastRadius = 0.5f;

	private LineRenderer line;

	private GolfBallController owner;

	private void Awake()
	{
		line = GetComponent<LineRenderer>();
	}

	public void SetOwner(GolfBallController controller)
	{
		if (owner != null)
		{
			owner.OnAimUpdate -= BallOnOnAimUpdate;
		}
		owner = controller;
		if (controller != null)
		{
			owner.OnAimUpdate += BallOnOnAimUpdate;
		}
		else
		{
			base.enabled = false;
		}
	}

	private void BallOnOnAimUpdate(Vector3 boost, bool b)
	{
		if (line == null)
		{
			if (owner != null)
			{
				owner.OnAimUpdate -= BallOnOnAimUpdate;
			}
			return;
		}
		line.positionCount = 2;
		line.SetPosition(0, base.transform.position);
		Ray ray = new Ray(base.transform.position, boost);
		if (Physics.SphereCast(ray, RaycastRadius, out var hitInfo, Distance, HitLayers))
		{
			line.SetPosition(1, hitInfo.point);
		}
		else
		{
			line.SetPosition(1, base.transform.position + boost.normalized * Distance);
		}
	}

	private void OnDisable()
	{
		if (line != null)
		{
			line.positionCount = 0;
			line.enabled = false;
		}
	}

	private void OnEnable()
	{
		if (line != null)
		{
			line.enabled = true;
		}
	}
}
