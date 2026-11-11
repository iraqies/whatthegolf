using System.Collections;
using UnityEngine;

public class EnableComponentAfterDelay : MonoBehaviour
{
	public MonoBehaviour component;

	public float delay = 0.5f;

	public bool OnAwake = true;

	private void Awake()
	{
		if (component != null)
		{
			component.enabled = false;
			if (OnAwake)
			{
				StartCoroutine(EnableAfterDelay());
			}
		}
	}

	private IEnumerator EnableAfterDelay()
	{
		yield return new WaitForSeconds(delay);
		if (component != null)
		{
			component.enabled = true;
		}
	}
}
