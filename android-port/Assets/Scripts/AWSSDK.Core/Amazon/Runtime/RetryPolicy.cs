using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F5")]
	public abstract class RetryPolicy
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25BA4", Offset = "0x25BA4")]
		private struct _003CRetryAsync_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RetryPolicy _003C_003E4__this;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Exception exception;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool _003CcanRetry_003E5__2;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool _003CisClockSkewError_003E5__3;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1294B6C", Offset = "0x1294B6C", VA = "0x1294B6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1295090", Offset = "0x1295090", VA = "0x1295090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BF8", Offset = "0x26BF8")]
		private int MaxRetries__BackingField;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C08", Offset = "0x26C08")]
		private ILogger Logger__BackingField;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C18", Offset = "0x26C18")]
		private ICollection<string> ThrottlingErrorCodes__BackingField;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C28", Offset = "0x26C28")]
		private ICollection<string> TimeoutErrorCodesToRetryOn__BackingField;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C38", Offset = "0x26C38")]
		private ICollection<string> ErrorCodesToRetryOn__BackingField;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C48", Offset = "0x26C48")]
		private ICollection<HttpStatusCode> HttpStatusCodesToRetryOn__BackingField;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C58", Offset = "0x26C58")]
		private ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn__BackingField;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26C68", Offset = "0x26C68")]
		private RetryCapacity RetryCapacity__BackingField;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<string> clockSkewErrorCodes;

		[Token(Token = "0x40003D7")]
		private const string clockSkewMessageFormat = "Identified clock skew: local time = {0}, local time with correction = {1}, current clock skew correction = {2}, server time = {3}, service endpoint = {4}.";

		[Token(Token = "0x40003D8")]
		private const string clockSkewUpdatedFormat = "Setting clock skew correction: new clock skew correction = {0}, service endpoint = {1}.";

		[Token(Token = "0x40003D9")]
		private const string clockSkewMessageParen = "(";

		[Token(Token = "0x40003DA")]
		private const string clockSkewMessagePlusSeparator = " + ";

		[Token(Token = "0x40003DB")]
		private const string clockSkewMessageMinusSeparator = " - ";

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static TimeSpan clockSkewMaxThreshold;

		[Token(Token = "0x1700023F")]
		public int MaxRetries
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1261AF4", Offset = "0x1261AF4", VA = "0x1261AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2950C", Offset = "0x2950C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x1261AFC", Offset = "0x1261AFC", VA = "0x1261AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2951C", Offset = "0x2951C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000240")]
		public ILogger Logger
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1261B04", Offset = "0x1261B04", VA = "0x1261B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2952C", Offset = "0x2952C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x1261B0C", Offset = "0x1261B0C", VA = "0x1261B0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2953C", Offset = "0x2953C")]
			set
			{
			}
		}

		[Token(Token = "0x17000241")]
		public virtual ICollection<string> ThrottlingErrorCodes
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1261B14", Offset = "0x1261B14", VA = "0x1261B14", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2954C", Offset = "0x2954C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1261B1C", Offset = "0x1261B1C", VA = "0x1261B1C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2955C", Offset = "0x2955C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000242")]
		public ICollection<string> TimeoutErrorCodesToRetryOn
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1261B24", Offset = "0x1261B24", VA = "0x1261B24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2956C", Offset = "0x2956C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1261B2C", Offset = "0x1261B2C", VA = "0x1261B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2957C", Offset = "0x2957C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000243")]
		public ICollection<string> ErrorCodesToRetryOn
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1261B34", Offset = "0x1261B34", VA = "0x1261B34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2958C", Offset = "0x2958C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1261B3C", Offset = "0x1261B3C", VA = "0x1261B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2959C", Offset = "0x2959C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000244")]
		public ICollection<HttpStatusCode> HttpStatusCodesToRetryOn
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1261B44", Offset = "0x1261B44", VA = "0x1261B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295AC", Offset = "0x295AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1261B4C", Offset = "0x1261B4C", VA = "0x1261B4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295BC", Offset = "0x295BC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000245")]
		public ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1261B54", Offset = "0x1261B54", VA = "0x1261B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295CC", Offset = "0x295CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1261B5C", Offset = "0x1261B5C", VA = "0x1261B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295DC", Offset = "0x295DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000246")]
		protected RetryCapacity RetryCapacity
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1261B64", Offset = "0x1261B64", VA = "0x1261B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295EC", Offset = "0x295EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1261B6C", Offset = "0x1261B6C", VA = "0x1261B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x295FC", Offset = "0x295FC")]
			set
			{
			}
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x12609BC", Offset = "0x12609BC", VA = "0x12609BC")]
		public bool Retry(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000870")]
		public abstract bool CanRetry(IExecutionContext executionContext);

		[Token(Token = "0x6000871")]
		public abstract bool RetryForException(IExecutionContext executionContext, Exception exception);

		[Token(Token = "0x6000872")]
		public abstract bool RetryLimitReached(IExecutionContext executionContext);

		[Token(Token = "0x6000873")]
		public abstract void WaitBeforeRetry(IExecutionContext executionContext);

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x12627E8", Offset = "0x12627E8", VA = "0x12627E8", Slot = "10")]
		public virtual void NotifySuccess(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x12627EC", Offset = "0x12627EC", VA = "0x12627EC", Slot = "11")]
		public virtual bool OnRetry(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x12627F4", Offset = "0x12627F4", VA = "0x12627F4", Slot = "12")]
		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return default;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x12627FC", Offset = "0x12627FC", VA = "0x12627FC", Slot = "13")]
		public virtual bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1262808", Offset = "0x1262808", VA = "0x1262808", Slot = "14")]
		public virtual void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x126280C", Offset = "0x126280C", VA = "0x126280C", Slot = "15")]
		public virtual bool IsThrottlingError(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x12629BC", Offset = "0x12629BC", VA = "0x12629BC", Slot = "16")]
		public virtual bool IsTransientError(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1262E78", Offset = "0x1262E78", VA = "0x1262E78", Slot = "17")]
		public virtual bool IsServiceTimeoutError(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1261B74", Offset = "0x1261B74", VA = "0x1261B74")]
		private bool IsClockskew(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1262FA0", Offset = "0x1262FA0", VA = "0x1262FA0")]
		private static bool TryParseDateHeader(AmazonServiceException ase, out DateTime serverTime)
		{
			return default;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x12631FC", Offset = "0x12631FC", VA = "0x12631FC")]
		private static bool TryParseExceptionMessage(AmazonServiceException ase, out DateTime serverTime)
		{
			return default;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x12633F0", Offset = "0x12633F0", VA = "0x12633F0")]
		private static IWebResponseData GetWebData(AmazonServiceException ase)
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1263488", Offset = "0x1263488", VA = "0x1263488")]
		protected static bool ContainErrorMessage(Exception exception, HashSet<string> errorMessages)
		{
			return default;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1263548", Offset = "0x1263548", VA = "0x1263548")]
		public Task<bool> RetryAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x126366C", Offset = "0x126366C", VA = "0x126366C", Slot = "18")]
		public virtual Task ObtainSendTokenAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		public abstract Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception);

		[Token(Token = "0x6000884")]
		public abstract Task WaitBeforeRetryAsync(IExecutionContext executionContext);

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x12636C8", Offset = "0x12636C8", VA = "0x12636C8")]
		protected RetryPolicy()
		{
		}
	}
}
