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
	}

	private IEnumerator PortCR(Vector3 position)
	{
		return null;
	}
}
