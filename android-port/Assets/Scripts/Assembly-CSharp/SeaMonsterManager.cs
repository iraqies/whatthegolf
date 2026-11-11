using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaMonsterManager : MonoBehaviour
{
	public GameObject DolphinPrefab;

	public GameObject SharkPrefab;

	public Transform[] DolphinSpots;

	public Transform[] SharkSpots;

	private List<GameObject> m_cachedDolphins;

	private List<GameObject> m_cachedSharks;

	public float DolphinCooldown;

	public float SharkCooldown;

	private void OnEnable()
	{
		StartCoroutine(DolphinRoutine());
		StartCoroutine(SharkRoutine());
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		if (m_cachedDolphins != null)
		{
			for (int i = m_cachedDolphins.Count - 1; i >= 0; i--)
			{
				GameObject go = m_cachedDolphins[i];
				m_cachedDolphins.RemoveAt(i);
				if (go != null)
				{
					Destroy(go);
				}
			}
		}
		if (m_cachedSharks != null)
		{
			for (int i = m_cachedSharks.Count - 1; i >= 0; i--)
			{
				GameObject go = m_cachedSharks[i];
				m_cachedSharks.RemoveAt(i);
				if (go != null)
				{
					Destroy(go);
				}
			}
		}
	}

	private IEnumerator SharkRoutine()
	{
		yield return new WaitForSeconds(DolphinCooldown);
		GameObject shark = null;
		if (SharkSpots != null && SharkSpots.Length > 0 && SharkPrefab != null)
		{
			Transform spot = SharkSpots[Random.Range(0, SharkSpots.Length)];
			if (spot != null)
			{
				shark = Instantiate(SharkPrefab, spot.position, Quaternion.identity);
				if (m_cachedDolphins == null)
				{
					m_cachedDolphins = new List<GameObject>();
				}
				m_cachedDolphins.Add(shark);
				if (Random.Range(0f, 3f) > 1.5f)
				{
					Vector3 ls = transform.localScale;
					shark.transform.localScale = new Vector3(-ls.x, ls.y, ls.z);
				}
			}
		}
		yield return new WaitForSeconds(4f);
		if (m_cachedDolphins != null && shark != null && m_cachedDolphins.Contains(shark))
		{
			m_cachedDolphins.Remove(shark);
		}
		if (shark != null)
		{
			Destroy(shark);
		}
		yield return StartCoroutine(SharkRoutine());
	}

	private IEnumerator DolphinRoutine()
	{
		yield return new WaitForSeconds(DolphinCooldown);
		GameObject dolphin = null;
		if (DolphinSpots != null && DolphinSpots.Length > 0 && DolphinPrefab != null)
		{
			Transform spot = DolphinSpots[Random.Range(0, DolphinSpots.Length)];
			if (spot != null)
			{
				dolphin = Instantiate(DolphinPrefab, spot.position, Quaternion.identity);
				if (m_cachedDolphins == null)
				{
					m_cachedDolphins = new List<GameObject>();
				}
				m_cachedDolphins.Add(dolphin);
				if (Random.Range(0f, 3f) > 1.5f)
				{
					Vector3 ls = transform.localScale;
					dolphin.transform.localScale = new Vector3(-ls.x, ls.y, ls.z);
				}
			}
		}
		yield return new WaitForSeconds(1.5f);
		if (m_cachedDolphins != null && dolphin != null && m_cachedDolphins.Contains(dolphin))
		{
			m_cachedDolphins.Remove(dolphin);
		}
		if (dolphin != null)
		{
			Destroy(dolphin);
		}
		yield return StartCoroutine(DolphinRoutine());
	}
}
