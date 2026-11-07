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
	}

	private void Update()
	{
	}
}
