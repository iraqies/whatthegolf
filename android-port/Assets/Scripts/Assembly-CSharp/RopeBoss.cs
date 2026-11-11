using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class RopeBoss : MonoBehaviour
{
	public float MoveSpeed = 10f;

	public float BobAmount = 1f;

	public float BobSpeed = 1f;

	public float ShakeMagnitudeMod = 0.05f;

	public List<Transform> Paws;

	public Animator Animator;

	public AudioSource Source;

	public List<AudioClip> StepClips;

	public List<AudioClip> CrashIntoIslandClips;

	public List<AudioClip> IntroSound;

	public BossIntro Intro;

	public float PauseAfterSeconds;

	public float PauseDuration;

	public GolfBallController GolfBall;

	private Rigidbody rigid;

	private float bobTimer;

	private float previousBob;

	private int lastStepIndex;

	private float introStopTimer;

	private bool playerHasShot;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		if (GolfBall == null)
		{
			GolfBall = Object.FindObjectOfType<GolfBallController>();
		}
		if (GolfBall != null)
		{
			GolfBall.OnShoot += delegate
			{
				playerHasShot = true;
			};
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(IntroSound);
		}
	}

	private void FixedUpdate()
	{
		if (Intro != null && Intro.InIntro)
		{
			return;
		}
		if (PauseDuration > 0f && !playerHasShot)
		{
			introStopTimer += Time.fixedDeltaTime;
			if (introStopTimer > PauseAfterSeconds && introStopTimer < PauseAfterSeconds + PauseDuration)
			{
				return;
			}
		}
		if (rigid != null)
		{
			rigid.MovePosition(base.transform.position + base.transform.forward * MoveSpeed * Time.fixedDeltaTime);
		}
	}

	private void Update()
	{
		if (Intro != null && Intro.InIntro)
		{
			return;
		}
		bobTimer += Time.deltaTime;
		float num = Mathf.Sin(bobTimer * BobSpeed) * BobAmount;
		base.transform.position += Vector3.up * (num - previousBob);
		if (previousBob > 0f && num <= 0f)
		{
			if (CameraManager.Instance != null && Paws != null && Paws.Count > 0)
			{
				int index = (lastStepIndex + 1) % Paws.Count;
				if (Paws[index] != null)
				{
					CameraManager.Instance.DirectionalShake(0.2f, 25f, Vector3.down, Paws[index].position, ShakeMagnitudeMod);
				}
				lastStepIndex = index;
			}
			if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
			{
				AudioManager.Instance.sfx.Play(StepClips, delegate(AudioSource s)
				{
					s.pitch = Random.Range(0.95f, 1.05f);
					s.volume = 0.8f;
				});
			}
		}
		previousBob = num;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CompareTag("Player"))
		{
			GolfBallController component = other.GetComponent<GolfBallController>();
			if (component == null)
			{
				component = Object.FindObjectOfType<GolfBallController>();
			}
			if (component != null)
			{
				component.OutOfBounds("Eaten!", 0.4f);
			}
		}
		else if (other.gameObject.layer == LayerMask.NameToLayer("RopeIsland"))
		{
			Rigidbody component2 = other.GetComponent<Rigidbody>();
			if (component2 != null)
			{
				component2.isKinematic = false;
				component2.constraints = RigidbodyConstraints.None;
				Vector3 normalized = (other.transform.position - base.transform.position).normalized;
				component2.AddForce((normalized + Vector3.up) * 20f, ForceMode.VelocityChange);
				component2.AddTorque(Random.onUnitSphere * 100f);
			}
			if (CameraManager.Instance != null)
			{
				CameraManager.Instance.PerlinShake(0.25f, 10f, 0.35f, other.transform.position);
			}
			if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
			{
				AudioManager.Instance.sfx.Play(CrashIntoIslandClips);
			}
			RopeJoint3D[] componentsInChildren = other.GetComponentsInChildren<RopeJoint3D>();
			if (componentsInChildren != null)
			{
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					if (componentsInChildren[i] != null)
					{
						Object.Destroy(componentsInChildren[i].gameObject);
					}
				}
			}
		}
		else if (other.gameObject.layer == LayerMask.NameToLayer("Goal"))
		{
			if (Animator != null)
			{
				Animator.SetTrigger("Fall");
			}
			if (rigid != null)
			{
				rigid.isKinematic = false;
				rigid.useGravity = true;
			}
			MoveSpeed = 0f;
			BobAmount = 0f;
			if (Source != null)
			{
				Source.Stop();
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
