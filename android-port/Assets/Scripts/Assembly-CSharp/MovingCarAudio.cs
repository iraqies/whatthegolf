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
		volume = audioSource.volume;
		pitch = audioSource.pitch;
		movingCar.OnMoveStart += OnDriveStart;
	}

	private void OnDriveStart()
	{
		if (audioSource != null && audioSource.isActiveAndEnabled)
		{
			audioSource.Play();
			StartCoroutine(pTween.To(1.3f, 0f, 1f, delegate(float s)
			{
				audioSource.volume = Mathf.Lerp(0f, volume, s);
				audioSource.pitch = Mathf.Lerp(pitch - 0.3f, pitch, s);
			}, Ease.EaseOutQuad).Then(delegate
			{
				audioSource.Stop();
			}));
		}
	}
}
