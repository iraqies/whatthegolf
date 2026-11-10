using System.Collections;
using Audio;
using UnityEngine;

public class Transmogrif : MonoBehaviour
{
	public enum BALLSHAPES
	{
		ball = 0,
		fish = 1,
		bread = 2,
		boat = 3,
		speedboat = 4,
		saw = 5,
		companioncube = 6,
		endball = 7,
		islandBall = 8,
		waterBall = 9,
		puckBall = 10,
		snowball = 11,
		pizza = 12,
		turkey = 13,
		goo = 14,
		END = 7
	}

	public BALLSHAPES targetShape;
	public BALLSHAPES shape => targetShape;

	public bool UseTargetPosition;

	public Transform targetPosition;

	public bool AddForceOnTransmogrif = true;

	public float outYVelocity;

	public Vector2 outVelocity;

	public float outAngularVelocity;

	public float delay;

	public bool isAnimatedGrif;

	public bool useCameraBlender = true;

	public float TimeBeforeColliderReenable = 0.2f;

	public SpriteRenderer fromBright;

	public SpriteRenderer fromDark;

	public SpriteRenderer toBright;

	public SpriteRenderer toDark;

	public ClipSettingsCollection sfxOnEnter;

	public ClipSettingsCollection sfxOnExit;

	public Animator anim;

	public string animationName;

	public void PlayAnimation(Transmogriffable.TransmogrifSprites start, Transmogriffable.TransmogrifSprites end)
	{
		if (fromBright != null && start != null)
		{
			fromBright.sprite = start.bright;
		}
		if (fromDark != null && start != null)
		{
			fromDark.sprite = start.dark;
		}
		if (toBright != null && end != null)
		{
			toBright.sprite = end.bright;
		}
		if (toDark != null && end != null)
		{
			toDark.sprite = end.dark;
		}
		if (anim != null)
		{
			anim.SetTrigger(animationName);
		}
		if (AudioManager.Instance != null && AudioManager.Instance.rumble != null)
		{
			AudioManager.Instance.rumble.PlayVibrationValue(0.35f, 80f, 0f, 0f, 0);
		}
		StartCoroutine(EndRumble());
	}

	private IEnumerator EndRumble()
	{
		yield return new WaitForSeconds(2f);
		if (AudioManager.Instance != null && AudioManager.Instance.rumble != null)
		{
			AudioManager.Instance.rumble.StopVibration(0);
		}
	}
}
