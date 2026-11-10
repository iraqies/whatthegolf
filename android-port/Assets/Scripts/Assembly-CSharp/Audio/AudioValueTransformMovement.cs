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
			if (listenTransform != null)
				lastPosition = listenTransform.position;
		}

		private void Update()
		{
			if (listenTransform != null)
				SetValue();
		}

		protected override void SetValue()
		{
			if (listenTransform == null) return;
			value = Vector3.Distance(listenTransform.position, lastPosition);
			lastPosition = listenTransform.position;
			base.SetValue();
		}
	}
}
