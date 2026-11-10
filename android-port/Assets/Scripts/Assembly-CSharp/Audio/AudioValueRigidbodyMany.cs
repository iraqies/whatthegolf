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

		public float PositionChangeSpeed = 5f;

		public float minVelocityThreshold = 0.5f;

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

		private float groundCheckCooldown => groundCheckFrequency > 0f ? (1f / groundCheckFrequency) : 0f;

		protected override bool Use2D => rigid2D != null && rigid2D.Count > 0;

		private void Start()
		{
			if (Use2D)
			{
				currentRigids2D = new List<Rigidbody2D>();
				if (rigid2D != null)
					currentRigids2D.AddRange(rigid2D);
			}
			else
			{
				currentRigids = new List<Rigidbody>();
				if (rigid != null)
					currentRigids.AddRange(rigid);
			}
		}

		private void Update()
		{
			SetValue();
			value = averageVelocity;
			if (audioSource != null && moveAudioSourceToMiddlePosition)
			{
				Vector3 pos = Vector3.MoveTowards(audioSource.transform.position, middlePosition, PositionChangeSpeed * Time.deltaTime);
				audioSource.transform.position = pos;
				lastPosition = pos;
			}
			base.SetValue();
		}

		private void FixedUpdate()
		{
			if (groundCheckFrequency > 0f)
			{
				if (groundCheckTimer <= 0f)
				{
					if (Use2D)
						GroundCheck2D();
					else
						GroundCheck3D();
					groundCheckTimer = 1f / groundCheckFrequency;
				}
				groundCheckTimer -= Time.fixedUnscaledDeltaTime;
			}
		}

		protected override void SetValue()
		{
			if (!Use2D)
				SetValuesFrom3D();
			else
				SetValuesFrom2D();
			base.SetValue();
		}

		private void SetValuesFrom3D()
		{
			averageVelocity = 0f;
			Vector3 posSum = Vector3.zero;
			if (currentRigids == null) return;
			int count = 0;
			for (int i = 0; i < currentRigids.Count; i++)
			{
				var r = currentRigids[i];
				if (r == null) continue;
				averageVelocity += r.velocity.magnitude;
				posSum += r.position;
				count++;
			}
			if (count >= 1)
			{
				averageVelocity /= count;
				middlePosition = posSum / count;
			}
			else
			{
				middlePosition = lastPosition;
			}
		}

		private void SetValuesFrom2D()
		{
			averageVelocity = 0f;
			Vector3 posSum = Vector3.zero;
			if (currentRigids2D == null) return;
			int count = 0;
			for (int i = 0; i < currentRigids2D.Count; i++)
			{
				var r = currentRigids2D[i];
				if (r == null) continue;
				averageVelocity += r.velocity.magnitude;
				posSum += (Vector3)r.position;
				count++;
			}
			if (count >= 1)
			{
				averageVelocity /= count;
				middlePosition = posSum / count;
			}
			else
			{
				middlePosition = lastPosition;
			}
		}

		private void GroundCheck3D()
		{
			if (currentRigids == null || rigid == null) return;
			currentRigids.Clear();
			for (int i = 0; i < rigid.Count; i++)
			{
				var r = rigid[i];
				if (r == null) continue;
				if (Physics.Raycast(r.position, Vector3.down, groundCheckDistance, groundIs))
					currentRigids.Add(r);
			}
		}

		private void GroundCheck2D()
		{
			if (currentRigids2D == null || rigid2D == null) return;
			currentRigids2D.Clear();
			for (int i = 0; i < rigid2D.Count; i++)
			{
				var r = rigid2D[i];
				if (r == null) continue;
				if (Physics2D.Raycast(r.position, Vector2.down, groundCheckDistance, groundIs))
					currentRigids2D.Add(r);
			}
		}

		private void OnAnyOutOfBounds(TriggerInfo info)
		{
			if (info.thisHit == null) return;
			if (Use2D)
			{
				var r2d = info.thisHit.GetComponent<Rigidbody2D>();
				if (r2d != null && rigid2D != null && rigid2D.Contains(r2d) && OutOfBounds(info.otherHit))
					rigid2D.Remove(r2d);
			}
			else
			{
				var r3d = info.thisHit.GetComponent<Rigidbody>();
				if (r3d != null && rigid != null && rigid.Contains(r3d) && OutOfBounds(info.otherHit))
					rigid.Remove(r3d);
			}
		}

		private bool OutOfBounds(GameObject otherHit)
		{
			if (otherHit == null) return false;
			return otherHit.CompareTag("Lava") || otherHit.CompareTag("Water") || otherHit.CompareTag("OutOfBounds");
		}
	}
}
