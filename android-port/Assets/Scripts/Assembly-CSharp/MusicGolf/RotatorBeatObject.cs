using UnityEngine;

namespace MusicGolf
{
	public class RotatorBeatObject : BeatObject
	{
		[SerializeField]
		private Rigidbody2D rigidbody2D;

		[SerializeField]
		private AnimationCurve rotationCurve;

		[SerializeField]
		private bool isUsingSceneRotationAsStartRotation;

		private Quaternion startRotation;

		private float startAngleOffset;

		public override void PlayStart()
		{
		}

		public override void PlayProgress(float t)
		{
		}
	}
}
