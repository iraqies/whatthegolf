using System.Collections;
using UnityEngine;

public class GooseSpawnedObject : MonoBehaviour
{
	[SerializeField]
	private float destroyDelay;

	[SerializeField]
	private float tweenDuration;

	[SerializeField]
	private AnimationCurve tweenCurve;

	private IEnumerator Start()
	{
		return null;
	}
}
