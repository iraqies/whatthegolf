using System;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x2000365")]
	internal sealed class EnumNameValueCache<TEnum> where TEnum : struct, IFormattable, IComparable
	{
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x0")]
		private static EnumNameValueCache<TEnum> ZdvtDIAlSFybwRVQSofHcnvOxpry;

		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x0")]
		private readonly ADictionary<string, TEnum> tgCUUCAoSxgMHCkWUaZcGbnabjsI;

		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x0")]
		private readonly string[] KSDfXUqAewnkJWAVFIkSbajHPmY;

		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x0")]
		private readonly long[] kovwpNGemwJXebpStuNyMURpTaMC;

		[Token(Token = "0x170006CB")]
		public static EnumNameValueCache<TEnum> Default
		{
			[Token(Token = "0x60019F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CC")]
		public int Count
		{
			[Token(Token = "0x60019F1")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60019F2")]
		private EnumNameValueCache()
		{
		}

		[Token(Token = "0x60019F3")]
		public TEnum GetValue(string name)
		{
			return (TEnum)null;
		}

		[Token(Token = "0x60019F4")]
		public string GetName(long value)
		{
			return null;
		}

		[Token(Token = "0x60019F5")]
		public TEnum GetValueAt(int index)
		{
			return (TEnum)null;
		}

		[Token(Token = "0x60019F6")]
		public int IndexOf(long value)
		{
			return default;
		}
	}
}
