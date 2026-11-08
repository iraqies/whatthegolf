using System.Collections.Generic;
using Core;
using UnityEngine;

public class ToggleObjectOnOutOfBounds : MonoBehaviour
{
	public List<GameObject> ObjectToToggle;

	private void Start()
	{
		if (Level.HasInstance)
		{
			Level.Instance.OnFail += OnOutOfBounds;
			if (Level.Instance.Ball != null)
				Level.Instance.Ball.OnReset += Ball_OnReset;
		}
	}

	private void Ball_OnReset()
	{
		if (ObjectToToggle == null) return;
		foreach (GameObject go in ObjectToToggle)
		{
			if (go != null)
				go.SetActive(true);
		}
	}

	private void OnOutOfBounds(GolfBallController c, string msg, Level.State state)
	{
		if (ObjectToToggle == null) return;
		foreach (GameObject go in ObjectToToggle)
		{
			if (go != null)
				go.SetActive(false);
		}
	}
}
