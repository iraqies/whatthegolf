using System;
using UnityEngine;

namespace Audio
{
	public class LobbySpawnAudio : MonoBehaviour
	{
		[Serializable]
		public struct AvatarSpawnSFX
		{
			public string Name;

			public PlayerColors.AvatarIDs avatarID;

			public ClipSettingsCollection avatarSpawnSFX;
		}

		[SerializeField]
		private float pipeMaxVolume = 1f;

		[SerializeField]
		private AudioSource pipeSource;

		[SerializeField]
		private ClipSettingsCollection confettiOnSpawn;

		[SerializeField]
		private AudioEventAsset popOnSpawn;

		[SerializeField]
		private float avatarSfxDelay = 0.1f;

		[SerializeField]
		private AvatarSpawnSFX[] avatarSpawnSFX;

		private float lastActivateTime;

		private bool isActivatingUpward;

		private Vector3 sfxPosition;

		private void Awake()
		{
			sfxPosition = transform.position;
		}

		private void Update()
		{
			if (pipeSource != null && Time.time - lastActivateTime > 0.15f && pipeSource.isPlaying)
			{
				pipeSource.volume = Mathf.MoveTowards(pipeSource.volume, 0f, Time.deltaTime * 4f);
				if (pipeSource.volume <= 0.01f)
				{
					pipeSource.Stop();
				}
			}
		}

		public void OnActivating(float time)
		{
			lastActivateTime = Time.time;
			if (pipeSource != null)
			{
				if (!pipeSource.isPlaying)
				{
					pipeSource.Play();
				}
				pipeSource.volume = Mathf.Clamp01(time) * pipeMaxVolume;
				pipeSource.pitch = Mathf.Lerp(0.8f, 1.4f, Mathf.Clamp01(time));
			}
		}

		public void OnSpawn(PlayerColors.AvatarData avatar)
		{
			if (pipeSource != null)
			{
				pipeSource.Stop();
			}
			if (confettiOnSpawn != null)
			{
				confettiOnSpawn.Play(null, sfxPosition, 1f, 1f);
			}
			if (popOnSpawn != null)
			{
				popOnSpawn.Play(sfxPosition, 1f, 1f);
			}
			if (avatar != null && avatarSpawnSFX != null)
			{
				for (int i = 0; i < avatarSpawnSFX.Length; i++)
				{
					if (avatarSpawnSFX[i].avatarID == avatar.AvatarID && avatarSpawnSFX[i].avatarSpawnSFX != null)
					{
						avatarSpawnSFX[i].avatarSpawnSFX.Play(null, sfxPosition, 1f, 1f);
						break;
					}
				}
			}
		}
	}
}
