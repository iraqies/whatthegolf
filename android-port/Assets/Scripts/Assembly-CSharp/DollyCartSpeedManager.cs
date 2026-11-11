using Cinemachine;
using UnityEngine;

public class DollyCartSpeedManager : MonoBehaviour
{
	[SerializeField]
	private Transform Follower;

	[SerializeField]
	private float FollowThreshold = 25f;

	[SerializeField]
	private bool useDistance = true;

	private float dollySpeed;

	[SerializeField]
	private CinemachineDollyCart dolly;

	private void Start()
	{
		dollySpeed = dolly.m_Speed;
	}

	internal void SetNewFollower(Transform newCamFollow)
	{
		Follower = newCamFollow;
	}

	public void SetNewSpeed(float s)
	{
		dolly.m_Speed = s;
		dollySpeed = s;
	}
}
