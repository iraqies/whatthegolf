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
		goo = 14
	}

	public BALLSHAPES targetShape;

	public bool UseTargetPosition;

	public Transform targetPosition;

	public bool AddForceOnTransmogrif;

	public float outYVelocity;

	public Vector2 outVelocity;

	public float outAngularVelocity;

	public float delay;

	public bool isAnimatedGrif;

	public bool useCameraBlender;

	public float TimeBeforeColliderReenable;

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
	}

	private IEnumerator EndRumble()
	{
		return null;
	}
}
