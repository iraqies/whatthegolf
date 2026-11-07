using UnityEngine;

namespace Chronos
{
	public class TrailRendererTimeline : ComponentTimeline<TrailRenderer>
	{
		private float _time;

		public float time => 0f;

		public TrailRendererTimeline(Timeline timeline, TrailRenderer component)
			: base((Timeline)null, (TrailRenderer)null)
		{
		}

		public override void CopyProperties(TrailRenderer source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
