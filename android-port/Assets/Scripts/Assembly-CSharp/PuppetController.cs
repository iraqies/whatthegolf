using Audio;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class PuppetController : UserControlThirdPerson
{
	public bool CanJump;

	public GolfBallController Controller;

	public float JumpTime;

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
	}

	public void OnShoot(Vector3 boost)
	{
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void Update()
	{
	}
}
