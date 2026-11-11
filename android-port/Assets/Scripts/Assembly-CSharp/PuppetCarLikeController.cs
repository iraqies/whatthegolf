using Audio;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetCarLikeController : UserControlThirdPerson
{
	public GolfBallController Controller;

	public CharacterPuppet Puppet;

	public AnimationCurve AnimSpeedMultiplierCurve;

	public ClipSettingsCollection ShootClip;

	protected CharacterAnimationThirdPerson characterAnimation;

	protected Vector3 aimDir;

	protected Vector3 moveDir;

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

	public virtual void OnShoot(Vector3 boost)
	{
		if (ShootClip != null)
		{
			ShootClip.Play(base.transform.position);
		}
		moveDir = boost.normalized;
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
