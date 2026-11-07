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
		private float unpin;

		[SerializeField]
		private float multiplier;

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
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private bool CheckMask(GameObject go)
		{
			return false;
		}
	}
}
