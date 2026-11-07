using System.Collections;
using UnityEngine;

public class BombControllerAddon : MonoBehaviour
{
	public ParticleSystem explosionParticlesPrefab;

	public Animator animator;

	private ParticleSystem _explosion;

	private Rigidbody _rigidbody;

	public float explosionForce;

	public float selfExplosionForce;

	public float selfExplosionCooldown;

	public bool explodeFootballPlayers;

	public LayerMask checkLayer;

	public float explosionRadius;

	private bool inCooldown;

	private GameObject lastObjectToCauseExplosion;

	[SerializeField]
	private PlayAudioClipSetting _playAudioOnExplode;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator WaitForCooldown()
	{
		return null;
	}
}
