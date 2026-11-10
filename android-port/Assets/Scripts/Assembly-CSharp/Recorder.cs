using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
	public struct Snapshot
	{
		public Vector3 Position;

		public Quaternion Rotation;

		public static Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return new Snapshot
			{
				Position = Vector3.Lerp(from.Position, to.Position, t),
				Rotation = Quaternion.Slerp(from.Rotation, to.Rotation, t)
			};
		}

		public static bool TryGetSnapshotAt(List<Snapshot> snapshots, float t, out Snapshot snapshot)
		{
			snapshot = default;
			if (snapshots == null || snapshots.Count == 0)
			{
				return false;
			}
			float interval = Mathf.Max(0.01f, TimeTravelController.Interval);
			int idx = Mathf.Clamp(Mathf.FloorToInt(t / interval), 0, snapshots.Count - 1);
			snapshot = snapshots[idx];
			return true;
		}

		public static bool TryGetInterpolatedSnapshot(List<Snapshot> snapshots, out Snapshot interpolatedSnapshot, float time)
		{
			interpolatedSnapshot = default;
			if (snapshots == null || snapshots.Count == 0)
			{
				return false;
			}
			float interval = Mathf.Max(0.01f, TimeTravelController.Interval);
			float exactIdx = time / interval;
			int i0 = Mathf.Clamp(Mathf.FloorToInt(exactIdx), 0, snapshots.Count - 1);
			int i1 = Mathf.Clamp(i0 + 1, 0, snapshots.Count - 1);
			float frac = Mathf.Clamp01(exactIdx - i0);
			interpolatedSnapshot = LerpSnapshots(snapshots[i0], snapshots[i1], frac);
			return true;
		}
	}

	public List<Snapshot> Snapshots = new List<Snapshot>();

	private TimeTravelController timeController;

	private void Start()
	{
		if (Snapshots == null)
		{
			Snapshots = new List<Snapshot>();
		}
		timeController = Object.FindObjectOfType<TimeTravelController>();
	}

	private void FixedUpdate()
	{
		if (timeController != null && timeController.GameState == TimeTravelController.StateEnum.Running)
		{
			RecordSnapshot();
		}
	}

	private void RecordSnapshot()
	{
		if (Snapshots == null)
		{
			Snapshots = new List<Snapshot>();
		}
		Snapshots.Add(new Snapshot
		{
			Position = transform.position,
			Rotation = transform.rotation
		});
	}

	public void Reset()
	{
		Snapshots?.Clear();
	}
}
