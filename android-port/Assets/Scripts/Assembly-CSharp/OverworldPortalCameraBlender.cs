using System.Collections.Generic;
using UnityEngine;

public class OverworldPortalCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings farPortal;

	public OverworldCameraSettings outgoing;

	private Coroutine current;

	[SerializeField]
	private List<SimplePortal> portals;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Portal_OnPortaling(SimplePortal portal, GameObject thing, SimplePortal targetPortal)
	{
	}
}
