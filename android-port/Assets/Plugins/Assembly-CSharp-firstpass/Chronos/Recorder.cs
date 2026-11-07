using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002A1")]
	public abstract class Recorder<TSnapshot> : MonoBehaviour
	{
		[Token(Token = "0x20002A2")]
		private class DelegatedRecorder : RecorderTimeline<Component, TSnapshot>
		{
			[Token(Token = "0x4001139")]
			[FieldOffset(Offset = "0x0")]
			private Recorder<TSnapshot> parent;

			[Token(Token = "0x6001168")]
			public DelegatedRecorder(Recorder<TSnapshot> parent, Timeline timeline)
			{
			}

			[Token(Token = "0x6001169")]
			protected override void ApplySnapshot(TSnapshot snapshot)
			{
			}

			[Token(Token = "0x600116A")]
			protected override TSnapshot CopySnapshot()
			{
				return (TSnapshot)null;
			}

			[Token(Token = "0x600116B")]
			protected override TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t)
			{
				return (TSnapshot)null;
			}
		}

		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x0")]
		private bool enabledOnce;

		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x0")]
		private Timeline timeline;

		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x0")]
		private RecorderTimeline<Component, TSnapshot> recorder;

		[Token(Token = "0x600115D")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600115E")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600115F")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6001160")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6001161")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6001162")]
		public virtual void ModifySnapshots(RecorderTimeline<Component, TSnapshot>.SnapshotModifier modifier)
		{
		}

		[Token(Token = "0x6001163")]
		protected abstract void ApplySnapshot(TSnapshot snapshot);

		[Token(Token = "0x6001164")]
		protected abstract TSnapshot CopySnapshot();

		[Token(Token = "0x6001165")]
		protected abstract TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t);

		[Token(Token = "0x6001166")]
		public virtual void CacheComponents()
		{
		}

		[Token(Token = "0x6001167")]
		protected Recorder()
		{
		}
	}
}
