using Audio;
using UnityEngine;

namespace Arena
{
	public abstract class ArenaDroppable : MonoBehaviour
	{
		public Rigidbody Rigidbody;

		public ParticleSystem destroyDropParticles;

		public AudioEventAsset swooshSfx;

		public AudioEventAsset crashSfx;

		public ClipSettingsCollection hitPlayerSFX;

		protected Animator animator;

		public Vector2 GridPosition { get; set; }

		public void PlaySwoosh()
		{
			if (swooshSfx != null)
			{
				AudioManager.PlaySFX(swooshSfx, transform.position);
			}
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Awake()
		{
			if (Rigidbody == null)
			{
				Rigidbody = GetComponent<Rigidbody>();
			}
			animator = GetComponentInChildren<Animator>();
		}

		public void CheckHits()
		{
			Collider[] cols = GetHitColliders();
			if (cols == null)
			{
				return;
			}
			for (int i = 0; i < cols.Length; i++)
			{
				if (cols[i] == null)
				{
					continue;
				}
				ArenaCrab crab = cols[i].GetComponentInParent<ArenaCrab>();
				if (crab != null)
				{
					crab.OnDroppedOnCrab(this);
					HitPlayer();
				}
			}
		}

		public virtual Collider[] GetHitColliders()
		{
			return Physics.OverlapSphere(transform.position, 1.5f);
		}

		public virtual void HitPlayer()
		{
			if (hitPlayerSFX != null)
			{
				hitPlayerSFX.Play(null, transform.position, 1f, 1f);
			}
		}

		public virtual void HitGround()
		{
			if (crashSfx != null)
			{
				AudioManager.PlaySFX(crashSfx, transform.position);
			}
			if (destroyDropParticles != null)
			{
				destroyDropParticles.Play();
			}
			CheckHits();
		}
	}
}
