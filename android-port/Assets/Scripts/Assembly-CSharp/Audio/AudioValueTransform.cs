using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AudioValueTransform : BaseAudioValue
	{
		public enum TransformListenType
		{
			LocalScaleX = 0,
			LocalScaleY = 1,
			LocalScaleZ = 2,
			LocalScaleMagnitude = 3,
			MovementDelta = 4,
			MovementDeltaAverage = 5
		}

		public Transform target;

		public TransformListenType listenType;

		private Vector3 lastPosition;

		private Queue<float> positionDeltas;

		private int sampleSize;

		protected override bool Use2D => false;

		private void Update()
		{
		}

		public override string ValueInputName()
		{
			return null;
		}

		protected override void SetValue()
		{
		}

		private void MovementDeltaAverage()
		{
		}
	}
}
