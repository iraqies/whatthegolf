using System.Collections;
using UnityEngine;

public class CrabEyes : MonoBehaviour
{
	[SerializeField]
	private GameObject[] eyes;

	private IEnumerator Start()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(1f, 1.5f));
			if (eyes != null)
			{
				for (int i = 0; i < eyes.Length; i++)
				{
					if (eyes[i] != null)
					{
						eyes[i].SetActive(false);
					}
				}
			}
			yield return new WaitForSeconds(0.1f);
			if (eyes != null)
			{
				for (int j = 0; j < eyes.Length; j++)
				{
					if (eyes[j] != null)
					{
						eyes[j].SetActive(true);
					}
				}
			}
		}
	}
}
