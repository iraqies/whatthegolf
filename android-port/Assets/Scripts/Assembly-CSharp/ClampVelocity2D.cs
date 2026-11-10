using UnityEngine;

public class ClampVelocity2D : MonoBehaviour
{
	public float MaxSpeed = 10f;

	public bool HardClamp;

	private Rigidbody2D rigid;

	private float sqrMaxSpeed;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		sqrMaxSpeed = MaxSpeed * MaxSpeed;
	}

	private void FixedUpdate()
	{
		if (rigid != null && rigid.velocity.sqrMagnitude > sqrMaxSpeed)
		{
			if (HardClamp)
			{
				Vector3 clamped = Vector3.ClampMagnitude(rigid.velocity, MaxSpeed);
				rigid.velocity = new Vector2(clamped.x, clamped.y);
			}
			else
			{
				rigid.velocity *= 0.99f;
			}
		}
	}
}
