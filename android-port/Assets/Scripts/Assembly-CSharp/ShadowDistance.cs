using UnityEngine;

public class ShadowDistance : MonoBehaviour
{
	public float shadowDistance = 150f;

	private void Awake()
	{
		if (shadowDistance > 0f)
			QualitySettings.shadowDistance = shadowDistance;
	}

	private void UpdateSettings()
	{
		if (shadowDistance > 0f)
			QualitySettings.shadowDistance = shadowDistance;
	}
}
