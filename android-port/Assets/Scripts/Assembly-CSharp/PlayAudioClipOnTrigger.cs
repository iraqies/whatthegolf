using Audio;
using UnityEngine;

public class PlayAudioClipOnTrigger : MonoBehaviour
{
	public ClipSettingsCollection Clips;

	public LayerMask AcceptedLayers = ~0;

	public float PlayDelay;

	private float delayTimer;

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || Clips == null)
			return;
		if (((1 << other.gameObject.layer) & AcceptedLayers.value) == 0)
			return;
		if (PlayDelay > 0f)
			Clips.PlayDelayed(transform.position, PlayDelay);
		else
			Clips.Play(transform.position);
	}
}
