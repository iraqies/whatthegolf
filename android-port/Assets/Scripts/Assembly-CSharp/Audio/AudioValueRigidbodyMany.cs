using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AudioValueRigidbodyMany : BaseAudioValue
	{
		public List<Rigidbody> rigid;

		public List<Rigidbody2D> rigid2D;

		public AudioSource audioSource;

		public bool moveAudioSourceToMiddlePosition;

		public float PositionChangeSpeed;

		public float minVelocityThreshold;

		public bool removeOnOutOfBounds;

		public float groundCheckFrequency;

		public float groundCheckDistance;

		public LayerMask groundIs;

		public float averageVelocity;

		private List<Rigidbody> currentRigids;

		private List<Rigidbody2D> currentRigids2D;

		private Vector3 middlePosition;

		private Vector3 lastPosition;

		private float groundCheckTimer;

		private float groundCheckCooldown => 0f;

		protected override bool Use2D => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void SetValue()
		{
		}

		private void SetValuesFrom3D()
		{
		}

		private void SetValuesFrom2D()
		{
		}

		private void GroundCheck3D()
		{
		}

		private void GroundCheck2D()
		{
		}

		private void OnAnyOutOfBounds(TriggerInfo info)
		{
		}

		private bool OutOfBounds(GameObject otherHit)
		{
			return false;
		}
	}
}
