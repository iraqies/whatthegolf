using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F2")]
	public class DanceMoveIndicator : MonoBehaviour
	{
		[Token(Token = "0x4006085")]
		[FieldOffset(Offset = "0x18")]
		private double time;

		[Token(Token = "0x4006086")]
		[FieldOffset(Offset = "0x20")]
		private DanceMove danceMove;

		[Token(Token = "0x4006087")]
		[FieldOffset(Offset = "0x28")]
		private Transform _transform;

		[Token(Token = "0x4006088")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip hitClip;

		[Token(Token = "0x4006089")]
		[FieldOffset(Offset = "0x38")]
		private Sequencer sequencer;

		[Token(Token = "0x1700090B")]
		public double Time
		{
			[Token(Token = "0x6005271")]
			[Address(RVA = "0x18D42B8", Offset = "0x18D42B8", VA = "0x18D42B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700090C")]
		public DanceMove DanceMove
		{
			[Token(Token = "0x6005272")]
			[Address(RVA = "0x18D42C0", Offset = "0x18D42C0", VA = "0x18D42C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090D")]
		public Transform Transform
		{
			[Token(Token = "0x6005273")]
			[Address(RVA = "0x18D42C8", Offset = "0x18D42C8", VA = "0x18D42C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005270")]
		[Address(RVA = "0x18D4288", Offset = "0x18D4288", VA = "0x18D4288")]
		public void Initialize(double time, DanceMove danceMove)
		{
		}

		[Token(Token = "0x6005274")]
		[Address(RVA = "0x18D42D0", Offset = "0x18D42D0", VA = "0x18D42D0")]
		public DanceMoveIndicator()
		{
		}
	}
}
