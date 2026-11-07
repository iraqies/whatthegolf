using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C5")]
	public class TrafficCarAudio : MonoBehaviour
	{
		[Token(Token = "0x4006A53")]
		[FieldOffset(Offset = "0x18")]
		public CarAgent carAgent;

		[Token(Token = "0x4006A54")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips clipOnSpeedUp;

		[Token(Token = "0x4006A55")]
		[FieldOffset(Offset = "0x28")]
		public RandomAudioClips clipsOnFallingOffSide;

		[Token(Token = "0x4006A56")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource audioSource;

		[Token(Token = "0x4006A57")]
		[FieldOffset(Offset = "0x38")]
		private bool isInitialSpawn;

		[Token(Token = "0x4006A58")]
		[FieldOffset(Offset = "0x40")]
		private TrafficController trafficController;

		[Token(Token = "0x4006A59")]
		[FieldOffset(Offset = "0x48")]
		private bool hasCarFallen;

		[Token(Token = "0x6005C41")]
		[Address(RVA = "0x172105C", Offset = "0x172105C", VA = "0x172105C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005C42")]
		[Address(RVA = "0x1721250", Offset = "0x1721250", VA = "0x1721250")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005C43")]
		[Address(RVA = "0x1721460", Offset = "0x1721460", VA = "0x1721460")]
		private void CarAgent_OnCarSpeeding()
		{
		}

		[Token(Token = "0x6005C44")]
		[Address(RVA = "0x1721508", Offset = "0x1721508", VA = "0x1721508")]
		private void CarAgent__OnCarFallingOffSide()
		{
		}

		[Token(Token = "0x6005C45")]
		[Address(RVA = "0x1721560", Offset = "0x1721560", VA = "0x1721560")]
		private void CarAgent_onOutOfBounds()
		{
		}

		[Token(Token = "0x6005C46")]
		[Address(RVA = "0x1721594", Offset = "0x1721594", VA = "0x1721594")]
		public TrafficCarAudio()
		{
		}
	}
}
