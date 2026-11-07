using System.Collections;
using CameraStack;
using Core;
using UnityEngine;

public class MarioPipeTrigger : ChallengeTriggerBase
{
	public Vector3 downDirection;

	public Transform midPointTop;

	public Collider midCollider;

	public Collider[] ignoreWith;

	public CameraBehavior overrideCameraBehaviour;

	private GolfBallShooterBase shooter;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void OnShoot(Vector3 obj)
	{
	}

	private IEnumerator PipeRoutine()
	{
		return null;
	}
}
