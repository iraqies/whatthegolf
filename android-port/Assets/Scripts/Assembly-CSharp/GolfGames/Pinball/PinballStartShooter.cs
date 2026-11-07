using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010B5")]
	public class PinballStartShooter : MonoBehaviour
	{
		[Token(Token = "0x40057FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject peg;

		[Token(Token = "0x4005800")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Pinball ball;

		[Token(Token = "0x4005801")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject ballToSpawn;

		[Token(Token = "0x4005802")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PinballShooter shooter;

		[Token(Token = "0x4005803")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform arrowPositionTransform;

		[Token(Token = "0x4005804")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform arrowPositionAfterShotTransform;

		[Token(Token = "0x4005805")]
		[FieldOffset(Offset = "0x48")]
		private int balls;

		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x15E30E0", Offset = "0x15E30E0", VA = "0x15E30E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x15E3100", Offset = "0x15E3100", VA = "0x15E3100")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x15E321C", Offset = "0x15E321C", VA = "0x15E321C")]
		private void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x15E31B4", Offset = "0x15E31B4", VA = "0x15E31B4")]
		private void CloseShooterPeg()
		{
		}

		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x15E32A8", Offset = "0x15E32A8", VA = "0x15E32A8")]
		public PinballStartShooter()
		{
		}
	}
}
