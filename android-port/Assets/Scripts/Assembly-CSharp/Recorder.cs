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
			return default;
		}

		public static bool TryGetSnapshotAt(List<Snapshot> snapshots, float t, out Snapshot snapshot)
		{
			snapshot = default;
			return false;
		}

		public static bool TryGetInterpolatedSnapshot(List<Snapshot> snapshots, out Snapshot interpolatedSnapshot, float time)
		{
			interpolatedSnapshot = default;
			return false;
		}
	}

	public List<Snapshot> Snapshots;

	private TimeTravelController timeController;

	private void Start()
	{
	}

	private void RecordSnapshot()
	{
	}

	public void Reset()
	{
	}
}
