using Il2CppDummyDll;
using UnityEngine;

namespace Ghost
{
	[Token(Token = "0x20010EE")]
	public class GhostManager : MonoBehaviour
	{
		[Token(Token = "0x4005935")]
		[FieldOffset(Offset = "0x18")]
		public GolfGhostRecorder recorder;

		[Token(Token = "0x4005936")]
		[FieldOffset(Offset = "0x20")]
		public GolfGhostPlayer player;

		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x1485AFC", Offset = "0x1485AFC", VA = "0x1485AFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x1485BDC", Offset = "0x1485BDC", VA = "0x1485BDC")]
		public void GoalReached()
		{
		}

		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x1485BF8", Offset = "0x1485BF8", VA = "0x1485BF8")]
		internal void GameWon(int strokes)
		{
		}

		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0x1485C14", Offset = "0x1485C14", VA = "0x1485C14")]
		public void RecordStroke()
		{
		}

		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0x1485C74", Offset = "0x1485C74", VA = "0x1485C74")]
		public GhostManager()
		{
		}
	}
}
