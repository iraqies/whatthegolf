using Cinemachine;
using RootMotion.Demos;

public class PuppetAutoRun : UserControlThirdPerson
{
	public CinemachineDollyCart FollowDolly;

	public CharacterPuppet Puppet;

	public float StartDelay;

	public bool AutoCorrectXOffset;

	protected override void Update()
	{
	}
}
