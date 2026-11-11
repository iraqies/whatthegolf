using System.Collections;
using Core;
using RootMotion.Demos;
using RootMotion.Dynamics;
using UnityEngine;

public class PortalblePuppet : PortableObject
{
	[SerializeField]
	private PuppetMaster Puppet;

	[SerializeField]
	private UserControlThirdPerson Character;

	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GolfBallController Controller;

	public override void Port(Vector3 position)
	{
		StartCoroutine(PortCR(position));
	}

	private IEnumerator PortCR(Vector3 position)
	{
		if (Puppet != null)
		{
			Puppet.SwitchToKinematicMode();
		}
		if (Controller != null)
		{
			Controller.BlockShooting = true;
		}
		if (Character != null)
		{
			Character.state.move = Vector3.zero;
		}
		yield return new WaitForSeconds(0.5f);
		if (Puppet != null)
		{
			Puppet.Teleport(position, Quaternion.identity, true);
		}
		yield return new WaitForSeconds(0.5f);
		if (Puppet != null)
		{
			Puppet.SwitchToActiveMode();
			Puppet.Resurrect();
		}
		if (Controller != null)
		{
			Controller.BlockShooting = false;
		}
	}
}
