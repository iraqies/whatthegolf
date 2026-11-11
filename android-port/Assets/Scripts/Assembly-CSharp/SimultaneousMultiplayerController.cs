using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class SimultaneousMultiplayerController : MonoBehaviour
{
	public List<GolfBallController> Players = new List<GolfBallController>();

	public bool isSplitScreen;

	private List<CameraManager> cams = new List<CameraManager>();

	private StrokeCounter strokeCounter;

	private IEnumerator Start()
	{
		strokeCounter = Object.FindObjectOfType<StrokeCounter>();
		cams = new List<CameraManager>();
		if (isSplitScreen && CameraManager.Instance != null && Players != null && Players.Count >= 2)
		{
			Transform parent = CameraManager.Instance.transform.parent;
			CameraManager cam0 = Object.Instantiate(CameraManager.Instance, parent);
			CameraManager cam1 = Object.Instantiate(CameraManager.Instance, parent);
			CameraManager.Instance.gameObject.SetActive(false);
			if (cam0.MainCamera != null)
			{
				cam0.MainCamera.rect = new Rect(0f, 0f, 0.5f, 1f);
			}
			if (cam1.MainCamera != null)
			{
				cam1.MainCamera.rect = new Rect(0.5f, 0f, 0.5f, 1f);
			}
			cams.Add(cam0);
			cams.Add(cam1);
		}
		if (Players != null)
		{
			for (int i = 0; i < Players.Count; i++)
			{
				GolfBallController p = Players[i];
				if (p == null)
				{
					continue;
				}
				if (strokeCounter != null)
				{
					strokeCounter.TogglePlayer(p.PlayerIndex, true, -1);
				}
				if (isSplitScreen && i < cams.Count && cams[i] != null)
				{
					CBFollow follow = cams[i].GetComponent<CBFollow>();
					if (follow != null)
					{
						follow.FollowTarget = p.transform;
					}
				}
			}
		}
		if (Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.OnGoalProgress += OnOnGoalProgress;
			Level.Instance.Goal.OnGoal += OnGoal;
		}
		yield break;
	}

	private void OnGoal(string obj)
	{
		if (Players == null || strokeCounter == null)
		{
			return;
		}
		for (int i = 0; i < Players.Count; i++)
		{
			if (Players[i] != null)
			{
				strokeCounter.TogglePlayer(Players[i].PlayerIndex, false, -1);
			}
		}
	}

	private void OnOnGoalProgress(int playerIndex, string message)
	{
		if (Players == null)
		{
			return;
		}
		for (int i = 0; i < Players.Count; i++)
		{
			if (Players[i] != null && Players[i].PlayerIndex == playerIndex)
			{
				Players[i].StopAiming();
				Players[i].enabled = false;
			}
		}
	}
}
