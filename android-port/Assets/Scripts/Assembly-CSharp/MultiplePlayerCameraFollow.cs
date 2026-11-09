using System.Collections.Generic;
using System.Linq;
using CameraStack;
using Core;
using UnityEngine;

public class MultiplePlayerCameraFollow : MonoBehaviour
{
	public List<Transform> objectsToFollow;

	public float HeightMod = 1f;

	public float HeightChangeSpeed = 1f;

	public float PositionChangeSpeed = 10f;

	public Vector2 ElevationRanges = new Vector2(10f, 100f);

	public Vector2 HeightBounds = new Vector2(-10f, 10f);

	public bool LockYAxis;

	public Transform GoalTransform;

	public float MaxFollowNumber = 2f;

	private CBFollow followCam;

	private List<Transform> toBeRemoved = new List<Transform>();

	private void Start()
	{
		if (CameraManager.Instance != null)
			followCam = CameraManager.Instance.ActiveBehavior as CBFollow;
		toBeRemoved = new List<Transform>();
	}

	private void Update()
	{
		if (objectsToFollow == null || objectsToFollow.Count == 0)
			return;
		if (GoalTransform != null)
		{
			objectsToFollow = objectsToFollow
				.Where(o => o != null)
				.OrderBy(o => Vector3.Distance(o.position, GoalTransform.position))
				.ToList();
		}

		Vector3 avgPos = Vector3.zero;
		int count = 0;
		for (int i = 0; i < objectsToFollow.Count; i++)
		{
			Transform o = objectsToFollow[i];
			if (o == null) continue;
			if (objectsToFollow.Count >= 2 && MaxFollowNumber > 0f && count >= (float)objectsToFollow.Count / MaxFollowNumber)
				break;
			if (o.position.y < HeightBounds.x || o.position.y > HeightBounds.y)
			{
				toBeRemoved.Add(o);
			}
			else
			{
				avgPos += o.position;
				count++;
			}
			if (!o.gameObject.activeSelf)
			{
				toBeRemoved.Add(o);
			}
			else if (CameraManager.Instance != null && CameraManager.Instance.MainCamera != null)
			{
				Vector3 vp = CameraManager.Instance.MainCamera.WorldToViewportPoint(o.position);
				if (vp.x < -0.2f || vp.x > 1.2f || vp.y < -0.2f || vp.y > 1.2f)
					toBeRemoved.Add(o);
			}
		}

		if (count >= 1)
		{
			float y = LockYAxis ? transform.position.y : (avgPos.y / count);
			Vector3 targetPos = new Vector3(avgPos.x / count, y, avgPos.z / count);
			transform.position = Vector3.MoveTowards(transform.position, targetPos, PositionChangeSpeed * Time.deltaTime);
		}

		if (followCam != null)
		{
			float curElev = followCam.GetElevation();
			float targetElev = Mathf.Clamp(avgPos.magnitude * HeightMod, ElevationRanges.x, ElevationRanges.y);
			followCam.SetElevation(Mathf.MoveTowards(curElev, targetElev, HeightChangeSpeed * Time.deltaTime));
		}

		if (toBeRemoved != null && toBeRemoved.Count > 0)
		{
			for (int i = 0; i < toBeRemoved.Count; i++)
			{
				var t = toBeRemoved[i];
				if (t != null)
				{
					var ctrl = t.GetComponent<GolfBallController>();
					if (ctrl != null)
					{
						ctrl.StopAiming();
						ctrl.enabled = false;
					}
					objectsToFollow.Remove(t);
				}
			}
			toBeRemoved.Clear();
		}
	}
}
