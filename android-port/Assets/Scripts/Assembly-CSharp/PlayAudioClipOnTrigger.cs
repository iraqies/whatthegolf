using Audio;
using UnityEngine;

public class PlayAudioClipOnTrigger : MonoBehaviour
{
	public ClipSettingsCollection Clips;

	public LayerMask AcceptedLayers;

	public float PlayDelay;

	private float delayTimer;

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
