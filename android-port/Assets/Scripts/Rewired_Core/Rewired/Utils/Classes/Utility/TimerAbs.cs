using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Utils.Classes.Utility
{
	[Serializable]
	[Token(Token = "0x200035C")]
	internal class TimerAbs
	{
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x10")]
		public bool running;

		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private double nFGtmBUvbKLGhcAGrTWGZJeYwGQM;

		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x20")]
		public double length;

		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x241CC90", Offset = "0x241CC90", VA = "0x241CC90")]
		public TimerAbs()
		{
		}

		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x241CC98", Offset = "0x241CC98", VA = "0x241CC98")]
		public TimerAbs(double P_0)
		{
		}

		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x241CCCC", Offset = "0x241CCCC", VA = "0x241CCCC")]
		public void Start()
		{
		}

		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x241CD58", Offset = "0x241CD58", VA = "0x241CD58")]
		public void Start(double inLength)
		{
		}

		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x241CDE8", Offset = "0x241CDE8", VA = "0x241CDE8")]
		public bool Update()
		{
			return default;
		}

		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x241CE78", Offset = "0x241CE78", VA = "0x241CE78")]
		public void Clear()
		{
		}
	}
}
