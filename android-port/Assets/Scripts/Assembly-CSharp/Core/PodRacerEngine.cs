using System;
using System.Collections;
using UnityEngine;

namespace Core
{
	public class PodRacerEngine : MonoBehaviour
	{
		[SerializeField]
		public ParticleSystem thrusterParticles;

		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[SerializeField]
		public bool useGravity;

		[SerializeField]
		private GolfBallController golfBallController;

		private bool didExplode;

		private ExplosionBarrel barrel;

		public bool didAim;

		public float firstAimTime;

		public bool failLevelOnExplode;

		public Action<GameObject> onExplode;

		public Rigidbody rigidbodyC;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private IEnumerator Boom(GameObject hitObject)
		{
			return null;
		}
	}
}
