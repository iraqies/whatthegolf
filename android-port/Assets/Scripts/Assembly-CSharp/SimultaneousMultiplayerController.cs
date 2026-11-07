using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class SimultaneousMultiplayerController : MonoBehaviour
{
	public List<GolfBallController> Players;

	public bool isSplitScreen;

	private List<CameraManager> cams;

	private StrokeCounter strokeCounter;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnGoal(string obj)
	{
	}

	private void OnOnGoalProgress(int playerIndex, string message)
	{
	}
}
