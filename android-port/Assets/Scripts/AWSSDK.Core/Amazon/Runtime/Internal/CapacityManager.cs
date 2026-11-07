using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000145")]
	public class CapacityManager : IDisposable
	{
		[Token(Token = "0x2000146")]
		public enum CapacityType
		{
			[Token(Token = "0x4000507")]
			Increment = 0,
			[Token(Token = "0x4000508")]
			Retry = 1,
			[Token(Token = "0x4000509")]
			Timeout = 2
		}

		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, RetryCapacity> _serviceUrlToCapacityMap;

		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x18")]
		private ReaderWriterLockSlim _rwlock;

		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x20")]
		private readonly int retryCost;

		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x24")]
		private readonly int timeoutRetryCost;

		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x28")]
		private readonly int initialRetryTokens;

		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x2C")]
		private readonly int noRetryIncrement;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x11DC418", Offset = "0x11DC418", VA = "0x11DC418", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x11DC498", Offset = "0x11DC498", VA = "0x11DC498", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x11DC4DC", Offset = "0x11DC4DC", VA = "0x11DC4DC")]
		public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost)
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x11DC568", Offset = "0x11DC568", VA = "0x11DC568")]
		public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost, int timeoutRetryCost)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x11DC600", Offset = "0x11DC600", VA = "0x11DC600")]
		public bool TryAcquireCapacity(RetryCapacity retryCapacity)
		{
			return default;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x11DC608", Offset = "0x11DC608", VA = "0x11DC608")]
		public bool TryAcquireCapacity(RetryCapacity retryCapacity, CapacityType capacityType)
		{
			return default;
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x11DC740", Offset = "0x11DC740", VA = "0x11DC740")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x29EDC", Offset = "0x29EDC")]
		public void TryReleaseCapacity(bool isRetryRequest, RetryCapacity retryCapacity)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x11DC754", Offset = "0x11DC754", VA = "0x11DC754")]
		public void ReleaseCapacity(CapacityType capacityType, RetryCapacity retryCapacity)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x11DC9C0", Offset = "0x11DC9C0", VA = "0x11DC9C0")]
		public RetryCapacity GetRetryCapacity(string serviceURL)
		{
			return null;
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x11DCA0C", Offset = "0x11DCA0C", VA = "0x11DCA0C")]
		private bool TryGetRetryCapacity(string key, out RetryCapacity value)
		{
			return default;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x11DCB6C", Offset = "0x11DCB6C", VA = "0x11DCB6C")]
		private RetryCapacity AddNewRetryCapacity(string serviceURL)
		{
			return null;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x11DC87C", Offset = "0x11DC87C", VA = "0x11DC87C")]
		private static void ReleaseCapacity(int capacity, RetryCapacity retryCapacity)
		{
		}
	}
}
