using System;

namespace Rewired.Utils.Classes.Utility
{
	internal struct SetAndRestoreVar<T> : IDisposable
	{
		private readonly Action<T> oTYaMbEJOHgWFriwyKVuQJmGgRLMA;

		private readonly T aeBVIwKfLInMbZLMxxXPuWvxrCrQ;

		public SetAndRestoreVar(T P_0, T P_1, Action<T> P_2)
		{
			oTYaMbEJOHgWFriwyKVuQJmGgRLMA = null;
			aeBVIwKfLInMbZLMxxXPuWvxrCrQ = default;
		}

		public void Dispose()
		{
		}
	}
}
