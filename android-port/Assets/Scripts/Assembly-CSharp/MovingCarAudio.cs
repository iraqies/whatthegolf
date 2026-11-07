using UnityEngine;

public class MovingCarAudio : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] clipAtEnd;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private MovingCar movingCar;

	private float volume;

	private float pitch;

	private void Awake()
	{
	}

	private void OnDriveStart()
	{
	}
}
