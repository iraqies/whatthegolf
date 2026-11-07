using Audio;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class SpinningBowlerBall : UserControlThirdPerson
{
	public GolfBallController Controller;

	public Transform LookObject;

	public float RotateSpeed;

	public ClipSettingsCollection ShootClip;

	private Vector3 moveDir;

	private bool hasShot;

	protected override void Start()
	{
	}

	private void ControllerOnOnShoot(Vector3 boost)
	{
	}

	protected override void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
