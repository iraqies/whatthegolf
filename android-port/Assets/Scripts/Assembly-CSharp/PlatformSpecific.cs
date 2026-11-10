using Core;
using UnityEngine;

public class PlatformSpecific : MonoBehaviour
{
	public bool includeOnRotated;

	public bool includeOnNormal;

	private void Awake()
	{
		var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
		bool isRotated = cfg != null && cfg.useRotatedOverworldAndCameraInLevels;
		bool active = isRotated ? includeOnRotated : includeOnNormal;
		gameObject.SetActive(active);
	}
}
