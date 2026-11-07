using Buoyancy;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200133E")]
	public class BuoyancyAudio : MonoBehaviour
	{
		[Token(Token = "0x40066F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] buoyancyGameObjects;

		[Token(Token = "0x40066F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float audioCooldown;

		[Token(Token = "0x40066F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MinMax volumeRange;

		[Token(Token = "0x40066F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MinMax pitchRange;

		[Token(Token = "0x40066F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MinMax waterHitVelocityRange;

		[Token(Token = "0x40066F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClipSettingsCollection skipClips;

		[Token(Token = "0x40066F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClipSettingsCollection splashClips;

		[Token(Token = "0x40066FA")]
		[FieldOffset(Offset = "0x50")]
		private IBuoyant[] buoyantObjects;

		[Token(Token = "0x40066FB")]
		[FieldOffset(Offset = "0x58")]
		private float nextSkipSfxTime;

		[Token(Token = "0x40066FC")]
		[FieldOffset(Offset = "0x5C")]
		private float nextSplashSfxTime;

		[Token(Token = "0x17000A1B")]
		private Vector3 AudioPosition
		{
			[Token(Token = "0x60059C2")]
			[Address(RVA = "0x170BC74", Offset = "0x170BC74", VA = "0x170BC74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x170BE28", Offset = "0x170BE28", VA = "0x170BE28")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x170C260", Offset = "0x170C260", VA = "0x170C260")]
		private void BuoyancyTarget_OnEnterWaterNoSkip(Vector3 obj)
		{
		}

		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x170C2D4", Offset = "0x170C2D4", VA = "0x170C2D4")]
		private void BuoyancyTarget_OnPostSkip(Vector3 obj)
		{
		}

		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x170C3F4", Offset = "0x170C3F4", VA = "0x170C3F4")]
		public BuoyancyAudio()
		{
		}
	}
}
