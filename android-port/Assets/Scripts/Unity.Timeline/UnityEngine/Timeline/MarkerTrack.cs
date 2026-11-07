using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class MarkerTrack : TrackAsset
	{
		public override IEnumerable<PlayableBinding> outputs => null;
	}
}
