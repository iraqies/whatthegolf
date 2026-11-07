using Cinemachine;
using UnityEngine;

public class DollyCartSpeedManager : MonoBehaviour
{
	[SerializeField]
	private Transform Follower;

	[SerializeField]
	private float FollowThreshold;

	[SerializeField]
	private bool useDistance;

	private float dollySpeed;

	[SerializeField]
	private CinemachineDollyCart dolly;

	private void Start()
	{
	}

	internal void SetNewFollower(Transform newCamFollow)
	{
	}

	public void SetNewSpeed(float s)
	{
	}
}
