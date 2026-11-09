using Audio.Impact;
using Core;
using UnityEngine;

namespace Audio
{
	public class ImpactUser : MonoBehaviour, ISpatializeDisable
	{
		[SerializeField]
		private bool getFirstRigidbodyInParent;

		[SerializeField]
		private bool sizeAffects;

		[SerializeField]
		private ObjectWeight objectSize;

		[SerializeField]
		private bool disableOnOutOfBounds;

		[SerializeField]
		private float startDelay;

		[SerializeField]
		public ImpactAsset impactAsset;

		private float nextPlayTime;

		private bool isCollisionWithPlayer;

		private bool isMultiplayerLevel;

		private int layerMaskGolfBall;

		public bool GetFirstRigidbodyInParent => getFirstRigidbodyInParent;

		public bool SizeAffects => sizeAffects;

		public ObjectWeight ObjectSize => objectSize;

		public bool DisableOnOutOfBounds => disableOnOutOfBounds;

		public float StartDelay => startDelay;

		public bool IsEnabled { get; set; } = true;

		public bool DisableSpatial { get; set; }

		private void Start()
		{
			isMultiplayerLevel = Level.HasInstance && Level.Instance != null && Level.Instance.IsMultiplayer;
		}

		private void Awake()
		{
			IsEnabled = true;
			nextPlayTime = Time.time + startDelay;
			layerMaskGolfBall = LayerMask.NameToLayer("GolfBall");
			if (getFirstRigidbodyInParent)
			{
				var rb = GetComponentInParent<Rigidbody>();
				if (rb != null && rb.gameObject != gameObject)
				{
					var ci = RigidbodyCollisionInfo.GetOrAdd(rb.gameObject);
					if (ci != null)
					{
						ci.onCollision -= OnHit;
						ci.onCollision += OnHit;
					}
				}
				var rb2d = GetComponentInParent<Rigidbody2D>();
				if (rb2d != null && rb2d.gameObject != gameObject)
				{
					var ci2 = RigidbodyCollisionInfo.GetOrAdd(rb2d.gameObject);
					if (ci2 != null)
					{
						ci2.onCollision -= OnHit;
						ci2.onCollision += OnHit;
					}
				}
			}
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
			if (collision != null)
				OnHit(AudioUtility.GetHitInfo(collision));
		}

		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null)
				OnHit(AudioUtility.GetHitInfo(collision));
		}

		protected virtual bool Validate(HitInfo info)
		{
			if (!IsEnabled || impactAsset == null)
				return false;
			if (Time.time < nextPlayTime)
				return false;
			return true;
		}

		public void OnHit(HitInfo info)
		{
			if (!Validate(info))
				return;
			isCollisionWithPlayer = info.otherHit != null && info.otherHit.layer == layerMaskGolfBall;
			DisableSpatial = !isMultiplayerLevel && isCollisionWithPlayer;
			if (impactAsset.OnCollision(info, this))
			{
				nextPlayTime = Time.time + 0.05f;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (disableOnOutOfBounds && other != null && (other.CompareTag("OutOfBounds") || other.CompareTag("Water") || other.CompareTag("Lava")))
			{
				IsEnabled = false;
			}
		}
	}
}
