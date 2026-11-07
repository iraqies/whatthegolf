using System.Collections.Generic;
using Audio;
using UnityEngine;

public class AutoSnowballThrower : MonoBehaviour
{
	public enum ThrowStateEnum
	{
		Idle = 0,
		Swinging = 1,
		Cooldown = 2
	}

	[SerializeField]
	private BowlingShooter shooter;

	[SerializeField]
	private List<Transform> targets;

	[SerializeField]
	private Transform specialTarget;

	[SerializeField]
	private float ThrowDistance;

	[SerializeField]
	private Vector2 cooldownRange;

	[SerializeField]
	private Vector2 swingTimeRange;

	[SerializeField]
	private float lookAhead;

	[SerializeField]
	private ClipSettingsCollection sfxOnRelease;

	private ThrowStateEnum throwState;

	private bool specialTargetIsNext;

	private float swingTimer;

	private Transform target;

	private Vector3 currentTarget;

	private Rigidbody targetRigid;

	private void Start()
	{
	}

	public void NowTargetSpecialTarget()
	{
	}

	private void GetNextTarget()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
