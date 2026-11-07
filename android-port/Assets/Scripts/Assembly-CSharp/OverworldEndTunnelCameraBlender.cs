using System.Collections.Generic;
using UnityEngine;

public class OverworldEndTunnelCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings inTunnel;

	private Coroutine current;

	[SerializeField]
	private List<ShortcutTunnel> tunnels;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Tunnel_OnBallEnterTunnel(ShortcutTunnel tunnel)
	{
	}

	private void Tunnel_OnBallExitTunnel(ShortcutTunnel tunnel)
	{
	}
}
