using System.Collections.Generic;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class DoubleThrowPuppet : MonoBehaviour
{
	public GolfBallController Controller;

	public GameObject FakeGolferRoot;

	public List<FixedJoint> JointsToDestroy;

	public float ThrowSpeed = 10f;

	public ThrownPuppet ThrownPuppet;

	public Animator CameraAnimator;

	public HammerThrowingCamera Camera;

	private Rigidbody[] rigidbodiesToThrow;

	private PuppetMaster puppet;

	private void Awake()
	{
		rigidbodiesToThrow = FakeGolferRoot.GetComponentsInChildren<Rigidbody>();
		Controller.OnShoot += OnShoot;
		puppet = FakeGolferRoot.GetComponentInChildren<PuppetMaster>();
	}

	private void OnShoot(Vector3 boost)
	{
		foreach (FixedJoint item in JointsToDestroy)
		{
			Object.Destroy(item);
		}
		Rigidbody[] array = rigidbodiesToThrow;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].useGravity = true;
		}
		puppet.pinWeight = 0f;
		CameraAnimator.SetTrigger("HasThrown");
		Controller.enabled = false;
	}

	public void DollHasGottenUp()
	{
		ThrownPuppet.Activate();
		Camera.enabled = true;
	}
}
