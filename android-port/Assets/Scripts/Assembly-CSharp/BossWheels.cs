using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BossWheels : MonoBehaviour
{
	[Serializable]
	public class WheelParticle
	{
		public BossCarState.CarStateEnum State;

		public ParticleSystem Particles;
	}

	public Rigidbody BossRigid;

	public float TurnMultiplier = 1f;

	public float SpinMultiplier = 1f;

	public float WheelStateChangeSpeed = 20f;

	public bool RightSideWheel;

	public List<WheelParticle> WheelParticles;

	private float spin;

	private float stateChangeValue;

	private BossCarState.CarStateEnum currentState;

	private BossCarState.CarStateEnum nextState;

	private ParticleSystem currentParticles;

	public void SetState(BossCarState.CarStateEnum state)
	{
		if (currentParticles != null)
		{
			currentParticles.Stop();
		}
		if (state == currentState || currentState == BossCarState.CarStateEnum.None)
		{
			currentState = state;
			WheelParticle wheelParticle = WheelParticles.FirstOrDefault((WheelParticle w) => w.State == state);
			if (wheelParticle != null)
			{
				currentParticles = wheelParticle.Particles;
				currentParticles.Play();
			}
			else
			{
				currentParticles = null;
			}
		}
		else
		{
			currentState = BossCarState.CarStateEnum.None;
			nextState = state;
			StartCoroutine(WaitForReset());
		}
	}

	private IEnumerator WaitForReset()
	{
		while (base.transform.rotation != Quaternion.identity)
		{
			yield return null;
		}
		SetState(nextState);
	}

	private void Update()
	{
		switch (currentState)
		{
		case BossCarState.CarStateEnum.Driving:
			spin += BossRigid.velocity.z * SpinMultiplier * Time.deltaTime;
			base.transform.localEulerAngles = new Vector3(spin, BossRigid.velocity.x * TurnMultiplier, 0f);
			break;
		case BossCarState.CarStateEnum.Flying:
		{
			spin += SpinMultiplier * Time.deltaTime * 100f;
			float y = (RightSideWheel ? spin : (0f - spin));
			Vector3 localEulerAngles = base.transform.localEulerAngles;
			float target = (RightSideWheel ? 90f : (-90f));
			float z = Mathf.MoveTowardsAngle(localEulerAngles.z, target, Time.deltaTime * WheelStateChangeSpeed * UnityEngine.Random.Range(0.5f, 1.2f));
			base.transform.localEulerAngles = new Vector3(0f, y, z);
			break;
		}
		case BossCarState.CarStateEnum.None:
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, Quaternion.identity, Time.deltaTime * WheelStateChangeSpeed * 5f);
			break;
		}
	}
}
