using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils
{
	[Token(Token = "0x2000333")]
	internal static class TempListPool
	{
		[Token(Token = "0x2000334")]
		private static class dCvGVaDLaDdfrJKpjhxKdpFXlRsK
		{
			[Token(Token = "0x400108D")]
			[FieldOffset(Offset = "0x0")]
			private static ADictionary<Type, List<object>> jUDNnJqJfIJBUyVJfWsdngnjwJIO;

			[Token(Token = "0x1700069B")]
			private static ADictionary<Type, List<object>> rSJrtpfsKIBEbMVQfoiSQfVTbBhg
			{
				[Token(Token = "0x600189A")]
				[Address(RVA = "0x2397ABC", Offset = "0x2397ABC", VA = "0x2397ABC")]
				get
				{
					return lbVhYzcslysBqoRryxxvHOFcabwh();
				}
			}

			[Token(Token = "0x600189A")]
			[Address(RVA = "0x2397ABC", Offset = "0x2397ABC", VA = "0x2397ABC")]
			private static ADictionary<Type, List<object>> lbVhYzcslysBqoRryxxvHOFcabwh()
			{
				return null;
			}

			[Token(Token = "0x600189B")]
			public static TList<_0001> wYIkNNRAMPoRaNuemNlHqDBzUPkX<_0001>(List<_0001> P_0)
			{
				return null;
			}

			[Token(Token = "0x600189C")]
			public static void XujZHhProIDfiWlYVdCJpXuAQjXA<_0001>(TList<_0001> P_0)
			{
			}
		}

		[Token(Token = "0x2000335")]
		internal sealed class TList<T> : IDisposable, ITListSetter<T>
		{
			[Token(Token = "0x400108E")]
			[FieldOffset(Offset = "0x0")]
			private List<T> jaEouEThGebUjciilFRztgFLhYrT;

			[Token(Token = "0x400108F")]
			[FieldOffset(Offset = "0x0")]
			private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

			[Token(Token = "0x1700069C")]
			public List<T> list
			{
				[Token(Token = "0x600189E")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600189D")]
			public static TList<T> Create()
			{
				return null;
			}

			[Token(Token = "0x600189F")]
			private TList()
			{
			}

			[Token(Token = "0x60018A0")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60018A1")]
			private void XujZHhProIDfiWlYVdCJpXuAQjXA()
			{
			}

			[Token(Token = "0x60018A2")]
			private void Rewired_002EUtils_002ETempListPool_002EITListSetter_003CT_003E_002ESetList(List<T> P_0)
			{
			}

			[Token(Token = "0x60018A3")]
			private static void AIChEpcNBxvGTvsDsgBIQQfnmcxCb()
			{
			}
		}

		[Token(Token = "0x2000336")]
		internal interface ITListSetter<T>
		{
			[Token(Token = "0x60018A4")]
			void SetList(List<T> list);
		}

		[Token(Token = "0x400108C")]
		[FieldOffset(Offset = "0x0")]
		private static ADictionary<Type, List<IList>> xanRufpPTjTVYieggvaIrNkualVGA;

		[Token(Token = "0x1700069A")]
		private static ADictionary<Type, List<IList>> lists
		{
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x241BD84", Offset = "0x241BD84", VA = "0x241BD84")]
			get
			{
				return cUNYTYJJFEeBeDghQKIXtRaFfbtAA();
			}
		}

		[Token(Token = "0x6001894")]
		[Address(RVA = "0x241BD84", Offset = "0x241BD84", VA = "0x241BD84")]
		private static ADictionary<Type, List<IList>> cUNYTYJJFEeBeDghQKIXtRaFfbtAA()
		{
			return null;
		}

		[Token(Token = "0x6001895")]
		public static TList<T> GetTList<T>()
		{
			return null;
		}

		[Token(Token = "0x6001896")]
		public static TList<T> GetTList<T>(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6001897")]
		public static List<T> Get<T>()
		{
			return null;
		}

		[Token(Token = "0x6001898")]
		public static List<T> Get<T>(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6001899")]
		public static void Return<T>(List<T> list)
		{
		}
	}
}
