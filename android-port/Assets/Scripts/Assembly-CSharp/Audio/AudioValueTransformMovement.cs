using UnityEngine;

namespace Audio
{
	public class AudioValueTransformMovement : BaseAudioValue
	{
		public Transform listenTransform;

		private Vector3 lastPosition;

		protected override bool Use2D => false;

		protected override void Initialize()
		{
		}

		private void Update()
		{
		}

		protected override void SetValue()
		{
		}
	}
}
