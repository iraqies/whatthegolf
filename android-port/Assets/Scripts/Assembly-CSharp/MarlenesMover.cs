using UnityEngine;

public class MarlenesMover : MonoBehaviour
{
	public Transform mover;

	public Transform pointA;

	public Transform pointB;

	public Transform startTransform;

	private Vector3 currPos;

	private Vector3 currTarget;

	private Vector3 currVelocity;

	public float smoothTime;

	public float maxSpeed;

	private void Awake()
	{
		if (startTransform != null)
		{
			currPos = startTransform.position;
			currTarget = currPos;
		}
	}

	public void GoToPointA()
	{
		if (pointA != null)
		{
			currTarget = pointA.position;
		}
	}

	public void GoToPointB()
	{
		if (pointB != null)
		{
			currTarget = pointB.position;
		}
	}

	private void FixedUpdate()
	{
		if (mover == null)
		{
			return;
		}
		currPos = Vector3.SmoothDamp(currPos, currTarget, ref currVelocity, smoothTime, maxSpeed, Time.deltaTime);
		mover.position = currPos;
	}
}
