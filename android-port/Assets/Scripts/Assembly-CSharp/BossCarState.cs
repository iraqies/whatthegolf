using System.Collections.Generic;
using UnityEngine;

public class BossCarState : MonoBehaviour
{
	public enum CarStateEnum
	{
		Driving = 0,
		Flying = 1,
		Resetting = 2
	}

	public CarStateEnum CarState;

	public Animator BossMonitorAnimator;

	public ParticleSystem[] WheelParticles;

	public BossStage Stage;

	public List<BossWheels> Wheels;

	private void Awake()
	{
		Stage.OnChallengeBegin += OnChallengeBegin;
		Stage.OnChallengeEnd += OnChallengeEnd;
	}

	private void OnChallengeEnd()
	{
	}

	private void OnChallengeBegin()
	{
		SetState(CarState);
	}

	public void SetState(CarStateEnum state)
	{
		foreach (BossWheels wheel in Wheels)
		{
			wheel.SetState(state);
		}
	}
}
