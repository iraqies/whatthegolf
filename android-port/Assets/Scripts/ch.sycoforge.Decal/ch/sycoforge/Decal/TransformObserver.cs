using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	internal class TransformObserver
	{
		[SerializeField]
		private Vector3 lastPosition;

		[SerializeField]
		private Vector3 lastScale;

		[SerializeField]
		private Quaternion lastRotation;

		[SerializeField]
		private Transform transform;

		public TransformObserver(Transform transform)
		{
		}

		public OrientationChange CheckTransformChange()
		{
			return OrientationChange.None;
		}
	}
}
