using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class EvilBoss : MonoBehaviour
{
	public Rigidbody ball;

	public bool KickTarget = true;

	public float KickForce = 50f;

	public float kickRange = 360f;

	public float speed;

	public float reactDistance;

	public float stopDistance;

	public List<AudioClip> sfxKick;

	public float rotateSpeed = 250f;

	public bool lookAlongVelocity = true;

	public int StrokePenaltiesOnCatch;

	public Animator Animator;

	public float StunDuration = 2f;

	public ParticleSystem StunParticles;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private Collider collider;

	private float waitTime;

	private bool targetIsTouching;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		startPosition = base.transform.position;
		startRotation = base.transform.rotation;
		collider = GetComponentInChildren<Collider>();
		Animator componentInChildren = GetComponentInChildren<Animator>();
		if (componentInChildren != null)
		{
			componentInChildren.speed = Random.Range(0.9f, 1.1f);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || !(collision.rigidbody == ball) || !(Time.time > nextHit) || !KickTarget || ball == null || rigid == null)
		{
			return;
		}
		Vector3 position = ball.transform.position;
		Vector3 position2 = rigid.position;
		Vector3 normalized = new Vector3(position.x - position2.x, 0f, position.z - position2.z).normalized;
		if (Vector3.Angle(base.transform.forward, normalized) > kickRange)
		{
			targetIsTouching = true;
			return;
		}
		targetIsTouching = false;
		StartCoroutine(DoKick(collision.rigidbody));
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision != null && collision.rigidbody == ball)
		{
			targetIsTouching = false;
		}
	}

	private IEnumerator DoKick(Rigidbody other)
	{
		if (Level.Instance == null || Level.Instance.Ball == null || !Level.Instance.Ball.enabled)
		{
			yield break;
		}
		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
		}
		if (ball != null)
		{
			ball.velocity = Vector3.zero;
			ball.angularVelocity = Vector3.zero;
		}
		Level.Instance.Ball.enabled = false;
		for (int i = 0; i < StrokePenaltiesOnCatch; i++)
		{
			Level.Instance.Ball.ForceShot();
			yield return new WaitForSeconds(0.2f);
		}
		Level.Instance.Ball.enabled = true;
		nextHit = Time.time + 0.1f;
		if (other != null)
		{
			other.AddForce(Vector3.up * KickForce - Vector3.forward * (KickForce * 6f), ForceMode.Impulse);
		}
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(sfxKick, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.volume = 0.5f;
					s.pitch = Random.Range(0.8f, 1.2f);
				}
			});
		}
	}

	public void Stunned()
	{
		if (StunParticles != null)
		{
			StunParticles.Play();
		}
		if (Animator != null)
		{
			Animator.SetBool("Stunned", true);
		}
		StartCoroutine(pTween.To(StunDuration, delegate
		{
		}).Then(delegate
		{
			if (Animator != null)
			{
				Animator.SetBool("Stunned", false);
			}
		}));
	}

	private void FixedUpdate()
	{
		if (ball == null || (Animator != null && Animator.GetBool("Stunned")) || Level.Instance == null || Level.Instance.Ball == null || !Level.Instance.Ball.enabled || rigid == null)
		{
			if (rigid != null)
			{
				rigid.angularVelocity = Vector3.zero;
				rigid.velocity = Vector3.zero;
			}
			return;
		}
		Vector3 position = ball.transform.position;
		Vector3 position2 = rigid.position;
		float y = position2.y;
		Vector3 normalized = new Vector3(position.x - position2.x, 0f, position.z - position2.z).normalized;
		float num = Vector3.Angle(base.transform.forward, normalized);
		if (targetIsTouching && num <= kickRange)
		{
			targetIsTouching = false;
			StartCoroutine(DoKick(ball));
		}
		if (collider != null)
		{
			Vector3 origin = collider.bounds.center + rigid.velocity * Time.deltaTime;
			float maxDistance = collider.bounds.size.y / 1.9f;
			int layerMask = 1 << LayerMask.NameToLayer("Ground");
			if (!Physics.Raycast(origin, Vector3.down, maxDistance, layerMask))
			{
				rigid.velocity = (startPosition - base.transform.position).normalized * speed;
				waitTime = 0.5f;
			}
		}
		if (waitTime > 0f)
		{
			waitTime -= Time.deltaTime;
		}
		float num2 = speed;
		Vector3 vector = startPosition - ball.transform.position;
		Vector3 vector2 = new Vector3(base.transform.position.x - ball.transform.position.x, 0f, base.transform.position.z - ball.transform.position.z);
		if (vector.magnitude > reactDistance)
		{
			vector2 = base.transform.position - startPosition;
		}
		if (vector.magnitude > reactDistance * 2f)
		{
			num2 = speed * 0.05f;
		}
		float magnitude = vector2.magnitude;
		float magnitude2 = vector2.magnitude;
		if (num > kickRange || (stopDistance > 0f && magnitude2 < stopDistance))
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		else if (waitTime <= 0f && (vector2.magnitude > 1f || vector.magnitude > 1f))
		{
			vector2 *= num2;
			if (vector2.magnitude * Time.fixedDeltaTime > magnitude)
			{
				vector2 = vector2.normalized * magnitude;
			}
			if (vector2.magnitude > 1f)
			{
				vector2.Normalize();
			}
			rigid.velocity = -vector2 * num2 * 0.9f;
		}
		if (lookAlongVelocity)
		{
			if (rigid.velocity.magnitude > 0.1f)
			{
				Quaternion to = Quaternion.LookRotation(rigid.velocity);
				rigid.MoveRotation(Quaternion.RotateTowards(base.transform.rotation, to, rotateSpeed * Time.unscaledDeltaTime));
			}
		}
		else if (vector.magnitude < reactDistance)
		{
			Vector3 normalized2 = (new Vector3(position.x, y, position.z) - rigid.position).normalized;
			Quaternion to2 = Quaternion.LookRotation(normalized2, Vector3.up);
			rigid.rotation = Quaternion.RotateTowards(rigid.rotation, to2, rotateSpeed * Time.unscaledDeltaTime);
		}
		else if (Vector3.Distance(base.transform.position, startPosition) < 1f)
		{
			rigid.MoveRotation(Quaternion.RotateTowards(base.transform.rotation, startRotation, rotateSpeed * Time.unscaledDeltaTime));
		}
	}
}
