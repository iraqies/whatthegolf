using UnityEngine;
using UnityEngine.Events;

public class TunnelEnteredAction : MonoBehaviour
{
	private ShortcutTunnel tunnel;

	public UnityEvent onTunnelEnter;

	public UnityEvent onTunnelExit;

	private bool inTunnel;

	private ShortcutTunnel Tunnel => tunnel != null ? tunnel : (tunnel = GetComponent<ShortcutTunnel>() ?? GetComponentInParent<ShortcutTunnel>());

	private void OnEnable()
	{
		if (Tunnel != null)
		{
			Tunnel.OnBallEnterTunnel -= TunnelEntered;
			Tunnel.OnBallEnterTunnel += TunnelEntered;
			Tunnel.OnBallExitTunnel -= TunnelExited;
			Tunnel.OnBallExitTunnel += TunnelExited;
		}
	}

	private void OnDisable()
	{
		if (tunnel != null)
		{
			tunnel.OnBallEnterTunnel -= TunnelEntered;
			tunnel.OnBallExitTunnel -= TunnelExited;
		}
	}

	private void TunnelExited(ShortcutTunnel obj)
	{
		inTunnel = false;
		onTunnelExit?.Invoke();
	}

	private void TunnelEntered(ShortcutTunnel obj)
	{
		inTunnel = true;
		onTunnelEnter?.Invoke();
	}

	private void Update()
	{
	}
}
