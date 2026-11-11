using System.Collections.Generic;
using UnityEngine;

public class RandomGoopOnTrees : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> goop;

	[SerializeField]
	private GameObject tape;

	[SerializeField]
	private bool _randomYRotation;

	public void Randomize()
	{
		int idx = Random.Range(0, 5);
		if (goop != null)
		{
			foreach (var g in goop)
			{
				if (g != null)
					g.SetActive(false);
			}
			if (idx >= 0 && idx < goop.Count && goop[idx] != null)
			{
				goop[idx].SetActive(true);
			}
		}
		if (_randomYRotation)
		{
			Vector3 euler = transform.rotation.eulerAngles;
			euler.y = Random.Range(0, 360);
			transform.rotation = Quaternion.Euler(euler);
		}
		if (tape != null)
		{
			bool showTape = Random.Range(0, 2) >= 1 && goop != null && idx >= goop.Count;
			tape.SetActive(showTape);
		}
	}
}
