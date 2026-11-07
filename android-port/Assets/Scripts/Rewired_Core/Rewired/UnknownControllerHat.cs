using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000019")]
	internal class UnknownControllerHat
	{
		[Token(Token = "0x200001A")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x19092C", Offset = "0x19092C")]
		public class HatButtons
		{
			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x10")]
			private int[] rgghiTwPYQtsKoFgKRoUtPldWus;

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x239AC60", Offset = "0x239AC60", VA = "0x239AC60")]
			public HatButtons(int[] P_0)
			{
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x239AC8C", Offset = "0x239AC8C", VA = "0x239AC8C")]
			public void GetNeighbors(int button, out int neighbor1, out int neighbor2)
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x239ADB0", Offset = "0x239ADB0", VA = "0x239ADB0")]
			public bool IsCardinal(int button)
			{
				return default;
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x239AE24", Offset = "0x239AE24", VA = "0x239AE24")]
			public bool IsCorner(int button)
			{
				return default;
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x239AD4C", Offset = "0x239AD4C", VA = "0x239AD4C")]
			public int IndexOf(int button)
			{
				return default;
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x239AEA0", Offset = "0x239AEA0", VA = "0x239AEA0")]
			public bool Contains(int button)
			{
				return default;
			}
		}

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		private HatButtons rgghiTwPYQtsKoFgKRoUtPldWus;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2438E18", Offset = "0x2438E18", VA = "0x2438E18")]
		public UnknownControllerHat(HatButtons P_0)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2438E44", Offset = "0x2438E44", VA = "0x2438E44")]
		public bool ContainsButtonIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2438E98", Offset = "0x2438E98", VA = "0x2438E98")]
		public bool IsButtonIndexCardinal(int index)
		{
			return default;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2438EEC", Offset = "0x2438EEC", VA = "0x2438EEC")]
		public HatButtons GetButtons()
		{
			return null;
		}
	}
}
