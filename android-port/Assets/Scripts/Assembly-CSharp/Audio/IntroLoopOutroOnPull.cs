using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139E")]
	public class IntroLoopOutroOnPull : MonoBehaviour
	{
		[Token(Token = "0x400696F")]
		[FieldOffset(Offset = "0x18")]
		public IntroLoopOutro loop;

		[Token(Token = "0x4006970")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController ball;

		[Token(Token = "0x4006971")]
		[FieldOffset(Offset = "0x28")]
		public float stopAfterTimeInactive;

		[Token(Token = "0x4006972")]
		[FieldOffset(Offset = "0x2C")]
		public bool blockStart;

		[Token(Token = "0x4006973")]
		[FieldOffset(Offset = "0x2D")]
		public bool stopOnShoot;

		[Token(Token = "0x4006974")]
		[FieldOffset(Offset = "0x2E")]
		public bool stopOnCancel;

		[Token(Token = "0x4006975")]
		[FieldOffset(Offset = "0x30")]
		public float cooldown;

		[Token(Token = "0x4006976")]
		[FieldOffset(Offset = "0x34")]
		private float lastBoost;

		[Token(Token = "0x4006977")]
		[FieldOffset(Offset = "0x38")]
		private bool lastBlockState;

		[Token(Token = "0x4006978")]
		[FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x4006979")]
		[FieldOffset(Offset = "0x40")]
		private bool stop;

		[Token(Token = "0x400697A")]
		[FieldOffset(Offset = "0x44")]
		private float nextStartTime;

		[Token(Token = "0x6005B96")]
		[Address(RVA = "0x14F2F98", Offset = "0x14F2F98", VA = "0x14F2F98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x14F3274", Offset = "0x14F3274", VA = "0x14F3274")]
		private void Ball_OnAimStart()
		{
		}

		[Token(Token = "0x6005B98")]
		[Address(RVA = "0x14F32E8", Offset = "0x14F32E8", VA = "0x14F32E8")]
		private void TryStart()
		{
		}

		[Token(Token = "0x6005B99")]
		[Address(RVA = "0x14F333C", Offset = "0x14F333C", VA = "0x14F333C")]
		private void Ball_OnAimUpdate(Vector3 boost, bool arg2)
		{
		}

		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x14F33EC", Offset = "0x14F33EC", VA = "0x14F33EC")]
		private void Ball_OnPreShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x14F3414", Offset = "0x14F3414", VA = "0x14F3414")]
		private void Ball_OnCancel()
		{
		}

		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x14F343C", Offset = "0x14F343C", VA = "0x14F343C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0x14F34AC", Offset = "0x14F34AC", VA = "0x14F34AC")]
		public IntroLoopOutroOnPull()
		{
		}
	}
}
