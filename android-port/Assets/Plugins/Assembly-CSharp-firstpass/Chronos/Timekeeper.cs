using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class Timekeeper : Singleton<Timekeeper>
	{
		public const int DefaultMaxParticleLoops = 10;

		[SerializeField]
		private bool _debug;

		[SerializeField]
		private int _maxParticleLoops;

		protected Dictionary<string, GlobalClock> _clocks;

		public bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int maxParticleLoops
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IEnumerable<GlobalClock> clocks => null;

		internal static float unscaledDeltaTime => 0f;

		public Timekeeper()
			: base(false, false)
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual bool HasClock(string key)
		{
			return false;
		}

		public virtual GlobalClock Clock(string key)
		{
			return null;
		}

		public virtual GlobalClock AddClock(string key)
		{
			return null;
		}

		public virtual void RemoveClock(string key)
		{
		}

		internal static TimeState GetTimeState(float timeScale)
		{
			return TimeState.Accelerated;
		}
	}
}
