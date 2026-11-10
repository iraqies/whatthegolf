using UnityEngine;

public class MovingTarget : MonoBehaviour
{
	public bool isMovingAway;

	public float speed;

	public float minDistance;

	public Transform avoidTarget;

	private Rigidbody2D rigid;

	private bool fadeInSpeed;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		float targetSpeed = speed;
		StartCoroutine(pTween.To(0.4f, t =>
		{
			speed = Mathf.Lerp(0f, targetSpeed, t);
		}));
	}

	private void FixedUpdate()
	{
		if (avoidTarget == null || rigid == null)
			return;
		Vector3 diff = transform.position - avoidTarget.position;
		if (isMovingAway)
		{
			if (diff.magnitude < minDistance)
			{
				rigid.AddForce(new Vector2(diff.x, diff.y) * speed * Time.fixedDeltaTime, ForceMode2D.Force);
			}
		}
		else
		{
			Vector3 norm = diff.normalized;
			rigid.AddForce(new Vector2(-norm.x, -norm.y) * speed * Time.fixedDeltaTime, ForceMode2D.Force);
		}
	}
}
