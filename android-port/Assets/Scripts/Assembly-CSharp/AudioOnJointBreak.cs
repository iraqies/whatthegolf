using Audio;
using UnityEngine;

public class AudioOnJointBreak : MonoBehaviour
{
	public bool disableCollisionSFXBeforeBreak;

	public AudioEventAsset sfxEventOnBreak;

	private void Awake()
	{
	}

	private void OnJointBreak(float breakForce)
	{
	}

	private void TrySetCollisionEnabled(bool enabled)
	{
	}
}
