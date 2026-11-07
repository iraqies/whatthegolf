using System;
using System.Collections;
using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class SuperGolfCannon : MonoBehaviour
{
	[Serializable]
	public class MuzzleGroup
	{
		public SuperGolfCannonMuzzle[] Muzzles;

		public float postDelay;

		public bool gunEnabled;
	}

	private float nextSoundTime;

	[SerializeField]
	private MuzzleGroup[] muzzleGroups;

	[SerializeField]
	private GameObject bulletPrefab;

	[SerializeField]
	private Timeline timeline;

	[SerializeField]
	private List<AudioClip> shootClips;

	[SerializeField]
	private float soundCooldown;

	public ObjectPool<GameObject> bulletPool;

	private float timer;

	private void OnBulletDeath(SuperGolfBullet bullet)
	{
	}

	private IEnumerator Start()
	{
		return null;
	}
}
