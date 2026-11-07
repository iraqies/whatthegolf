using UnityEngine;

namespace Chronos
{
	public class NonRewindableParticleSystemTimeline : ComponentTimeline<ParticleSystem>, IParticleSystemTimeline, IComponentTimeline
	{
		private bool warnedRewind;

		private float _playbackSpeed;

		public float playbackSpeed => 0f;

		public NonRewindableParticleSystemTimeline(Timeline timeline, ParticleSystem component)
			: base((Timeline)null, (ParticleSystem)null)
		{
		}

		public override void CopyProperties(ParticleSystem source)
		{
		}

		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
