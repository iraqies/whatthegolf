using System.Collections;
using Core;
using UnityEngine;

public class CatBossKillCollider : MonoBehaviour
{
	public Transform Target;

	public float KillVelocityThreshold;

	public bool KillOnHit;

	public float HitForce;

	public float SquashDuration = 4f;

	public float ShootVelocityMod = 2f;

	private Rigidbody rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		KillVelocityThreshold *= KillVelocityThreshold;
	}

	private void FixedUpdate()
	{
		if (Target != null && rigid != null)
		{
			rigid.MovePosition(Target.position);
			rigid.MoveRotation(Target.rotation);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.transform == null || !other.transform.CompareTag("Player") || rigid == null)
		{
			return;
		}
		if (rigid.velocity.sqrMagnitude >= KillVelocityThreshold)
		{
			Rigidbody rigidbody = other.rigidbody;
			if (KillOnHit)
			{
				StartCoroutine(Squash(rigidbody));
			}
			else if (rigidbody != null)
			{
				rigidbody.AddForce(rigid.velocity * HitForce, ForceMode.Impulse);
			}
		}
	}

	private IEnumerator Squash(Rigidbody player)
	{
		if (player == null)
		{
			yield break;
		}
		MarioLevelController shooter = player.gameObject.GetComponent<MarioLevelController>();
		Transform playerTransform = player.transform;
		playerTransform.localScale = new Vector3(1.5f, 0.5f, 1f);
		if (shooter != null)
		{
			shooter.fullShootVelocity /= ShootVelocityMod;
		}
		yield return new WaitForSeconds(SquashDuration);
		yield return StartCoroutine(pTween.To(0.5f, delegate(float t)
		{
			if (playerTransform != null)
			{
				float num = Mathf.Clamp01(TweenFunctions.punch(1f, t));
				float num2 = num * 0.5f + 1f;
				playerTransform.localScale = new Vector3(num2, num2, 1f);
			}
		}));
		if (playerTransform != null)
		{
			playerTransform.localScale = Vector3.one;
		}
		if (shooter != null)
		{
			shooter.fullShootVelocity *= ShootVelocityMod;
		}
	}
}
