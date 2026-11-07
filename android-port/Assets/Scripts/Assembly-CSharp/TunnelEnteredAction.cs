using UnityEngine;
using UnityEngine.Events;

public class TunnelEnteredAction : MonoBehaviour
{
	private ShortcutTunnel tunnel;

	public UnityEvent onTunnelEnter;

	public UnityEvent onTunnelExit;

	private bool inTunnel;

	private ShortcutTunnel Tunnel => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TunnelExited(ShortcutTunnel obj)
	{
	}

	private void TunnelEntered(ShortcutTunnel obj)
	{
	}

	private void Update()
	{
	}
}
