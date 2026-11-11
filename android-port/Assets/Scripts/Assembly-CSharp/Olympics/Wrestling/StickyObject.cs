using RootMotion.Dynamics;
using UnityEngine;

namespace Olympics.Wrestling
{
	public class StickyObject : MonoBehaviour
	{
		public struct StickInfo
		{
			public Transform stickTo;

			public Vector3 offsetOnTransform;

			public MuscleCollisionBroadcaster muscle;
		}

		[SerializeField]
		private float unpin = 10f;

		[SerializeField]
		private float multiplier = 15f;

		[SerializeField]
		private LayerMask stickToLayer;

		[SerializeField]
		private bool stickToOtherStickyObjects;

		private Rigidbody stickyRigidbody;

		private Collider stickyCollider;

		private Vector3 Velocity;

		private bool stickNextFrame;

		private StickInfo stickInfo;

		public Rigidbody StuckOn { get; private set; }

		private void Awake()
		{
			stickyRigidbody = GetComponent<Rigidbody>();
			stickyCollider = GetComponent<Collider>();
		}

		private void FixedUpdate()
		{
			if (stickyRigidbody == null)
			{
				return;
			}
			if (stickNextFrame)
			{
				transform.SetParent(stickInfo.stickTo);
				stickyRigidbody.isKinematic = true;
				if (stickyCollider != null)
				{
					Object.Destroy(stickyCollider);
				}
			}
			Velocity = stickyRigidbody.velocity;
			stickNextFrame = false;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (stickNextFrame || stickyRigidbody == null || Velocity.sqrMagnitude < 45f || collision == null || collision.rigidbody == null)
			{
				return;
			}
			if (CheckMask(collision.gameObject))
			{
				collision.gameObject.TryGetComponent<MuscleCollisionBroadcaster>(out MuscleCollisionBroadcaster muscle);
				ContactPoint cp = collision.GetContact(0);
				stickNextFrame = true;
				stickInfo = new StickInfo
				{
					stickTo = collision.transform,
					offsetOnTransform = collision.transform.position - cp.point,
					muscle = muscle
				};
			}
		}

		private bool CheckMask(GameObject go)
		{
			if (go == null)
			{
				return false;
			}
			return ((stickToLayer.value >> go.layer) & 1) == 0;
		}
	}
}
