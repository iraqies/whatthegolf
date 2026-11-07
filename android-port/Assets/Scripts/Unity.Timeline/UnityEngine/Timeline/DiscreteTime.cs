using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200001E")]
	internal struct DiscreteTime : IComparable
	{
		[Token(Token = "0x40000B4")]
		private const double k_Tick = 1E-12;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DiscreteTime kMaxTime;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		private readonly long m_DiscreteTime;

		[Token(Token = "0x17000074")]
		public static double tickValue
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2AE6DD4", Offset = "0x2AE6DD4", VA = "0x2AE6DD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2AE6DE0", Offset = "0x2AE6DE0", VA = "0x2AE6DE0")]
		private DiscreteTime(long time)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2AE6DE8", Offset = "0x2AE6DE8", VA = "0x2AE6DE8")]
		public DiscreteTime(double time)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2AE6F54", Offset = "0x2AE6F54", VA = "0x2AE6F54")]
		public DiscreteTime(int time)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2AE70A4", Offset = "0x2AE70A4", VA = "0x2AE70A4")]
		public DiscreteTime OneTickBefore()
		{
			return default;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2AE70B0", Offset = "0x2AE70B0", VA = "0x2AE70B0")]
		public DiscreteTime OneTickAfter()
		{
			return default;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2AE70BC", Offset = "0x2AE70BC", VA = "0x2AE70BC")]
		public static DiscreteTime FromTicks(long ticks)
		{
			return default;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2AE70C0", Offset = "0x2AE70C0", VA = "0x2AE70C0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2AE7170", Offset = "0x2AE7170", VA = "0x2AE7170")]
		public bool Equals(DiscreteTime other)
		{
			return default;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2AE7180", Offset = "0x2AE7180", VA = "0x2AE7180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2AE6ED0", Offset = "0x2AE6ED0", VA = "0x2AE6ED0")]
		private static long DoubleToDiscreteTime(double time)
		{
			return default;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2AE6FC8", Offset = "0x2AE6FC8", VA = "0x2AE6FC8")]
		private static long IntToDiscreteTime(int time)
		{
			return default;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2AE7218", Offset = "0x2AE7218", VA = "0x2AE7218")]
		private static double ToDouble(long time)
		{
			return default;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2AE722C", Offset = "0x2AE722C", VA = "0x2AE722C")]
		public static explicit operator double(DiscreteTime b)
		{
			return default;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2AE72A0", Offset = "0x2AE72A0", VA = "0x2AE72A0")]
		public static explicit operator DiscreteTime(double time)
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2AE72C8", Offset = "0x2AE72C8", VA = "0x2AE72C8")]
		public static implicit operator DiscreteTime(int time)
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2AE7340", Offset = "0x2AE7340", VA = "0x2AE7340")]
		public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2AE734C", Offset = "0x2AE734C", VA = "0x2AE734C")]
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2AE73BC", Offset = "0x2AE73BC", VA = "0x2AE73BC")]
		public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2AE73C8", Offset = "0x2AE73C8", VA = "0x2AE73C8")]
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2AE73D4", Offset = "0x2AE73D4", VA = "0x2AE73D4")]
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2AE73DC", Offset = "0x2AE73DC", VA = "0x2AE73DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2AE7408", Offset = "0x2AE7408", VA = "0x2AE7408", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2AE7434", Offset = "0x2AE7434", VA = "0x2AE7434")]
		public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2AE74C0", Offset = "0x2AE74C0", VA = "0x2AE74C0")]
		public static long GetNearestTick(double time)
		{
			return default;
		}
	}
}
