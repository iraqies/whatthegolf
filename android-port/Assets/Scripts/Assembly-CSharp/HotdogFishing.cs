using System.Collections;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class HotdogFishing : UserControlThirdPerson
{
	public GolfBallController Controller;

	public SpringJoint Spring;

	public float SpringReturnSpeed;

	public Rigidbody Bait;

	public float BaitFollowMinDistance;

	public float MaxBaitDistance;

	public float BaitThrowMagnitude;

	private Vector3 aimDir;

	private float targetSpring;

	private float baseSpring;

	private Vector3 lastBaitVel;

	protected override void Start()
	{
	}

	private void OnAimStart()
	{
	}

	public void OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ThrowBait(Vector3 dir)
	{
		return null;
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
