using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class UncompletedFlagScanner : MonoBehaviour
{
	public float StayDuration;
	public float ZoomedSize;
	public float PushAwayDistance;
	public float MoveMod;
	public Material ScannerEffect;
	public ClipSettingsCollection FoundFlagClip;
	public ClipSettingsCollection NoFlagsLeftClip;
	public List<OverworldGoal> goals { get => allGoals; set => allGoals = value; }
	private List<OverworldGoal> allGoals;
	private bool routineRunning;

	public void Init(List<OverworldGoal> goals)
	{
		allGoals = goals;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private IEnumerator MoveCameraRoutine(OverworldBall2D ball, Vector3 collisionPoint)
	{
		yield break;
	}
}
