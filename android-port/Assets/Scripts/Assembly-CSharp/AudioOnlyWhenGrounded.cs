using UnityEngine;

public class AudioOnlyWhenGrounded : MonoBehaviour
{
	public bool use2D;

	public float minVolume;

	public float maxVolume;

	public LayerMask layer;

	public float distanceToGroundThreshold;

	private AudioSource audioSource;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Check2DGround()
	{
	}

	private void Check3DGround()
	{
	}

	private void SetVolume(bool shouldPlay)
	{
	}
}
