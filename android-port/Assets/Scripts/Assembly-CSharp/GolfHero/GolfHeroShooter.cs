using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010D8")]
	public class GolfHeroShooter : ShooterBase
	{
		[Token(Token = "0x40058C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int lane;

		[Token(Token = "0x40058C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GolfHeroSequencer sequencer;

		[Token(Token = "0x40058C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve bounceCurve;

		[Token(Token = "0x40058C9")]
		[FieldOffset(Offset = "0x38")]
		private float laneSpacing;

		[Token(Token = "0x40058CA")]
		[FieldOffset(Offset = "0x3C")]
		private int numberOfLanes;

		[Token(Token = "0x40058CB")]
		[FieldOffset(Offset = "0x40")]
		private float horizontalSpeed;

		[Token(Token = "0x40058CC")]
		[FieldOffset(Offset = "0x44")]
		private int lane_target;

		[Token(Token = "0x40058CD")]
		[FieldOffset(Offset = "0x48")]
		private float pos_x_target;

		[Token(Token = "0x40058CE")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 pos;

		[Token(Token = "0x40058CF")]
		[FieldOffset(Offset = "0x58")]
		private float beatPerBounce;

		[Token(Token = "0x40058D0")]
		[FieldOffset(Offset = "0x5C")]
		private float bounceHeight;

		[Token(Token = "0x170007FC")]
		public int Lane
		{
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x14A1ECC", Offset = "0x14A1ECC", VA = "0x14A1ECC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x14A1CB8", Offset = "0x14A1CB8", VA = "0x14A1CB8")]
		public void SetSequencer(GolfHeroSequencer _sequencer)
		{
		}

		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x14A1CC0", Offset = "0x14A1CC0", VA = "0x14A1CC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x14A1CFC", Offset = "0x14A1CFC", VA = "0x14A1CFC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x14A1DE8", Offset = "0x14A1DE8", VA = "0x14A1DE8")]
		public void Update()
		{
		}

		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x14A1B4C", Offset = "0x14A1B4C", VA = "0x14A1B4C")]
		public float LaneToX(int index)
		{
			return default;
		}

		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x14A1ED4", Offset = "0x14A1ED4", VA = "0x14A1ED4")]
		public GolfHeroShooter()
		{
		}
	}
}
