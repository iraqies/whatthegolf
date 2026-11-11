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
			if (Rigidbody != null)
			{
				limbs = Rigidbody.GetComponentsInChildren<Rigidbody>();
				colliders = Rigidbody.GetComponentsInChildren<Collider>();
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			didCheckHits = false;
			SetColliderActiveStatus(true);
		}

		private void FixedUpdate()
		{
			if (Rigidbody == null)
			{
				return;
			}
			if (!didCheckHits && IsAtGround())
			{
				CheckHits();
				Knockup();
				if (animator != null)
				{
					animator.SetTrigger("Fall");
				}
				didCheckHits = true;
				StartCoroutine(RemoveRagdollCoroutine());
			}
		}

		private void Knockup()
		{
			if (Rigidbody != null)
			{
				Rigidbody.MovePosition(transform.position);
				Rigidbody.velocity = Vector3.up * 5f;
				Rigidbody.detectCollisions = true;
			}
		}

		private bool IsAtGround()
		{
			return Rigidbody != null && Rigidbody.position.y <= transform.position.y + 0.5f;
		}

		private bool IsMoving()
		{
			return Rigidbody != null && Rigidbody.velocity.sqrMagnitude > 0.1f;
		}

		private IEnumerator RemoveRagdollCoroutine()
		{
			yield return new WaitForSeconds(2f);
			while (!IsAtGround() || IsMoving())
			{
				yield return null;
			}
			SetRagdollKinematicStatus(true);
			if (Rigidbody != null)
			{
				Vector3 startPos = Rigidbody.position;
				Vector3 endPos = startPos + Vector3.down * 2f;
				float elapsed = 0f;
				while (elapsed < 1f)
				{
					elapsed += Time.deltaTime;
					Rigidbody.MovePosition(Vector3.Lerp(startPos, endPos, Mathf.Clamp01(elapsed)));
					yield return null;
				}
			}
			gameObject.SetActive(false);
		}

		private void SetColliderActiveStatus(bool active)
		{
			if (colliders == null)
			{
				return;
			}
			for (int i = 0; i < colliders.Length; i++)
			{
				if (colliders[i] != null)
				{
					colliders[i].enabled = active;
				}
			}
		}

		private void SetRagdollKinematicStatus(bool active)
		{
			if (limbs == null)
			{
				return;
			}
			for (int i = 0; i < limbs.Length; i++)
			{
				if (limbs[i] != null)
				{
					if (limbs[i].TryGetComponent<Collider>(out Collider col))
					{
						col.enabled = !active;
					}
					limbs[i].isKinematic = active;
					if (active)
					{
						limbs[i].velocity = Vector3.zero;
					}
				}
			}
		}
	}
}
