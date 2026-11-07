using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001048")]
	public class PuzzleSwitchLaser : PuzzleSwitchBase
	{
		[Token(Token = "0x40055D3")]
		[FieldOffset(Offset = "0x50")]
		private AudioSource audioSource;

		[Token(Token = "0x40055D4")]
		[FieldOffset(Offset = "0x58")]
		private LazerJoint currentJoint;

		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x1631950", Offset = "0x1631950", VA = "0x1631950")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x16319AC", Offset = "0x16319AC", VA = "0x16319AC")]
		public void SetLaser(LazerJoint laser)
		{
		}

		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x1631B14", Offset = "0x1631B14", VA = "0x1631B14")]
		public PuzzleSwitchLaser()
		{
		}
	}
}
