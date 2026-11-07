using UnityEngine;

namespace Chronos
{
	public abstract class Recorder<TSnapshot> : MonoBehaviour
	{
		private class DelegatedRecorder : RecorderTimeline<Component, TSnapshot>
		{
			private Recorder<TSnapshot> parent;

			public DelegatedRecorder(Recorder<TSnapshot> parent, Timeline timeline)
				: base((Timeline)null, (Component)null)
			{
			}

			protected override void ApplySnapshot(TSnapshot snapshot)
			{
			}

			protected override TSnapshot CopySnapshot()
			{
				return default;
			}

			protected override TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t)
			{
				return default;
			}
		}

		private bool enabledOnce;

		private Timeline timeline;

		private RecorderTimeline<Component, TSnapshot> recorder;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void ModifySnapshots(RecorderTimeline<Component, TSnapshot>.SnapshotModifier modifier)
		{
		}

		protected abstract void ApplySnapshot(TSnapshot snapshot);

		protected abstract TSnapshot CopySnapshot();

		protected abstract TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t);

		public virtual void CacheComponents()
		{
		}
	}
}
