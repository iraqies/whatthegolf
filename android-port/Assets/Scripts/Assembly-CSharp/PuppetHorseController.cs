using Audio;
using Core;
using RootMotion.Demos;
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
	public AnimationCurve powerToPitchWeightCurve;

	[SerializeField]
	public float spin;

	[SerializeField]
	public float jumpMinForce;

	[SerializeField]
	public float jumpMaxForce;

	private float jumpStartTime;

	private Rigidbody rb;

	public ClipSettingsCollection ShootClip;

	private CharacterAnimationThirdPerson characterAnimation;

	private Vector3 aimDir;

	private Vector3 moveDir;

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
