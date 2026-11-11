using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class HighJumper : GolfBall2DShooterBase
{
	[Serializable]
	public class Judge
	{
		public Transform SignPivot;

		public List<ConstantForce2D> Hands;
	}

	[Serializable]
	public class JumpStage
	{
		public JumpStateEnum JumpState;

		public Transform CameraFollow;

		public float OrthographicSize;

		public float TimeScale;

		public float BlockTime;

		public float TimeScaleRevert;
	}

	public enum JumpStateEnum
	{
		OnSpringBoard = 0,
		InAir = 1,
		InWater = 2,
		GettingJudged = 3
	}

	public List<JumpStage> JumpStages;

	public List<ConstantForce2D> ForceAppliers;

	public Collider2D Water;

	public ParticleSystem WaterParticles;

	public List<Judge> Judges;

	public BoxCollider2D OnBoardTrigger;

	public bool instantWin;

	public float winWaitTime = 0.3f;

	[SerializeField]
	private float minShootVelocity = 5f;

	[SerializeField]
	private float fullShootVelocity = 25f;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float spin;

	[SerializeField]
	private JumpStateEnum currentJumpState;

	public Action onJump;

	private TimeControl timeControl;

	public Rigidbody2D[] rigidbodies;

	private void Start()
	{
		timeControl = UnityEngine.Object.FindObjectOfType<TimeControl>();
		rigidbodies = GetComponentsInChildren<Rigidbody2D>();
	}

	public override void OnShoot(Vector3 boost)
	{
		switch (currentJumpState)
		{
		case JumpStateEnum.OnSpringBoard:
			base.OnShoot(boost);
			if (Controller != null)
			{
				Vector3 axis = Vector3.Cross(boost, Controller.GetPlane(Controller.PlayPlane).normal);
				boost = Quaternion.AngleAxis(pitch, axis) * boost;
			}
			StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
			onJump?.Invoke();
			break;
		case JumpStateEnum.InAir:
			if (rigidbodies == null)
			{
				break;
			}
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				Rigidbody2D rigidbody2D = rigidbodies[i];
				if (rigidbody2D != null)
				{
					rigidbody2D.velocity = Vector2.zero;
					rigidbody2D.angularVelocity = 0f;
					rigidbody2D.AddTorque(boost.magnitude * UnityEngine.Random.Range(0.8f, 1.2f) * -5f, ForceMode2D.Impulse);
				}
			}
			break;
		}
	}

	private void ChangeJumpState(JumpStateEnum newState)
	{
		currentJumpState = newState;
		if (JumpStages == null)
		{
			return;
		}
		JumpStage jumpStage = JumpStages.FirstOrDefault((JumpStage s) => s != null && s.JumpState == newState);
		if (jumpStage == null)
		{
			return;
		}
		if (jumpStage.BlockTime > 0f && Controller != null)
		{
			Controller.TimedBlockShot(jumpStage.BlockTime);
		}
		if (timeControl != null)
		{
			float oldTimeScale = timeControl.AimTimeScale;
			float newTimeScale = jumpStage.TimeScale;
			StartCoroutine(pTween.To(0.1f, delegate(float t)
			{
				if (timeControl != null)
				{
					timeControl.SetNewAimTimeScale(Mathf.Lerp(oldTimeScale, newTimeScale, t));
				}
			}));
			if (jumpStage.TimeScaleRevert > 0f)
			{
				StartCoroutine(pTween.ToRealTime(jumpStage.TimeScaleRevert, delegate
				{
				}).Then(pTween.To(0.1f, delegate(float t)
				{
					if (timeControl != null)
					{
						timeControl.SetNewAimTimeScale(Mathf.Lerp(newTimeScale, oldTimeScale, t));
					}
				})));
			}
		}
	}

	private void ReverseForces()
	{
		if (ForceAppliers == null)
		{
			return;
		}
		foreach (ConstantForce2D forceApplier in ForceAppliers)
		{
			if (forceApplier != null)
			{
				forceApplier.force = -forceApplier.force;
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (currentJumpState == JumpStateEnum.InAir && other == Water)
		{
			if (WaterParticles != null)
			{
				WaterParticles.transform.position = base.transform.position;
				WaterParticles.Play();
			}
			ChangeJumpState(JumpStateEnum.InWater);
			StartCoroutine(pTween.To(1.5f, delegate
			{
			}).Then(delegate
			{
				ChangeJumpState(JumpStateEnum.GettingJudged);
				if (instantWin && Level.Instance != null && Level.Instance.Goal != null)
				{
					Level.Instance.Goal.Complete();
				}
			}).Then(pTween.To(1f, delegate
			{
			}))
				.Then(delegate
				{
					StartCoroutine(JudgeVerdicts());
				}));
		}
		else if (currentJumpState == JumpStateEnum.InAir && other == OnBoardTrigger)
		{
			currentJumpState = JumpStateEnum.OnSpringBoard;
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (!base.gameObject.activeInHierarchy || !(col == OnBoardTrigger))
		{
			return;
		}
		if (ForceAppliers != null)
		{
			foreach (ConstantForce2D forceApplier in ForceAppliers)
			{
				if (forceApplier != null)
				{
					forceApplier.enabled = false;
				}
			}
		}
		ChangeJumpState(JumpStateEnum.InAir);
	}

	private IEnumerator JudgeVerdicts()
	{
		yield return new WaitForSeconds(winWaitTime);
		if (Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}
}
