using UnityEngine;

public class FroggerShooter : BallShooter
{
	public float moveDistnace;

	public float speed;

	public Vector3 target;

	public Vector2 bounds;

	protected override void Awake()
	{
		base.Awake();
		target = transform.position;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (OnShootEvent != null)
		{
			target += boost.normalized * moveDistnace;
			OnShootEvent.Invoke(new Vector2(boost.x, boost.y));
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigid != null)
		{
			float t = Mathf.Clamp01(Time.fixedDeltaTime * speed);
			Vector2 nextPos = Vector2.Lerp(rigid.position, new Vector2(target.x, target.y), t);
			rigid.MovePosition(nextPos);
			if (target.x < -bounds.x)
				target.x = -bounds.x;
			if (target.x > bounds.x)
				target.x = bounds.x;
			if (target.y > bounds.y)
				target.y = bounds.y;
		}
	}
}
