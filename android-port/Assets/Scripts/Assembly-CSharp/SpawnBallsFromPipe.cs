using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SpawnBallsFromPipe : MonoBehaviour
{
	public Rigidbody ObjectToSpawn;

	public Transform SpawnPosition;

	public Animator SpawnAnimator;

	public ClipSettingsCollection sfxOnSpawn;

	private List<GameObject> spawnedObjects;

	private void Start()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private IEnumerator SpawnRoutine()
	{
		return null;
	}
}
