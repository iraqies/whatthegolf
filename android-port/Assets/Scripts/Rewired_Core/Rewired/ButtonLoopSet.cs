using Il2CppDummyDll;
using Rewired.Config;

namespace Rewired
{
	[Token(Token = "0x2000023")]
	internal class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData>
	{
		[Token(Token = "0x2000024")]
		public class ButtonData
		{
			[Token(Token = "0x40000B6")]
			[FieldOffset(Offset = "0x10")]
			public readonly UpdateLoopType updateLoop;

			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x18")]
			public readonly bool[] values;

			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x20")]
			public readonly bool[] wasTrueThisFrame;

			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x28")]
			private bool[] LyGfISdSObUoFaqJjsGGokDLAPHRA;

			[Token(Token = "0x40000BA")]
			[FieldOffset(Offset = "0x30")]
			private int YAhDGbgVpvgHBJxiiekCiwdIeNtoc;

			[Token(Token = "0x40000BB")]
			[FieldOffset(Offset = "0x38")]
			private readonly bool[] xwHGzJHGnbjbOkbDglBjnUCxqgJP;

			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x40")]
			private readonly bool[] AginueIiWHDqqBTEZmVXaMqQkhsFA;

			[Token(Token = "0x17000045")]
			public bool[] effectiveValue
			{
				[Token(Token = "0x60000C8")]
				[Address(RVA = "0x2450AC4", Offset = "0x2450AC4", VA = "0x2450AC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2450C10", Offset = "0x2450C10", VA = "0x2450C10")]
			public ButtonData(int P_0, UpdateLoopType P_1)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2450D40", Offset = "0x2450D40", VA = "0x2450D40")]
			public void SetValue(int index, bool value)
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2450E6C", Offset = "0x2450E6C", VA = "0x2450E6C")]
			public void ClearWasTrueThisFrame()
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2450AF8", Offset = "0x2450AF8", VA = "0x2450AF8")]
			private void cdoKZnCDqOOiWvCXOdYlBGYzOkyK()
			{
			}
		}

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x34")]
		public readonly int buttonCount;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x234F930", Offset = "0x234F930", VA = "0x234F930")]
		public ButtonLoopSet(UpdateLoopSetting P_0, int P_1)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x234FA54", Offset = "0x234FA54", VA = "0x234FA54")]
		public void SetValue(int index, bool value, double timestamp)
		{
		}
	}
}
