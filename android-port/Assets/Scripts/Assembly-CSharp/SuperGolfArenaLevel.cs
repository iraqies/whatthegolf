using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SuperGolfArenaLevel : MonoBehaviour
{
	[Serializable]
	public class LevelEvent
	{
		public List<GameObject> Enemies;

		public UnityEvent Event;

		public bool Invoked;
	}

	public UnityEvent OnLevelStart;

	public List<LevelEvent> Events;

	private void Start()
	{
		if (OnLevelStart != null)
		{
			OnLevelStart.Invoke();
		}
	}

	private void Update()
	{
		if (Events == null)
		{
			return;
		}
		foreach (LevelEvent @event in Events)
		{
			if (@event == null || @event.Invoked || @event.Enemies == null)
			{
				continue;
			}
			for (int num = @event.Enemies.Count - 1; num >= 0; num--)
			{
				if (@event.Enemies[num] == null || !@event.Enemies[num].activeSelf)
				{
					@event.Enemies.Remove(@event.Enemies[num]);
				}
			}
			if (@event.Enemies.Count == 0)
			{
				if (@event.Event != null)
				{
					@event.Event.Invoke();
				}
				base.enabled = false;
			}
		}
	}
}
