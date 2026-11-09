using System.Collections;
using UnityEngine;

namespace Arena
{
	public class ArenaDroppableRagdoll : ArenaDroppable
	{
		private Rigidbody[] limbs;

		private Collider[] colliders;

		private bool didCheckHits;

		protected override void Awake()
	{
		base.Awake();
	}

		protected override void OnEnable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Knockup()
		{
		}

		private bool IsAtGround()
		{
			return false;
		}

		private bool IsMoving()
		{
			return false;
		}

		private IEnumerator RemoveRagdollCoroutine()
		{
			return null;
		}

		private void SetColliderActiveStatus(bool active)
		{
		}

		private void SetRagdollKinematicStatus(bool active)
		{
		}
	}
}
