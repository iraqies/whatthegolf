using Audio;
using Core;
using GolfCourse;
using UnityEngine;

public class BottleFlipWinCondition : MonoBehaviour
{
	public GolfBallController Bottle;

	public GolfCoursePinGoal GolfGoal;

	public AudioClip winClip;

	public float SleepThreshold = 1f;

	public float DotThreshold = 0.01f;

	public float CheckTimer = 0.5f;

	public bool disableControllerOnWin;

	public Vector3 AxisToCheck = Vector3.right;

	public bool ResetPositionOnFaultyShot = true;

	public bool BlockShooting = true;

	private bool hasBeenShot;

	private Rigidbody bottleRigid;

	public BottleFlipWinCondition otherDie;

	private bool winPosition;

	private float timer;

	private void Start()
	{
		bottleRigid = Bottle.GetComponent<Rigidbody>();
		Bottle.OnShoot += Bottle_OnShoot;
		Bottle.OnReset += BottleOnOnReset;
		timer = CheckTimer;
	}

	private void BottleOnOnReset()
	{
		hasBeenShot = false;
		if (BlockShooting)
		{
			Bottle.BlockShooting = false;
		}
	}

	private void Bottle_OnShoot(Vector3 obj)
	{
		hasBeenShot = true;
		winPosition = false;
		if (BlockShooting)
		{
			Bottle.BlockShooting = true;
		}
	}

	private void FixedUpdate()
	{
		if (bottleRigid.velocity.magnitude > SleepThreshold)
		{
			timer = CheckTimer;
			return;
		}
		timer -= Time.deltaTime;
		if (timer > 0f)
		{
			return;
		}
		float num = Vector3.Dot(Bottle.transform.up, AxisToCheck);
		if (Mathf.Abs(num - 1f) < DotThreshold)
		{
			winPosition = true;
			if (otherDie == null || (otherDie != null && otherDie.winPosition))
			{
				AudioManager.Instance.shortEffects.Play(winClip);
				if (GolfGoal != null)
				{
					GolfGoal.CheckObject(base.transform, false);
				}
				else
				{
					Level.Instance.Complete();
				}
				base.enabled = false;
			}
			if (disableControllerOnWin)
			{
				Bottle.enabled = false;
			}
		}
		else if (ResetPositionOnFaultyShot)
		{
			Bottle.Reset(0f);
		}
		else
		{
			Bottle.enabled = true;
		}
		timer = CheckTimer;
	}
}
