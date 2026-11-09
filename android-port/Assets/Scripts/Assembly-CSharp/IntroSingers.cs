using UnityEngine;

public class IntroSingers : MonoBehaviour
{
	public IntroTunnelInOverworld tunnel;

	private IntroSinger[] singers;

	private void Start()
	{
		singers = GetComponentsInChildren<IntroSinger>(true);
		if (singers != null)
		{
			for (int i = 0; i < singers.Length; i++)
				if (singers[i] != null) singers[i].Hide();
		}
		if (tunnel == null)
			tunnel = FindObjectOfType<IntroTunnelInOverworld>();
		if (tunnel != null)
		{
			tunnel.OnPreAtLogo -= Tunnel_OnPreAtLogo;
			tunnel.OnPreAtLogo += Tunnel_OnPreAtLogo;
		}
	}

	private void Tunnel_OnPreAtLogo()
	{
		if (singers == null) return;
		for (int i = 0; i < singers.Length; i++)
		{
			if (singers[i] != null)
				singers[i].BeginAnimat(1.8f);
		}
	}
}
