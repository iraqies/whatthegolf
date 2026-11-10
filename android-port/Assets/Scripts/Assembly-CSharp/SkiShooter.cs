using Core;
using UnityEngine;

public class SkiShooter : GolfBall2DShooterBase
{
	public float JumpUpForce = 10f;

	public float JumpForwardForce = 10f;

	public bool Grounded;

	public Vector2 OrthographicSizeRange = new Vector2(18f, 25f);

	public bool DontModifyAngularDragInFlight;

	private void Update()
	{
		if (DontModifyAngularDragInFlight || Rigidbody == null)
			return;
		Rigidbody.angularDrag = Grounded ? 10f : 1000f;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (!Grounded || Rigidbody == null)
			return;
		Vector3 localDir = transform.InverseTransformDirection(boost);
		Vector2 relForce = Vector2.up * (localDir.y * JumpUpForce) + Vector2.right * (localDir.x * JumpForwardForce);
		Rigidbody.AddRelativeForce(relForce, ForceMode2D.Impulse);
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		if (other != null && other.gameObject != null && other.gameObject.layer == LayerMask.NameToLayer("Ground"))
		{
			Grounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other != null && other.gameObject != null && other.gameObject.layer == LayerMask.NameToLayer("Ground"))
		{
			Grounded = false;
		}
	}
}
