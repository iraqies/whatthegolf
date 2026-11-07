using Audio;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetLocomotionAudio : MonoBehaviour
{
	[SerializeField]
	private float runCycleDuration;

	[SerializeField]
	private float leftFootAnimationOffset;

	[SerializeField]
	private float rightFootAnimationOffset;

	[SerializeField]
	private ClipSettingsCollection oneshotFootstepSfx;

	[SerializeField]
	private ClipSettingsCollection jumpSfx;

	[SerializeField]
	private ClipSettingsCollection landSfx;

	private PuppetMaster puppetMaster;

	private CharacterPuppet characterPuppet;

	private Animator animator;

	private CharacterAnimationThirdPerson animationThirdPerson;

	private Rigidbody hipRigidbody;

	private bool didJump;

	private bool wasGrounded;

	private Vector3 lastHipVelocity;

	private float lastTimeInRunAnimation;

	private float timeInRun;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void HandleLanding()
	{
	}

	private void HandleFootsteps()
	{
	}

	private void HandleJump()
	{
	}
}
