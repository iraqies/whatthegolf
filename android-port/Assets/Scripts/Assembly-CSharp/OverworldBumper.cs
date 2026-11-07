using System.Collections;
using Audio;
using UnityEngine;

public class OverworldBumper : MonoBehaviour
{
	public Transform scaleTransform;

	public SpriteRenderer sprite;

	public Transform pupil;

	public float pupilMoveDist;

	public Color hitColor;

	public Color baseColor;

	public float pushForce;

	public float scaleOnHit;

	public ClipSettingsCollection bumperSFX;

	private float nextPush;

	private float pushCooldown;

	public float BlinkCooldownMin;

	public float BlinkCooldownMax;

	private float currentPupilDist;

	private float yScale;

	private bool hasBlinked;

	private bool DontBlink;

	private bool isBlinking;

	private bool isAwake;

	private Vector3 baseScale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void EnableEye()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	public void Bump()
	{
	}
}
