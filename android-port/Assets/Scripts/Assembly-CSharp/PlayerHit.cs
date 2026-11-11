using System.Collections;
using Core;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
	public FinalLevel FinalLevel;

	public SuperGolfShooter Shooter;

	public ParticleSystem Particles;

	public Rigidbody Rigidbody;

	public float InvisibilityDuration = 0.2f;

	private float baseDrag;

	private float invisibilityTimer;

	private bool ignoreFirstReset = true;

	private void Awake()
	{
		if (Shooter != null)
		{
			Shooter.OnDeath += OnDeath;
		}
		if (Rigidbody != null)
		{
			baseDrag = Rigidbody.drag;
		}
	}

	private void Start()
	{
		if (Shooter != null && Shooter.GolfBallController != null)
		{
			Shooter.GolfBallController.OnReset += OnOnReset;
		}
	}

	private void OnOnReset()
	{
		if (ignoreFirstReset)
		{
			ignoreFirstReset = false;
		}
	}

	private void Update()
	{
		if (invisibilityTimer > 0f)
		{
			invisibilityTimer -= Time.deltaTime;
		}
	}

	public void OnDeath(SuperGolfShooter obj)
	{
		if (obj != null)
		{
			OnDeath(obj.GolfBallController);
		}
	}

	public void OnDeath(GolfBallController obj)
	{
		if (invisibilityTimer <= 0f)
		{
			invisibilityTimer = InvisibilityDuration;
			if (FinalLevel != null && !FinalLevel.PlayerHit(obj))
			{
				StartCoroutine(FreezeFrame());
			}
		}
	}

	private IEnumerator FreezeFrame()
	{
		TimeControl tc = Object.FindObjectOfType<TimeControl>();
		if (tc != null)
		{
			tc.TogglePause(true);
		}
		yield return new WaitForSecondsRealtime(0.075f);
		if (tc != null)
		{
			tc.TogglePause(false);
		}
	}
}
