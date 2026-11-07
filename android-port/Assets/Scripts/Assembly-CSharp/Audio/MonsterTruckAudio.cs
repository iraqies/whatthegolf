using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200138F")]
	public class MonsterTruckAudio : MonoBehaviour
	{
		[Token(Token = "0x2001390")]
		private enum CarState
		{
			[Token(Token = "0x4006904")]
			Grounded = 0,
			[Token(Token = "0x4006905")]
			NonGrounded = 1
		}

		[Token(Token = "0x40068EF")]
		[FieldOffset(Offset = "0x18")]
		public WheelCollider[] wheels;

		[Token(Token = "0x40068F0")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController controller;

		[Token(Token = "0x40068F1")]
		[FieldOffset(Offset = "0x28")]
		public float minRPM;

		[Token(Token = "0x40068F2")]
		[FieldOffset(Offset = "0x2C")]
		public float maxRPM;

		[Token(Token = "0x40068F3")]
		[FieldOffset(Offset = "0x30")]
		public int decreaseVolumeOverShots;

		[Token(Token = "0x40068F4")]
		[FieldOffset(Offset = "0x38")]
		public RandomAudioClips RevClips;

		[Token(Token = "0x40068F5")]
		[FieldOffset(Offset = "0x40")]
		public RandomAudioClips DirtClips;

		[Token(Token = "0x40068F6")]
		[FieldOffset(Offset = "0x48")]
		public RandomAudioClips FailExhaustClips;

		[Token(Token = "0x40068F7")]
		[FieldOffset(Offset = "0x50")]
		public float steerDirtThreshold;

		[Token(Token = "0x40068F8")]
		[FieldOffset(Offset = "0x58")]
		public AudioSource RevAudiosource;

		[Token(Token = "0x40068F9")]
		[FieldOffset(Offset = "0x60")]
		public AudioSource DirtAudiosource;

		[Token(Token = "0x40068FA")]
		[FieldOffset(Offset = "0x68")]
		public float RPM;

		[Token(Token = "0x40068FB")]
		[FieldOffset(Offset = "0x6C")]
		private float shootClipGain;

		[Token(Token = "0x40068FC")]
		[FieldOffset(Offset = "0x70")]
		private float lastSteering;

		[Token(Token = "0x40068FD")]
		[FieldOffset(Offset = "0x74")]
		private int shots;

		[Token(Token = "0x40068FE")]
		[FieldOffset(Offset = "0x78")]
		private float shotTimer;

		[Token(Token = "0x40068FF")]
		[FieldOffset(Offset = "0x7C")]
		private float shotTimeCooldown;

		[Token(Token = "0x4006900")]
		[FieldOffset(Offset = "0x80")]
		private float nextSoundTime;

		[Token(Token = "0x4006901")]
		[FieldOffset(Offset = "0x84")]
		private int wheelsGrounded;

		[Token(Token = "0x4006902")]
		[FieldOffset(Offset = "0x88")]
		private CarState state;

		[Token(Token = "0x6005B48")]
		[Address(RVA = "0x156CA24", Offset = "0x156CA24", VA = "0x156CA24")]
		private int WheelsGrounded()
		{
			return default;
		}

		[Token(Token = "0x6005B49")]
		[Address(RVA = "0x156CAA4", Offset = "0x156CAA4", VA = "0x156CAA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0x156CBFC", Offset = "0x156CBFC", VA = "0x156CBFC")]
		private void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0x156CE50", Offset = "0x156CE50", VA = "0x156CE50")]
		private void OnShootWhileBlocked(Vector3 boost)
		{
		}

		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0x156CC64", Offset = "0x156CC64", VA = "0x156CC64")]
		private void PlayRev()
		{
		}

		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0x156CDA8", Offset = "0x156CDA8", VA = "0x156CDA8")]
		private void PlayPuff()
		{
		}

		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0x156CEA4", Offset = "0x156CEA4", VA = "0x156CEA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B4F")]
		[Address(RVA = "0x156D004", Offset = "0x156D004", VA = "0x156D004")]
		public MonsterTruckAudio()
		{
		}
	}
}
