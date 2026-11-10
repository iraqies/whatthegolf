using UnityEngine;

public class MoveBetween : MonoBehaviour
{
	public bool startMoving = true;

	public bool stopOnShoot;

	public bool startOnShoot;

	public Transform A;

	public Transform B;

	public float offsetTimer;

	public float Speed;

	public float startPos;

	private BallShooter shooter;

	private Rigidbody2D rigid;

	private float adjustedSpeed;

	private float timer;

	private bool isMoving;

	private void Awake()
	{
		shooter = Object.FindObjectOfType<BallShooter>();
		isMoving = startMoving;
		rigid = GetComponent<Rigidbody2D>();
		if (A != null && B != null && rigid != null)
		{
			float t = Mathf.Clamp01(startPos);
			rigid.MovePosition(new Vector2(Mathf.Lerp(A.position.x, B.position.x, t), Mathf.Lerp(A.position.y, B.position.y, t)));
			timer = startPos;
			float dist = Vector3.Distance(A.position, B.position);
			adjustedSpeed = ((dist > 1e-05f) ? (Speed / dist) : 0f);
		}
		if (shooter != null)
		{
			shooter.OnShoot += Shooter_OnShoot;
		}
	}

	private void Shooter_OnShoot(Vector2 dir)
	{
		if (startOnShoot)
		{
			isMoving = true;
		}
		if (stopOnShoot)
		{
			isMoving = false;
		}
	}

	private void FixedUpdate()
	{
		if (isMoving && A != null && B != null && rigid != null)
		{
			timer += Time.deltaTime * adjustedSpeed;
			float t = Mathf.Clamp01(Mathf.PingPong(timer, 1f));
			rigid.MovePosition(new Vector2(Mathf.Lerp(A.position.x, B.position.x, t), Mathf.Lerp(A.position.y, B.position.y, t)));
		}
	}
}
