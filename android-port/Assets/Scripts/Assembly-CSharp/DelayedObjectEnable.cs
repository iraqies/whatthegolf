using System.Collections.Generic;
using Core;
using UnityEngine;

public class DelayedObjectEnable : MonoBehaviour
{
	public List<Behaviour> BehavioursToToggle;

	private void Awake()
	{
		Toggle(false);
		if (!(Level.Instance != null) || !Level.Instance.IsMultiplayer)
		{
			Level.Instance.OnStart += OnStart;
		}
	}

	private void OnStart()
	{
		Toggle(true);
	}

	private void Toggle(bool state)
	{
		foreach (Behaviour item in BehavioursToToggle)
		{
			item.enabled = state;
		}
	}
}
