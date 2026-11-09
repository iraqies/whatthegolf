using System.Collections.Generic;
using UnityEngine;

public class OverworldEndTunnelCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings inTunnel;
	private Coroutine current;
	[SerializeField] private List<ShortcutTunnel> tunnels;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
	}

	private void Start()
	{
		if (tunnels == null) return;
		for (int i = 0; i < tunnels.Count; i++)
		{
			var t = tunnels[i];
			if (t != null)
			{
				t.OnBallEnterTunnel -= Tunnel_OnBallEnterTunnel;
				t.OnBallEnterTunnel += Tunnel_OnBallEnterTunnel;
			}
		}
	}

	private void Tunnel_OnBallEnterTunnel(ShortcutTunnel tunnel)
	{
		if (tunnel == null) return;
		tunnel.OnBallExitTunnel -= Tunnel_OnBallExitTunnel;
		tunnel.OnBallExitTunnel += Tunnel_OnBallExitTunnel;
		if (inTunnel != null)
		{
			if (current != null) StopCoroutine(current);
			current = StartCoroutine(pTween.To(0.2f, 0f, 1f, t =>
			{
				if (inTunnel != null)
					inTunnel.SetValue(t * t);
			}));
		}
	}

	private void Tunnel_OnBallExitTunnel(ShortcutTunnel tunnel)
	{
		if (tunnel == null) return;
		tunnel.OnBallExitTunnel -= Tunnel_OnBallExitTunnel;
		if (tunnel.useCameraBlend && inTunnel != null)
		{
			if (current != null) StopCoroutine(current);
			current = StartCoroutine(pTween.To(0.1f, 0f, 1f, t =>
			{
				if (inTunnel != null)
				{
					float inv = 1f - t;
					inTunnel.SetValue(inv * inv);
				}
			}));
		}
	}
}
