using Cinemachine;
using UnityEngine;

public class GoopSpeedManager : MonoBehaviour
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

	private void FixedUpdate()
	{
	}
}
