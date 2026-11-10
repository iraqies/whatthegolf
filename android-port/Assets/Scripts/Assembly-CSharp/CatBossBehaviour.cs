using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class CatBossBehaviour : MonoBehaviour
{
	[Serializable]
	public class BossEvent
	{
		public string TriggerName;

		public float Weight;

		public int EventsBeforeAvailable;

		public int SkipsLeft;

		public bool HasCustomMovement;

		public AnimationCurve MovementCurve;

		public float NormalizedEventStartPosition;

		public float EventSpeedMod = 1f;
	}

	public List<BossEvent> BossEvents;

	public Vector2 LeftRightRanges;

	public Vector2 DelayRange = new Vector2(1f, 2f);

	public float MovementSpeedMod = 1f;

	public BossIntro Intro;

	public GolfBallController Controller;

	public int Health = 3;

	public ParticleSystem HurtParticles;

	public List<AudioClip> HurtClips;

	public List<GameObject> HurtObjects;

	public List<Rigidbody> Drops;

	public List<AudioClip> SmashClips;

	public List<AudioClip> CatIntroClips;

	public List<AudioClip> CatPeekingClips;

	public List<AudioClip> SwooshClips;

	public List<AudioClip> CatDraggingClips;

	public List<AudioClip> AnticipationClips;

	public AudioClip SmashRecoverClip;

	public AudioClip CatFallClip;

	public AudioClip ExplosionClip;

	public Explosion2D FlagSpawnParticles;

	public GameObject Flag;

	private Animator animator;

	private float delay;

	private float movementTime;

	private float eventTime;

	private BossEvent currentEvent;

	private int direction;

	private int startHealth;

	private static bool hasPlayedIntro;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		hasPlayedIntro = false;
	}

	private void Awake()
	{
		animator = GetComponent<Animator>();
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += delegate
			{
				hasPlayedIntro = false;
			};
			Level.Instance.OnAbort += delegate
			{
				hasPlayedIntro = false;
			};
		}
		if (hasPlayedIntro)
		{
			if (animator != null)
			{
				animator.SetTrigger("Reset");
			}
			base.enabled = true;
		}
		else
		{
			hasPlayedIntro = true;
		}
		if (HurtObjects == null)
		{
			return;
		}
		foreach (GameObject hurtObject in HurtObjects)
		{
			if (hurtObject != null)
			{
				hurtObject.SetActive(false);
			}
		}
	}

	private void Start()
	{
		if (BossEvents != null)
		{
			foreach (BossEvent bossEvent in BossEvents)
			{
				if (bossEvent != null)
				{
					bossEvent.SkipsLeft = bossEvent.EventsBeforeAvailable - 1;
				}
			}
		}
		delay = 2f;
		movementTime = Mathf.InverseLerp(LeftRightRanges.x, LeftRightRanges.y, base.transform.position.x);
		direction = ((UnityEngine.Random.value > 0.5f) ? 1 : (-1));
		startHealth = Health;
		if (animator != null)
		{
			animator.SetInteger("Health", Health);
		}
	}

	private void OnReset()
	{
		Health = startHealth;
		if (BossEvents != null)
		{
			foreach (BossEvent bossEvent in BossEvents)
			{
				if (bossEvent != null)
				{
					bossEvent.SkipsLeft = bossEvent.EventsBeforeAvailable - 1;
				}
			}
		}
		delay = 2f;
		movementTime = 0.5f;
		eventTime = 0f;
		float x = Mathf.Lerp(LeftRightRanges.x, LeftRightRanges.y, movementTime);
		base.transform.position = new Vector3(x, base.transform.position.y, base.transform.position.z);
		direction = ((UnityEngine.Random.value > 0.5f) ? 1 : (-1));
		if (animator != null)
		{
			animator.SetTrigger("Reset");
			animator.SetInteger("Health", Health);
		}
		currentEvent = null;
		if (HurtParticles != null)
		{
			HurtParticles.Clear();
			HurtParticles.Stop();
		}
		if (HurtObjects == null)
		{
			return;
		}
		foreach (GameObject hurtObject in HurtObjects)
		{
			if (hurtObject != null)
			{
				hurtObject.SetActive(false);
			}
		}
	}

	private void Update()
	{
		if (animator == null)
		{
			return;
		}
		if (delay > 0f)
		{
			if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") && eventTime >= 1f)
			{
				float x = Mathf.Lerp(LeftRightRanges.x, LeftRightRanges.y, Mathf.PingPong(movementTime, 1f));
				base.transform.position = new Vector3(x, base.transform.position.y, base.transform.position.z);
				movementTime += Time.deltaTime * MovementSpeedMod * (float)direction;
				delay -= Time.deltaTime;
			}
			else if (currentEvent != null && currentEvent.HasCustomMovement)
			{
				eventTime += Time.deltaTime * currentEvent.EventSpeedMod;
				Vector3 a = new Vector3(LeftRightRanges.x, base.transform.position.y, base.transform.position.z);
				Vector3 b = new Vector3(LeftRightRanges.y, base.transform.position.y, base.transform.position.z);
				if (currentEvent.MovementCurve != null)
				{
					float t = currentEvent.MovementCurve.Evaluate(eventTime);
					base.transform.position = Vector3.LerpUnclamped(a, b, t);
					movementTime = currentEvent.MovementCurve.Evaluate(eventTime);
				}
			}
			else
			{
				eventTime = 1f;
			}
		}
		else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
		{
			currentEvent = GetNextEvent();
			delay = UnityEngine.Random.Range(DelayRange.x, DelayRange.y);
			eventTime = 0f;
			StartCoroutine(StartEvent());
		}
	}

	public void DoScreenShake()
	{
		StartCoroutine(DelayedScreenShake());
	}

	private IEnumerator DelayedScreenShake()
	{
		yield return null;
		yield return null;
		yield return null;
		if (CameraManager.Instance != null)
		{
			CameraManager.Instance.Shake(0.5f, 20f, 2f);
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && SmashClips != null)
		{
			AudioManager.Instance.sfx.Play(SmashClips, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.7f;
					s.pitch = 1.3f;
				}
			}, true, false, 0f);
		}
		if (Drops != null && Drops.Count >= 1)
		{
			List<Vector3> list = new List<Vector3>();
			int num = 1 << base.gameObject.layer;
			for (int i = 0; i < 20; i++)
			{
				float x = Mathf.Lerp(LeftRightRanges.x, LeftRightRanges.y, (float)i / 20f);
				float z = ((Level.Instance != null && Level.Instance.Ball != null) ? Level.Instance.Ball.transform.position.z : 0f);
				Vector3 vector = new Vector3(x, 20f, z);
				if (!Physics.SphereCast(new Ray(vector, Vector3.down), 5f, 30f, num))
				{
					list.Add(vector);
				}
			}
			if (list.Count > 0)
			{
				Rigidbody original = Drops[UnityEngine.Random.Range(0, Drops.Count)];
				Vector3 position = list[UnityEngine.Random.Range(0, list.Count)];
				Rigidbody rigidbody = UnityEngine.Object.Instantiate(original, position, UnityEngine.Random.rotation);
				if (rigidbody != null)
				{
					rigidbody.angularVelocity = UnityEngine.Random.onUnitSphere * 5f;
					rigidbody.velocity = Vector3.down * 5f;
				}
			}
		}
	}

	private BossEvent GetNextEvent()
	{
		if (BossEvents == null)
		{
			return null;
		}
		List<BossEvent> list = BossEvents.Where((BossEvent e) => e.SkipsLeft < 1).ToList();
		BossEvents.Except(list).ToList().ForEach(delegate(BossEvent e)
		{
			e.SkipsLeft--;
		});
		float max = list.Sum((BossEvent e) => e.Weight);
		float num = UnityEngine.Random.Range(0f, max);
		float num2 = 0f;
		for (int i = 0; i < list.Count; i++)
		{
			num2 += list[i].Weight;
			if (num < num2)
			{
				list[i].SkipsLeft = list[i].EventsBeforeAvailable;
				return list[i];
			}
		}
		Debug.LogWarning("Something is wrong with weighted random event selection");
		return null;
	}

	private IEnumerator StartEvent()
	{
		if (currentEvent != null && currentEvent.HasCustomMovement)
		{
			Vector3 startPos = base.transform.position;
			float x = Mathf.Lerp(LeftRightRanges.x, LeftRightRanges.y, currentEvent.NormalizedEventStartPosition);
			Vector3 targetPos = new Vector3(x, base.transform.position.y, base.transform.position.z);
			yield return StartCoroutine(pTween.To(0.3f, delegate(float t)
			{
				float t2 = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, t));
				base.transform.position = Vector3.Lerp(startPos, targetPos, t2);
			}));
		}
		if (currentEvent != null && animator != null)
		{
			animator.SetTrigger(currentEvent.TriggerName);
		}
	}

	public void TakeDamage()
	{
		Health--;
		if (animator != null)
		{
			animator.SetInteger("Health", Health);
		}
		if (HurtParticles != null)
		{
			HurtParticles.Play();
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && HurtClips != null)
		{
			AudioManager.Instance.sfx.Play(HurtClips);
		}
		if (Health > 0)
		{
			if (HurtObjects != null)
			{
				int num = startHealth - Health - 1;
				if (num >= 0 && num < HurtObjects.Count && HurtObjects[num] != null)
				{
					HurtObjects[num].SetActive(true);
				}
			}
		}
		else
		{
			base.enabled = false;
			StartCoroutine(pTween.To(6f, delegate
			{
			}).Then(delegate
			{
				if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && ExplosionClip != null)
				{
					AudioManager.Instance.sfx.Play(ExplosionClip);
				}
				Vector3 position = base.transform.position;
				float z = ((Controller != null) ? Controller.transform.position.z : position.z);
				if (FlagSpawnParticles != null)
				{
					FlagSpawnParticles.transform.position = new Vector3(position.x, 0.5f, z);
					FlagSpawnParticles.Explode(1f);
				}
				if (Flag != null)
				{
					Flag.transform.position = new Vector3(position.x, 0.5f, z);
				}
				if (CameraManager.Instance != null)
				{
					CameraManager.Instance.Shake(0.5f, 20f, 2f);
				}
			}));
		}
	}

	public void PlayPeekClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && CatPeekingClips != null)
		{
			AudioManager.Instance.sfx.Play(CatPeekingClips);
		}
	}

	public void PlayIntro()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && CatIntroClips != null)
		{
			AudioManager.Instance.sfx.Play(CatIntroClips);
		}
		if (Controller != null)
		{
			Controller.TimedBlockShot(1.5f);
		}
		if (Intro != null)
		{
			Intro.PlayIntro(OnReset);
		}
	}

	public void PlayDragClip()
	{
		if (AudioManager.Instance == null || AudioManager.Instance.sfx == null || CatDraggingClips == null)
		{
			return;
		}
		AudioSource source = AudioManager.Instance.sfx.Play(CatDraggingClips, delegate(AudioSource m)
		{
			if (m != null)
			{
				m.volume = 1f;
				m.pitch = 0.3f;
			}
		}, true, false, 0f);
		if (source != null)
		{
			StartCoroutine(pTween.To(1f, delegate
			{
			}).Then(pTween.To(0.2f, source.volume, 0f, delegate(float s)
			{
				if (source != null)
				{
					source.volume = s;
				}
			}, pTween.TimeMode.Realtime, false)));
		}
	}

	public void PlayFallClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && CatFallClip != null)
		{
			AudioManager.Instance.sfx.Play(CatFallClip, delegate(AudioSource m)
			{
				if (m != null)
				{
					m.volume = 0.7f;
					m.pitch = 1.7f;
				}
			}, false, 0f);
		}
	}

	public void PlaySwooshClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && SwooshClips != null)
		{
			AudioManager.Instance.sfx.Play(SwooshClips, delegate(AudioSource m)
			{
				if (m != null)
				{
					m.volume = 0.7f;
					m.pitch = 1.7f;
				}
			}, true, false, 0f);
		}
	}

	public void PlaySmashRecoverClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && SmashRecoverClip != null)
		{
			AudioManager.Instance.sfx.Play(SmashRecoverClip, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.2f;
				}
			}, false, 0f);
		}
	}

	public void PlayAnticipationClip(int index)
	{
		if (index >= 0 && AnticipationClips != null && index <= AnticipationClips.Count - 1 && AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.Play(AnticipationClips[index], delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.45f;
					s.pitch = 0.8f;
				}
			}, false, 0f);
		}
	}
}
