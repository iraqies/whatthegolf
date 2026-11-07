using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010EA")]
	public class BeatFighterShooter : ShooterBase
	{
		[Token(Token = "0x4005928")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BeatFighterSequencer sequencer;

		[Token(Token = "0x4005929")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x400592A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BeatTrackAction[] possibleActions;

		[Token(Token = "0x400592B")]
		[FieldOffset(Offset = "0x38")]
		private BeatTrackAction currentAction;

		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x160D284", Offset = "0x160D284", VA = "0x160D284", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x160D3E0", Offset = "0x160D3E0", VA = "0x160D3E0")]
		public BeatFighterShooter()
		{
		}
	}
}
