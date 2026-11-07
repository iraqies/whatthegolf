using UnityEngine;

namespace Chronos
{
	public class AnimationTimeline : ComponentTimeline<Animation>
	{
		private float _speed;

		public float speed => 0f;

		public AnimationTimeline(Timeline timeline, Animation component)
			: base((Timeline)null, (Animation)null)
		{
		}

		public override void CopyProperties(Animation source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
