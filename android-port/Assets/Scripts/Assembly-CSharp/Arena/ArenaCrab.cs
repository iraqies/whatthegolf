using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Impact;
using Core;
using UnityEngine;

namespace Arena
{
	public class ArenaCrab : MonoBehaviour
	{
		public enum PushState
		{
			Push = 0,
			Recovering = 1,
			None = 2
		}

		[SerializeField]
		private Transform modelContainer;

		[SerializeField]
		private float squashDuration = 2f;

		[SerializeField]
		private float squashSlowFactor = 0.4f;

		[SerializeField]
		private AudioEventAsset _sfxOnSquash;

		[SerializeField]
		private AudioEventAsset _sfxOnUnsquash;

		[SerializeField]
		private ParticleSystem squashParticles;

		[SerializeField]
		private ImpactAsset gruntOnHit;

		[SerializeField]
		private float initialPushMultiplier = 1.5f;

		[SerializeField]
		private ForceMode initialPushForceMode = ForceMode.VelocityChange;

		[SerializeField]
		private float updateForceMultiplier = 5f;

		[SerializeField]
		private ForceMode updateForceMode = ForceMode.Acceleration;

		[SerializeField]
		private ImpactAsset sfxOnPush;

		[SerializeField]
		private float regainShootVelocityTime = 0.5f;

		private Rigidbody _rigidbody;

		private Transform _transform;

		private ArenaCrabShooter _shooter;

		private float _maxSpeed;

		private float _maxLegMoveSpeed;

		private Vector3 _scale;

		private WaitForSeconds _squashWait;

		private List<ArenaCrab> touchingCrabs;

		[CompilerGenerated]
		private Action<ArenaDroppable, ArenaCrab> m_OnCrabHit;

		public bool IsBeingPushed { get; private set; }

		public bool isSquashed { get; private set; }

		public Vector3 Velocity { get; private set; }

		public float LastPushTime { get; private set; }

		public float PushForce { get; private set; }

		public Vector3 PushDirection { get; private set; }

		public PushState CurrentPushState { get; private set; } = PushState.None;

		public event Action<ArenaDroppable, ArenaCrab> OnCrabHit
		{
			[CompilerGenerated]
			add
			{
				m_OnCrabHit = (Action<ArenaDroppable, ArenaCrab>)Delegate.Combine(m_OnCrabHit, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnCrabHit = (Action<ArenaDroppable, ArenaCrab>)Delegate.Remove(m_OnCrabHit, value);
			}
		}

		public GolfBallController GetController()
		{
			return GetComponent<GolfBallController>();
		}

		private void Start()
		{
			_transform = transform;
			_rigidbody = GetComponent<Rigidbody>();
			_shooter = GetComponent<ArenaCrabShooter>();
			touchingCrabs = new List<ArenaCrab>();
			_scale = modelContainer != null ? modelContainer.localScale : transform.localScale;
			_squashWait = new WaitForSeconds(Mathf.Max(0.2f, squashDuration));
			if (_shooter != null)
			{
				_maxSpeed = _shooter.fullShootVelocity;
				if (_shooter.Legs != null)
				{
					_maxLegMoveSpeed = _shooter.Legs.FeetMoveSpeed;
				}
			}
			GolfBallController ctrl = GetController();
			if (ctrl != null)
			{
				ctrl.OnShoot += OnCrabShoot;
			}
		}

		private void OnCrabShoot(Vector3 boost)
		{
			CurrentPushState = PushState.None;
			IsBeingPushed = false;
		}

		private void FixedUpdate()
		{
			if (_rigidbody != null)
			{
				Velocity = _rigidbody.velocity;
			}
			if (CurrentPushState == PushState.Push)
			{
				if (Time.time - LastPushTime > regainShootVelocityTime)
				{
					CurrentPushState = PushState.Recovering;
					IsBeingPushed = false;
					if (_shooter != null)
					{
						_shooter.UseAddForce = false;
					}
				}
				else if (_rigidbody != null)
				{
					_rigidbody.AddForce(PushDirection * updateForceMultiplier, updateForceMode);
				}
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null)
			{
				return;
			}
			ArenaCrab other = collision.gameObject.GetComponentInParent<ArenaCrab>();
			if (other != null && other != this)
			{
				if (!touchingCrabs.Contains(other))
				{
					touchingCrabs.Add(other);
				}
				if (Velocity.sqrMagnitude > other.Velocity.sqrMagnitude)
				{
					other.DoPush(Velocity, (other.transform.position - transform.position).normalized);
				}
			}
		}

		private void OnCollisionExit(Collision collision)
		{
			if (collision == null)
			{
				return;
			}
			ArenaCrab other = collision.gameObject.GetComponentInParent<ArenaCrab>();
			if (other != null)
			{
				touchingCrabs.Remove(other);
			}
		}

		public void DoPush(Vector3 incomingVelocity, Vector3 direction)
		{
			IsBeingPushed = true;
			CurrentPushState = PushState.Push;
			LastPushTime = Time.time;
			PushDirection = new Vector3(direction.x, 0f, direction.z).normalized;
			PushForce = incomingVelocity.magnitude * initialPushMultiplier;
			if (_shooter != null)
			{
				_shooter.UseAddForce = true;
			}
			if (_rigidbody != null)
			{
				_rigidbody.AddForce(PushDirection * PushForce, initialPushForceMode);
			}
		}

		public void OnDroppedOnCrab(ArenaDroppable dropped)
		{
			m_OnCrabHit?.Invoke(dropped, this);
			Squash();
		}

		public void Squash()
		{
			if (!isSquashed)
			{
				StartCoroutine(SquashCoroutine());
			}
		}

		private void Recover()
		{
			isSquashed = false;
			if (modelContainer != null)
			{
				modelContainer.localScale = _scale;
			}
			if (_shooter != null)
			{
				_shooter.fullShootVelocity = _maxSpeed;
				if (_shooter.Legs != null)
				{
					_shooter.Legs.FeetMoveSpeed = _maxLegMoveSpeed;
				}
			}
			if (_sfxOnUnsquash != null)
			{
				AudioManager.PlaySFX(_sfxOnUnsquash, transform.position);
			}
		}

		private IEnumerator SquashCoroutine()
		{
			isSquashed = true;
			if (_sfxOnSquash != null)
			{
				AudioManager.PlaySFX(_sfxOnSquash, transform.position);
			}
			if (squashParticles != null)
			{
				squashParticles.Play();
			}
			if (modelContainer != null)
			{
				modelContainer.localScale = new Vector3(_scale.x * 1.3f, _scale.y * 0.35f, _scale.z * 1.3f);
			}
			if (_shooter != null)
			{
				_shooter.fullShootVelocity = _maxSpeed * squashSlowFactor;
				if (_shooter.Legs != null)
				{
					_shooter.Legs.FeetMoveSpeed = _maxLegMoveSpeed * squashSlowFactor;
				}
			}
			yield return _squashWait;
			Recover();
		}
	}
}
