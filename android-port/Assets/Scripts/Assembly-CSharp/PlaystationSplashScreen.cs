using System.Collections;
using UnityEngine;

public class PlaystationSplashScreen : MonoBehaviour
{
	public Transition transition;

	public float timeToShowTransitionPS4;

	public float timeToShowTransitionPS5;

	private bool isShowing;

	private float loadingTime;

	private float timeToShowTransition;

	private void Awake()
	{
	}

	public IEnumerator ShowRoutine()
	{
		return null;
	}

	public IEnumerator HideRoutine()
	{
		return null;
	}

	private void Update()
	{
	}
}
