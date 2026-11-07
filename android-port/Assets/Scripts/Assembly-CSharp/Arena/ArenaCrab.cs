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
		private float squashDuration;

		[SerializeField]
		private float squashSlowFactor;

		[SerializeField]
		private AudioEventAsset _sfxOnSquash;

		[SerializeField]
		private AudioEventAsset _sfxOnUnsquash;

		[SerializeField]
		private ParticleSystem squashParticles;

		[SerializeField]
		private ImpactAsset gruntOnHit;

		[SerializeField]
		private float initialPushMultiplier;

		[SerializeField]
		private ForceMode initialPushForceMode;

		[SerializeField]
		private float updateForceMultiplier;

		[SerializeField]
		private ForceMode updateForceMode;

		[SerializeField]
		private ImpactAsset sfxOnPush;

		[SerializeField]
		private float regainShootVelocityTime;

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

		public PushState CurrentPushState { get; private set; }

		public event Action<ArenaDroppable, ArenaCrab> OnCrabHit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GolfBallController GetController()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnCrabShoot(Vector3 boost)
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		public void DoPush(Vector3 incomingVelocity, Vector3 direction)
		{
		}

		public void OnDroppedOnCrab(ArenaDroppable dropped)
		{
		}

		public void Squash()
		{
		}

		private void Recover()
		{
		}

		private IEnumerator SquashCoroutine()
		{
			return null;
		}
	}
}
