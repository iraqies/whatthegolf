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
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void Awake()
		{
		}

		public void CheckHits()
		{
		}

		public virtual Collider[] GetHitColliders()
		{
			return null;
		}

		public virtual void HitPlayer()
		{
		}

		public virtual void HitGround()
		{
		}
	}
}
