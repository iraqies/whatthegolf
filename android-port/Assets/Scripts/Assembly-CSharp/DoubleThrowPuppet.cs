using System.Collections.Generic;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class DoubleThrowPuppet : MonoBehaviour
{
	public GolfBallController Controller;

	public GameObject FakeGolferRoot;

	public List<FixedJoint> JointsToDestroy;

	public float ThrowSpeed;

	public ThrownPuppet ThrownPuppet;

	public Animator CameraAnimator;

	public HammerThrowingCamera Camera;

	private Rigidbody[] rigidbodiesToThrow;

	private PuppetMaster puppet;

	private void Awake()
	{
	}

	private void OnShoot(Vector3 boost)
	{
	}

	public void DollHasGottenUp()
	{
	}
}
