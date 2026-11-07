using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000095")]
	public class HeadingTracker
	{
		[Token(Token = "0x2000096")]
		private struct Item
		{
			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 velocity;

			[Token(Token = "0x4000325")]
			[FieldOffset(Offset = "0xC")]
			public float weight;

			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x10")]
			public float time;
		}

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x10")]
		private Item[] mHistory;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x18")]
		private int mTop;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x1C")]
		private int mBottom;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x20")]
		private int mCount;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 mHeadingSum;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x30")]
		private float mWeightSum;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x34")]
		private float mWeightTime;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 mLastGoodHeading;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x0")]
		private static float mDecayExponent;

		[Token(Token = "0x170000D9")]
		public int FilterSize
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x190AF18", Offset = "0x190AF18", VA = "0x190AF18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x190AE08", Offset = "0x190AE08", VA = "0x190AE08")]
		public HeadingTracker(int filterSize)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x190AEE0", Offset = "0x190AEE0", VA = "0x190AEE0")]
		private void ClearHistory()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x190AF34", Offset = "0x190AF34", VA = "0x190AF34")]
		private static float Decay(float time)
		{
			return default;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x190AF90", Offset = "0x190AF90", VA = "0x190AF90")]
		public void Add(Vector3 velocity)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x190B11C", Offset = "0x190B11C", VA = "0x190B11C")]
		private void PopBottom()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x190B268", Offset = "0x190B268", VA = "0x190B268")]
		public void DecayHistory()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x190B340", Offset = "0x190B340", VA = "0x190B340")]
		public Vector3 GetReliableHeading()
		{
			return default;
		}
	}
}
