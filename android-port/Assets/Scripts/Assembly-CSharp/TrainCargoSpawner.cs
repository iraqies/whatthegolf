using System.Collections;
using UnityEngine;

public class TrainCargoSpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private Transform spawnPosition;

	[SerializeField]
	private Transform activationPosition;

	[SerializeField]
	private float inflateDuration;

	[SerializeField]
	private Transform wagon;

	[SerializeField]
	private AudioClip inflateSound;

	private bool isSpawning;

	private float smallSpawnLocalScale;

	private IEnumerator Start()
	{
		return null;
	}
}
