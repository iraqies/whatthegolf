using UnityEngine;

public class FlyingBallShooter : BallShooter
{
	public float gravity;

	public float moveDistnace;

	public float speed;

	public Vector3 target;

	public bool useBounds;

	public bool useGravity = true;

	public Vector2 bounds;

	private bool startedFlying;

	protected override void Awake()
	{
		base.Awake();
		target = transform.position;
		if (GolfBallController != null)
			GolfBallController.OnAimUpdate += Controller_OnAimUpdate;
	}

	private void Controller_OnAimUpdate(Vector3 boost, bool arg2)
	{
		if (!arg2 && boost.magnitude > 0.1f && rigid != null)
		{
			Vector3 norm = boost.normalized;
			rigid.velocity = new Vector2(norm.x * speed, norm.y * speed);
			startedFlying = true;
			ClampVelocity();
		}
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void ClampVelocity()
	{
		if (!useBounds || rigid == null)
			return;
		Vector2 v = rigid.velocity;
		Vector3 lp = transform.localPosition;
		if (lp.x < -bounds.x)
			v.x = Mathf.Max(0f, v.x + Time.deltaTime * 0.01f);
		if (lp.x > bounds.x)
			v.x = Mathf.Min(0f, v.x - Time.deltaTime * 0.01f);
		if (lp.y < -bounds.y)
			v.y = Mathf.Max(0f, v.y + Time.deltaTime * 0.01f);
		if (lp.y > bounds.y)
			v.y = Mathf.Min(0f, v.y - Time.deltaTime * 0.01f);
		rigid.velocity = v;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (GolfBallController != null && !GolfBallController.isAiming && startedFlying && useGravity && rigid != null)
		{
			rigid.AddForce(Vector2.down * gravity * Time.fixedDeltaTime, ForceMode2D.Force);
		}
		ClampVelocity();
	}
}
