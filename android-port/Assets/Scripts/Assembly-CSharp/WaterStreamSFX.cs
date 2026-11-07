using UnityEngine;

public class WaterStreamSFX : MonoBehaviour
{
	public AudioSource audioSource;

	public float minVolume;

	public float maxVolume;

	public float smoothTime;

	public int minParticleAmount;

	public int maxPartcielAmount;

	public float decay;

	private float _timer;

	private float volumeVelocity;

	private Vector3 _posVelocity;

	private Vector3 _position;

	private bool firstCollision;

	private void Update()
	{
	}

	public void OnTrigger(Vector3 position)
	{
	}
}
