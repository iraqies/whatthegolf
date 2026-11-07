using UnityEngine;

public class LandMine : MonoBehaviour
{
	public float radius;

	public float power;

	private ParticleSystem particle;

	private Renderer rend;

	private Collider col;

	private AudioSource audio;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
