using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x2000366")]
	internal abstract class ValueWatcher
	{
		[Token(Token = "0x60019F7")]
		public abstract bool Update();

		[Token(Token = "0x60019F8")]
		public abstract bool Use();

		[Token(Token = "0x60019F9")]
		public abstract bool TriggerEvent();

		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x243EE3C", Offset = "0x243EE3C", VA = "0x243EE3C")]
		protected ValueWatcher()
		{
		}
	}
	[Token(Token = "0x2000367")]
	internal sealed class ValueWatcher<T> : ValueWatcher
	{
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x0")]
		private static IEqualityComparer<T> suMDhezeJHkJqletOMyLOpnVArbx;

		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x0")]
		private bool YdQriBdGGvAqsKFtyxZnRoVXpGIB;

		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x0")]
		private T ckUkzuSDJGuJonmPceZrDLTKWbwc;

		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x0")]
		private bool iwKVgRFJRKamjQxYRpyVLqqRWXxJ;

		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> XwzDgvMWltiflzVyqEhvijYXnoqzA;

		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x0")]
		private Action<T> FFXtbgAfoebxOqlQslBSuuhHySjm;

		[Token(Token = "0x170006CD")]
		public Func<T> getValueDelegate
		{
			[Token(Token = "0x60019FB")]
			set
			{
			}
		}

		[Token(Token = "0x170006CE")]
		public T value
		{
			[Token(Token = "0x60019FC")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x1400004D")]
		public event Action<T> ChangedEvent
		{
			[Token(Token = "0x60019FD")]
			add
			{
			}
			[Token(Token = "0x60019FE")]
			remove
			{
			}
		}

		[Token(Token = "0x60019FF")]
		public ValueWatcher(T P_0, bool P_1)
		{
		}

		[Token(Token = "0x6001A00")]
		public ValueWatcher(T P_0, Func<T> P_1, bool P_2)
		{
		}

		[Token(Token = "0x6001A01")]
		public override bool Update()
		{
			return default;
		}

		[Token(Token = "0x6001A02")]
		public override bool Use()
		{
			return default;
		}

		[Token(Token = "0x6001A03")]
		public override bool TriggerEvent()
		{
			return default;
		}

		[Token(Token = "0x6001A04")]
		public bool Set(T value)
		{
			return default;
		}
	}
}
