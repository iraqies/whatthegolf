using Audio;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetHorseController : UserControlThirdPerson
{
	public GolfBallController Controller;

	public CharacterPuppet Puppet;

	public AnimationCurve AnimSpeedMultiplierCurve;

	public CharacterAnimationSimple animController;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

	[SerializeField]
	public float spin;

	[SerializeField]
	public float jumpMinForce = 20f;

	[SerializeField]
	public float jumpMaxForce = 50f;

	private float jumpStartTime = float.NegativeInfinity;

	private Rigidbody rb;

	public ClipSettingsCollection ShootClip;

	private CharacterAnimationThirdPerson characterAnimation;

	private Vector3 aimDir;

	private Vector3 moveDir;

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
		rb = GetComponent<Rigidbody>();
	}

	public void OnShoot(Vector3 boost)
	{
		if (Puppet != null && Puppet.onGround && Puppet.puppet != null && Puppet.puppet.state == BehaviourPuppet.State.Puppet)
		{
			if (ShootClip != null)
			{
				ShootClip.Play(base.transform.position);
			}
			moveDir = boost.normalized;
			if (canJump && animController != null)
			{
				animController.Jump();
				jumpStartTime = Time.time;
				state.jump = true;
			}
		}
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Puppet != null && Puppet.puppet != null && Puppet.puppet.state == BehaviourPuppet.State.Puppet)
		{
			aimDir = boost;
		}
	}

	protected override void Update()
	{
		if (characterAnimation != null && AnimSpeedMultiplierCurve != null)
		{
			characterAnimation.animSpeedMultiplier = Mathf.Max(1f, AnimSpeedMultiplierCurve.Evaluate(moveDir.magnitude));
		}
		if (animController != null && Time.time - jumpStartTime > animController.jumpDuration)
		{
			state.jump = false;
		}
		Vector3 tangent = new Vector3(moveDir.x, 0f, moveDir.z).normalized;
		if (Puppet != null && Puppet.puppet != null && Puppet.puppet.state != BehaviourPuppet.State.Puppet)
		{
			tangent = Vector3.zero;
			moveDir = Vector3.zero;
			aimDir = Vector3.forward;
		}
		if (tangent != Vector3.zero)
		{
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			state.move = tangent;
		}
		else
		{
			state.move = Vector3.zero;
		}
		if (Controller != null && Controller.IsAiming)
		{
			if (Puppet != null)
			{
				Puppet.moveMode = CharacterThirdPerson.MoveMode.Strafe;
			}
			state.lookPos = base.transform.position + aimDir;
		}
		else
		{
			if (Puppet != null)
			{
				Puppet.moveMode = CharacterThirdPerson.MoveMode.Directional;
			}
			state.lookPos = base.transform.position + base.transform.forward;
		}
	}
}
