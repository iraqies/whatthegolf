using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class RetryPolicy
	{
		private static HashSet<string> clockSkewErrorCodes;

		private const string clockSkewMessageFormat = "Identified clock skew: local time = {0}, local time with correction = {1}, current clock skew correction = {2}, server time = {3}, service endpoint = {4}.";

		private const string clockSkewUpdatedFormat = "Setting clock skew correction: new clock skew correction = {0}, service endpoint = {1}.";

		private const string clockSkewMessageParen = "(";

		private const string clockSkewMessagePlusSeparator = " + ";

		private const string clockSkewMessageMinusSeparator = " - ";

		private static TimeSpan clockSkewMaxThreshold;

		public int MaxRetries { get; protected set; }

		public ILogger Logger { get; set; }

		public virtual ICollection<string> ThrottlingErrorCodes { get; protected set; }

		public ICollection<string> TimeoutErrorCodesToRetryOn { get; protected set; }

		public ICollection<string> ErrorCodesToRetryOn { get; protected set; }

		public ICollection<HttpStatusCode> HttpStatusCodesToRetryOn { get; protected set; }

		public ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn { get; protected set; }

		protected RetryCapacity RetryCapacity { get; set; }

		public bool Retry(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}

		public abstract bool CanRetry(IExecutionContext executionContext);

		public abstract bool RetryForException(IExecutionContext executionContext, Exception exception);

		public abstract bool RetryLimitReached(IExecutionContext executionContext);

		public abstract void WaitBeforeRetry(IExecutionContext executionContext);

		public virtual void NotifySuccess(IExecutionContext executionContext)
		{
		}

		public virtual bool OnRetry(IExecutionContext executionContext)
		{
			return false;
		}

		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return false;
		}

		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return false;
		}

		public virtual void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		public virtual bool IsThrottlingError(Exception exception)
		{
			return false;
		}

		public virtual bool IsTransientError(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}

		public virtual bool IsServiceTimeoutError(Exception exception)
		{
			return false;
		}

		private bool IsClockskew(IExecutionContext executionContext, Exception exception)
		{
			return false;
		}

		private static bool TryParseDateHeader(AmazonServiceException ase, out DateTime serverTime)
		{
			serverTime = default;
			return false;
		}

		private static bool TryParseExceptionMessage(AmazonServiceException ase, out DateTime serverTime)
		{
			serverTime = default;
			return false;
		}

		private static IWebResponseData GetWebData(AmazonServiceException ase)
		{
			return null;
		}

		protected static bool ContainErrorMessage(Exception exception, HashSet<string> errorMessages)
		{
			return false;
		}

		public Task<bool> RetryAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		public virtual Task ObtainSendTokenAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		public abstract Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception);

		public abstract Task WaitBeforeRetryAsync(IExecutionContext executionContext);
	}
}
