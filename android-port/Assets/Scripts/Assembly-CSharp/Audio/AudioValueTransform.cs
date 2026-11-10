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

		private int sampleSize = 5;

		protected override bool Use2D => false;

		private void Update()
		{
			if (target != null)
				SetValue();
		}

		public override string ValueInputName()
		{
			string prefix = (target != null && target.gameObject != null) ? (target.gameObject.name + " ") : "";
			return prefix + listenType;
		}

		protected override void SetValue()
		{
			if (target == null) return;
			switch (listenType)
			{
			case TransformListenType.LocalScaleX:
				value = target.localScale.x;
				break;
			case TransformListenType.LocalScaleY:
				value = target.localScale.y;
				break;
			case TransformListenType.LocalScaleZ:
				value = target.localScale.z;
				break;
			case TransformListenType.LocalScaleMagnitude:
				value = target.localScale.magnitude;
				break;
			case TransformListenType.MovementDelta:
				value = (target.position - lastPosition).magnitude;
				lastPosition = target.position;
				break;
			case TransformListenType.MovementDeltaAverage:
				MovementDeltaAverage();
				break;
			}
			base.SetValue();
		}

		private void MovementDeltaAverage()
		{
			if (target == null) return;
			if (positionDeltas == null)
				positionDeltas = new Queue<float>();
			int count = positionDeltas.Count;
			if (count < sampleSize)
			{
				float d = (target.position - lastPosition).magnitude;
				lastPosition = target.position;
				positionDeltas.Enqueue(d);
			}
			else
			{
				float sum = 0f;
				while (positionDeltas.Count > 0)
					sum += positionDeltas.Dequeue();
				if (count > 0)
					value = sum / count;
			}
		}
	}
}
