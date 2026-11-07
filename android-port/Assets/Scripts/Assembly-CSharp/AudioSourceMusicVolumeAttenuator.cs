using UnityEngine;

public class AudioSourceMusicVolumeAttenuator : MonoBehaviour
{
	[SerializeField]
	private AudioSource target;

	private float initialMusicVolume;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnMusicVolumeChanged(float value)
	{
	}
}
