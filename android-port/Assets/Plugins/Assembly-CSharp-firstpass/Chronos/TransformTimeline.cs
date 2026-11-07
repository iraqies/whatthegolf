using UnityEngine;

namespace Chronos
{
	public class TransformTimeline : RecorderTimeline<Transform, TransformTimeline.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;

			public Quaternion rotation;

			public static Snapshot Lerp(Snapshot from, Snapshot to, float t)
			{
				return default;
			}
		}

		public TransformTimeline(Timeline timeline, Transform component)
			: base((Timeline)null, (Transform)null)
		{
		}

		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		protected override Snapshot CopySnapshot()
		{
			return default;
		}

		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}
	}
}
