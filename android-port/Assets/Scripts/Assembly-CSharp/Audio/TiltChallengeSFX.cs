using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013B4")]
	public class TiltChallengeSFX : MonoBehaviour
	{
		[Token(Token = "0x4006A12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection clips;

		[Token(Token = "0x4006A13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float maxPitch;

		[Token(Token = "0x4006A14")]
		[FieldOffset(Offset = "0x24")]
		private float queueDelay;

		[Token(Token = "0x4006A15")]
		[FieldOffset(Offset = "0x28")]
		private int amountToPlay;

		[Token(Token = "0x4006A16")]
		[FieldOffset(Offset = "0x2C")]
		private float lastPlayTime;

		[Token(Token = "0x4006A17")]
		[FieldOffset(Offset = "0x30")]
		private float pitchIncrementPerTip;

		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x1714310", Offset = "0x1714310", VA = "0x1714310")]
		public void Init(int max)
		{
		}

		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x17144D4", Offset = "0x17144D4", VA = "0x17144D4")]
		public void Play()
		{
		}

		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x1714698", Offset = "0x1714698", VA = "0x1714698")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C02")]
		[Address(RVA = "0x171475C", Offset = "0x171475C", VA = "0x171475C")]
		public TiltChallengeSFX()
		{
		}
	}
}
