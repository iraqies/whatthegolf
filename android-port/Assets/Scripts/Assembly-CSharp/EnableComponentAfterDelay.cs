using System.Collections;
using UnityEngine;

public class EnableComponentAfterDelay : MonoBehaviour
{
	public MonoBehaviour component;

	public float delay;

	public bool OnAwake;

	private void Awake()
	{
	}

	private IEnumerator EnableAfterDelay()
	{
		return null;
	}
}
