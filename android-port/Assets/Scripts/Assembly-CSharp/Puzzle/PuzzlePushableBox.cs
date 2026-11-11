using UnityEngine;

namespace Puzzle
{
	public class PuzzlePushableBox : PuzzleObjectBase
	{
		public float speed;

		public LayerMask layerMask;

		private Rigidbody2D rb;

		private Vector2 newPos;

		private Vector2 resolveTo;

		private bool resolveCollision;

		private void Awake()
		{
			rb = GetComponent<Rigidbody2D>();
		}

		public override void ResetObject()
		{
			if (rb != null)
			{
				rb.velocity = Vector2.zero;
			}
			base.ResetObject();
		}

		private void FixedUpdate()
		{
			if (resolveCollision && rb != null)
			{
				rb.MovePosition(resolveTo);
				rb.velocity = Vector2.zero;
				resolveCollision = false;
			}
		}

		private void LateUpdate()
		{
			if (rb != null)
			{
				newPos = rb.position;
				if (rb.velocity.magnitude > 0.1f)
				{
					resolveCollision = AnyHit(rb.velocity.normalized);
				}
			}
		}

		private bool AnyHit(Vector2 _dir)
		{
			if (rb == null)
			{
				return false;
			}
			float distance = rb.velocity.magnitude * Time.fixedDeltaTime + 0.2f;
			Vector3 localScale = base.transform.localScale;
			Vector2 origin = newPos + new Vector2(_dir.x * localScale.x * 0.5f, _dir.y * localScale.y * 0.5f) + _dir * 0.01f;
			RaycastHit2D raycastHit2D = Physics2D.Raycast(origin, _dir, distance, layerMask);
			if (raycastHit2D.collider != null)
			{
				PuzzlePushableBox component = raycastHit2D.collider.GetComponent<PuzzlePushableBox>();
				if (component != null)
				{
					Vector3 position = component.transform.position;
					Vector3 localScale2 = component.transform.localScale;
					resolveTo = new Vector2(position.x - _dir.x * localScale2.x, position.y - _dir.y * localScale2.y);
				}
				else
				{
					Vector2 point = raycastHit2D.point;
					Vector2 normalized = rb.velocity.normalized;
					Vector3 localScale3 = base.transform.localScale;
					resolveTo = new Vector2(point.x - normalized.x * localScale3.x * 0.5f, point.y - normalized.y * localScale3.y * 0.5f);
				}
				return true;
			}
			return false;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null && collision.gameObject.GetComponent<OverworldBall2D>() != null && collision.contacts != null && collision.contacts.Length != 0)
			{
				Vector2 vector = PuzzleUtility.SnapTo(collision.contacts[0].normal, 0f, 90f);
				if (!AnyHit(vector) && rb != null)
				{
					rb.velocity = vector * speed;
				}
			}
		}
	}
}
