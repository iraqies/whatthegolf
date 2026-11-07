using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	public class GlobalClock : Clock
	{
		protected HashSet<Clock> clocks;

		protected HashSet<Timeline> timelines;

		[SerializeField]
		private string _key;

		public string key
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal virtual void Register(Timeline timeline)
		{
		}

		internal virtual void Unregister(Timeline timeline)
		{
		}

		internal virtual void Register(Clock clock)
		{
		}

		internal virtual void Unregister(Clock clock)
		{
		}
	}
}
