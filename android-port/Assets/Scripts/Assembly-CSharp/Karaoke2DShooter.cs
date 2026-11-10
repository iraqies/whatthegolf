using System;
using Core;
using UnityEngine;

public class Karaoke2DShooter : ShooterBase
{
	[SerializeField]
	private float forwardSpeed = 1f;

	[SerializeField]
	private float jumpSpeed = 1f;

	[SerializeField]
	private float checkY;

	[SerializeField]
	private float checkLength = 1f;

	[SerializeField]
	private float checkRadius = 0.5f;

	[SerializeField]
	private float fallLimit = 0.1f;

	[SerializeField]
	private float groundSkin = 0.1f;

	[SerializeField]
	private float failY;

	private Vector2 velocity = Vector2.zero;

	private Vector2 gravity = new Vector2(0f, -19f);

	private bool isGrounded;

	private Action m_OnBeginForwardMovement;

	private bool isMoving;

	public bool IsGrounded => isGrounded;

	public event Action OnBeginForwardMovement
	{
		add
		{
			m_OnBeginForwardMovement = (Action)Delegate.Combine(m_OnBeginForwardMovement, value);
		}
		remove
		{
			m_OnBeginForwardMovement = (Action)Delegate.Remove(m_OnBeginForwardMovement, value);
		}
	}

	private void Start()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += _ =>
			{
				velocity.x = 0f;
			};
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (boost.x > 0f)
		{
			velocity.x = forwardSpeed;
			if (!isMoving)
			{
				m_OnBeginForwardMovement?.Invoke();
				isMoving = true;
			}
		}
		if (boost.y > 0f)
		{
			velocity.y = jumpSpeed;
		}
	}

	private float GetGroundY(float checkX)
	{
		RaycastHit2D hit = Physics2D.CircleCast(new Vector2(checkX, checkY), checkRadius, Vector2.down * checkLength);
		if (hit.collider != null)
		{
			return hit.centroid.y;
		}
		return float.NegativeInfinity;
	}

	public void Update()
	{
		Vector3 localPos = transform.localPosition;
		float nextX = localPos.x + velocity.x * Time.deltaTime;
		float nextY = localPos.y + velocity.y * Time.deltaTime;
		float groundY = GetGroundY(nextX);
		if (localPos.y > groundY - fallLimit && nextY < groundY)
		{
			if (velocity.y < 0f)
			{
				velocity.y *= -0.4f;
			}
			nextY = groundY;
		}
		transform.localPosition = new Vector3(nextX, nextY, 0f);
		isGrounded = (nextY - groundY) < groundSkin;
		velocity += gravity * Time.deltaTime;
		if (transform.position.y < failY && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}
}
