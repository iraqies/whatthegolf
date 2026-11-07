using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E6")]
	public interface ICache
	{
		[Token(Token = "0x170003D0")]
		TimeSpan MaximumItemLifespan
		{
			[Token(Token = "0x6000EFC")]
			get;
			[Token(Token = "0x6000EFD")]
			set;
		}

		[Token(Token = "0x170003D1")]
		TimeSpan CacheClearPeriod
		{
			[Token(Token = "0x6000EFE")]
			get;
			[Token(Token = "0x6000EFF")]
			set;
		}

		[Token(Token = "0x170003D2")]
		int ItemCount
		{
			[Token(Token = "0x6000F00")]
			get;
		}

		[Token(Token = "0x6000EFB")]
		void Clear();
	}
	[Token(Token = "0x20001E7")]
	public interface ICache<TKey, TValue> : ICache
	{
		[Token(Token = "0x170003D3")]
		List<TKey> Keys
		{
			[Token(Token = "0x6000F04")]
			get;
		}

		[Token(Token = "0x6000F01")]
		TValue GetValue(TKey key, Func<TKey, TValue> creator);

		[Token(Token = "0x6000F02")]
		TValue GetValue(TKey key, Func<TKey, TValue> creator, out bool isStaleItem);

		[Token(Token = "0x6000F03")]
		void Clear(TKey key);

		[Token(Token = "0x6000F05")]
		TOut UseCache<TOut>(TKey key, Func<TOut> operation, Action onError, Predicate<Exception> shouldRetryForException);
	}
}
