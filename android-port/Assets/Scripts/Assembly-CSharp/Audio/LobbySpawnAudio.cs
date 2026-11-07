using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001339")]
	public class LobbySpawnAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200133A")]
		public struct AvatarSpawnSFX
		{
			[Token(Token = "0x40066DB")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x40066DC")]
			[FieldOffset(Offset = "0x8")]
			public PlayerColors.AvatarIDs avatarID;

			[Token(Token = "0x40066DD")]
			[FieldOffset(Offset = "0x10")]
			public ClipSettingsCollection avatarSpawnSFX;
		}

		[Token(Token = "0x40066D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float pipeMaxVolume;

		[Token(Token = "0x40066D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource pipeSource;

		[Token(Token = "0x40066D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClipSettingsCollection confettiOnSpawn;

		[Token(Token = "0x40066D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioEventAsset popOnSpawn;

		[Token(Token = "0x40066D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float avatarSfxDelay;

		[Token(Token = "0x40066D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AvatarSpawnSFX[] avatarSpawnSFX;

		[Token(Token = "0x40066D8")]
		[FieldOffset(Offset = "0x48")]
		private float lastActivateTime;

		[Token(Token = "0x40066D9")]
		[FieldOffset(Offset = "0x4C")]
		private bool isActivatingUpward;

		[Token(Token = "0x40066DA")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 sfxPosition;

		[Token(Token = "0x60059AA")]
		[Address(RVA = "0x153A840", Offset = "0x153A840", VA = "0x153A840")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059AB")]
		[Address(RVA = "0x153A87C", Offset = "0x153A87C", VA = "0x153A87C")]
		private void Update()
		{
		}

		[Token(Token = "0x60059AC")]
		[Address(RVA = "0x153A91C", Offset = "0x153A91C", VA = "0x153A91C")]
		public void OnActivating(float time)
		{
		}

		[Token(Token = "0x60059AD")]
		[Address(RVA = "0x153A98C", Offset = "0x153A98C", VA = "0x153A98C")]
		public void OnSpawn(PlayerColors.AvatarData avatar)
		{
		}

		[Token(Token = "0x60059AE")]
		[Address(RVA = "0x153AA9C", Offset = "0x153AA9C", VA = "0x153AA9C")]
		public LobbySpawnAudio()
		{
		}
	}
}
