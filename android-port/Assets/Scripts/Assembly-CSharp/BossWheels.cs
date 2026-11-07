using System;
using System.Collections;
using System.Collections.Generic;
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

	public float TurnMultiplier;

	public float SpinMultiplier;

	public float WheelStateChangeSpeed;

	public bool RightSideWheel;

	public List<WheelParticle> WheelParticles;

	private float spin;

	private float stateChangeValue;

	private BossCarState.CarStateEnum currentState;

	private BossCarState.CarStateEnum nextState;

	private ParticleSystem currentParticles;

	public void SetState(BossCarState.CarStateEnum state)
	{
	}

	private IEnumerator WaitForReset()
	{
		return null;
	}

	private void Update()
	{
	}
}
