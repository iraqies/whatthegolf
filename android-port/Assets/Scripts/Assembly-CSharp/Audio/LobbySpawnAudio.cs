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
		private float pipeMaxVolume;

		[SerializeField]
		private AudioSource pipeSource;

		[SerializeField]
		private ClipSettingsCollection confettiOnSpawn;

		[SerializeField]
		private AudioEventAsset popOnSpawn;

		[SerializeField]
		private float avatarSfxDelay;

		[SerializeField]
		private AvatarSpawnSFX[] avatarSpawnSFX;

		private float lastActivateTime;

		private bool isActivatingUpward;

		private Vector3 sfxPosition;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void OnActivating(float time)
		{
		}

		public void OnSpawn(PlayerColors.AvatarData avatar)
		{
		}
	}
}
