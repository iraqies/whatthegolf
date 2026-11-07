using System.Collections;
using CameraStack;
using UnityEngine;

public class OverworldTransmogrifCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings inTrans;

	public OverworldCameraSettings inTransZoomed;

	private Coroutine current;

	[SerializeField]
	private OverworldCamera overworldCamera;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Instance_OnTransmoGriffed1(Transmogrif grif)
	{
	}

	private IEnumerator DoCameraBlend()
	{
		return null;
	}
}
