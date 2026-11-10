using System;
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
		if (intro != null)
		{
			intro.OnAtEndOfTunnel -= Intro_OnAtEndOfTunnel;
			intro.OnAtEndOfTunnel += Intro_OnAtEndOfTunnel;
		}
	}

	private void Intro_OnAtEndOfTunnel()
	{
		StartCoroutine(SetSaveOkay());
	}

	public IEnumerator SetSaveOkay()
	{
		if (!SaveGame.IsIntroAnimationComplete)
		{
			if (save != null && save.gameObject != null)
				save.gameObject.SetActive(false);

			bool waitingForDoor = door != null && !door.openOrOpening;
			Action onDoorOpen = () => waitingForDoor = false;
			if (door != null)
				door.OnOpen += onDoorOpen;

			float endTime = Time.realtimeSinceStartup + 5f;
			while (waitingForDoor && Time.realtimeSinceStartup < endTime)
				yield return null;

			if (door != null)
				door.OnOpen -= onDoorOpen;

			UpdateSave();
			didEnableSave = true;
		}

		if (save != null && save.gameObject != null)
			save.gameObject.SetActive(true);
		SaveGame.Save(false);
	}

	private void UpdateSave()
	{
		SaveGame.IsOnboardingComplete = true;
		SaveGame.IsIntroAnimationComplete = true;
	}
}
