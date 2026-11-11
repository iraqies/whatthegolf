using UnityEngine;

public class EndPong : MonoBehaviour
{
	public float speed;

	public Transform target;

	public float width;

	private Rigidbody2D rigid;

	private Vector3 basePos;

	private float movementSpeed;

	private void Awake()
	{
		basePos = base.transform.position;
		rigid = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		float num = Mathf.Clamp(target.position.x, basePos.x - width * 0.5f, basePos.x + width * 0.5f) - base.transform.position.x;
		float num2 = -1.5f;
		if (num < 0f || (num2 = 1.5f) > 0f && num > 0f)
		{
			movementSpeed = Mathf.MoveTowards(movementSpeed, num2, Time.deltaTime * 5f);
		}
		float x = Mathf.Clamp(base.transform.position.x + movementSpeed * speed * Time.deltaTime, basePos.x - width * 0.5f, basePos.x + width * 0.5f);
		rigid.MovePosition(new Vector2(x, base.transform.position.y));
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawLine(base.transform.position - Vector3.right * width * 0.5f, base.transform.position + Vector3.right * width * 0.5f);
	}
}
