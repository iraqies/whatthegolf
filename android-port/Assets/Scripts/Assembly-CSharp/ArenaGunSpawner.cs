using System.Collections.Generic;
using UnityEngine;

public class ArenaGunSpawner : MonoBehaviour
{
	public List<SuperGolfGun> Guns;

	public Vector3 SpawnOffset = new Vector3(0f, 2f, 0f);

	private List<SuperGolfGun> currentGuns;

	private void Awake()
	{
		foreach (SuperGolfGun gun in Guns)
		{
			gun.gameObject.SetActive(false);
		}
	}

	private void Start()
	{
		currentGuns = new List<SuperGolfGun>(Guns.Count);
		SpawnNewGuns();
	}

	private void Update()
	{
		bool flag = false;
		foreach (SuperGolfGun currentGun in currentGuns)
		{
			flag |= currentGun.gameObject.activeSelf;
		}
		if (!flag)
		{
			SpawnNewGuns();
		}
	}

	private void SpawnNewGuns()
	{
		foreach (SuperGolfGun currentGun in currentGuns)
		{
			Object.Destroy(currentGun.gameObject);
		}
		currentGuns.Clear();
		foreach (SuperGolfGun gun in Guns)
		{
			SuperGolfGun superGolfGun = Object.Instantiate(gun, gun.transform.position + SpawnOffset, gun.transform.rotation, gun.transform.parent);
			superGolfGun.gameObject.SetActive(true);
			currentGuns.Add(superGolfGun);
		}
	}
}
