using Audio;
using Core;
using UnityEngine;

public class RollingCowAI : MonoBehaviour
{
	public RollingCowShooter Cow;

	public Transform Player;

	public float FleeDistance;

	public ClipSettingsCollection FleeClips;

	private Vector3 currentFleeGoal;

	private float clipDelayTimer;

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
