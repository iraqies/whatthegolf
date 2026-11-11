using System.Collections;
using System.Collections.Generic;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class WrestlerController : UserControlThirdPerson
{
	public GolfBallController Controller;

	public float JumpTime = 1f;

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
		base.Start();
		controllerRigidbody = GetComponent<Rigidbody>();
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimUpdate += OnAimUpdate;
		}
		defaultPinInfo = new Dictionary<Muscle, Muscle.Props>();
		if (arms == null || puppetMaster == null || puppetMaster.muscles == null)
		{
			return;
		}
		for (int i = 0; i < arms.Length; i++)
		{
			if (arms[i] != null && arms[i].TryGetComponent<MuscleCollisionBroadcaster>(out var component) && component != null && component.muscleIndex >= 0 && component.muscleIndex < puppetMaster.muscles.Length)
			{
				Muscle muscle = puppetMaster.muscles[component.muscleIndex];
				if (muscle != null)
				{
					defaultPinInfo.Add(muscle, muscle.props);
				}
			}
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (Puppet != null && (!Puppet.onGround || (Puppet.propeller != null && Puppet.propeller.state != BehaviourPuppet.State.Puppet)))
		{
			return;
		}
		SetWeights(false);
		jumpTimer = JumpTime;
		StartCoroutine(RegainPinDelayed(0f));
	}

	private void SetWeights(bool setToDefault)
	{
		if (defaultPinInfo == null)
		{
			return;
		}
		foreach (KeyValuePair<Muscle, Muscle.Props> item in defaultPinInfo)
		{
			if (item.Key != null)
			{
				item.Key.props = (setToDefault ? item.Value : inJumpArmProperties);
			}
		}
	}

	private IEnumerator RegainPinDelayed(float delay)
	{
		yield return new WaitForSeconds(0.1f);
		while (Puppet != null && Puppet.isJumping && !Puppet.onGround)
		{
			yield return null;
		}
		if (Puppet != null && Puppet.propeller != null)
		{
			Puppet.propeller.SetState(BehaviourPuppet.State.Unpinned);
		}
		SetWeights(true);
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Puppet != null && Puppet.propeller != null && Puppet.propeller.state == BehaviourPuppet.State.Puppet)
		{
			aimDir = boost;
		}
	}

	protected override void Update()
	{
		if (Puppet == null || Puppet.propeller == null)
		{
			return;
		}
		if (Puppet.propeller.state != BehaviourPuppet.State.Puppet)
		{
			state.jump = false;
			jumpTimer = 0f;
			return;
		}
		jumpTimer -= Time.deltaTime;
		Vector3 zero = Vector3.zero;
		if ((Controller != null && Controller.IsAiming) || jumpTimer > 0f || !Puppet.onGround)
		{
			zero.x = aimDir.x;
			zero.z = aimDir.z;
		}
		state.jump = jumpTimer > 0f;
		Vector3 tangent = new Vector3(zero.x, 0f, zero.z).normalized;
		if (tangent != Vector3.zero)
		{
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			state.move = tangent;
		}
		else
		{
			state.move = Vector3.zero;
		}
		if (cam != null)
		{
			state.lookPos = base.transform.position + cam.forward * 100f;
		}
	}
}
