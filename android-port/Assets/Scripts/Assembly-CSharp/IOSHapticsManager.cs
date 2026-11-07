using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IOSHapticsManager : MonoBehaviour
{
	private MobileVibrator mobileVibrator;

	private List<GolfBallController> _golfBallControllers;

	private List<OverworldGoal> _overworldGoals;

	private List<OverworldButton2D> overworldButton2Ds;

	private List<Button> _buttons;

	private GolfGoal _golfGoal;

	private iOSHapticsContainer _container;

	private void Start()
	{
	}

	private void AddEvents(Scene scene, LoadSceneMode mode)
	{
	}

	private void RemoveEvents()
	{
	}

	private void OnButtonClick()
	{
	}

	private void OnTransforgriffed(Transmogrif t)
	{
	}

	private void OnOverworldGoalHit(OverworldGoal g, Vector3 v, OverworldBall2D ball)
	{
	}

	private void OnGoalHit(string s)
	{
	}

	private void OnAimStart()
	{
	}

	private void OnShootCanceled()
	{
	}

	private void OnShoot(Vector3 v)
	{
	}

	private void OnDoorOpen()
	{
	}
}
