using System.Collections;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BossPlayerEgg : MonoBehaviour
{
	public GolfBallController PlayerController;

	public float FinalSize = 1f;

	public float HatchTime = 1f;

	public float ShakeDuration = 0.5f;

	public float ShakeSpeed = 25f;

	public float ShakeAmount = 15f;

	public GameObject CrackedEgg;

	public UnityEvent OnHatchEvent;

	public bool UseEggHeightOnHatch;

	public float OverrideHatchHeight;

	public AudioClipSettings HatchSound;

	public AudioSource ShakeSound;

	public AudioSource GrowSound;

	public Animator RobotFaceAnimator;

	private IEnumerator Start()
	{
		if (PlayerController != null)
		{
			PlayerController.gameObject.SetActive(false);
		}
		Vector3 baseScale = transform.localScale;
		if (FinalSize > 0.01f)
		{
			baseScale = Vector3.one * FinalSize;
		}
		if (GrowSound != null)
		{
			GrowSound.Play();
		}
		float dur = Mathf.Max(0.15f, HatchTime);
		float t = 0f;
		while (t < dur)
		{
			t += Time.deltaTime;
			transform.localScale = Vector3.Lerp(Vector3.zero, baseScale, t / dur);
			yield return null;
		}
		transform.localScale = baseScale;
		if (ShakeSound != null)
		{
			ShakeSound.Play();
		}
		float shakeDur = Mathf.Max(0.1f, ShakeDuration);
		t = 0f;
		Quaternion startRot = transform.localRotation;
		while (t < shakeDur)
		{
			t += Time.deltaTime;
			float z = Mathf.Sin(t * ShakeSpeed) * ShakeAmount;
			transform.localRotation = startRot * Quaternion.Euler(0f, 0f, z);
			yield return null;
		}
		transform.localRotation = startRot;
		if (HatchSound != null)
		{
			AudioManager.PlaySFX(HatchSound, transform.position);
		}
		if (CrackedEgg != null)
		{
			CrackedEgg.transform.SetParent(null);
			CrackedEgg.SetActive(true);
		}
		if (PlayerController != null)
		{
			PlayerController.transform.SetParent(null);
			Vector3 spawnPos = transform.position;
			if (!UseEggHeightOnHatch && Mathf.Abs(OverrideHatchHeight) > 0.001f)
			{
				spawnPos.y = OverrideHatchHeight;
			}
			PlayerController.transform.position = spawnPos;
			PlayerController.gameObject.SetActive(true);
			PlayerController.Activate();
		}
		OnHatchEvent?.Invoke();
		gameObject.SetActive(false);
	}
}
