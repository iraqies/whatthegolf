using Cinemachine;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetAutoController : UserControlThirdPerson
{
	[SerializeField]
	private CharacterPuppet Puppet;

	[SerializeField]
	private PuppetMaster PuppetMaster;

	[SerializeField]
	private Transform Follower;

	[SerializeField]
	private float FollowThreshold;

	private CharacterAnimationThirdPerson characterAnimation;

	private float dollySpeed;

	[SerializeField]
	private CinemachineDollyCart dolly;

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}
}
