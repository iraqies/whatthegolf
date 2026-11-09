using Audio;
using UnityEngine;

public class AudioOnJointBreak : MonoBehaviour
{
	public bool disableCollisionSFXBeforeBreak;

	public AudioEventAsset sfxEventOnBreak;

	private void Awake()
	{
		if (disableCollisionSFXBeforeBreak)
			TrySetCollisionEnabled(false);
	}

	private void OnJointBreak(float breakForce)
	{
		if (disableCollisionSFXBeforeBreak)
			TrySetCollisionEnabled(true);
		if (sfxEventOnBreak != null)
			sfxEventOnBreak.Play(transform.position);
	}

	private void TrySetCollisionEnabled(bool enabled)
	{
		var iu = GetComponent<ImpactUser>();
		if (iu != null)
			iu.IsEnabled = enabled;
		var col = GetComponent<OnCollisionAudioBase>();
		if (col != null)
			col.IsEnabled = enabled;
	}
}
