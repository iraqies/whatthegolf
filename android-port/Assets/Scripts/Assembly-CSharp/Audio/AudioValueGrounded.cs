using System;
using UnityEngine;

namespace Audio
{
	public class AudioValueGrounded : BaseAudioValue
	{
		[Serializable]
		public class Direction
		{
			public Vector3 direction;

			public bool localAxis;

			public Vector3 GetDirection(Transform transform)
			{
				return default;
			}
		}

		public Transform relativeTransform;

		public Transform[] checkTransforms;

		public Direction[] directions;

		public bool check2DColliders;

		public float distanceToGround;

		public LayerMask layermask;

		public float raycastFrequency;

		private float nextCheckTime;

		protected override bool Use2D => false;

		private float cooldown => 0f;

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

		private bool Grounded()
		{
			return false;
		}
	}
}
