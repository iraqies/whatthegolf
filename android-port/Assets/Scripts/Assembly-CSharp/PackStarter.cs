using UnityEngine;

public class PackStarter : MonoBehaviour
{
	[SerializeField] private string packId;

	public async void StartPack()
	{
		if (string.IsNullOrEmpty(packId)) return;
		var cp = RuntimeStoreData.instance != null ? RuntimeStoreData.instance.TryGetContent(packId).GetPack() : null;
		if (cp != null)
		{
			bool ok = await PackStarterManager.StartPack(cp, false);
			if (!ok)
				Debug.LogError("Failed to start pack with id: " + packId);
		}
		else
		{
			Debug.Log("Could not find pack with id: " + packId);
		}
	}
}
