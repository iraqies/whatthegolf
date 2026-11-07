using System.Collections.Generic;
using Chronos.Reflection;
using UnityEngine;

namespace Chronos
{
	public class CustomRecorder : Recorder<CustomRecorder.Snapshot>
	{
		public class Snapshot
		{
			public object[] values { get; private set; }

			public Snapshot(int size)
			{
			}
		}

		[SerializeField]
		private List<UnityVariable> variables;

		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}

		protected override Snapshot CopySnapshot()
		{
			return null;
		}

		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return null;
		}

		private static object LerpValue(object from, object to, float t)
		{
			return null;
		}
	}
}
