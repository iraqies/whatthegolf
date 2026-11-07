using UnityEngine;
using UnityEngine.Events;

public class OnParticleCollisionEvents : MonoBehaviour
{
	public UnityEvent OnCollisionEnterEvent;

	private RaycastHit _hit;

	[SerializeField]
	private ParticleSystem PSystem;

	private void OnParticleCollision(GameObject other)
	{
	}
}
