using System.Collections.Generic;
using UnityEngine;

public class Replayer : MonoBehaviour
{
	public bool TimeLineOver;

	public List<Recorder.Snapshot> Snapshots;

	private void Start()
	{
	}

	private void Update()
	{
		if (Snapshots == null || Snapshots.Count == 0)
		{
			return;
		}
		if (Recorder.Snapshot.TryGetInterpolatedSnapshot(Snapshots, out Recorder.Snapshot snap, TimeTravelController.CurrentTime))
		{
			transform.position = snap.Position;
			transform.rotation = snap.Rotation;
		}
	}

	public void Reset()
	{
		TimeLineOver = false;
	}
}
