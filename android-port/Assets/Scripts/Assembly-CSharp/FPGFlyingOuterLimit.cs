using System.Collections;
using UnityEngine;

public class FPGFlyingOuterLimit : MonoBehaviour
{
	public float FogCoverDensity;

	public float RepositionHeight;

	public float LerpTime;

	private bool routineRunning;

	private void OnTriggerExit(Collider other)
	{
	}

	private IEnumerator RepositioningRoutine(Transform player)
	{
		return null;
	}
}
