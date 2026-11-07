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
	}

	private void OnDisable()
	{
	}

	private IEnumerator SharkRoutine()
	{
		return null;
	}

	private IEnumerator DolphinRoutine()
	{
		return null;
	}
}
