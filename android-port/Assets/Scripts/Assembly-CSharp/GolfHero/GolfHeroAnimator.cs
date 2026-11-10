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
		private AnimationCurve xRotation = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		private AnimationCurve yRotation = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		private AnimationCurve zRotation = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		private void Update()
		{
			if (sequencer == null || !sequencer.IsRunning || beatDuration <= 0f)
				return;

			float t = (float)(sequencer.BeatTime % beatDuration) / beatDuration;
			float rx = xRotation != null ? xRotation.Evaluate(t) : 0f;
			float ry = yRotation != null ? yRotation.Evaluate(t) : 0f;
			float rz = zRotation != null ? zRotation.Evaluate(t) : 0f;
			base.transform.localRotation = Quaternion.Euler(rx, ry, rz);
		}
	}
}
