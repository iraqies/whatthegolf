using System.Collections.Generic;
using Core;
using UnityEngine;

public class FPGGravityGun : MonoBehaviour
{
	public GolfBallController Controller;

	public List<LineRenderer> Trail;

	public List<ParticleSystem> Particles;

	public Animator Animator;

	public float GravityGunRotateSpeed;

	public float LineWidth;

	public float PulseSpeed;

	public int MaxHeldObjectsSize;

	public float Range;

	public float BeamSize;

	public float SuckForce;

	public LayerMask AffectedLayers;

	public float ShootForce;

	public float CaptureDistance;

	private List<SpringJoint> joints;

	private bool isSucking;

	private float currentSizeSum;

	private void Start()
	{
	}

	private void OnCancel()
	{
	}

	private void OnAimUpdate(Vector3 boost, bool onlyAim)
	{
	}

	private void OnAimStart()
	{
	}

	private void OnShoot(Vector3 obj)
	{
	}

	private void Update()
	{
	}
}
