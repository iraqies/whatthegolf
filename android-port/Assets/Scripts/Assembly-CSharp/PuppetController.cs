using Audio;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetController : UserControlThirdPerson
{
	public bool CanJump = true;

	public GolfBallController Controller;

	public float JumpTime = 1f;

	public CharacterPuppet Puppet;

	public float BlockTime;

	public AnimationCurve AnimSpeedMultiplierCurve;

	public ClipSettingsCollection ShootClip;

	private CharacterAnimationThirdPerson characterAnimation;

	private Vector3 aimDir;

	private float jumpTimer;

	private float blockTimer;

	protected override void Start()
	{
		base.Start();
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimUpdate += OnAimUpdate;
		}
		if (Puppet != null)
		{
			characterAnimation = Puppet.characterAnimation as CharacterAnimationThirdPerson;
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (ShootClip != null)
		{
			ShootClip.Play(base.transform.position);
		}
		blockTimer = BlockTime * boost.magnitude;
		if (CanJump && Puppet != null && Puppet.onGround && Puppet.puppet != null && Puppet.puppet.state == BehaviourPuppet.State.Puppet)
		{
			jumpTimer = JumpTime;
		}
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if ((!(BlockTime > 0f) || !(blockTimer > 0f)) && Puppet != null && Puppet.puppet != null && Puppet.puppet.state == BehaviourPuppet.State.Puppet)
		{
			aimDir = boost;
		}
	}

	protected override void Update()
	{
		if (Puppet == null || Puppet.puppet == null)
		{
			return;
		}
		if (Puppet.puppet.state != BehaviourPuppet.State.Puppet)
		{
			state.jump = false;
			jumpTimer = 0f;
			blockTimer = 0f;
			return;
		}
		blockTimer -= Time.deltaTime;
		jumpTimer -= Time.deltaTime;
		Vector3 zero = Vector3.zero;
		if (BlockTime > 0f && AnimSpeedMultiplierCurve != null && characterAnimation != null)
		{
			float num = AnimSpeedMultiplierCurve.Evaluate(1f - blockTimer / BlockTime);
			characterAnimation.animSpeedMultiplier = Mathf.Max(1f, num * aimDir.magnitude);
		}
		if ((Controller != null && Controller.IsAiming) || blockTimer > 0f || jumpTimer > 0f || !Puppet.onGround)
		{
			zero.x = aimDir.x;
			zero.z = aimDir.z;
		}
		state.jump = jumpTimer > 0f;
		Vector3 tangent = new Vector3(zero.x, 0f, zero.z).normalized;
		if (tangent != Vector3.zero && (BlockTime <= 0f || blockTimer > 0f))
		{
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			state.move = tangent;
		}
		else
		{
			state.move = Vector3.zero;
		}
		if (BlockTime > 0f)
		{
			if (blockTimer <= 0f)
			{
				state.lookPos = base.transform.position + tangent * 100f;
			}
		}
		else if (cam != null)
		{
			state.lookPos = base.transform.position + cam.forward * 100f;
		}
	}
}
