using UnityEngine;

public class BreakoutBallAdjust : MonoBehaviour
{
	private Rigidbody2D rigid;

	public Vector2 adjustAxis;

	public float snapShootDirWithinAngle;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		BallShooter shooter = GetComponent<BallShooter>();
		if (shooter != null)
			shooter.OnShootEvent += Handle_OnShootEvent;
	}

	private void Handle_OnShootEvent(Vector2 dir)
	{
		if (Vector2.Angle(dir, Vector2.up) < snapShootDirWithinAngle && rigid != null)
		{
			rigid.velocity = Vector2.up * rigid.velocity.magnitude;
		}
	}

	private void FixedUpdate()
	{
		if (rigid == null)
			return;
		Vector2 v = rigid.velocity;
		float mag = v.magnitude;
		if (mag <= 0.001f)
			return;
		Vector2 norm = v / mag;
		if (Mathf.Abs(norm.x) < adjustAxis.x && Mathf.Abs(norm.x) > 0.0001f)
		{
			norm.x = Mathf.Sign(norm.x) * adjustAxis.x;
			rigid.velocity = norm.normalized * mag;
		}
		else if (Mathf.Abs(norm.y) < adjustAxis.y && Mathf.Abs(norm.y) > 0.0001f)
		{
			norm.y = Mathf.Sign(norm.y) * adjustAxis.y;
			rigid.velocity = norm.normalized * mag;
		}
	}
}
