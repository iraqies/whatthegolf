using System.Collections;
using System.Collections.Generic;
using Audio;
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

		private List<Entry> entries;

		private float accumulatedWeight;

		public void AddEntry(T item, float weight)
		{
		}

		public T GetRandom()
		{
			return default;
		}
	}

	public Vector2 MoveSpeed;

	public float MoveWarmupTime;

	public Vector2 RangeX;

	public List<FrogKingBaseWave> WaveTypes;

	public FrogKingBaseWave BallWave;

	public int BallWaveCooldown;

	public SkinnedMeshRenderer FrogModel;

	public Material NormalMaterial;

	public Material HitMaterial;

	public Material HurtMaterial;

	public float HurtTime;

	public float HitTime;

	public int Health;

	public Animator FrogKingAnimator;

	public ClipSettingsCollection hurtSFX;

	public bool InWebPhase;

	public float WebPhaseMoveSpeed;

	public Transform WebPlayer;

	private FrogKingBaseWave currentStateRoutine;

	private float currentSpeed;

	private Rigidbody rigid;

	private WeightedRandomBag<FrogKingBaseWave> weightedBag;

	private int waveNumber;

	private float xPosition;

	private Material origMaterial;

	private Vector3 startPos;

	private bool playerIsResetting;

	private bool canStartNewWave;

	public int HitsTaken { get; set; }

	public bool IsAlive => false;

	public void Initialize()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void PlayerIsAboutToReset()
	{
	}

	public void SinkReset()
	{
	}

	public void SinkResetAfter()
	{
	}

	private IEnumerator WaveRoutine()
	{
		return null;
	}

	private FrogKingBaseWave GetNextState()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public IEnumerator WaitForPlayerShot(GameObject ball)
	{
		return null;
	}

	private IEnumerator HurtRoutine()
	{
		return null;
	}
}
