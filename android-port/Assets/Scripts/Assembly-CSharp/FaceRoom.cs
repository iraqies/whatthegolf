using System.Collections;
using Audio;
using UnityEngine;

public class FaceRoom : MonoBehaviour
{
	public ClipSettingsCollection wakeupSFX;

	public Transform eyeLeft;

	public Transform eyeRight;

	public Transform mouth;

	private Vector3 eyeBaseScale;

	private Vector3 mouthScale;

	private Vector3 closedMouthScale;

	private bool isAwake;

	private Vector3 baseScale;

	public bool UseAnimation;

	public Animator animator;

	private bool onCooldown;

	public float CooldownDuration;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private IEnumerator CooldownRoutine()
	{
		return null;
	}

	private IEnumerator WakeUp()
	{
		return null;
	}
}
