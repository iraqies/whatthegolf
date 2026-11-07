using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class TokenBucket
	{
		private const int MaxAttempts = 15;

		private readonly object _bucketLock;

		private readonly double _minFillRate;

		private readonly double _minCapacity;

		private readonly double _beta;

		private readonly double _scaleConstant;

		private readonly double _smooth;

		private static readonly DateTime _epoch;

		protected double? FillRate { get; set; }

		protected double? MaxCapacity { get; set; }

		protected double CurrentCapacity { get; set; }

		protected double? LastTimestamp { get; set; }

		protected double MeasuredTxRate { get; set; }

		protected double LastTxRateBucket { get; set; }

		protected long RequestCount { get; set; }

		protected double LastMaxRate { get; set; }

		protected double LastThrottleTime { get; set; }

		protected double TimeWindow { get; set; }

		protected bool Enabled { get; set; }

		public TokenBucket()
		{
		}

		public TokenBucket(double minFillRate, double minCapacity, double beta, double scaleConstant, double smooth)
		{
		}

		public bool TryAcquireToken(double amount, bool failFast)
		{
			return false;
		}

		public Task<bool> TryAcquireTokenAsync(double amount, bool failFast, CancellationToken cancellationToken)
		{
			return null;
		}

		private bool? SetupAcquireToken(double amount)
		{
			return null;
		}

		private int ObtainCapacity(double amount)
		{
			return 0;
		}

		public void UpdateClientSendingRate(bool isThrottlingError)
		{
		}

		protected virtual void TokenBucketRefill()
		{
		}

		protected virtual void TokenBucketUpdateRate(double newRps)
		{
		}

		protected virtual void UpdateMeasuredRate()
		{
		}

		protected virtual void CalculateTimeWindow()
		{
		}

		protected virtual double CUBICSuccess(double timestamp)
		{
			return 0.0;
		}

		protected virtual double CUBICThrottle(double rateToUse)
		{
			return 0.0;
		}

		protected virtual int CalculateWait(double amount, double currentCapacity, double fillRate)
		{
			return 0;
		}

		protected virtual void WaitForToken(int delayMs)
		{
		}

		protected virtual Task WaitForTokenAsync(int delayMs, CancellationToken cancellationToken)
		{
			return null;
		}

		protected virtual double GetTimestamp()
		{
			return 0.0;
		}

		private static double GetTimeInSeconds()
		{
			return 0.0;
		}
	}
}
