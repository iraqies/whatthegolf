using UnityEngine;

namespace GolfHero
{
	public class GolfHeroAnimator : MonoBehaviour
	{
		[SerializeField]
		private GolfHeroSequencer sequencer;

		[SerializeField]
		private float beatDuration;

		[SerializeField]
		private AnimationCurve xRotation;

		[SerializeField]
		private AnimationCurve yRotation;

		[SerializeField]
		private AnimationCurve zRotation;

		private void Update()
		{
		}
	}
}
