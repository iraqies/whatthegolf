using Audio.Impact;
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

		public bool GetFirstRigidbodyInParent => false;

		public bool SizeAffects => false;

		public ObjectWeight ObjectSize => ObjectWeight.Light;

		public bool DisableOnOutOfBounds => false;

		public float StartDelay => 0f;

		public bool IsEnabled { get; set; }

		public bool DisableSpatial { get; set; }

		private void Start()
		{
		}

		private void Awake()
		{
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		protected virtual bool Validate(HitInfo info)
		{
			return false;
		}

		public void OnHit(HitInfo info)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
