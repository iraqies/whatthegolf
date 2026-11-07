using System;
using System.Collections.Generic;
using UnityEngine;

public class AddTempTimeline : MonoBehaviour
{
	[Serializable]
	public class TempTimeline
	{
		public string Name;

		public string ClockName;

		public bool AddToChildren;
	}

	public List<TempTimeline> ObjectsToAdd;

	private List<Behaviour> timelineAdded;

	private bool applicationIsQuitting;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
