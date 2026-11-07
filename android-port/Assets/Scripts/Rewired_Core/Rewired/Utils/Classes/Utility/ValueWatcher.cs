using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	internal abstract class ValueWatcher
	{
		public abstract bool Update();

		public abstract bool Use();

		public abstract bool TriggerEvent();
	}
	internal sealed class ValueWatcher<T> : ValueWatcher
	{
		private static IEqualityComparer<T> suMDhezeJHkJqletOMyLOpnVArbx;

		private bool YdQriBdGGvAqsKFtyxZnRoVXpGIB;

		private T ckUkzuSDJGuJonmPceZrDLTKWbwc;

		private bool iwKVgRFJRKamjQxYRpyVLqqRWXxJ;

		private Func<T> XwzDgvMWltiflzVyqEhvijYXnoqzA;

		private Action<T> FFXtbgAfoebxOqlQslBSuuhHySjm;

		public Func<T> getValueDelegate
		{
			set
			{
			}
		}

		public T value => default;

		public event Action<T> ChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public ValueWatcher(T P_0, bool P_1)
		{
		}

		public ValueWatcher(T P_0, Func<T> P_1, bool P_2)
		{
		}

		public override bool Update()
		{
			return false;
		}

		public override bool Use()
		{
			return false;
		}

		public override bool TriggerEvent()
		{
			return false;
		}

		public bool Set(T value)
		{
			return false;
		}
	}
}
