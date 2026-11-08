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
		timeToShowTransition = timeToShowTransitionPS4;
		if (transition != null)
		{
			var cam = transition.GetComponent<Camera>();
			if (cam != null) cam.enabled = false;
		}
		gameObject.SetActive(false);
	}

	public IEnumerator ShowRoutine()
	{
		yield break;
	}

	public IEnumerator HideRoutine()
	{
		gameObject.SetActive(false);
		yield break;
	}

	private void Update()
	{
	}
}
