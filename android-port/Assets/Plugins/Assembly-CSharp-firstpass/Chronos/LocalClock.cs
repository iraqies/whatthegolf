using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class LocalClock : Clock
	{
		protected Timeline timeline;

		protected override void Awake()
		{
		}

		public virtual void CacheComponents()
		{
		}
	}
}
