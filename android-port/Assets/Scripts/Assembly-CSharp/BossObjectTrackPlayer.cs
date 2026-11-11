using System.Linq;
using Audio;
using Core;
using UnityEngine;

public class BossObjectTrackPlayer : MonoBehaviour
{
	public float MoveSpeed = 10f;

	public RandomAudioClips DeathClips;

	private GolfBallController controller;

	private Rigidbody rigid;

	private ParticleSystem destroyParticles;

	private bool isGrounded;

	private void Start()
	{
		controller = Object.FindObjectsOfType<GolfBallController>().Where((GolfBallController g) => g.enabled).First();
		rigid = GetComponent<Rigidbody>();
		destroyParticles = GetComponentInChildren<ParticleSystem>();
	}

	private void FixedUpdate()
	{
		if (controller != null)
		{
			if (isGrounded)
			{
				Vector3 normalized = (controller.transform.position - base.transform.position).normalized;
				rigid.AddForce(normalized * MoveSpeed, ForceMode.Acceleration);
			}
			else
			{
				Vector3 normalized2 = (controller.transform.position - base.transform.position).normalized;
				rigid.AddForce(normalized2 * MoveSpeed / 3f, ForceMode.Acceleration);
			}
		}
		isGrounded = false;
	}

	private void OnCollisionStay(Collision other)
	{
		isGrounded = true;
	}

	private void OnParticleCollision(GameObject other)
	{
		if (other.layer == LayerMask.NameToLayer("GolfBall"))
		{
			destroyParticles.transform.SetParent(null, true);
			destroyParticles.transform.up = Vector3.up;
			destroyParticles.Play();
			DeathClips.PlayRandomClip(base.transform.position);
			Object.Destroy(base.gameObject);
		}
	}
}
