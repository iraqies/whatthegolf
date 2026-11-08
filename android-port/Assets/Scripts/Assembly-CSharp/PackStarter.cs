using UnityEngine;

public class PackStarter : MonoBehaviour
{
	[SerializeField] private string packId;

	public void StartPack()
	{
		if (!string.IsNullOrEmpty(packId))
			_ = Hub.FlagPackStarter.StartFlag(packId);
	}
}
