using System.Collections;
using System.Collections.Generic;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class WrestlerController : UserControlThirdPerson
{
	public GolfBallController Controller;

	public float JumpTime;

	public CharacterPuppet Puppet;

	public PuppetMaster puppetMaster;

	public Transform[] arms;

	public Muscle.Props inJumpArmProperties;

	private Vector3 aimDir;

	private float jumpTimer;

	private Rigidbody controllerRigidbody;

	private Dictionary<Muscle, Muscle.Props> defaultPinInfo;

	protected override void Start()
	{
	}

	public void OnShoot(Vector3 boost)
	{
	}

	private void SetWeights(bool setToDefault)
	{
	}

	private IEnumerator RegainPinDelayed(float delay)
	{
		return null;
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void Update()
	{
	}
}
