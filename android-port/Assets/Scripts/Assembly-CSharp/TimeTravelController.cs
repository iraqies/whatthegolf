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

	public float TimeLimitInSeconds;

	public int TimeLinesLimit;

	public GameObject ReplayPlayerPrefab;

	public Recorder PlayerRecorder;

	public static float CurrentTime;

	public static float Interval;

	public List<Transform> SpawnPoints;

	public float RewindSpeed;

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
	}

	private void Awake()
	{
	}

	private void GolfGoalOnOnComplete(string message)
	{
	}

	private void Update()
	{
	}

	public void ResetCurrentTimeline()
	{
	}

	private IEnumerator EndCurrentTimeline()
	{
		return null;
	}

	private void SpawnNewTimeline()
	{
	}

	private void SetInfoText()
	{
	}
}
