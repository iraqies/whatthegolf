using System.Collections;
using UnityEngine;

public class DisableExteriorDecorationBasedOnSection : MonoBehaviour
{
	public HubSection section;

	private RotateAxis2D[] fans;

	private IEnumerator Start()
	{
		yield return null;
		yield return null;
		yield return null;
		yield return null;
		if (section != null && section.gameObject.activeInHierarchy)
		{
			fans = GetComponentsInChildren<RotateAxis2D>(true);
			section.OnSectionCullingUpdate += Section_OnSectionCullingUpdate;
			SetFanStatus(section.isActiveInCulling);
		}
	}

	private void Section_OnSectionCullingUpdate(bool active)
	{
		SetFanStatus(active);
	}

	private void SetFanStatus(bool active)
	{
		if (fans == null) return;
		for (int i = 0; i < fans.Length; i++)
		{
			if (fans[i] != null)
				fans[i].enabled = active;
		}
	}
}
