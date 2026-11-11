using System.Collections;
using UnityEngine;

public class BombControllerAddon : MonoBehaviour
{
	public ParticleSystem explosionParticlesPrefab;

	public Animator animator;

	private ParticleSystem _explosion;

	private Rigidbody _rigidbody;

	public float explosionForce = 1000f;

	public float selfExplosionForce = 1f;

	public float selfExplosionCooldown = 0.2f;

	public bool explodeFootballPlayers;

	public LayerMask checkLayer;

	public float explosionRadius = 10f;

	private bool inCooldown;

	private GameObject lastObjectToCauseExplosion;

	[SerializeField]
	private PlayAudioClipSetting _playAudioOnExplode;

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();
		if (explosionParticlesPrefab != null)
		{
			_explosion = Object.Instantiate(explosionParticlesPrefab, base.transform);
			_explosion.transform.localPosition = Vector3.zero;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		Vector3 point = other.contacts[0].point;
		RaycastHit[] array = Physics.SphereCastAll(point, explosionRadius, Vector3.up, 10f, checkLayer);
		if (array.Length < 1)
		{
			return;
		}
		bool flag = false;
		RaycastHit[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			RaycastHit raycastHit = array2[i];
			if (raycastHit.rigidbody == null || raycastHit.rigidbody == _rigidbody || raycastHit.rigidbody.isKinematic)
			{
				continue;
			}
			if (explodeFootballPlayers)
			{
				SoccerPlayer component = raycastHit.transform.GetComponent<SoccerPlayer>();
				if (component != null)
				{
					component.enabled = false;
					raycastHit.rigidbody.constraints = RigidbodyConstraints.None;
					raycastHit.rigidbody.mass = 1f;
				}
				OutOfBoundsTrigger component2 = raycastHit.transform.GetComponent<OutOfBoundsTrigger>();
				if (component2 != null)
				{
					component2.OutOfBounds();
				}
			}
			if (!inCooldown)
			{
				raycastHit.rigidbody.AddExplosionForce(explosionForce, point, explosionRadius, 1f, ForceMode.Impulse);
				_rigidbody.velocity = Vector3.zero;
				_rigidbody.AddForce(Vector3.up * selfExplosionForce, ForceMode.Impulse);
				lastObjectToCauseExplosion = other.transform.gameObject;
				StartCoroutine(WaitForCooldown());
				flag = true;
			}
		}
		if (flag)
		{
			if (_explosion != null)
			{
				_explosion.Play();
			}
			if (_playAudioOnExplode != null)
			{
				_playAudioOnExplode.Play();
			}
			if (animator != null)
			{
				animator.SetTrigger("Explode");
			}
		}
	}

	private IEnumerator WaitForCooldown()
	{
		inCooldown = true;
		yield return new WaitForSeconds(selfExplosionCooldown);
		inCooldown = false;
	}
}
