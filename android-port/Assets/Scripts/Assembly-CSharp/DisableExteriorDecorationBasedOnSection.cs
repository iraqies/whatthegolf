using System.Collections;
using UnityEngine;

public class DisableExteriorDecorationBasedOnSection : MonoBehaviour
{
	public HubSection section;

	private RotateAxis2D[] fans;

	private IEnumerator Start()
	{
		return null;
	}

	private void Section_OnSectionCullingUpdate(bool active)
	{
	}

	private void SetFanStatus(bool active)
	{
	}
}
