using System;
using System.Collections.Generic;
using Chronos;
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
		timelineAdded = new List<Behaviour>();
		if (ObjectsToAdd == null)
		{
			return;
		}
		foreach (TempTimeline item in ObjectsToAdd)
		{
			if (item == null)
			{
				continue;
			}
			GameObject go = GameObject.Find(item.Name);
			if (go == null || go.GetComponent<Timeline>() != null)
			{
				continue;
			}
			Timeline timeline = go.AddComponent<Timeline>();
			timeline.mode = TimelineMode.Global;
			timeline.globalClockKey = item.ClockName;
			timeline.rewindable = false;
			timelineAdded.Add(timeline);
			if (!item.AddToChildren)
			{
				continue;
			}
			foreach (Transform child in go.transform)
			{
				if (child != null)
				{
					TimelineChild childTimeline = child.gameObject.AddComponent<TimelineChild>();
					timelineAdded.Add(childTimeline);
				}
			}
		}
	}

	private void OnDestroy()
	{
		if (applicationIsQuitting || timelineAdded == null)
		{
			return;
		}
		foreach (Behaviour b in timelineAdded)
		{
			if (b != null)
			{
				AudioSource src = b.gameObject.GetComponent<AudioSource>();
				if (src != null)
				{
					src.pitch = 1f;
				}
				UnityEngine.Object.Destroy(b);
			}
		}
	}

	private void OnApplicationQuit()
	{
		applicationIsQuitting = true;
	}
}
