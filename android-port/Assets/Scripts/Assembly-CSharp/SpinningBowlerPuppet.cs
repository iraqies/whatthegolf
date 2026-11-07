using System;
using Audio;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class SpinningBowlerPuppet : UserControlThirdPerson
{
	public GolfBallController Controller;

	public Transform LookObject;

	public float RotateSpeed;

	public ClipSettingsCollection ShootClip;

	private Vector3 runTarget;

	private Action OnTargedReached;

	protected override void Update()
	{
	}

	public void SetRunTarget(Vector3 target, Action OnTargedReached)
	{
	}
}
