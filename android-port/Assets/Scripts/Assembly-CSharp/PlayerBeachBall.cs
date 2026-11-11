using UnityEngine;

public class PlayerBeachBall : MonoBehaviour
{
	public BeachBallWithAvatarController Player;

	private Rigidbody rigid;

	private float nextPushTime;

	public bool debugThings;

	public float pushMultiplier;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		Player.OnCollision(collision);
		Rigidbody attachedRigidbody = collision.collider.attachedRigidbody;
		if (!(attachedRigidbody != null))
		{
			return;
		}
		PlayerBeachBall component = attachedRigidbody.GetComponent<PlayerBeachBall>();
		Debug.Log("beach ball! " + component);
		if (!(component != null))
		{
			return;
		}
		Vector3 point = collision.GetContact(0).point;
		point.y = base.transform.position.y;
		Vector3 normalized = (attachedRigidbody.position - base.transform.position).normalized;
		Vector3 normalized2 = (base.transform.position - attachedRigidbody.position).normalized;
		float magnitude = Vector3.Project(rigid.velocity, -normalized).magnitude;
		float magnitude2 = Vector3.Project(attachedRigidbody.velocity, normalized2).magnitude;
		if (debugThings)
		{
			Debug.DrawLine(base.transform.position, point, Color.red, 1f);
			Debug.DrawLine(base.transform.position, base.transform.position + Vector3.Project(rigid.velocity, normalized) * 5f, Color.blue, 1f);
		}
		if (!(magnitude2 > magnitude))
		{
			component.Push(normalized * magnitude);
			nextPushTime = Time.time + 0.08f;
		}
	}

	public void Push(Vector3 dir)
	{
		if (Time.time > nextPushTime)
		{
			Debug.Log("Push!");
			rigid.AddForce(dir * pushMultiplier, ForceMode.Impulse);
		}
	}
}
