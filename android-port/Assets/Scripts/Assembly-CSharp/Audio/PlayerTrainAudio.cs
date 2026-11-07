using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139A")]
	public class PlayerTrainAudio : MonoBehaviour
	{
		[Token(Token = "0x400693D")]
		[FieldOffset(Offset = "0x18")]
		public GolfBallController golfBallController;

		[Token(Token = "0x400693E")]
		[FieldOffset(Offset = "0x20")]
		public ClipSettingsCollection _soundOnFirstShot;

		[Token(Token = "0x400693F")]
		[FieldOffset(Offset = "0x28")]
		public Metronome metronome;

		[Token(Token = "0x4006940")]
		[FieldOffset(Offset = "0x30")]
		public int minTempo;

		[Token(Token = "0x4006941")]
		[FieldOffset(Offset = "0x34")]
		public int maxTempo;

		[Token(Token = "0x4006942")]
		[FieldOffset(Offset = "0x38")]
		public float minVelocity;

		[Token(Token = "0x4006943")]
		[FieldOffset(Offset = "0x3C")]
		public float maxVelocity;

		[Token(Token = "0x4006944")]
		[FieldOffset(Offset = "0x40")]
		private TrainShooter trainShooter;

		[Token(Token = "0x4006945")]
		[FieldOffset(Offset = "0x48")]
		private Rigidbody2D trainRigidbody2D;

		[Token(Token = "0x4006946")]
		[FieldOffset(Offset = "0x50")]
		private bool playedInitialSound;

		[Token(Token = "0x4006947")]
		[FieldOffset(Offset = "0x54")]
		private int lastTempo;

		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x15FCC14", Offset = "0x15FCC14", VA = "0x15FCC14")]
		private void Start()
		{
		}

		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x15FCD14", Offset = "0x15FCD14", VA = "0x15FCD14")]
		private void Train_OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x15FCDBC", Offset = "0x15FCDBC", VA = "0x15FCDBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B79")]
		[Address(RVA = "0x15FD018", Offset = "0x15FD018", VA = "0x15FD018")]
		public PlayerTrainAudio()
		{
		}
	}
}
