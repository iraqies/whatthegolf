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
		if (door != null)
		{
			door.OnOpen -= UpdateSave;
			door.OnOpen += UpdateSave;
		}
		if (intro != null)
		{
			intro.OnAtEndOfTunnel -= Intro_OnAtEndOfTunnel;
			intro.OnAtEndOfTunnel += Intro_OnAtEndOfTunnel;
		}
	}

	private void Intro_OnAtEndOfTunnel()
	{
		if (!didEnableSave)
		{
			didEnableSave = true;
			StartCoroutine(SetSaveOkay());
		}
	}

	public IEnumerator SetSaveOkay()
	{
		yield return new WaitForSeconds(1f);
		if (save != null)
			save.gameObject.SetActive(true);
	}

	private void UpdateSave()
	{
		SaveGame.IsIntroAnimationComplete = true;
		SaveGame.Save(false);
	}
}
