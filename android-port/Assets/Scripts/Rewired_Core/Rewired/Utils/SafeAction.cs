using System;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x2000330")]
	internal sealed class SafeAction : SafeDelegate<Action>
	{
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x0")]
		private static Action<object, Action> eaSmezmUiTddkXzvgCvPVDenrmsG;

		[Token(Token = "0x17000697")]
		private static Action<object, Action> invokeDelegate
		{
			[Token(Token = "0x6001882")]
			[Address(RVA = "0x240BA6C", Offset = "0x240BA6C", VA = "0x240BA6C")]
			get
			{
				return RijPrMwcgpUKOgODCHvjRnHVQcjU();
			}
		}

		[Token(Token = "0x600187D")]
		[Address(RVA = "0x240B9B4", Offset = "0x240B9B4", VA = "0x240B9B4")]
		public SafeAction()
		{
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x23FFC14", Offset = "0x23FFC14", VA = "0x23FFC14")]
		public SafeAction(Action<Exception> P_0)
		{
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x240BA0C", Offset = "0x240BA0C", VA = "0x240BA0C")]
		private SafeAction(SafeAction P_0)
		{
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x2405348", Offset = "0x2405348", VA = "0x2405348")]
		public void Invoke()
		{
		}

		[Token(Token = "0x6001881")]
		[Address(RVA = "0x240BB24", Offset = "0x240BB24", VA = "0x240BB24", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		[Token(Token = "0x6001882")]
		[Address(RVA = "0x240BA6C", Offset = "0x240BA6C", VA = "0x240BA6C")]
		private static Action<object, Action> RijPrMwcgpUKOgODCHvjRnHVQcjU()
		{
			return null;
		}

		[Token(Token = "0x6001883")]
		[Address(RVA = "0x240BBB8", Offset = "0x240BBB8", VA = "0x240BBB8")]
		private static void GGIVvebCPkEFsDmSRuDeLjmSaIhib(object P_0, Action P_1)
		{
		}

		[Token(Token = "0x6001884")]
		[Address(RVA = "0x2400178", Offset = "0x2400178", VA = "0x2400178")]
		public static SafeAction operator +(SafeAction eventList, Action listener)
		{
			return null;
		}

		[Token(Token = "0x6001885")]
		[Address(RVA = "0x24002FC", Offset = "0x24002FC", VA = "0x24002FC")]
		public static SafeAction operator -(SafeAction eventList, Action listener)
		{
			return null;
		}
	}
	[Token(Token = "0x2000331")]
	internal sealed class SafeAction<T> : SafeDelegate<Action<T>>
	{
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x0")]
		private T iycFpybfiLRDYdIeXNFDXPzNFHkdA;

		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x0")]
		private static Action<object, Action<T>> eaSmezmUiTddkXzvgCvPVDenrmsG;

		[Token(Token = "0x17000698")]
		private static Action<object, Action<T>> invokeDelegate
		{
			[Token(Token = "0x600188B")]
			get
			{
				return RijPrMwcgpUKOgODCHvjRnHVQcjU();
			}
		}

		[Token(Token = "0x6001886")]
		public SafeAction()
		{
		}

		[Token(Token = "0x6001887")]
		public SafeAction(Action<Exception> P_0)
		{
		}

		[Token(Token = "0x6001888")]
		protected SafeAction(SafeAction<T> P_0)
		{
		}

		[Token(Token = "0x6001889")]
		public void Invoke(T arg0)
		{
		}

		[Token(Token = "0x600188A")]
		public override object Clone()
		{
			return null;
		}

		[Token(Token = "0x600188B")]
		private static Action<object, Action<T>> RijPrMwcgpUKOgODCHvjRnHVQcjU()
		{
			return null;
		}

		[Token(Token = "0x600188C")]
		private static void GGIVvebCPkEFsDmSRuDeLjmSaIhib(object P_0, Action<T> P_1)
		{
		}

		[Token(Token = "0x600188D")]
		public static SafeAction<T> operator +(SafeAction<T> eventList, Action<T> listener)
		{
			return null;
		}

		[Token(Token = "0x600188E")]
		public static SafeAction<T> operator -(SafeAction<T> eventList, Action<T> listener)
		{
			return null;
		}
	}
}
