using System.Linq;
using UnityEngine;

namespace Core
{
	public class RollingCowShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float jumpForce;

		[SerializeField]
		public float dashForce;

		[SerializeField]
		public bool doJumpOnShoot;

		[SerializeField]
		public bool doDashOnShoot;

		[SerializeField]
		public bool onlyPushSpecificTag;

		[SerializeField]
		public string specifiedTag;

		[SerializeField]
		private bool onlyAddTorqueWhenGrounded;

		[SerializeField]
		private LayerMask groundLayer;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool _remoteControlled;

		private Vector3 _remoteControlDirection;

		private bool didAim;

		public float impactForceMultiplier = 2f;

		private Collider[] _childColliders;

		private bool grounded;

		private float _lastPush;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
			var myCol = GetComponent<Collider>();
			_childColliders = GetComponentsInChildren<Collider>();
			if (_childColliders != null && myCol != null)
			{
				for (int i = 0; i < _childColliders.Length; i++)
				{
					if (_childColliders[i] != null && _childColliders[i] != myCol)
						Physics.IgnoreCollision(myCol, _childColliders[i]);
				}
			}
		}

		private void OnEnable()
		{
			if (rigidbodyC == null)
				rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
			var myCol = GetComponent<Collider>();
			if (myCol != null)
			{
				_childColliders = GetComponentsInChildren<Collider>();
				if (_childColliders != null)
				{
					for (int i = 0; i < _childColliders.Length; i++)
					{
						if (_childColliders[i] != null && _childColliders[i] != myCol)
							Physics.IgnoreCollision(myCol, _childColliders[i]);
					}
				}
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (!onlyAimArrow)
			{
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
				lastShootVelocity = boost.normalized * speed;
				isAiming = true;
			}
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			didAim = true;
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (rigidbodyC == null)
				rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
			if (rigidbodyC == null)
				return;

			if (doJumpOnShoot)
			{
				rigidbodyC.velocity *= 0.5f;
				rigidbodyC.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			}
			else if (doDashOnShoot)
			{
				rigidbodyC.AddForce(boost.normalized * dashForce + Vector3.up * jumpForce, ForceMode.Impulse);
			}
			else
			{
				rigidbodyC.angularVelocity = Vector3.zero;
				float mag = boost.magnitude;
				Vector3 n = boost.normalized;
				Vector3 flat = new Vector3(n.x * mag, mag, n.z * mag);
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, flat.magnitude);
				lastShootVelocity = flat.normalized * speed;
			}
			didAim = true;
			isAiming = false;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (Time.time < _lastPush + 0.3f)
				return;
			if (_childColliders == null || collision == null || collision.collider == null)
				return;
			if (_childColliders.Contains(collision.collider))
				return;
			Rigidbody otherRb = collision.rigidbody;
			if (otherRb == null || otherRb.isKinematic)
				return;
			if (onlyPushSpecificTag && collision.collider.tag != specifiedTag)
				return;

			float mass = otherRb.mass;
			Vector3 relVel = collision.relativeVelocity;
			Vector3 force = Vector3.up * (impactForceMultiplier * 300f) - relVel * (mass * impactForceMultiplier);
			if (collision.contacts != null && collision.contacts.Length > 0)
			{
				otherRb.AddForceAtPosition(force, collision.contacts[0].point, ForceMode.Impulse);
			}
			_lastPush = Time.time;
		}

		private void OnCollisionStay(Collision other)
		{
			if (other == null || other.gameObject == null)
				return;
			if (((groundLayer.value >> other.gameObject.layer) & 1) != 0)
				grounded = true;
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (rigidbodyC == null)
				return;

			if (_remoteControlled)
			{
				rigidbodyC.AddTorque(Vector3.Cross(Vector3.up, _remoteControlDirection) * fullShootVelocity);
				return;
			}

			if (didAim)
			{
				if (isAiming && (!onlyAddTorqueWhenGrounded || grounded))
				{
					rigidbodyC.AddTorque(Vector3.Cross(Vector3.up, lastShootVelocity) * fullShootVelocity);
				}
				grounded = false;
			}
			else
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}

		public void RemoteControl(Vector3 aimDirection)
		{
			_remoteControlled = true;
			_remoteControlDirection = aimDirection * fullShootVelocity;
		}
	}
}
