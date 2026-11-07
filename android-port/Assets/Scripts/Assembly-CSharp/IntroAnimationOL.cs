using System.Collections;
using UnityEngine;

public class IntroAnimationOL : MonoBehaviour
{
	public OverworldButton2D door;

	public SaveSpot save;

	public IntroTunnelInOverworld intro;

	private bool didEnableSave;

	private void Start()
	{
	}

	private void Intro_OnAtEndOfTunnel()
	{
	}

	public IEnumerator SetSaveOkay()
	{
		return null;
	}

	private void UpdateSave()
	{
	}
}
