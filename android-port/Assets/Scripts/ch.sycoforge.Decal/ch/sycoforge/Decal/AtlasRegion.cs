using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	public class AtlasRegion
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private Rect region;

		public Rect Region => default;

		public float AspectRatio => 0f;

		public override bool Equals(object other)
		{
			return false;
		}

		public virtual bool Equals(AtlasRegion other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
