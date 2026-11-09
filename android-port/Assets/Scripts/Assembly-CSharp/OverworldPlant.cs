using System;
using Audio;
using UnityEngine;

public class OverworldPlant : GolfBehaviour, IAudioEvent
{
	private float nextHitSound;

	[SerializeField]
	private Collider2D col;

	private Transform baseTransform;

	private Quaternion baseRotation;

	public int particleAmount = 1;

	[SerializeField]
	private PlantParticles plantParticles;

	private OverworldBallManager overworldBallManager;

	public Action<Vector3> OnAudioEvent { get; set; }

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		col = GetComponent<Collider2D>();
		plantParticles = GetComponentInChildren<PlantParticles>();
	}

	private void Awake()
	{
		baseTransform = transform;
		baseRotation = baseTransform.rotation;
	}

	private void OnEnable()
	{
		overworldBallManager = OverworldBallManager.Instance;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.rigidbody == null)
			return;
		var ballMgr = OverworldBallManager.Instance;
		if (ballMgr == null || ballMgr.Ball == null || collision.rigidbody != ballMgr.Ball.rigidBody)
			return;

		float impact = Mathf.Clamp01(collision.relativeVelocity.magnitude / 10f);
		if (impact <= 0.1f || Time.time <= nextHitSound)
			return;

		nextHitSound = Time.time + 0.15f;
		OnAudioEvent?.Invoke(baseTransform != null ? baseTransform.position : transform.position);

		if (plantParticles != null)
		{
			plantParticles.Emit(particleAmount * UnityEngine.Random.Range(2, 5));
		}

		StartCoroutine(pTween.To(1f, t =>
		{
			if (baseTransform != null)
			{
				Vector3 euler = baseRotation.eulerAngles;
				baseTransform.rotation = Quaternion.Euler(0f, 0f, euler.z + TweenFunctions.punch(5f, t));
			}
		}).Then(() =>
		{
			if (baseTransform != null)
				baseTransform.rotation = baseRotation;
		}));
	}
}
