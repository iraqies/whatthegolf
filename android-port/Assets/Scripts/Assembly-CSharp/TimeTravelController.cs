using System.Collections;
using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;

public class TimeTravelController : MonoBehaviour
{
	public enum StateEnum
	{
		Countdown = 0,
		Running = 1,
		Rewining = 2,
		Resetting = 3,
		LevelEnded = 4
	}

	public float TimeLimitInSeconds = 10f;

	public int TimeLinesLimit = 3;

	public GameObject ReplayPlayerPrefab;

	public Recorder PlayerRecorder;

	public static float CurrentTime;

	public static float Interval = 0.02f;

	public List<Transform> SpawnPoints;

	public float RewindSpeed = 3f;

	public bool IsRewining;

	public float TimeLimitIncrement;

	public ParticleSystem SpawnParticles;

	public TextMeshPro InfoText;

	private GolfBallController golfController;

	private int numberOfTimeLines;

	private List<Replayer> spawnedReplayers;

	private float longestTimeline;

	private CameraFilterPack_TV_VHS_Rewind rewind;

	private LevelGate[] gates;

	private bool stopCountdown;

	private Replayer playerReplayer;

	private TimeControl timeControl;

	public StateEnum GameState { get; private set; }

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		CurrentTime = 0f;
		Interval = 0.02f;
	}

	private void Awake()
	{
		CurrentTime = 0f;
		Interval = Time.fixedDeltaTime > 0f ? Time.fixedDeltaTime : 0.02f;
		spawnedReplayers = new List<Replayer>();
		golfController = Object.FindObjectOfType<GolfBallController>();
		gates = Object.FindObjectsOfType<LevelGate>();
		GameState = StateEnum.Running;
		SpawnNewTimeline();
		SetInfoText();
	}

	private void GolfGoalOnOnComplete(string message)
	{
		GameState = StateEnum.LevelEnded;
	}

	private void Update()
	{
		if (GameState == StateEnum.Running)
		{
			CurrentTime += Time.deltaTime;
			SetInfoText();
			if (!stopCountdown && CurrentTime >= TimeLimitInSeconds)
			{
				StartCoroutine(EndCurrentTimeline());
			}
		}
	}

	public void ResetCurrentTimeline()
	{
		if (GameState == StateEnum.Running)
		{
			StartCoroutine(EndCurrentTimeline());
		}
	}

	private IEnumerator EndCurrentTimeline()
	{
		GameState = StateEnum.Rewining;
		IsRewining = true;
		if (PlayerRecorder != null && ReplayPlayerPrefab != null && PlayerRecorder.Snapshots != null && PlayerRecorder.Snapshots.Count > 0)
		{
			GameObject repObj = Object.Instantiate(ReplayPlayerPrefab, PlayerRecorder.Snapshots[0].Position, PlayerRecorder.Snapshots[0].Rotation);
			Replayer rep = repObj.GetComponent<Replayer>();
			if (rep != null)
			{
				rep.Snapshots = new List<Recorder.Snapshot>(PlayerRecorder.Snapshots);
				spawnedReplayers.Add(rep);
			}
			PlayerRecorder.Reset();
		}
		while (CurrentTime > 0f)
		{
			CurrentTime = Mathf.Max(0f, CurrentTime - Time.deltaTime * Mathf.Max(1f, RewindSpeed) * TimeLimitInSeconds);
			SetInfoText();
			yield return null;
		}
		IsRewining = false;
		numberOfTimeLines++;
		TimeLimitInSeconds += TimeLimitIncrement;
		SpawnNewTimeline();
		GameState = StateEnum.Running;
	}

	private void SpawnNewTimeline()
	{
		if (golfController != null && SpawnPoints != null && SpawnPoints.Count > 0)
		{
			Transform sp = SpawnPoints[numberOfTimeLines % SpawnPoints.Count];
			if (sp != null)
			{
				golfController.transform.position = sp.position;
				golfController.transform.rotation = sp.rotation;
				Rigidbody rb = golfController.GetComponent<Rigidbody>();
				if (rb != null && !rb.isKinematic)
				{
					rb.velocity = Vector3.zero;
					rb.angularVelocity = Vector3.zero;
				}
				if (SpawnParticles != null)
				{
					SpawnParticles.transform.position = sp.position;
					SpawnParticles.Play();
				}
			}
		}
	}

	private void SetInfoText()
	{
		if (InfoText != null)
		{
			float rem = Mathf.Max(0f, TimeLimitInSeconds - CurrentTime);
			InfoText.text = rem.ToString("0.0");
		}
	}
}
