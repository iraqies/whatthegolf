using Audio;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class SpinningBowlerBall : UserControlThirdPerson
{
	public GolfBallController Controller;

	public Transform LookObject;

	public float RotateSpeed = 10f;

	public ClipSettingsCollection ShootClip;

	private Vector3 moveDir;

	private bool hasShot;

	protected override void Start()
	{
		base.Start();
		if (Controller != null)
		{
			Controller.OnShoot += ControllerOnOnShoot;
		}
	}

	private void ControllerOnOnShoot(Vector3 boost)
	{
		moveDir = boost.normalized;
		hasShot = true;
	}

	protected override void Update()
	{
		state.move = moveDir;
		if (Controller != null && (Controller.IsCharging || !hasShot) && LookObject != null)
		{
			state.lookPos = LookObject.position;
			LookObject.RotateAround(transform.position, Vector3.up, RotateSpeed * Time.deltaTime);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (hasShot && other != null && other.transform != null && other.transform.CompareTag("Obstacle"))
		{
			ContactPoint[] contacts = other.contacts;
			if (contacts != null && contacts.Length > 0)
			{
				moveDir = Vector3.Reflect(moveDir, contacts[0].normal);
			}
		}
	}
}
