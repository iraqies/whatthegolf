using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon.Runtime.Internal
{
	public class CapacityManager : IDisposable
	{
		public enum CapacityType
		{
			Increment = 0,
			Retry = 1,
			Timeout = 2
		}

		private bool _disposed;

		private static Dictionary<string, RetryCapacity> _serviceUrlToCapacityMap;

		private ReaderWriterLockSlim _rwlock;

		private readonly int retryCost;

		private readonly int timeoutRetryCost;

		private readonly int initialRetryTokens;

		private readonly int noRetryIncrement;

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost)
		{
		}

		public CapacityManager(int throttleRetryCount, int throttleRetryCost, int throttleCost, int timeoutRetryCost)
		{
		}

		public bool TryAcquireCapacity(RetryCapacity retryCapacity)
		{
			return false;
		}

		public bool TryAcquireCapacity(RetryCapacity retryCapacity, CapacityType capacityType)
		{
			return false;
		}

		[Obsolete]
		public void TryReleaseCapacity(bool isRetryRequest, RetryCapacity retryCapacity)
		{
		}

		public void ReleaseCapacity(CapacityType capacityType, RetryCapacity retryCapacity)
		{
		}

		public RetryCapacity GetRetryCapacity(string serviceURL)
		{
			return null;
		}

		private bool TryGetRetryCapacity(string key, out RetryCapacity value)
		{
			value = null;
			return false;
		}

		private RetryCapacity AddNewRetryCapacity(string serviceURL)
		{
			return null;
		}

		private static void ReleaseCapacity(int capacity, RetryCapacity retryCapacity)
		{
		}
	}
}
