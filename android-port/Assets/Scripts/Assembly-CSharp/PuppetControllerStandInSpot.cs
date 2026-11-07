using RootMotion.Demos;
using UnityEngine;

public class PuppetControllerStandInSpot : UserControlThirdPerson
{
	public CharacterPuppet Puppet;

	public float movementDeadzone;

	private Vector3 originPos;

	private void Awake()
	{
	}

	protected override void Update()
	{
	}
}
