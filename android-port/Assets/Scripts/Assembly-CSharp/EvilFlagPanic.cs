using System.Collections;
using Core;
using UnityEngine;

public class EvilFlagPanic : MonoBehaviour
{
	public Transform validAreaCenter;

	public float searchAreaMinRadius = 5f;

	public float searchAreaMaxRadius = 10f;

	public float velocity = 50f;

	public float changeDirChance = 0.1f;

	public float awayAngle1 = 70f;

	public float awayAngle2 = 120f;

	public int maxAttempts = 20;

	public GolfBallController ball;

	private Rigidbody rigid;

	private Vector3 currentTarget;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		if (rigid != null)
			currentTarget = rigid.position;
		if (ball != null)
		{
			ball.OnAimStart -= Ball_OnAimStart;
			ball.OnAimStart += Ball_OnAimStart;
		}
	}

	private void Ball_OnAimStart()
	{
		if (ball != null)
			ball.OnAimStart -= Ball_OnAimStart;
		StartCoroutine(Behavior());
	}

	private IEnumerator Behavior()
	{
		while (true)
		{
			if (Vector3.Distance(transform.position, currentTarget) < 0.2f || Random.Range(0f, 1f) < changeDirChance)
			{
				currentTarget = GetNewTarget(maxAttempts);
			}
			yield return new WaitForSeconds(0.1f);
		}
	}

	private Vector3 GetNewTarget(int maxAttempts)
	{
		if (ball == null) return transform.position;
		for (int i = 0; i < maxAttempts; i++)
		{
			Vector3 away = transform.position - ball.transform.position;
			away.y = 0f;
			Vector3 awayNorm = away.normalized;

			float ang1 = Random.Range(-awayAngle1, awayAngle1);
			Vector3 dir1 = Quaternion.AngleAxis(ang1, Vector3.up) * awayNorm;
			Vector3 cand1 = transform.position + dir1 * Random.Range(searchAreaMinRadius, searchAreaMaxRadius);
			if (Physics.Raycast(cand1 + Vector3.up * 0.5f, Vector3.down, out RaycastHit hit1, 2f) && Vector3.Angle(Vector3.up, hit1.normal) < 1f)
				return cand1;

			float ang2 = Random.Range(-awayAngle2, -awayAngle1);
			Vector3 dir2 = Quaternion.AngleAxis(ang2, Vector3.up) * awayNorm;
			Vector3 cand2 = transform.position + dir2 * Random.Range(searchAreaMinRadius, searchAreaMaxRadius);
			if (Physics.Raycast(cand2 + Vector3.up * 0.5f, Vector3.down, out RaycastHit hit2, 2f) && Vector3.Angle(Vector3.up, hit2.normal) < 1f)
				return cand2;

			float ang3 = Random.Range(awayAngle1, awayAngle2);
			Vector3 dir3 = Quaternion.AngleAxis(ang3, Vector3.up) * awayNorm;
			Vector3 cand3 = transform.position + dir3 * Random.Range(searchAreaMinRadius, searchAreaMaxRadius);
			if (Physics.Raycast(cand3 + Vector3.up * 0.5f, Vector3.down, out RaycastHit hit3, 2f) && Vector3.Angle(Vector3.up, hit3.normal) < 1f)
				return cand3;
		}
		return transform.position;
	}

	private void FixedUpdate()
	{
		if (rigid == null) return;
		Vector3 delta = currentTarget - transform.position;
		float step = Mathf.Min(delta.magnitude, velocity * Time.fixedDeltaTime);
		rigid.MovePosition(transform.position + delta.normalized * step);
	}

	private void OnDrawGizmos()
	{
	}
}
