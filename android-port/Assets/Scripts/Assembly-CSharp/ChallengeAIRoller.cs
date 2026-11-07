using Core;
using UnityEngine;

public class ChallengeAIRoller : MonoBehaviour
{
	public Transform chaseTarget;

	private RollingCowShooter _rollingCowShooter;

	private Vector3 _oldTargetDirection;

	public float aimSpeed;

	public float lookDistance;

	[SerializeField]
	private bool DisableKinematicOnEnable;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
