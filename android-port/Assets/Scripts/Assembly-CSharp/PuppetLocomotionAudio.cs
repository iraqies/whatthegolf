using Audio;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetLocomotionAudio : MonoBehaviour
{
	[SerializeField]
	private float runCycleDuration = 0.8f;

	[SerializeField]
	private float leftFootAnimationOffset = 0.2f;

	[SerializeField]
	private float rightFootAnimationOffset = 0.7f;

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
		Transform root = transform.root;
		if (root != null)
		{
			puppetMaster = root.GetComponentInChildren<PuppetMaster>();
			if (puppetMaster != null && puppetMaster.muscles != null && puppetMaster.muscles.Length > 0 && puppetMaster.muscles[0] != null)
			{
				hipRigidbody = puppetMaster.muscles[0].rigidbody;
			}
			characterPuppet = root.GetComponentInChildren<CharacterPuppet>();
		}
		wasGrounded = true;
		animator = GetComponentInParent<Animator>();
		animationThirdPerson = GetComponentInParent<CharacterAnimationThirdPerson>();
	}

	private void Update()
	{
		if (puppetMaster != null && characterPuppet != null)
		{
			HandleFootsteps();
		}
	}

	private void FixedUpdate()
	{
		if (puppetMaster == null || characterPuppet == null || hipRigidbody == null)
		{
			return;
		}
		Vector3 vel = hipRigidbody.velocity;
		HandleJump();
		HandleLanding();
		lastHipVelocity = vel;
	}

	private void HandleLanding()
	{
		if (characterPuppet == null)
		{
			return;
		}
		if (characterPuppet.onGround && !wasGrounded && landSfx != null)
		{
			landSfx.Play(null, transform.position, 1f, 1f);
		}
		wasGrounded = characterPuppet.onGround;
	}

	private void HandleFootsteps()
	{
		if (animationThirdPerson == null || characterPuppet == null || animator == null)
		{
			return;
		}
		if (!animationThirdPerson.animationGrounded || characterPuppet.animState.moveDirection.z == 0f)
		{
			lastTimeInRunAnimation = 0f;
			timeInRun = 0f;
			return;
		}
		timeInRun += Time.deltaTime * animator.speed;
		float normTime = (timeInRun % Mathf.Max(0.01f, runCycleDuration)) / Mathf.Max(0.01f, runCycleDuration);
		if ((lastTimeInRunAnimation < leftFootAnimationOffset && normTime > leftFootAnimationOffset)
			|| (lastTimeInRunAnimation < rightFootAnimationOffset && normTime > rightFootAnimationOffset))
		{
			if (oneshotFootstepSfx != null)
			{
				oneshotFootstepSfx.Play(null, transform.position, 1f, 1f);
			}
		}
		lastTimeInRunAnimation = normTime;
	}

	private void HandleJump()
	{
		if (characterPuppet == null)
		{
			return;
		}
		bool jumping = characterPuppet.animState.jump;
		if (jumping && !didJump && jumpSfx != null)
		{
			jumpSfx.Play(null, transform.position, 1f, 1f);
		}
		didJump = jumping;
	}
}
