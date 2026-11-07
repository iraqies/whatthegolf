using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class TimelineChild : TimelineEffector
	{
		public Timeline parent { get; private set; }

		protected override Timeline timeline => null;

		protected override void Awake()
		{
		}

		public void CacheParent()
		{
		}
	}
}
