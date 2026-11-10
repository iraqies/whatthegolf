using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
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

		public bool gunEnabled = true;
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
		if (bullet != null && bulletPool != null)
		{
			bulletPool.Return(bullet.gameObject, true);
		}
	}

	private IEnumerator Start()
	{
		bulletPool = new ObjectPool<GameObject>(bulletPrefab, 50, delegate(GameObject go)
		{
			if (go != null)
			{
				SuperGolfBullet componentInChildren = go.GetComponentInChildren<SuperGolfBullet>();
				Collider[] componentsInChildren = GetComponentsInChildren<Collider>();
				if (componentInChildren != null)
				{
					componentInChildren.previousOwnerColliders = new List<Collider>(componentsInChildren);
					componentInChildren.OnBulletDeath = (Action<SuperGolfBullet>)Delegate.Combine(componentInChildren.OnBulletDeath, new Action<SuperGolfBullet>(OnBulletDeath));
				}
			}
		});
		while (true)
		{
			if (muzzleGroups == null)
			{
				yield break;
			}
			MuzzleGroup[] array = muzzleGroups;
			foreach (MuzzleGroup muzzleGroup in array)
			{
				if (muzzleGroup == null || !muzzleGroup.gunEnabled || muzzleGroup.Muzzles == null)
				{
					continue;
				}
				for (int j = 0; j < muzzleGroup.Muzzles.Length; j++)
				{
					SuperGolfCannonMuzzle superGolfCannonMuzzle = muzzleGroup.Muzzles[j];
					if (superGolfCannonMuzzle == null)
					{
						continue;
					}
					if (superGolfCannonMuzzle.MoveCannonOnShot)
					{
						StartCoroutine(superGolfCannonMuzzle.PreFireAnimation());
					}
					if (superGolfCannonMuzzle.BulletOrigin != null && bulletPool != null)
					{
						GameObject gameObject = bulletPool.Get(superGolfCannonMuzzle.BulletOrigin.position, superGolfCannonMuzzle.BulletOrigin.rotation);
						if (gameObject != null)
						{
							gameObject.SetActive(true);
						}
					}
					if (superGolfCannonMuzzle.Particles != null)
					{
						superGolfCannonMuzzle.Particles.Play();
					}
					if (Time.time > nextSoundTime)
					{
						nextSoundTime = Time.time + soundCooldown;
						if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && shootClips != null)
						{
							AudioManager.Instance.sfx.Play(shootClips, delegate(AudioSource t)
							{
								if (t != null)
								{
									t.transform.position = base.transform.position;
									t.volume = UnityEngine.Random.Range(0.25f, 0.32f);
									t.pitch = UnityEngine.Random.Range(0.95f, 1.05f);
								}
							}, true, false, 0f);
						}
					}
				}
				while (timer < muzzleGroup.postDelay)
				{
					if (timeline != null)
					{
						timer += timeline.deltaTime * Time.timeScale;
					}
					yield return null;
				}
				timer = 0f;
			}
			yield return null;
		}
	}
}
