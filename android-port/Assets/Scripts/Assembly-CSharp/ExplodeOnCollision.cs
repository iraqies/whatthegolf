using UnityEngine;

public class ExplodeOnCollision : MonoBehaviour
{
	public ExplosionBarrel2D Explosion;

	public ParticleSystem explosionParticlesPrefab;

	private Rigidbody _rigidbody;

	public float explosionForce = 1000f;

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Explosion.gameObject.SetActive(true);
		Explosion.transform.parent = null;
		Explosion.Explode(collision.collider);
		Object.Destroy(base.gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Vector3 point = other.contacts[0].point;
		RaycastHit[] array = Physics.SphereCastAll(point, 10f, Vector3.up);
		if (array.Length < 1)
		{
			return;
		}
		RaycastHit[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			RaycastHit raycastHit = array2[i];
			if (!(raycastHit.rigidbody == null) && !(raycastHit.rigidbody == _rigidbody))
			{
				raycastHit.rigidbody.AddExplosionForce(explosionForce, point, 10f);
			}
		}
	}
}
