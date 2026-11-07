using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	internal class ObjectPool<T> : IObjectPool where T : class
	{
		protected readonly Queue<T> _pool;

		protected readonly Func<T> _createInstanceDelegate;

		protected readonly Action<T> _processOnReturnDelegate;

		private ulong CpmIjziOpPELRjKVLKljMysvOoke;

		public ObjectPool(int P_0, Func<T> P_1, Action<T> P_2 = null)
		{
		}

		public ObjectPool(Func<T> P_0)
		{
		}

		public T Get()
		{
			return null;
		}

		public bool Return(T item)
		{
			return false;
		}

		private bool QRrYLGYgbUoxbbAAnCQVUHkPaGiW(object P_0)
		{
			return false;
		}

		bool IObjectPool.Return(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in QRrYLGYgbUoxbbAAnCQVUHkPaGiW
			return this.QRrYLGYgbUoxbbAAnCQVUHkPaGiW(P_0);
		}

		protected T CreateInstance()
		{
			return null;
		}

		protected ulong IncrementInstanceCount()
		{
			return 0uL;
		}
	}
}
