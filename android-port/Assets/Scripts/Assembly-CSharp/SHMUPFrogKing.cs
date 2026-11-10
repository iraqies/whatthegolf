using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class SHMUPFrogKing : MonoBehaviour
{
	private class WeightedRandomBag<T>
	{
		private struct Entry
		{
			public double accumulatedWeight;

			public T item;
		}

		private List<Entry> entries = new List<Entry>();

		private float accumulatedWeight;

		public void AddEntry(T item, float weight)
		{
			accumulatedWeight += weight;
			entries.Add(new Entry
			{
				item = item,
				accumulatedWeight = accumulatedWeight
			});
		}

		public T GetRandom()
		{
			if (entries == null || entries.Count == 0)
				return default;
			double r = UnityEngine.Random.value * accumulatedWeight;
			for (int i = 0; i < entries.Count; i++)
			{
				if (entries[i].accumulatedWeight >= r)
					return entries[i].item;
			}
			return entries[entries.Count - 1].item;
		}
	}

	public Vector2 MoveSpeed = new Vector2(10f, 50f);

	public float MoveWarmupTime = 2f;

	public Vector2 RangeX = new Vector2(-100f, 100f);

	public List<FrogKingBaseWave> WaveTypes;

	public FrogKingBaseWave BallWave;

	public int BallWaveCooldown = 3;

	public SkinnedMeshRenderer FrogModel;

	public Material NormalMaterial;

	public Material HitMaterial;

	public Material HurtMaterial;

	public float HurtTime = 0.1f;

	public float HitTime = 0.1f;

	public int Health = 3;

	public Animator FrogKingAnimator;

	public ClipSettingsCollection hurtSFX;

	public bool InWebPhase;

	public float WebPhaseMoveSpeed = 50f;

	public Transform WebPlayer;

	private FrogKingBaseWave currentStateRoutine;

	private float currentSpeed;

	private Rigidbody rigid;

	private WeightedRandomBag<FrogKingBaseWave> weightedBag;

	private int waveNumber;

	private float xPosition = 0.5f;

	private Material origMaterial;

	private Vector3 startPos;

	private bool playerIsResetting;

	private bool canStartNewWave = true;

	public int HitsTaken { get; set; }

	public bool IsAlive => HitsTaken < Health;

	public void Initialize()
	{
		rigid = GetComponent<Rigidbody>();
		weightedBag = new WeightedRandomBag<FrogKingBaseWave>();
		if (WaveTypes != null)
		{
			foreach (FrogKingBaseWave wave in WaveTypes)
			{
				if (wave != null)
					weightedBag.AddEntry(wave, wave.Weight);
			}
		}
	}

	private void Start()
	{
		if (rigid == null)
			Initialize();
		startPos = transform.position;
		StartCoroutine(WaveRoutine());
	}

	private void FixedUpdate()
	{
		if (playerIsResetting)
			return;

		if (InWebPhase)
		{
			if (rigid != null)
			{
				rigid.MovePosition(rigid.position + Vector3.forward * (Time.deltaTime * WebPhaseMoveSpeed));
			}
			return;
		}

		if (HitsTaken >= Health)
			MoveSpeed.x = 0f;

		if (MoveWarmupTime > 0f)
			currentSpeed = Mathf.MoveTowards(currentSpeed, MoveSpeed.y, Time.deltaTime / MoveWarmupTime);
		else
			currentSpeed = MoveSpeed.y;

		float targetX = Mathf.Lerp(RangeX.x, RangeX.y, Mathf.PingPong(xPosition, 1f));
		if (rigid != null)
		{
			Vector3 curPos = rigid.position;
			Vector3 newPos = new Vector3(targetX, curPos.y, curPos.z) + Vector3.forward * (Time.deltaTime * currentSpeed);
			rigid.MovePosition(newPos);
		}
		xPosition += Time.deltaTime * MoveSpeed.x;
	}

	public void PlayerIsAboutToReset()
	{
		playerIsResetting = true;
		canStartNewWave = false;
	}

	public void SinkReset()
	{
		currentSpeed = 0f;
		transform.position = startPos;
		if (WaveTypes != null)
		{
			foreach (FrogKingBaseWave wave in WaveTypes)
			{
				if (wave != null)
				{
					wave.OnSinkReset();
					wave.StopAllCoroutines();
				}
			}
		}
		if (BallWave != null)
		{
			BallWave.OnSinkReset();
			BallWave.StopAllCoroutines();
		}
	}

	public void SinkResetAfter()
	{
		playerIsResetting = false;
		canStartNewWave = true;
	}

	private IEnumerator WaveRoutine()
	{
		yield return new WaitForSeconds(3f);
		currentStateRoutine = GetNextState();
		while (IsAlive)
		{
			if (canStartNewWave)
			{
				if (currentStateRoutine != null)
					yield return StartCoroutine(currentStateRoutine.WaveRoutine(this));
				currentStateRoutine = GetNextState();
			}
			else
			{
				yield return new WaitForSeconds(1f);
			}
		}
	}

	private FrogKingBaseWave GetNextState()
	{
		waveNumber++;
		if (BallWaveCooldown > 0 && waveNumber % BallWaveCooldown == 0 && BallWave != null)
			return BallWave;
		return weightedBag != null ? weightedBag.GetRandom() : null;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.attachedRigidbody == null)
			return;
		if (other.attachedRigidbody.GetComponent<BossHurtBall>() == null)
			return;

		other.attachedRigidbody.gameObject.SetActive(false);
		HitsTaken++;
		MoveSpeed.x *= 1f + HitsTaken / 10f;
		StartCoroutine(HurtRoutine());
	}

	public IEnumerator WaitForPlayerShot(GameObject ball)
	{
		canStartNewWave = false;
		while (ball != null && ball.activeSelf)
		{
			yield return null;
		}
		canStartNewWave = true;
	}

	private IEnumerator HurtRoutine()
	{
		if (!IsAlive && FrogKingAnimator != null)
			FrogKingAnimator.SetBool("Dead", true);

		if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.BumpHard != null)
		{
			AudioManager.Instance.rumbleManager.BumpHard.Play(0, 1f);
		}
		if (FrogKingAnimator != null)
			FrogKingAnimator.SetTrigger("Hurt");
		if (hurtSFX != null)
			hurtSFX.Play(null, Vector3.zero, 1f, 1f);

		if (FrogModel != null && HitMaterial != null)
			FrogModel.sharedMaterial = HitMaterial;
		yield return new WaitForSeconds(HitTime);

		if (FrogModel != null && HurtMaterial != null)
			FrogModel.sharedMaterial = HurtMaterial;
		yield return new WaitForSeconds(HurtTime);

		if (FrogModel != null && NormalMaterial != null)
			FrogModel.sharedMaterial = NormalMaterial;
		canStartNewWave = true;
	}
}
