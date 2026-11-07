using System;
using System.Collections.Generic;

namespace Audio.Rumble
{
	[Serializable]
	public class RumbleCollection : IPlayableClipCollection
	{
		public CollectionPlayMode PlayMode;

		public List<RumbleFileSetting> Rumbles;

		public CollectionPlayMode GetPlayMode => CollectionPlayMode.RandomNonRepeating;

		public int LastCollectionIndex { get; set; }

		public int Count => 0;
	}
}
