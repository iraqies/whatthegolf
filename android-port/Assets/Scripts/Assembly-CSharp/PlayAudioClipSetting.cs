using Audio;
using UnityEngine;

public class PlayAudioClipSetting : MonoBehaviour
{
	public ClipSettingsCollection clipCollection;

	public Transform position;

	private void Start()
	{
		DefaultSetPos();
	}

	private void DefaultSetPos()
	{
		if (position == null)
			position = transform;
	}

	public void Play()
	{
		DefaultSetPos();
		if (clipCollection != null)
			clipCollection.Play(position != null ? position.position : transform.position);
	}
}
