using UnityEngine;

public class AudioOnlyWhenGrounded : MonoBehaviour
{
	public bool use2D;

	public float minVolume;

	public float maxVolume = 1f;

	public LayerMask layer;

	public float distanceToGroundThreshold = 1f;

	private AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (use2D)
			Check2DGround();
		else
			Check3DGround();
	}

	private void Check2DGround()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, distanceToGroundThreshold, layer);
		bool grounded = hit.collider != null;
		SetVolume(grounded);
	}

	private void Check3DGround()
	{
		Ray r = new Ray(transform.position, Vector3.down);
		bool grounded = Physics.Raycast(r, distanceToGroundThreshold, layer);
		SetVolume(grounded);
	}

	private void SetVolume(bool shouldPlay)
	{
		if (audioSource == null) return;
		float target = shouldPlay ? maxVolume : minVolume;
		audioSource.volume = Mathf.MoveTowards(audioSource.volume, target, Time.unscaledDeltaTime * 10f);
	}
}
