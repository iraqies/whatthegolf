using UnityEngine;

namespace Chronos
{
	public class AnimatorTimeline : ComponentTimeline<Animator>
	{
		private float _speed;

		public float speed => 0f;

		private int recordedFrames => 0;

		public AnimatorTimeline(Timeline timeline, Animator component)
			: base((Timeline)null, (Animator)null)
		{
		}

		public override void CopyProperties(Animator source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}

		public override void OnStartOrReEnable()
		{
		}

		public override void OnDisable()
		{
		}

		public override void Update()
		{
		}
	}
}
