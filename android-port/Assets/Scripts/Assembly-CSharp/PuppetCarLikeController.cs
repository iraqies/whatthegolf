using Audio;
using Core;
using RootMotion.Demos;
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
	}

	public virtual void OnShoot(Vector3 boost)
	{
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void Update()
	{
	}
}
