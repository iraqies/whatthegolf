using System;
using UnityEngine;

public class LobbyDonationMachine : MonoBehaviour
{
	public UnlockablesManager Manager;

	public Action<UnlockableContentPackage> ContentUnlocked;

	public Action OnNoCoinsAvailable;

	private void OnCollisionEnter(Collision other)
	{
	}
}
