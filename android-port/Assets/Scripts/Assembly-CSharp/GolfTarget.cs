using System.Collections.Generic;
using Audio;
using UnityEngine;

public class GolfTarget : MonoBehaviour
{
	public List<AudioClip> HitClips;

	public bool isCompleted;

	public LayerMask AcceptedLayers;

	public IncrementLevelMusicRTPC IncrementRTPC;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
		{
			return;
		}
		int mask = AcceptedLayers;
		if (mask != (mask | (1 << collision.gameObject.layer)))
		{
			return;
		}
		if (AudioManager.Instance != null && AudioManager.Instance.rumble != null && AudioManager.Instance.rumble.GolfBallBounce != null)
		{
			AudioManager.Instance.rumble.GolfBallBounce.Play(1f, 0);
		}
		if (IncrementRTPC != null)
		{
			IncrementRTPC.Increment();
		}
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && HitClips != null)
		{
			AudioManager.Instance.sfx.Play(HitClips);
		}
		Vector3 startScale = transform.localScale;
		Vector3 endScale = Vector3.zero;
		StartCoroutine(pTween.To(0.2f, t =>
		{
			transform.localScale = Vector3.Lerp(startScale, endScale, t);
		}).Then(() =>
		{
			isCompleted = true;
			gameObject.SetActive(false);
		}));
	}
}
