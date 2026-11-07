using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x200035F")]
	internal class ObjectPool<T> : IObjectPool where T : class
	{
		[Token(Token = "0x400116B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Queue<T> _pool;

		[Token(Token = "0x400116C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Func<T> _createInstanceDelegate;

		[Token(Token = "0x400116D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Action<T> _processOnReturnDelegate;

		[Token(Token = "0x400116E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong CpmIjziOpPELRjKVLKljMysvOoke;

		[Token(Token = "0x60019CE")]
		public ObjectPool(int P_0, Func<T> P_1, [Optional] Action<T> P_2)
		{
		}

		[Token(Token = "0x60019CF")]
		public ObjectPool(Func<T> P_0)
		{
		}

		[Token(Token = "0x60019D0")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60019D1")]
		public bool Return(T item)
		{
			return default;
		}

		[Token(Token = "0x60019D2")]
		private bool QRrYLGYgbUoxbbAAnCQVUHkPaGiW(object P_0)
		{
			return default;
		}

		[Token(Token = "0x60019D3")]
		protected T CreateInstance()
		{
			return null;
		}

		[Token(Token = "0x60019D4")]
		protected ulong IncrementInstanceCount()
		{
			return default;
		}
	}
}
