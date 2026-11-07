using System;
using System.Collections.Generic;

namespace Amazon.Util
{
	public class CircularReferenceTracking
	{
		private class Tracker : IDisposable
		{
			private bool disposed;

			public object Target { get; private set; }

			private CircularReferenceTracking State { get; set; }

			public Tracker(CircularReferenceTracking state, object target)
			{
			}

			public override string ToString()
			{
				return null;
			}

			protected virtual void Dispose(bool disposing)
			{
			}

			public void Dispose()
			{
			}

			~Tracker()
			{
			}
		}

		private object referenceTrackersLock;

		private Stack<Tracker> referenceTrackers;

		public IDisposable Track(object target)
		{
			return null;
		}

		private void PopTracker(Tracker tracker)
		{
		}

		private bool TrackerExists(object target)
		{
			return false;
		}
	}
}
