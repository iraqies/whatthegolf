using Core;
using UnityEngine;

public class ChairBeachBall : MonoBehaviour
{
	public ParticleSystem HitParticles;

	public float pushForce = 10f;

	public CrabsController CrabController;

	public PlayerHit playhit;

	private GolfBallController owner;

	private SuperGolfShooter superShooter;

	private Rigidbody rigid;

	private float baseMaxShoot;

	private float nextPushTime;

	private Coroutine shootSpeedRoutine;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		owner = GetComponent<GolfBallController>();
		superShooter = GetComponent<SuperGolfShooter>();
		baseMaxShoot = superShooter.fullShootVelocity;
	}

	public void Push(Vector3 dir)
	{
		nextPushTime = Time.time + 0.08f;
		superShooter.useSlowShot = true;
		if (shootSpeedRoutine != null)
		{
			StopCoroutine(shootSpeedRoutine);
		}
		shootSpeedRoutine = StartCoroutine(pTween.To(0.4f, delegate(float t)
		{
			superShooter.slowShootPct = TweenFunctions.EaseIn(t) * 0.9f;
		}).Then(delegate
		{
			superShooter.slowShootPct = 1f;
			superShooter.useSlowShot = false;
		}));
		rigid.AddForce(dir * pushForce, ForceMode.Impulse);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!(collision.collider.attachedRigidbody != null))
		{
			return;
		}
		CrabsController.CrabInfo crabWithRigid = CrabController.GetCrabWithRigid(collision.rigidbody);
		if (crabWithRigid != null)
		{
			if (!crabWithRigid.Barrel.HasExploded)
			{
				HitParticles.transform.position = collision.contacts[0].point + Vector3.up * 2f;
				HitParticles.Play();
				CrabController.ScareCrab(collision.contacts[0].point, crabWithRigid);
				playhit.OnDeath(owner);
				crabWithRigid.Barrel.Explode();
			}
		}
		else if (Time.time > nextPushTime)
		{
			Debug.Log("Hit: " + collision.collider.attachedRigidbody.name);
			if (collision.collider.attachedRigidbody.GetComponent<GolfBallController>() != null)
			{
				Debug.Log("Hit other player: " + collision.collider.attachedRigidbody.name);
				Rigidbody attachedRigidbody = collision.collider.attachedRigidbody;
				Vector3 point = collision.GetContact(0).point;
				point.y = base.transform.position.y;
				Vector3 normalized = (point - base.transform.position).normalized;
				Vector3 normalized2 = (point - attachedRigidbody.position).normalized;
				float magnitude = Vector3.Project(rigid.velocity, normalized).magnitude;
				if (!(Vector3.Project(attachedRigidbody.velocity, normalized2).magnitude > magnitude))
				{
					attachedRigidbody.GetComponent<ChairBeachBall>().Push(normalized);
					nextPushTime = Time.time + 0.08f;
				}
			}
		}
	}
}
